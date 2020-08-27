using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace FacultyEventsPlanner
{
    public partial class StudentsEventsForm : Form
    {
        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection con, con2;

        OracleDataAdapter adapter;
        DataSet dataset;

        string ssn;
        string fname;
        string rate;

        public StudentForm refToStudent { get; set; }
        public StudentsEventsForm(string ssn, string fname)
        {
            this.ssn = ssn;
            this.fname = fname;
            InitializeComponent();
            Name_lbl.Text = fname;

            con = new OracleConnection(ordb);
            con.Open();

            OracleCommand c = new OracleCommand();
            c.Connection = con;
            c.CommandText = "DisplayEvents";
            c.CommandType = CommandType.StoredProcedure;
            c.Parameters.Add("ussn", ssn);
            c.Parameters.Add("events", OracleDbType.RefCursor,
                               ParameterDirection.Output);
            OracleDataReader dr = c.ExecuteReader();

            int i = 0;
            while (dr.Read())
            {
                Events_grid.Rows.Insert(i, dr[0], dr[1], dr[3], dr[2], dr[4]);
                i++;
            }

            con2 = new OracleConnection(ordb);
            con2.Open();

            OracleCommand c2 = new OracleCommand();
            c2.Connection = con2;
            c2.CommandText = "select EVENT_ID,RATE  from rate_for where SSN = :ssn";
            c2.CommandType = CommandType.Text;
            c2.Parameters.Add("ussn", ssn);
            OracleDataReader dr2 = c2.ExecuteReader();
            string[] arr = new string[50];
            string[] ids = new string[50];
            i = 0;
            while (dr2.Read())
            {
                ids[i] = dr2[0].ToString();
                arr[i] = dr2[1].ToString();
                i++;
            }
            dr.Close();
            if (i != 0)
            {
                for (int j = 0; j < Events_grid.Rows.Count - 1; j++)
                {
                    for (int k = 0; k < i; k++)
                    {
                        if (Events_grid.Rows[j].Cells[0].Value.ToString() == ids[k])
                        {
                            Events_grid.Rows[j].Cells[5].Value = arr[k];
                        }
                    }
                }
            }

        }

        private void Home_btn_Click(object sender, EventArgs e)
        {
            refToStudent.Show();
            this.Hide();
        }

        private void Events_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            int index;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
              e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 6)
                {
                    index = e.RowIndex;
                    //deltitle = Events_grid.Rows[e.RowIndex].Cells[0].Value.ToString();
                    OracleCommand cancel = new OracleCommand();
                    cancel.Connection = con;
                    cancel.CommandType = CommandType.Text;

                    cancel.CommandText = "delete from Register_to where SSN=:ssn AND EVENT_ID=:id";
                    cancel.Parameters.Add("ssn", ssn);
                    cancel.Parameters.Add("id", Events_grid.Rows[e.RowIndex].Cells[0].Value.ToString());
                    int r = cancel.ExecuteNonQuery();
                    if (r != -1)
                    {
                        OracleCommand d = new OracleCommand();
                        d.Connection = con;
                        d.CommandText = "select event_capacity from event where EVENT_ID=:id";
                        d.CommandType = CommandType.Text;
                        d.Parameters.Add("id", Events_grid.Rows[e.RowIndex].Cells[0].Value.ToString());
                        OracleDataReader c = d.ExecuteReader();
                        string cap = null;
                        while (c.Read())
                        {
                            cap = c[0].ToString();
                        }
                        c.Close();

                        OracleCommand u = new OracleCommand();
                        cap = (Convert.ToInt32(cap) + 1).ToString();
                        u.Connection = con;
                        u.CommandText = "update event set EVENT_CAPACITY = :cap where EVENT_ID = :id";
                        u.CommandType = CommandType.Text;
                        u.Parameters.Add("cap", cap);
                        u.Parameters.Add("id", Events_grid.Rows[e.RowIndex].Cells[0].Value.ToString());
                        int update = u.ExecuteNonQuery();
                        if (update != -1)
                        {
                            MessageBox.Show("Event canceled");
                            Events_grid.Rows.RemoveAt(e.RowIndex);
                        }
                    }
                }

                if (e.ColumnIndex == 7)
                {
                    DataRow dr = dataset.Tables[0].NewRow();
                    dr["SSN"] = ssn;
                    dr["EVENT_ID"] = Events_grid.Rows[e.RowIndex].Cells[0].Value;
                    dr["RATE"] = Events_grid.Rows[e.RowIndex].Cells[5].Value;
                    dataset.Tables[0].Rows.Add(dr);

                    OracleCommandBuilder builder = new OracleCommandBuilder(adapter);
                    adapter.Update(dataset.Tables[0]);
                    MessageBox.Show("Rated Succesfully");
                }
            }
        }

        private void StudentsEventsForm_Load(object sender, EventArgs e)
        {
            string constr = "Data Source=orcl;User Id=scott;Password=tiger;";
            string cmdstr = @"select SSN,EVENT_ID,RATE
                              from rate_for
                              where SSN = :ssn";
            adapter = new OracleDataAdapter(cmdstr, constr);
            adapter.SelectCommand.Parameters.Add("ssn", ssn);
            dataset = new DataSet();
            adapter.Fill(dataset);
        }
    }
}
