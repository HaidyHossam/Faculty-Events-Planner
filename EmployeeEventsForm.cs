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
    public partial class EmployeeEventsForm : Form
    {
        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection con, con2;
        public DataSet dataset, dataset2;
        public OracleDataAdapter adapter, adapter1, adapter2;
        public int index;
        public string id, date, title, budget, capacity, duration, privacy;

        string ssn;
        string username;
        string email;
        string fname;
        string lname;
        string password;
        public EmployeeForm refToEmployee { get; set; }
        public EmployeeEventsForm(string username, string password, string id, string email, string fname, string lname)
        {
            InitializeComponent();

            ssn = id;
            this.username = username;
            this.password = password;
            this.email = email;
            this.fname = fname;
            this.lname = lname;
            NameE_lbl.Text = fname;

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
                AttendedEvents_grid.Rows.Insert(i, dr[0], dr[1], dr[3], dr[2], dr[4]);
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
                for (int j = 0; j < AttendedEvents_grid.Rows.Count - 1; j++)
                {
                    for (int k = 0; k < i; k++)
                    {
                        if (AttendedEvents_grid.Rows[j].Cells[0].Value.ToString() == ids[k])
                        {
                            AttendedEvents_grid.Rows[j].Cells[5].Value = arr[k];
                        }
                    }
                }
            }
        }
        private void Home_btn_Click(object sender, EventArgs e)
        {
            OracleCommandBuilder builder = new OracleCommandBuilder(adapter);
            adapter.Update(dataset.Tables[0]);
            refToEmployee.Show();
            string constr = "Data Source=orcl;User Id=scott;Password=tiger;";
            string cmdstr = @"select EVENT_ID,EVENT_TITLE,EVENT_DURATION,EVENT_DATE,EVENT_BUDGET,EVENT_CAPACITY,EVENT_PRIVACY
                              from event";
            adapter1 = new OracleDataAdapter(cmdstr, constr);
            refToEmployee.dataset.Clear();
            adapter.Fill(refToEmployee.dataset);
            this.Hide();
        }
        private void AttendedEvents_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                    cancel.Parameters.Add("id", AttendedEvents_grid.Rows[e.RowIndex].Cells[0].Value.ToString());
                    int r = cancel.ExecuteNonQuery();
                    if (r != -1)
                    {
                        OracleCommand d = new OracleCommand();
                        d.Connection = con;
                        d.CommandText = "select event_capacity from event where EVENT_ID=:id";
                        d.CommandType = CommandType.Text;
                        d.Parameters.Add("id", AttendedEvents_grid.Rows[e.RowIndex].Cells[0].Value.ToString());
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
                        u.Parameters.Add("id", AttendedEvents_grid.Rows[e.RowIndex].Cells[0].Value.ToString());
                        int update = u.ExecuteNonQuery();
                        if (update != -1)
                        {
                            MessageBox.Show("Event canceled");
                            AttendedEvents_grid.Rows.RemoveAt(e.RowIndex);
                        }
                    }
                }

                if (e.ColumnIndex == 7)
                {
                    DataRow dr = dataset2.Tables[0].NewRow();
                    dr["SSN"] = ssn;
                    dr["EVENT_ID"] = AttendedEvents_grid.Rows[e.RowIndex].Cells[0].Value;
                    dr["RATE"] = AttendedEvents_grid.Rows[e.RowIndex].Cells[5].Value;
                    dataset2.Tables[0].Rows.Add(dr);

                    OracleCommandBuilder builder = new OracleCommandBuilder(adapter2);
                    adapter2.Update(dataset2.Tables[0]);
                    MessageBox.Show("Rated Succesfully");
                }
            }
        }

        private void MadeEvents_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 7)
                {
                    index = e.RowIndex;
                    id = MadeEvents_grid.Rows[e.RowIndex].Cells[0].Value.ToString();
                    title = MadeEvents_grid.Rows[e.RowIndex].Cells[1].Value.ToString();
                    duration = MadeEvents_grid.Rows[e.RowIndex].Cells[2].Value.ToString();
                    date = MadeEvents_grid.Rows[e.RowIndex].Cells[3].Value.ToString();
                    budget = MadeEvents_grid.Rows[e.RowIndex].Cells[4].Value.ToString();
                    capacity = MadeEvents_grid.Rows[e.RowIndex].Cells[5].Value.ToString();
                    privacy = MadeEvents_grid.Rows[e.RowIndex].Cells[6].Value.ToString();
                    EditEventForm EditEvent = new EditEventForm();
                    EditEvent.refToEmployeeEvents = this;
                    EditEvent.refToEmployee = refToEmployee;
                    EditEvent.Show();
                    this.Hide();
                }
            }
        }

        private void EmployeeEventsForm_Load(object sender, EventArgs e)
        {
            string constr = "Data Source=orcl;User Id=scott;Password=tiger;";
            string cmdstr = @"select EVENT_ID,EVENT_TITLE,EVENT_DURATION,EVENT_DATE,EVENT_BUDGET,EVENT_CAPACITY,EVENT_PRIVACY
                              from event
                              where organizer_ssn = :SSN";
            adapter = new OracleDataAdapter(cmdstr, constr);
            adapter.SelectCommand.Parameters.Add("SSN", ssn);
            dataset = new DataSet();
            adapter.Fill(dataset);
            MadeEvents_grid.DataSource = dataset.Tables[0];
            DataGridViewButtonColumn EditButtonColumn = new DataGridViewButtonColumn();
            EditButtonColumn.Name = "Edit";
            EditButtonColumn.Text = "Edit";
            EditButtonColumn.UseColumnTextForButtonValue = true;
            MadeEvents_grid.Columns.Add(EditButtonColumn);

            string constr1 = "Data Source=orcl;User Id=scott;Password=tiger;";
            string cmdstr1 = @"select SSN,EVENT_ID,RATE
                              from rate_for
                              where SSN = :ssn";
            adapter2 = new OracleDataAdapter(cmdstr1, constr1);
            adapter2.SelectCommand.Parameters.Add("ssn", ssn);
            dataset2 = new DataSet();
            adapter2.Fill(dataset2);
        }
    }
}
