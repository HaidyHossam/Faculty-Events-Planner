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
    public partial class EditEventForm : Form
    {
        public EmployeeForm refToEmployee { get; set; }
        public EmployeeEventsForm refToEmployeeEvents { get; set; }
        public EditEventForm()
        {
            InitializeComponent();
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            EventInfoFirst_grp.Show();
            NextE_btn.Show();
        }

        private void NextE_btn_Click(object sender, EventArgs e)
        {
            DateTime date = new DateTime(EventDateE_pkr.Value.Date.Year, EventDateE_pkr.Value.Date.Month, EventDateE_pkr.Value.Date.Day);
            refToEmployeeEvents.dataset.Tables[0].Rows[refToEmployeeEvents.index][0] = refToEmployeeEvents.id;
            refToEmployeeEvents.dataset.Tables[0].Rows[refToEmployeeEvents.index][1] = TitleE_txt.Text;
            refToEmployeeEvents.dataset.Tables[0].Rows[refToEmployeeEvents.index][2] = EventDuration_cmbo.GetItemText(EventDuration_cmbo.SelectedItem);
            refToEmployeeEvents.dataset.Tables[0].Rows[refToEmployeeEvents.index][3] = date;
            refToEmployeeEvents.dataset.Tables[0].Rows[refToEmployeeEvents.index][4] = Budget_txt.Text;
            refToEmployeeEvents.dataset.Tables[0].Rows[refToEmployeeEvents.index][5] = CapacityE_txt.Text;
            refToEmployeeEvents.dataset.Tables[0].Rows[refToEmployeeEvents.index][6] = PrivacyE_cmbo.GetItemText(PrivacyE_cmbo.SelectedItem);
            OracleCommandBuilder builder = new OracleCommandBuilder(refToEmployeeEvents.adapter);
            refToEmployeeEvents.adapter.Update(refToEmployeeEvents.dataset.Tables[0]);
            this.Hide();
            refToEmployeeEvents.Show();
        }

        private void EditEventHome_btn_Click(object sender, EventArgs e)
        {
            refToEmployee.Show();
            this.Hide();
        }

        private void EditEventForm_Load(object sender, EventArgs e)
        {
            TitleE_txt.Text = refToEmployeeEvents.title;
            Budget_txt.Text = refToEmployeeEvents.budget;
            PrivacyE_cmbo.Text = refToEmployeeEvents.privacy;
            EventDuration_cmbo.Text = refToEmployeeEvents.duration;
            CapacityE_txt.Text = refToEmployeeEvents.capacity;
            EventDateE_pkr.Value = DateTime.Parse(refToEmployeeEvents.date);
        }
    }
}
