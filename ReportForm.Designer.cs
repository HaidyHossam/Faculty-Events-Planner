namespace FacultyEventsPlanner
{
    partial class ReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Home_btn = new System.Windows.Forms.Button();
            this.Report1_btn = new System.Windows.Forms.Button();
            this.Report2_btn = new System.Windows.Forms.Button();
            this.Report3_btn = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.Event_Privacy_lbl = new System.Windows.Forms.Label();
            this.Event_Privacy_cmb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Home_btn
            // 
            this.Home_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Home_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home_btn.Location = new System.Drawing.Point(0, 0);
            this.Home_btn.Name = "Home_btn";
            this.Home_btn.Size = new System.Drawing.Size(75, 23);
            this.Home_btn.TabIndex = 0;
            this.Home_btn.Text = "Home";
            this.Home_btn.UseVisualStyleBackColor = true;
            this.Home_btn.Click += new System.EventHandler(this.Home_btn_Click);
            // 
            // Report1_btn
            // 
            this.Report1_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Report1_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Report1_btn.Location = new System.Drawing.Point(0, 38);
            this.Report1_btn.Name = "Report1_btn";
            this.Report1_btn.Size = new System.Drawing.Size(75, 23);
            this.Report1_btn.TabIndex = 1;
            this.Report1_btn.Text = "Report 1";
            this.Report1_btn.UseVisualStyleBackColor = true;
            this.Report1_btn.Click += new System.EventHandler(this.Report1_btn_Click);
            // 
            // Report2_btn
            // 
            this.Report2_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Report2_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Report2_btn.Location = new System.Drawing.Point(81, 38);
            this.Report2_btn.Name = "Report2_btn";
            this.Report2_btn.Size = new System.Drawing.Size(75, 23);
            this.Report2_btn.TabIndex = 2;
            this.Report2_btn.Text = "Report 2";
            this.Report2_btn.UseVisualStyleBackColor = true;
            this.Report2_btn.Click += new System.EventHandler(this.Report2_btn_Click);
            // 
            // Report3_btn
            // 
            this.Report3_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Report3_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Report3_btn.Location = new System.Drawing.Point(609, 38);
            this.Report3_btn.Name = "Report3_btn";
            this.Report3_btn.Size = new System.Drawing.Size(75, 23);
            this.Report3_btn.TabIndex = 3;
            this.Report3_btn.Text = "Report 3";
            this.Report3_btn.UseVisualStyleBackColor = true;
            this.Report3_btn.Click += new System.EventHandler(this.Report3_btn_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 67);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(745, 302);
            this.crystalReportViewer1.TabIndex = 4;
            // 
            // Event_Privacy_lbl
            // 
            this.Event_Privacy_lbl.AutoSize = true;
            this.Event_Privacy_lbl.Location = new System.Drawing.Point(500, 10);
            this.Event_Privacy_lbl.Name = "Event_Privacy_lbl";
            this.Event_Privacy_lbl.Size = new System.Drawing.Size(73, 13);
            this.Event_Privacy_lbl.TabIndex = 5;
            this.Event_Privacy_lbl.Text = "Event Privacy";
            // 
            // Event_Privacy_cmb
            // 
            this.Event_Privacy_cmb.FormattingEnabled = true;
            this.Event_Privacy_cmb.Location = new System.Drawing.Point(592, 7);
            this.Event_Privacy_cmb.Name = "Event_Privacy_cmb";
            this.Event_Privacy_cmb.Size = new System.Drawing.Size(121, 21);
            this.Event_Privacy_cmb.TabIndex = 6;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 370);
            this.Controls.Add(this.Event_Privacy_cmb);
            this.Controls.Add(this.Event_Privacy_lbl);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.Report3_btn);
            this.Controls.Add(this.Report2_btn);
            this.Controls.Add(this.Report1_btn);
            this.Controls.Add(this.Home_btn);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Home_btn;
        private System.Windows.Forms.Button Report1_btn;
        private System.Windows.Forms.Button Report2_btn;
        private System.Windows.Forms.Button Report3_btn;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Label Event_Privacy_lbl;
        private System.Windows.Forms.ComboBox Event_Privacy_cmb;
    }
}