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
    public partial class CreateEventForm : Form
    {
        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection con;
        string returnval;
        public EmployeeForm refToEmployee { get; set; }

        int positionY = 270, StuffpnlSize = 263;
        static int num = 1;
        Panel NewStuff = new Panel();
        public CreateEventForm()
        {
            InitializeComponent();
            BackE_btn.Hide();
            Event2ndE_pnl.Hide();
            Event2ndE_pnl.AutoScroll = true;
        }

        private void NextE_btn_Click(object sender, EventArgs e)
        {
            if (NextE_btn.Text.ToString() == "Next")
            {
                con = new OracleConnection(ordb);
                con.Open();

                OracleCommand c = new OracleCommand();
                c.Connection = con;
                c.CommandText = "CREATEEVENT";
                c.CommandType = CommandType.StoredProcedure;
                c.Parameters.Add("ussn", refToEmployee.ssn);
                c.Parameters.Add("EDate", EventDateE_pkr.Value.Date.Day.ToString() + "-" + EventDateE_pkr.Value.Date.Month.ToString() + "-" + EventDateE_pkr.Value.Date.Year.ToString());
                c.Parameters.Add("Epriv", PrivacyE_cmbo.GetItemText(PrivacyE_cmbo.SelectedItem));
                c.Parameters.Add("Ecap", CapacityE_txt.Text);
                c.Parameters.Add("budget", Budget_txt.Text);
                c.Parameters.Add("Eduration", EventDuration_cmbo.SelectedItem);
                string str = PlaceE_cmbo.GetItemText(PlaceE_cmbo.SelectedItem);

                char[] spearator = { ' ' };
                string[] strlist = str.Split(spearator);

                c.Parameters.Add("hallName", strlist[0]);
                c.Parameters.Add("title", TitleE_txt.Text);
                c.Parameters.Add("specialty", Speacialty_cmbo.GetItemText(Speacialty_cmbo.SelectedItem));
                OracleParameter ret = c.Parameters.Add("Eid", OracleDbType.Int32);
                ret.Direction = ParameterDirection.Output;

                c.ExecuteNonQuery();

                returnval = c.Parameters["Eid"].Value.ToString();
                con.Close();

                con = new OracleConnection(ordb);
                con.Open();
                OracleCommand c2 = new OracleCommand();
                c2.Connection = con;
                c2.CommandType = CommandType.Text;
                c2.CommandText = "insert into supply (vendor_id, event_id) values (:vendorID,:eventID)";

                string str2 = VendorE_cmbo.GetItemText(VendorE_cmbo.SelectedItem);

                char[] spearator2 = { ' ' };
                string[] strlist2 = str2.Split(spearator);

                int id = Convert.ToInt32(strlist2[0]);
                c2.Parameters.Add("vendorID", id);
                c2.Parameters.Add("eventID", Convert.ToInt32(returnval));
                c2.ExecuteNonQuery();
                con.Close();

                DialogResult IsAddSec = MessageBox.Show("Do You Want To add Sections?", "Making Event", MessageBoxButtons.YesNo);
                if (IsAddSec == DialogResult.Yes)
                {
                    BackE_btn.Show();
                    Event2ndE_pnl.Show();
                    EventFirstE_pnl.Hide();
                    NextE_btn.Text = "Done";
                }
                else
                {
                    MessageBox.Show("OK! Your Event Has Been Created :)", "Done Event");
                    refToEmployee.Show();
                    this.Hide();
                }
            }
            else
            {
                con = new OracleConnection(ordb);
                con.Open();
                OracleCommand c2 = new OracleCommand();
                c2.Connection = con;
                c2.CommandText = "INSERTSECTION";
                c2.CommandType = CommandType.StoredProcedure;
                c2.Parameters.Add("cood_name", Coor_txt.Text);
                c2.Parameters.Add("duration", SecDuration_cmbo.SelectedItem.ToString());
                c2.Parameters.Add("content", SecContentE_txt.Text);
                c2.Parameters.Add("title", SecTitleE_txt.Text);
                c2.Parameters.Add("event_id", Convert.ToInt32(returnval));

                c2.ExecuteNonQuery();

                for (int i = 1; i < num; i++)
                {
                    OracleCommand c1 = new OracleCommand();
                    c1.Connection = con;
                    c1.CommandText = "INSERTSECTION";
                    c1.CommandType = CommandType.StoredProcedure;
                    string name = ((TextBox)Event2ndE_pnl.Controls["Coor_txt" + i.ToString()]).Text;
                    c1.Parameters.Add("cood_name", name);
                    string duration = ((ComboBox)Event2ndE_pnl.Controls["SecDuration_cmbo" + i.ToString()]).Text;
                    c1.Parameters.Add("duration", duration);
                    string content = ((TextBox)Event2ndE_pnl.Controls["SecContentE_txt" + i.ToString()]).Text;
                    c1.Parameters.Add("content", content);
                    string title = ((TextBox)Event2ndE_pnl.Controls["SecTitleE_txt" + i.ToString()]).Text;
                    c1.Parameters.Add("title", title);
                    c1.Parameters.Add("event_id", Convert.ToInt32(returnval));

                    c1.ExecuteNonQuery();
                }
                con.Close();
                MessageBox.Show("OK! Your Event Has Been Created :)", "Done Event");
                refToEmployee.Show();
                this.Hide();
            }

        }

        private void BackE_btn_Click(object sender, EventArgs e)
        {
            BackE_btn.Hide();
            Event2ndE_pnl.Hide();
            EventFirstE_pnl.Show();
            NextE_btn.Text = "Next";

        }

        private void CEHome_btn_Click(object sender, EventArgs e)
        {
            refToEmployee.Show();
            this.Hide();
        }

        private void VendorE_cmbo_Click(object sender, EventArgs e)
        {
            VendorE_cmbo.Items.Clear();
            con = new OracleConnection(ordb);
            con.Open();
            OracleCommand venor = new OracleCommand();
            venor.Connection = con;
            venor.CommandText = "select VENDOR_ID,VENDOR_NAME,VENDOR_PRICE from vendor where VENDOR_PRICE <:bdgd";
            venor.CommandType = CommandType.Text;
            int budget = Convert.ToInt32(Budget_txt.Text);
            venor.Parameters.Add("bdgd", budget);
            OracleDataReader od = venor.ExecuteReader();
            while (od.Read())
            {
                VendorE_cmbo.Items.Add(od[0] + " " + od[1] + " " + od[2]);
            }
            od.Close();
        }

        private void PlaceE_cmbo_Click(object sender, EventArgs e)
        {
            PlaceE_cmbo.Items.Clear();
            con = new OracleConnection(ordb);
            con.Open();
            OracleCommand halls = new OracleCommand();
            halls.Connection = con;
            halls.CommandText = @"select DISTINCT hall_name, hall_capacity
                                  from hall h, event e
                                  WHERE h.hall_id <> e.hall_id
                                  and e.event_date <> to_date(:Edate, 'dd-MM-yyyy')";
            halls.CommandType = CommandType.Text;
            halls.Parameters.Add("Edate", EventDateE_pkr.Value.Date.Day.ToString() + "-" + EventDateE_pkr.Value.Date.Month.ToString() + "-" + EventDateE_pkr.Value.Date.Year.ToString());
            OracleDataReader od = halls.ExecuteReader();
            while (od.Read())
            {
                PlaceE_cmbo.Items.Add(od[0] + " " + od[1]);
            }
            od.Close();
        }

        private void AddSecE_btn_Click(object sender, EventArgs e)
        {
            if (num == 5)
                MessageBox.Show("Sorry, Too Many Sections. You Can't Have More Than 5", "Error");
            else
            {
                string name = "NewStuff_pnl";
                name += num.ToString();
                NewStuff.Name = name;
                NewStuff.Size = Stuff_pnl.Size;
                NewStuff.Location = new Point(Stuff_pnl.Location.X, positionY);
                foreach (Control c in Stuff_pnl.Controls)
                {
                    Control c2 = new Control();
                    if (c.GetType() == typeof(Label))
                        c2 = new Label();
                    else if (c.GetType() == typeof(ComboBox))
                    {
                        c2 = new ComboBox();
                        if (c2.Name == "SecDuration_cmbo")
                        {
                            ComboBox temp = new ComboBox();
                            temp.Items.AddRange(new object[]
                            {
                                "1/2h",
                                "1h",
                                "2h",
                                "3h"
                            });
                            c2 = temp;
                        }
                    }
                    else if (c.GetType() == typeof(TextBox))
                        c2 = new TextBox();
                    else
                        continue;

                    if (c.Name == "SecContentE_txt")
                    {
                        TextBox temp = new TextBox();
                        temp.Multiline = true;
                        c2 = temp;
                    }
                    c2.Size = c.Size;
                    c2.Location = new Point(c.Location.X, c.Location.Y + positionY);
                    if (c.Name == "SectioNoE_lbl")
                    {
                        int secnum = num + 1;
                        c2.Text = secnum.ToString();
                    }
                    else
                        c2.Text = c.Text;
                    c2.Name = c.Name + num.ToString();

                    NewStuff.Controls.Add(c2);
                    Event2ndE_pnl.Controls.Add(c2);
                }
                Event2ndE_pnl.Controls.Add(NewStuff);
                AddSecE_btn.Location = new Point(370, positionY + StuffpnlSize);
                Event2ndE_pnl.Controls.Add(AddSecE_btn);
                num++;
                NewStuff = new Panel();
            }
        }
    }
}
