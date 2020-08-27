namespace FacultyEventsPlanner
{
    partial class EditEventForm
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
            this.components = new System.ComponentModel.Container();
            this.SearchToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.EditEventHome_btn = new System.Windows.Forms.Button();
            this.NameE_lbl = new System.Windows.Forms.Label();
            this.HiE_lbl = new System.Windows.Forms.Label();
            this.NextE_btn = new System.Windows.Forms.Button();
            this.EventInfoFirst_grp = new System.Windows.Forms.GroupBox();
            this.EventDuration_cmbo = new System.Windows.Forms.ComboBox();
            this.EventDuration_lbl = new System.Windows.Forms.Label();
            this.Budget_lbl = new System.Windows.Forms.Label();
            this.Budget_txt = new System.Windows.Forms.TextBox();
            this.Date_lbl = new System.Windows.Forms.Label();
            this.Title_lbl = new System.Windows.Forms.Label();
            this.EventDateE_pkr = new System.Windows.Forms.DateTimePicker();
            this.Capacity = new System.Windows.Forms.Label();
            this.CapacityE_txt = new System.Windows.Forms.TextBox();
            this.TitleE_txt = new System.Windows.Forms.TextBox();
            this.PrivacyE_cmbo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EventInfoFirst_grp.SuspendLayout();
            this.SuspendLayout();
            // 
            // EditEventHome_btn
            // 
            this.EditEventHome_btn.Location = new System.Drawing.Point(413, 10);
            this.EditEventHome_btn.Name = "EditEventHome_btn";
            this.EditEventHome_btn.Size = new System.Drawing.Size(75, 23);
            this.EditEventHome_btn.TabIndex = 3;
            this.EditEventHome_btn.Text = "Home";
            this.EditEventHome_btn.UseVisualStyleBackColor = true;
            this.EditEventHome_btn.Click += new System.EventHandler(this.EditEventHome_btn_Click);
            // 
            // NameE_lbl
            // 
            this.NameE_lbl.AutoSize = true;
            this.NameE_lbl.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameE_lbl.ForeColor = System.Drawing.Color.Teal;
            this.NameE_lbl.Location = new System.Drawing.Point(108, 12);
            this.NameE_lbl.Name = "NameE_lbl";
            this.NameE_lbl.Size = new System.Drawing.Size(57, 19);
            this.NameE_lbl.TabIndex = 7;
            this.NameE_lbl.Text = "Name";
            // 
            // HiE_lbl
            // 
            this.HiE_lbl.AutoSize = true;
            this.HiE_lbl.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HiE_lbl.ForeColor = System.Drawing.Color.Teal;
            this.HiE_lbl.Location = new System.Drawing.Point(12, 12);
            this.HiE_lbl.Name = "HiE_lbl";
            this.HiE_lbl.Size = new System.Drawing.Size(99, 19);
            this.HiE_lbl.TabIndex = 6;
            this.HiE_lbl.Text = "Hello, Prof.";
            // 
            // NextE_btn
            // 
            this.NextE_btn.Location = new System.Drawing.Point(416, 285);
            this.NextE_btn.Name = "NextE_btn";
            this.NextE_btn.Size = new System.Drawing.Size(75, 23);
            this.NextE_btn.TabIndex = 14;
            this.NextE_btn.Text = "Done";
            this.NextE_btn.UseVisualStyleBackColor = true;
            this.NextE_btn.Click += new System.EventHandler(this.NextE_btn_Click);
            // 
            // EventInfoFirst_grp
            // 
            this.EventInfoFirst_grp.Controls.Add(this.EventDuration_cmbo);
            this.EventInfoFirst_grp.Controls.Add(this.EventDuration_lbl);
            this.EventInfoFirst_grp.Controls.Add(this.Budget_lbl);
            this.EventInfoFirst_grp.Controls.Add(this.Budget_txt);
            this.EventInfoFirst_grp.Controls.Add(this.Date_lbl);
            this.EventInfoFirst_grp.Controls.Add(this.Title_lbl);
            this.EventInfoFirst_grp.Controls.Add(this.EventDateE_pkr);
            this.EventInfoFirst_grp.Controls.Add(this.Capacity);
            this.EventInfoFirst_grp.Controls.Add(this.CapacityE_txt);
            this.EventInfoFirst_grp.Controls.Add(this.TitleE_txt);
            this.EventInfoFirst_grp.Controls.Add(this.PrivacyE_cmbo);
            this.EventInfoFirst_grp.Controls.Add(this.label1);
            this.EventInfoFirst_grp.Location = new System.Drawing.Point(5, 39);
            this.EventInfoFirst_grp.Name = "EventInfoFirst_grp";
            this.EventInfoFirst_grp.Size = new System.Drawing.Size(486, 240);
            this.EventInfoFirst_grp.TabIndex = 16;
            this.EventInfoFirst_grp.TabStop = false;
            this.EventInfoFirst_grp.Text = "Event Info";
            // 
            // EventDuration_cmbo
            // 
            this.EventDuration_cmbo.FormattingEnabled = true;
            this.EventDuration_cmbo.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.EventDuration_cmbo.Location = new System.Drawing.Point(248, 131);
            this.EventDuration_cmbo.Name = "EventDuration_cmbo";
            this.EventDuration_cmbo.Size = new System.Drawing.Size(232, 21);
            this.EventDuration_cmbo.TabIndex = 34;
            // 
            // EventDuration_lbl
            // 
            this.EventDuration_lbl.AutoSize = true;
            this.EventDuration_lbl.Location = new System.Drawing.Point(256, 116);
            this.EventDuration_lbl.Name = "EventDuration_lbl";
            this.EventDuration_lbl.Size = new System.Drawing.Size(47, 13);
            this.EventDuration_lbl.TabIndex = 33;
            this.EventDuration_lbl.Text = "Duration";
            // 
            // Budget_lbl
            // 
            this.Budget_lbl.AutoSize = true;
            this.Budget_lbl.Location = new System.Drawing.Point(6, 117);
            this.Budget_lbl.Name = "Budget_lbl";
            this.Budget_lbl.Size = new System.Drawing.Size(41, 13);
            this.Budget_lbl.TabIndex = 31;
            this.Budget_lbl.Text = "Budget";
            // 
            // Budget_txt
            // 
            this.Budget_txt.Location = new System.Drawing.Point(5, 132);
            this.Budget_txt.Name = "Budget_txt";
            this.Budget_txt.Size = new System.Drawing.Size(225, 20);
            this.Budget_txt.TabIndex = 32;
            // 
            // Date_lbl
            // 
            this.Date_lbl.AutoSize = true;
            this.Date_lbl.Location = new System.Drawing.Point(8, 64);
            this.Date_lbl.Name = "Date_lbl";
            this.Date_lbl.Size = new System.Drawing.Size(30, 13);
            this.Date_lbl.TabIndex = 20;
            this.Date_lbl.Text = "Date";
            // 
            // Title_lbl
            // 
            this.Title_lbl.AutoSize = true;
            this.Title_lbl.Location = new System.Drawing.Point(8, 25);
            this.Title_lbl.Name = "Title_lbl";
            this.Title_lbl.Size = new System.Drawing.Size(58, 13);
            this.Title_lbl.TabIndex = 19;
            this.Title_lbl.Text = "Event Title";
            // 
            // EventDateE_pkr
            // 
            this.EventDateE_pkr.Location = new System.Drawing.Point(11, 89);
            this.EventDateE_pkr.Name = "EventDateE_pkr";
            this.EventDateE_pkr.Size = new System.Drawing.Size(469, 20);
            this.EventDateE_pkr.TabIndex = 27;
            // 
            // Capacity
            // 
            this.Capacity.AutoSize = true;
            this.Capacity.Location = new System.Drawing.Point(6, 167);
            this.Capacity.Name = "Capacity";
            this.Capacity.Size = new System.Drawing.Size(99, 13);
            this.Capacity.TabIndex = 22;
            this.Capacity.Text = "Attendees Capacity";
            // 
            // CapacityE_txt
            // 
            this.CapacityE_txt.Location = new System.Drawing.Point(6, 183);
            this.CapacityE_txt.Name = "CapacityE_txt";
            this.CapacityE_txt.Size = new System.Drawing.Size(224, 20);
            this.CapacityE_txt.TabIndex = 25;
            // 
            // TitleE_txt
            // 
            this.TitleE_txt.Location = new System.Drawing.Point(9, 41);
            this.TitleE_txt.Name = "TitleE_txt";
            this.TitleE_txt.Size = new System.Drawing.Size(471, 20);
            this.TitleE_txt.TabIndex = 24;
            // 
            // PrivacyE_cmbo
            // 
            this.PrivacyE_cmbo.FormattingEnabled = true;
            this.PrivacyE_cmbo.Items.AddRange(new object[] {
            "Public",
            "Private"});
            this.PrivacyE_cmbo.Location = new System.Drawing.Point(249, 182);
            this.PrivacyE_cmbo.Name = "PrivacyE_cmbo";
            this.PrivacyE_cmbo.Size = new System.Drawing.Size(231, 21);
            this.PrivacyE_cmbo.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Event Privacy";
            // 
            // EditEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 321);
            this.Controls.Add(this.NextE_btn);
            this.Controls.Add(this.NameE_lbl);
            this.Controls.Add(this.HiE_lbl);
            this.Controls.Add(this.EditEventHome_btn);
            this.Controls.Add(this.EventInfoFirst_grp);
            this.Name = "EditEventForm";
            this.Text = "Edit Event";
            this.Load += new System.EventHandler(this.EditEventForm_Load);
            this.EventInfoFirst_grp.ResumeLayout(false);
            this.EventInfoFirst_grp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip SearchToolTip;
        private System.Windows.Forms.Button EditEventHome_btn;
        private System.Windows.Forms.Label NameE_lbl;
        private System.Windows.Forms.Label HiE_lbl;
        private System.Windows.Forms.Button NextE_btn;
        private System.Windows.Forms.GroupBox EventInfoFirst_grp;
        private System.Windows.Forms.ComboBox EventDuration_cmbo;
        private System.Windows.Forms.Label EventDuration_lbl;
        private System.Windows.Forms.Label Budget_lbl;
        private System.Windows.Forms.TextBox Budget_txt;
        private System.Windows.Forms.Label Date_lbl;
        private System.Windows.Forms.Label Title_lbl;
        private System.Windows.Forms.DateTimePicker EventDateE_pkr;
        private System.Windows.Forms.Label Capacity;
        private System.Windows.Forms.TextBox CapacityE_txt;
        private System.Windows.Forms.TextBox TitleE_txt;
        private System.Windows.Forms.ComboBox PrivacyE_cmbo;
        private System.Windows.Forms.Label label1;
    }
}