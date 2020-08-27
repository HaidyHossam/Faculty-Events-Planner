using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;

namespace FacultyEventsPlanner
{
    public partial class ReportForm : Form
    {
        CrystalReport1 CR1;
        CrystalReport2 CR2;
        CrystalReport3 CR3;

        public InformationForm refToInfo { get; set; }
        public ReportForm()
        {
            InitializeComponent();
        }

        private void Home_btn_Click(object sender, EventArgs e)
        {
            refToInfo.Show();
            this.Hide();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            CR1 = new CrystalReport1();
            CR2 = new CrystalReport2();
            CR3 = new CrystalReport3();

            foreach (ParameterDiscreteValue v in CR3.ParameterFields[0].DefaultValues)
                Event_Privacy_cmb.Items.Add(v.Value);
        }

        private void Report1_btn_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = CR1;
        }

        private void Report2_btn_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = CR2;
        }

        private void Report3_btn_Click(object sender, EventArgs e)
        {
            CR3.SetParameterValue(0,Event_Privacy_cmb.Text);
            crystalReportViewer1.ReportSource = CR3;
        }
    }
}
