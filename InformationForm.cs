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
using Oracle.DataAccess.Types;

namespace FacultyEventsPlanner
{
    public partial class InformationForm : Form
    {
        static string ordb = "Data Source=ORCL;User Id=Scott;Password=tiger;";
        OracleConnection conn = new OracleConnection(ordb);
        public SignOrLog_frm refToSign { get; set; }
        public InformationForm()
        {
            InitializeComponent();
            BackToolTip.SetToolTip(back_lbl,"Back");
        }

        private void back_lbl_Click(object sender, EventArgs e)
        {
            refToSign.Show();
            this.Hide();
        }

        private void back_lbl_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Hand;
        }

        private void back_lbl_MouseMove(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Hand;
        }

        private void back_lbl_MouseEnter(object sender, EventArgs e)
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Hand;

        }

        private void InformationForm_Load(object sender, EventArgs e)
        {
            conn.Open();
            OracleCommand display = new OracleCommand();
            display.Connection = conn;
            display.CommandType = CommandType.Text;
            display.CommandText = "select HALL_NAME ,HALL_lOCATION from hall";

            DataTable dt = new DataTable();
            OracleDataReader dr = display.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                Halls_grid.Rows.Insert(i, dr[0], dr[1]);
                i++;

            }
            dr.Close();
            conn.Close();
        }

        private void Report_btn_Click(object sender, EventArgs e)
        {
            ReportForm newReport = new ReportForm();
            newReport.refToInfo = this;
            newReport.Show();
            this.Hide();
        }
    }
}
