using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;


namespace FacultyEventsPlanner
{
    public partial class SignOrLog_frm : Form
    {
        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection con;

        public static bool isEmp;
        ToolTip InfoToolTip = new ToolTip();
        int x = 13, y = 25;
        Label interest = new Label();
        List<String> interst_array = new List<string>();

        public SignOrLog_frm()
        {
            InitializeComponent();
            Register_pnl.Hide();
            InfoToolTip.SetToolTip(Info_lbl, "Halls location and more.");
            back_lbl.Hide();
            BackToolTip.SetToolTip(back_lbl, "Back");
            ThemeFunction();

            con = new OracleConnection(ordb);
            con.Open();
        }

        private void Create_lbl_Click(object sender, EventArgs e)
        {
            SignOrLog_frm.ActiveForm.Text = "Registeration";
            back_lbl.Show();
            LogIn_pnl.Hide();
            Register_pnl.Show();
        }

        private void Create_lbl_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Hand;
        }

        private void Create_lbl_MouseMove(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Hand;
        }

        private void LogIn_btn_Click(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = con;
            c.CommandText = "login";
            c.CommandType = CommandType.StoredProcedure;
            c.Parameters.Add("uuid", SSNLogIn_txt.Text);
            c.Parameters.Add("upassword", PassLogIn_txt.Text);

            OracleParameter uusername = new OracleParameter("uusername", OracleDbType.Varchar2, 20);
            uusername.Direction = ParameterDirection.Output;
            c.Parameters.Add(uusername);

            OracleParameter urole = new OracleParameter("urole", OracleDbType.Varchar2, 20);
            urole.Direction = ParameterDirection.Output;
            c.Parameters.Add(urole);

            OracleParameter uemail = new OracleParameter("uemail", OracleDbType.Varchar2, 20);
            uemail.Direction = ParameterDirection.Output;
            c.Parameters.Add(uemail);

            OracleParameter ufname = new OracleParameter("ufname", OracleDbType.Varchar2, 20);
            ufname.Direction = ParameterDirection.Output;
            c.Parameters.Add(ufname);

            OracleParameter ulname = new OracleParameter("ulname", OracleDbType.Varchar2, 20);
            ulname.Direction = ParameterDirection.Output;
            c.Parameters.Add(ulname);

            string username = "";
            string email = "";
            string fname = "";
            string lname = "";
            try
            {
                c.ExecuteNonQuery();

                if (Convert.ToString(urole.Value) == "Student")
                {
                    username = Convert.ToString(uusername.Value);
                    email = Convert.ToString(uemail.Value);
                    fname = Convert.ToString(ufname.Value);
                    lname = Convert.ToString(ulname.Value);
                    StudentForm stud;
                    stud = new StudentForm(username, PassLogIn_txt.Text, SSNLogIn_txt.Text, email, fname, lname);
                    isEmp = false;
                    stud.refToMain = this;
                    stud.Show();
                    this.Hide();
                }
                else
                {
                    username = Convert.ToString(uusername.Value);
                    email = Convert.ToString(uemail.Value);
                    fname = Convert.ToString(ufname.Value);
                    lname = Convert.ToString(ulname.Value);
                    EmployeeForm emp;
                    emp = new EmployeeForm(username, PassLogIn_txt.Text, SSNLogIn_txt.Text, email, fname, lname);
                    emp.refToMain = this;
                    isEmp = true;
                    emp.Show();
                    this.Hide();
                }

            }
            catch
            { MessageBox.Show("invalid username/password"); }
        }

        private void Info_lbl_Click(object sender, EventArgs e)
        {
            InformationForm newinfo = new InformationForm();
            newinfo.refToSign = this;
            newinfo.Show();
            this.Hide();
        }

        private void Info_lbl_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Hand;
        }

        private void Info_lbl_MouseMove(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Hand;
        }

        private void back_lbl_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Hand;
        }

        private void back_lbl_MouseMove(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Hand;
        }

        private void back_lbl_Click(object sender, EventArgs e)
        {
            LogIn_pnl.Show();
            Register_pnl.Hide();
            back_lbl.Hide();
        }
        private void ThemeFunction()
        {
            if (StudentForm.isDark_Student || EmployeeForm.isDark_Employee)
            {
                this.BackColor = Color.FromArgb(30, 30, 30);
                LogIn_pnl.BackColor = Color.FromArgb(30, 30, 30);
                Register_pnl.BackColor = Color.FromArgb(30, 30, 30);

                Register_pnl.ForeColor = Color.FromArgb(219, 219, 219);
                SSNLogIn_lbl.ForeColor = Color.FromArgb(219, 219, 219);
                PassLogIn_lbl.ForeColor = Color.FromArgb(219, 219, 219);
                noAccount_lbl.ForeColor = Color.FromArgb(219, 219, 219);
                SignUp_btn.ForeColor = DefaultForeColor;
                GeneralInfo_grp.ForeColor = Color.FromArgb(219, 219, 219);
            }
            else
            {
                this.BackColor = DefaultBackColor;
                LogIn_pnl.BackColor = DefaultBackColor;
                Register_pnl.BackColor = DefaultBackColor;

                Register_pnl.ForeColor = DefaultForeColor;
                SSNLogIn_lbl.ForeColor = DefaultForeColor;
                PassLogIn_lbl.ForeColor = DefaultForeColor;
                noAccount_lbl.ForeColor = DefaultForeColor;
                SignUp_btn.ForeColor = DefaultForeColor;
                GeneralInfo_grp.ForeColor = DefaultForeColor;
            }
        }

        private void Interests_cmbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string choice = Interests_cmbo.SelectedItem.ToString();
            interest.AutoSize = true;
            interest.Location = new Point(x, y);
            interest.Name = choice;
            interest.Text = choice;
            Interests_grp.Controls.Add(interest);
            interst_array.Add(choice);
            int size = interest.Size.Width;
            x += size + 1;
            interest = new Label();
            Interests_cmbo.Items.Remove(choice);
        }

        private void SignUp_btn_Click(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = con;
            c.CommandText = "Signup";
            c.CommandType = CommandType.StoredProcedure;
            c.Parameters.Add("ussn", SSN_txt.Text);
            c.Parameters.Add("UROLE", Choice_cmbo.SelectedItem.ToString());
            c.Parameters.Add("UFNAME", FName_txt.Text);
            c.Parameters.Add("ULNAME", LName_txt.Text);
            c.Parameters.Add("UEMAIL", Email_txt.Text);
            c.Parameters.Add("UPASSWORD", PassReg_txt.Text);
            c.Parameters.Add("UUSERNAME", UserNameReg_txt.Text);
            c.ExecuteNonQuery();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "insertIntersts";
            cmd.CommandType = CommandType.StoredProcedure;

            for (int i = 0; i < interst_array.Count; i++)
            {
                cmd.Parameters.Clear();
                cmd.Parameters.Add("ussn", SSN_txt.Text);
                cmd.Parameters.Add("intrest", interst_array[i]);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Signup successfully.");
        }
    }
}
