using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace FacultyEventsPlanner
{
    public partial class Account : Form
    {
        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection con;
        public string ssn;
        string username;
        string password;
        string email;
        string fname;
        string lname;
        List<string> Intr = new List<string>();

        public StudentForm refToCurrentStudent { get; set; }
        public EmployeeForm refToCurrentEmployee { get; set; }

        ToolTip ShowToolTip = new ToolTip();
        Label interest = new Label();

        int lastindex1 = 95, lastindex2 = 219;

        public static bool isEmpA;
        public Account(string username, string password, string ssn, string email, string fname, string lname)
        {
            this.ssn = ssn;
            this.username = username;
            this.password = password;
            //FName_txt.Text = fname;
            this.email = email;
            this.fname = fname;
            this.lname = lname;

            InitializeComponent();
            Name_lbl.Text = username;

            UserNameAE_lbl.Text = username;
            PassAE_lbl.Text = password;
            SSNA_lbl.Text = ssn;
            EmailA_lbl.Text = email;
            FNameA_lbl.Text = fname;
            LNameA_lbl.Text = lname;

            PassAE_lbl.Hide();
            UserNameE_txt.Hide();
            PasswordE_txt.Hide();
            interestAE_cmbo.Hide();
            InterestsAE_lbl.Hide();
            Email_txt.Hide();
            FName_txt.Hide();
            LName_txt.Hide();
            ShowToolTip.SetToolTip(show_lbl, "Show Password");
            ThemeFunction();

            con = new OracleConnection(ordb);
            con.Open();


        }

        private void show_lbl_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Hand;
            if (PassAE_lbl.Visible == true)
                ShowToolTip.SetToolTip(show_lbl, "Hide Password");
            else
                ShowToolTip.SetToolTip(show_lbl, "Show Password");
            ShowToolTip.ShowAlways = true;
        }

        private void show_lbl_Click(object sender, EventArgs e)
        {
            if (PassAE_lbl.Visible == true)
            {
                PassAE_lbl.Hide();
                Stars_lbl.Show();
            }
            else
            {
                PassAE_lbl.Show();
                Stars_lbl.Hide();
            }
        }

        private void show_lbl_MouseMove(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Hand;
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {

            if (Edit_btn.Text.ToString() != "Done")
            {

                interestAE_cmbo.Show();
                InterestsAE_lbl.Show();
                UserNameE_txt.Text = username;
                UserNameE_txt.Show();
                PasswordE_txt.Text = password;
                PasswordE_txt.Show();
                Email_txt.Text = email;
                Email_txt.Show();
                FName_txt.Text = fname;
                FName_txt.Show();
                LName_txt.Text = lname;
                LName_txt.Show();
                Line7_lbl.Location = new Point(3, 269);
                Edit_btn.Text = "Done";

            }
            else
            {


                OracleCommand c = new OracleCommand();
                c.Connection = con;
                c.CommandText = "updateAccount";
                c.CommandType = CommandType.StoredProcedure;
                c.Parameters.Add("ussn", ssn);
                c.Parameters.Add("ufname", FName_txt.Text);
                c.Parameters.Add("ulname", LName_txt.Text);
                c.Parameters.Add("uemail", Email_txt.Text);
                c.Parameters.Add("upassword", PasswordE_txt.Text);
                c.Parameters.Add("uusername", UserNameE_txt.Text);
                c.ExecuteNonQuery();
                

                OracleCommand cc = new OracleCommand();
                cc.Connection = con;
                cc.CommandText = "deleteInterests";
                cc.CommandType = CommandType.StoredProcedure;
                cc.Parameters.Add("ussn", ssn);
                cc.ExecuteNonQuery();

                OracleCommand ccc = new OracleCommand();
                ccc.Connection = con;
                ccc.CommandText = "insertIntersts";
                ccc.CommandType = CommandType.StoredProcedure;

                for (int i = 0; i < Intr.Count; i++)
                {
                    ccc.Parameters.Clear();
                    ccc.Parameters.Add("ussn", ssn);
                    ccc.Parameters.Add("intrest", Intr[i]);
                    ccc.ExecuteNonQuery();
                }
                MessageBox.Show("Account Updated");

                interestAE_cmbo.Hide();
                InterestsAE_lbl.Hide();
                UserNameE_txt.Hide();
                PasswordE_txt.Hide();
                Email_txt.Hide();
                FName_txt.Hide();
                LName_txt.Hide();
                Line7_lbl.Location = new Point(3, 232);
                Edit_btn.Text = "Edit Info";
            }

        }

        private void Home_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (isEmpA)
                this.refToCurrentEmployee.Show();
            else
                this.refToCurrentStudent.Show();

        }

        private void interestAE_cmbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string choice = interestAE_cmbo.SelectedItem.ToString();
            interest.AutoSize = true;
            interest.Location = new Point(lastindex1, lastindex2);
            interest.Name = choice;
            interest.Text = choice;
            AccountInfo_pnl.Controls.Add(interest);
            Intr.Add(choice);
            int size = interest.Size.Width;
            lastindex1 += size + 1;
            interest = new Label();
            interestAE_cmbo.Items.Remove(choice);
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = con;
            c.CommandText = "deleteAccount";
            c.CommandType = CommandType.StoredProcedure;
            c.Parameters.Add("ussn", ssn);
            c.ExecuteNonQuery();
            MessageBox.Show("Account Deleted");

            SignOrLog_frm signin = new SignOrLog_frm();
            signin.Show();
            SignOrLog_frm.isEmp = true;
            this.Hide();
        }

        private void ThemeFunction()
        {
            if (StudentForm.isDark_Student || EmployeeForm.isDark_Employee)
            {
                this.BackColor = Color.FromArgb(30, 30, 30);
                AccountInfo_pnl.BackColor = Color.FromArgb(30, 30, 30);


                EmailA_lbl.ForeColor = Color.FromArgb(219, 219, 219);
                Email_lbl.ForeColor = Color.FromArgb(219, 219, 219);
                FNameA_lbl.ForeColor = Color.FromArgb(219, 219, 219);
                FName_lbl.ForeColor = Color.FromArgb(219, 219, 219);
                InterestsAE_lbl.ForeColor = Color.FromArgb(219, 219, 219);
                InterestsA_lbl.ForeColor = Color.FromArgb(219, 219, 219);
                Line2_lbl.ForeColor = Color.FromArgb(219, 219, 219);
                Line3_lbl.ForeColor = Color.FromArgb(219, 219, 219);
                Line4_lbl.ForeColor = Color.FromArgb(219, 219, 219);
                Line5_lbl.ForeColor = Color.FromArgb(219, 219, 219);
                Line6_lbl.ForeColor = Color.FromArgb(219, 219, 219);
                Line7_lbl.ForeColor = Color.FromArgb(219, 219, 219);
                Line_lbl.ForeColor = Color.FromArgb(219, 219, 219);
                LNameA_lbl.ForeColor = Color.FromArgb(219, 219, 219);
                LName_lbl.ForeColor = Color.FromArgb(219, 219, 219);
                PassAE_lbl.ForeColor = Color.FromArgb(219, 219, 219);
                PassA_lbl.ForeColor = Color.FromArgb(219, 219, 219);
                SSNA_lbl.ForeColor = Color.FromArgb(219, 219, 219);
                SSN_lbl.ForeColor = Color.FromArgb(219, 219, 219);
                Stars_lbl.ForeColor = Color.FromArgb(219, 219, 219);
                UserNameAE_lbl.ForeColor = Color.FromArgb(219, 219, 219);
                UserNameA_lbl.ForeColor = Color.FromArgb(219, 219, 219);
                AccountInfo_pnl.ForeColor = Color.FromArgb(219, 219, 219);
                Edit_btn.ForeColor = DefaultForeColor;
            }
            else
            {
                this.BackColor = DefaultBackColor;
                AccountInfo_pnl.BackColor = DefaultBackColor;

                EmailA_lbl.ForeColor = DefaultForeColor;
                Email_lbl.ForeColor = DefaultForeColor;
                FNameA_lbl.ForeColor = DefaultForeColor;
                FName_lbl.ForeColor = DefaultForeColor;
                InterestsAE_lbl.ForeColor = DefaultForeColor;
                InterestsA_lbl.ForeColor = DefaultForeColor;
                Line2_lbl.ForeColor = DefaultForeColor;
                Line3_lbl.ForeColor = DefaultForeColor;
                Line4_lbl.ForeColor = DefaultForeColor;
                Line5_lbl.ForeColor = DefaultForeColor;
                Line6_lbl.ForeColor = DefaultForeColor;
                Line7_lbl.ForeColor = DefaultForeColor;
                Line_lbl.ForeColor = DefaultForeColor;
                LNameA_lbl.ForeColor = DefaultForeColor;
                LName_lbl.ForeColor = DefaultForeColor;
                PassAE_lbl.ForeColor = DefaultForeColor;
                PassA_lbl.ForeColor = DefaultForeColor;
                SSNA_lbl.ForeColor = DefaultForeColor;
                SSN_lbl.ForeColor = DefaultForeColor;
                Stars_lbl.ForeColor = DefaultForeColor;
                UserNameAE_lbl.ForeColor = DefaultForeColor;
                UserNameA_lbl.ForeColor = DefaultForeColor;
                show_lbl.ForeColor = DefaultForeColor;
                this.ForeColor = DefaultForeColor;
                Hi_lbl.ForeColor = Color.DarkCyan;
                Name_lbl.ForeColor = Color.DarkCyan;
                Home_btn.ForeColor = DefaultForeColor;
                AccountInfo_pnl.ForeColor = DefaultForeColor;
                Edit_btn.ForeColor = DefaultForeColor;
            }
        }
    }
}
