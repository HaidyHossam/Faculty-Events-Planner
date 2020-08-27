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
    public partial class NotificationForm : Form
    {
        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection con;
        string ssn;

        public StudentForm refToStudent { get; set; }
        public EmployeeForm refToEmployee { get; set; }
        public NotificationForm(string id)
        {
            InitializeComponent();

            ssn = id;

            con = new OracleConnection(ordb);
            con.Open();

            OracleCommand c = new OracleCommand();
            c.Connection = con;
            c.CommandText = "MyNotifications";
            c.CommandType = CommandType.StoredProcedure;
            c.Parameters.Add("UID", ssn);
            c.Parameters.Add("NOTF", OracleDbType.RefCursor,
                               ParameterDirection.Output);
            OracleDataReader dr = c.ExecuteReader();

            int i = 0;
            while (dr.Read())
            {
                JoinedEvents_grid.Rows.Insert(i, dr[0], dr[2], dr[1], dr[3]);
                i++;
            }
        }

        private void Home_btn_Click(object sender, EventArgs e)
        {
            if (refToEmployee == null)
                refToStudent.Show();
            else
                refToEmployee.Show();
            this.Hide();
        }
    }
}
