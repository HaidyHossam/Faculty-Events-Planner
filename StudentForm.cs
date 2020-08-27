﻿using Oracle.DataAccess.Client;
using System;
using System.Data;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;


namespace FacultyEventsPlanner
{
    public partial class StudentForm : Form
    {
        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection con;
        string ssn;
        string username;
        string email;
        string fname;
        string lname;
        string password;

        List<string> IDs = new List<string>();
        List<string> Interest = new List<string>();

        OracleDataAdapter adapter;
        DataSet dataset;

        public SignOrLog_frm refToMain { get; set; }

        public static bool isEmpS;
        public static bool isDark_Student;

        public StudentForm(string username, string password, string id, string email, string fname, string lname)
        {
            InitializeComponent();
            isEmpS = SignOrLog_frm.isEmp;

            ForTheThemeFunction();

            ssn = id;
            this.username = username;
            this.password = password;
            this.email = email;
            this.fname = fname;
            this.lname = lname;
            Name_lbl.Text = fname;

            con = new OracleConnection(ordb);
            con.Open();

            OracleCommand ReIn = new OracleCommand();
            ReIn.Connection = con;
            ReIn.CommandText = "select INTERESTS from INTERESTS where SSN=:ssn";
            ReIn.CommandType = CommandType.Text;
            ReIn.Parameters.Add("ssn", ssn);
            OracleDataReader read = ReIn.ExecuteReader();
            while (read.Read())
            {
                Interest.Add(read[0].ToString());
            }
            read.Close();

            con = new OracleConnection(ordb);
            con.Open();

            OracleCommand cmd1 = new OracleCommand();
            cmd1.Connection = con;
            cmd1.CommandText = "select event_ID,event_title,Event_Duration,Event_Date,Hall_ID from event where Event_capacity>0 AND EVENT_SPECIALTY=:interest";
            cmd1.CommandType = CommandType.Text;
            //cmd.Parameters.Add("interest", Interest[0]);
            OracleDataReader dr1 = null;
            int k = 0;
            for (int j = 0; j < Interest.Count; j++)
            {
                cmd1.Parameters.Clear();
                cmd1.Parameters.Add("interest", Interest[j]);
                dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                {
                    IDs.Add(dr1[0].ToString());
                    RecommendEvents_grid.Rows.Insert(k, dr1[1], dr1[2], dr1[3], dr1[4]);
                    k++;
                }
                dr1.Close();
            }
        }

        private void myAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Account StA = new Account(username, password, ssn, email, fname, lname);
            isEmpS = SignOrLog_frm.isEmp;
            Account.isEmpA = isEmpS;
            StA.refToCurrentStudent = this;
            StA.Show();
            this.Hide();
        }

        private void LogOutS_btn_Click(object sender, EventArgs e)
        {
            SignOrLog_frm signin = new SignOrLog_frm();
            signin.Show();
            SignOrLog_frm.isEmp = true;
            this.Hide();
        }

        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isDark_Student = true;
            this.Refresh();
            ForTheThemeFunction();
        }

        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isDark_Student = false;
            this.Refresh();
            ForTheThemeFunction();
        }
        private void ForTheThemeFunction()
        {
            if (isDark_Student)
            {
                this.BackColor = Color.FromArgb(30, 30, 30);

                EventsS_grp.BackColor = Color.FromArgb(30, 30, 30);
                myAccountToolStripMenuItem.BackColor = Color.FromArgb(45, 44, 49);
                myEventsToolStripMenuItem.BackColor = Color.FromArgb(45, 44, 49);
                notificationToolStripMenuItem.BackColor = Color.FromArgb(45, 44, 49);
                editThemeToolStripMenuItem.BackColor = Color.FromArgb(45, 44, 49);
                defaultToolStripMenuItem.BackColor = Color.FromArgb(45, 44, 49);
                darkToolStripMenuItem.BackColor = Color.FromArgb(45, 44, 49);
                notificationToolStripMenuItem.BackColor = Color.FromArgb(45, 44, 49);


                EventsS_grp.ForeColor = Color.FromArgb(219, 219, 219);
                TitleSearch_lbl.ForeColor = Color.FromArgb(219, 219, 219);
                myAccountToolStripMenuItem.ForeColor = Color.FromArgb(219, 219, 219);
                myEventsToolStripMenuItem.ForeColor = Color.FromArgb(219, 219, 219);
                notificationToolStripMenuItem.ForeColor = Color.FromArgb(219, 219, 219);
                editThemeToolStripMenuItem.ForeColor = Color.FromArgb(219, 219, 219);
                defaultToolStripMenuItem.ForeColor = Color.FromArgb(219, 219, 219);
                darkToolStripMenuItem.ForeColor = Color.FromArgb(219, 219, 219);
                menuToolStripMenuItem.ForeColor = Color.FromArgb(219, 219, 219);
                notificationToolStripMenuItem.ForeColor = Color.FromArgb(219, 219, 219);

                MainMenuStrip.Renderer = new StudentMenuRenderer();

            }
            else
            {
                this.BackColor = DefaultBackColor;

                EventsS_grp.BackColor = DefaultBackColor;
                myAccountToolStripMenuItem.BackColor = DefaultBackColor;
                myEventsToolStripMenuItem.BackColor = DefaultBackColor;
                notificationToolStripMenuItem.BackColor = DefaultBackColor;
                editThemeToolStripMenuItem.BackColor = DefaultBackColor;
                defaultToolStripMenuItem.BackColor = DefaultBackColor;
                darkToolStripMenuItem.BackColor = DefaultBackColor;
                notificationToolStripMenuItem.BackColor = DefaultBackColor;

                TitleSearch_lbl.ForeColor = DefaultForeColor;
                EventsS_grp.ForeColor = DefaultForeColor;
                myAccountToolStripMenuItem.ForeColor = DefaultForeColor;
                myEventsToolStripMenuItem.ForeColor = DefaultForeColor;
                notificationToolStripMenuItem.ForeColor = DefaultForeColor;
                editThemeToolStripMenuItem.ForeColor = DefaultForeColor;
                defaultToolStripMenuItem.ForeColor = DefaultForeColor;
                darkToolStripMenuItem.ForeColor = DefaultForeColor;
                menuToolStripMenuItem.ForeColor = DefaultForeColor;
                notificationToolStripMenuItem.ForeColor = DefaultForeColor;

                MainMenuStrip.Renderer = default(ToolStripProfessionalRenderer);

            }

        }

        private void myEventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentsEventsForm Events = new StudentsEventsForm(ssn, fname);
            Events.refToStudent = this;
            Events.Show();
            this.Hide();
        }

        private void notificationToolStripMenuItem_Click(object sender, EventArgs e)
        {


            NotificationForm NewNotification = new NotificationForm(ssn);
            NewNotification.refToStudent = this;
            NewNotification.Show();
            this.Hide();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            string constr = "Data Source=orcl;User Id=scott;Password=tiger;";
            string cmdstr = @"select EVENT_ID,EVENT_TITLE,EVENT_DURATION,EVENT_DATE,EVENT_BUDGET,EVENT_CAPACITY,EVENT_PRIVACY
                              from event
                              where EVENT_PRIVACY = 'public'";
            adapter = new OracleDataAdapter(cmdstr, constr);
            dataset = new DataSet();
            adapter.Fill(dataset);
            Events_grid.DataSource = dataset.Tables[0];
            DataGridViewButtonColumn JoinButtonColumn = new DataGridViewButtonColumn();
            JoinButtonColumn.Name = "Join";
            JoinButtonColumn.Text = "Join";
            JoinButtonColumn.UseColumnTextForButtonValue = true;
            Events_grid.Columns.Add(JoinButtonColumn);
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            string constr = "Data Source=orcl;User Id=scott;Password=tiger;";
            string cmdstr = @"select EVENT_ID,EVENT_TITLE,EVENT_DURATION,EVENT_DATE,EVENT_BUDGET,EVENT_CAPACITY,EVENT_PRIVACY
                              from event
                              where EVENT_TITLE = :title ";
            OracleDataAdapter adapter1 = new OracleDataAdapter(cmdstr, constr);
            adapter1.SelectCommand.Parameters.Add("title", TitleSearch_txt.Text);
            DataSet dataset1 = new DataSet();
            adapter1.Fill(dataset1);
            SearchEvents_grid.DataSource = dataset1.Tables[0];
            DataGridViewButtonColumn JoinButtonColumn = new DataGridViewButtonColumn();
            JoinButtonColumn.Name = "Join";
            JoinButtonColumn.Text = "Join";
            JoinButtonColumn.UseColumnTextForButtonValue = true;
            SearchEvents_grid.Columns.Add(JoinButtonColumn);
        }

        private void RecommendEvents_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
              e.RowIndex >= 0)
            {
                OracleCommand Join = new OracleCommand();
                Join.CommandType = CommandType.Text;
                Join.Connection = con;
                string current = IDs[e.RowIndex];
                Join.CommandText = "insert into Register_to values(:ssn,:id)";
                Join.Parameters.Add("ssn", ssn);
                Join.Parameters.Add("id", current);
                int j = new int();
                try
                {
                    j = Join.ExecuteNonQuery();
                    if (j != -1)
                    {
                        OracleCommand u = new OracleCommand();
                        u.Connection = con;
                        u.CommandText = "select event_capacity from event where EVENT_ID=:id";
                        u.CommandType = CommandType.Text;
                        u.Parameters.Add("id", current);
                        OracleDataReader c = u.ExecuteReader();
                        string cap = null;
                        while (c.Read())
                        {
                            cap = c[0].ToString();
                        }
                        c.Close();

                        cap = (Convert.ToInt32(cap) - 1).ToString();

                        OracleCommand s = new OracleCommand();
                        s.Connection = con;
                        s.CommandText = "update event set EVENT_CAPACITY=:cap where EVENT_ID=:id";
                        s.CommandType = CommandType.Text;
                        s.Parameters.Add("cap", cap);
                        s.Parameters.Add("id", current);
                        int update = s.ExecuteNonQuery();
                        if (update != -1)
                        {
                            MessageBox.Show("You joined the event successfully");
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Already Joined");
                }
            }

        }

        private void SearchEvents_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
              e.RowIndex >= 0)
            {
                OracleCommand Join = new OracleCommand();
                Join.CommandType = CommandType.Text;
                Join.Connection = con;
                string current = SearchEvents_grid.Rows[e.RowIndex].Cells[1].Value.ToString();
                Join.CommandText = "insert into Register_to values(:ssn,:id)";
                Join.Parameters.Add("ssn", ssn);
                Join.Parameters.Add("id", current);

                int j = new int();
                try
                {
                    j = Join.ExecuteNonQuery();
                    if (j != -1)
                    {
                        OracleCommand u = new OracleCommand();
                        u.Connection = con;
                        u.CommandText = "select event_capacity from event where EVENT_ID=:id";
                        u.CommandType = CommandType.Text;
                        u.Parameters.Add("id", current);
                        OracleDataReader c = u.ExecuteReader();
                        string cap = null;
                        while (c.Read())
                        {
                            cap = c[0].ToString();
                        }
                        c.Close();

                        cap = (Convert.ToInt32(cap) - 1).ToString();

                        OracleCommand s = new OracleCommand();
                        s.Connection = con;
                        s.CommandText = "update event set EVENT_CAPACITY=:cap where EVENT_ID=:id";
                        s.CommandType = CommandType.Text;
                        s.Parameters.Add("cap", cap);
                        s.Parameters.Add("id", current);
                        int update = s.ExecuteNonQuery();
                        if (update != -1)
                        {
                            MessageBox.Show("You joined the event successfully");
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Already Joined");
                }
            }
        }

        private void Events_grid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
              e.RowIndex >= 0)
            {
                int index = e.RowIndex;
                OracleCommand Join = new OracleCommand();
                Join.CommandType = CommandType.Text;
                Join.Connection = con;
                string current = Events_grid.Rows[index].Cells[1].Value.ToString();
                Join.CommandText = "insert into Register_to values(:ssn,:id)";
                Join.Parameters.Add("ssn", ssn);
                Join.Parameters.Add("id", current);
                int j = new int();
                try
                {
                    j = Join.ExecuteNonQuery();
                    if (j != -1)
                    {
                        OracleCommand u = new OracleCommand();
                        u.Connection = con;
                        u.CommandText = "select event_capacity from event where EVENT_ID=:id";
                        u.CommandType = CommandType.Text;
                        u.Parameters.Add("id", current);
                        OracleDataReader c = u.ExecuteReader();
                        string cap = null;
                        while (c.Read())
                        {
                            cap = c[0].ToString();
                        }
                        c.Close();

                        cap = (Convert.ToInt32(cap) - 1).ToString();

                        OracleCommand s = new OracleCommand();
                        s.Connection = con;
                        s.CommandText = "update event set EVENT_CAPACITY=:cap where EVENT_ID=:id";
                        s.CommandType = CommandType.Text;
                        s.Parameters.Add("cap", cap);
                        s.Parameters.Add("id", current);
                        int update = s.ExecuteNonQuery();
                        if (update != -1)
                        {
                            MessageBox.Show("You joined the event successfully");
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Already Joined");
                }
            }
        }
    }

    //New Class For The MenuStrip Renderer Colors
    public class StudentMenuRenderer : ToolStripProfessionalRenderer
    {
        public StudentMenuRenderer() : base(new StudentMenuColors()) { }
    }
    public class StudentMenuColors : ProfessionalColorTable
    {
        public override Color MenuStripGradientBegin
        {
            get { return Color.Black; }
        }
        public override Color MenuStripGradientEnd
        {
            get { return Color.FromArgb(74, 74, 74); }
        }
        public override Color MenuItemSelected
        {
            get { return Color.FromArgb(82, 82, 82); }
        }
        public override Color MenuItemBorder
        {
            get { return Color.FromArgb(74, 74, 74); }
        }
        public override Color MenuItemPressedGradientBegin
        {
            get { return Color.Black; }
        }
        public override Color MenuItemPressedGradientMiddle
        {
            get { return Color.Black; }
        }
        public override Color MenuItemPressedGradientEnd
        {
            get { return Color.FromArgb(74, 74, 74); }
        }
    }
}
