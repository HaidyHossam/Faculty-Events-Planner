namespace FacultyEventsPlanner
{
    partial class EmployeeEventsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.NameE_lbl = new System.Windows.Forms.Label();
            this.HiE_lbl = new System.Windows.Forms.Label();
            this.Home_btn = new System.Windows.Forms.Button();
            this.EmployeeEvents_tab = new System.Windows.Forms.TabControl();
            this.MadeEvents_tab = new System.Windows.Forms.TabPage();
            this.MadeEvents_grid = new System.Windows.Forms.DataGridView();
            this.AttendedEvents_tab = new System.Windows.Forms.TabPage();
            this.AttendedEvents_grid = new System.Windows.Forms.DataGridView();
            this.idd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitleE_colm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DurationE_colm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateE_colm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocationE_colm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RatingE_colm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cancel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.RateE_btn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EmployeeEvents_tab.SuspendLayout();
            this.MadeEvents_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MadeEvents_grid)).BeginInit();
            this.AttendedEvents_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AttendedEvents_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // NameE_lbl
            // 
            this.NameE_lbl.AutoSize = true;
            this.NameE_lbl.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameE_lbl.ForeColor = System.Drawing.Color.Teal;
            this.NameE_lbl.Location = new System.Drawing.Point(108, 9);
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
            this.HiE_lbl.Location = new System.Drawing.Point(12, 9);
            this.HiE_lbl.Name = "HiE_lbl";
            this.HiE_lbl.Size = new System.Drawing.Size(99, 19);
            this.HiE_lbl.TabIndex = 6;
            this.HiE_lbl.Text = "Hello, Prof.";
            // 
            // Home_btn
            // 
            this.Home_btn.ForeColor = System.Drawing.Color.Black;
            this.Home_btn.Location = new System.Drawing.Point(480, 5);
            this.Home_btn.Name = "Home_btn";
            this.Home_btn.Size = new System.Drawing.Size(75, 23);
            this.Home_btn.TabIndex = 9;
            this.Home_btn.Text = "Home";
            this.Home_btn.UseVisualStyleBackColor = true;
            this.Home_btn.Click += new System.EventHandler(this.Home_btn_Click);
            // 
            // EmployeeEvents_tab
            // 
            this.EmployeeEvents_tab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeeEvents_tab.Controls.Add(this.MadeEvents_tab);
            this.EmployeeEvents_tab.Controls.Add(this.AttendedEvents_tab);
            this.EmployeeEvents_tab.Location = new System.Drawing.Point(4, 53);
            this.EmployeeEvents_tab.Name = "EmployeeEvents_tab";
            this.EmployeeEvents_tab.SelectedIndex = 0;
            this.EmployeeEvents_tab.Size = new System.Drawing.Size(553, 277);
            this.EmployeeEvents_tab.TabIndex = 10;
            // 
            // MadeEvents_tab
            // 
            this.MadeEvents_tab.BackColor = System.Drawing.SystemColors.Control;
            this.MadeEvents_tab.Controls.Add(this.MadeEvents_grid);
            this.MadeEvents_tab.Location = new System.Drawing.Point(4, 22);
            this.MadeEvents_tab.Name = "MadeEvents_tab";
            this.MadeEvents_tab.Padding = new System.Windows.Forms.Padding(3);
            this.MadeEvents_tab.Size = new System.Drawing.Size(547, 252);
            this.MadeEvents_tab.TabIndex = 0;
            this.MadeEvents_tab.Text = "Events I Have Made";
            // 
            // MadeEvents_grid
            // 
            this.MadeEvents_grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MadeEvents_grid.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.MadeEvents_grid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MadeEvents_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.MadeEvents_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MadeEvents_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.MadeEvents_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MadeEvents_grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.MadeEvents_grid.Location = new System.Drawing.Point(0, 0);
            this.MadeEvents_grid.Name = "MadeEvents_grid";
            this.MadeEvents_grid.Size = new System.Drawing.Size(543, 246);
            this.MadeEvents_grid.TabIndex = 1;
            this.MadeEvents_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MadeEvents_grid_CellContentClick);
            // 
            // AttendedEvents_tab
            // 
            this.AttendedEvents_tab.BackColor = System.Drawing.SystemColors.Control;
            this.AttendedEvents_tab.Controls.Add(this.AttendedEvents_grid);
            this.AttendedEvents_tab.Location = new System.Drawing.Point(4, 22);
            this.AttendedEvents_tab.Name = "AttendedEvents_tab";
            this.AttendedEvents_tab.Padding = new System.Windows.Forms.Padding(3);
            this.AttendedEvents_tab.Size = new System.Drawing.Size(545, 251);
            this.AttendedEvents_tab.TabIndex = 1;
            this.AttendedEvents_tab.Text = "Events I Attended";
            // 
            // AttendedEvents_grid
            // 
            this.AttendedEvents_grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AttendedEvents_grid.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.AttendedEvents_grid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AttendedEvents_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.AttendedEvents_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AttendedEvents_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.AttendedEvents_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AttendedEvents_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idd,
            this.TitleE_colm,
            this.DurationE_colm,
            this.DateE_colm,
            this.LocationE_colm,
            this.RatingE_colm,
            this.Cancel,
            this.RateE_btn});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AttendedEvents_grid.DefaultCellStyle = dataGridViewCellStyle4;
            this.AttendedEvents_grid.Location = new System.Drawing.Point(0, 0);
            this.AttendedEvents_grid.Name = "AttendedEvents_grid";
            this.AttendedEvents_grid.Size = new System.Drawing.Size(542, 248);
            this.AttendedEvents_grid.TabIndex = 1;
            this.AttendedEvents_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AttendedEvents_grid_CellContentClick);
            // 
            // idd
            // 
            this.idd.HeaderText = "ID";
            this.idd.Name = "idd";
            // 
            // TitleE_colm
            // 
            this.TitleE_colm.HeaderText = "Title";
            this.TitleE_colm.Name = "TitleE_colm";
            this.TitleE_colm.ReadOnly = true;
            // 
            // DurationE_colm
            // 
            this.DurationE_colm.HeaderText = "Duration";
            this.DurationE_colm.Name = "DurationE_colm";
            this.DurationE_colm.ReadOnly = true;
            // 
            // DateE_colm
            // 
            this.DateE_colm.HeaderText = "Date";
            this.DateE_colm.Name = "DateE_colm";
            this.DateE_colm.ReadOnly = true;
            // 
            // LocationE_colm
            // 
            this.LocationE_colm.HeaderText = "Location";
            this.LocationE_colm.Name = "LocationE_colm";
            this.LocationE_colm.ReadOnly = true;
            // 
            // RatingE_colm
            // 
            this.RatingE_colm.HeaderText = "Rating";
            this.RatingE_colm.Name = "RatingE_colm";
            // 
            // Cancel
            // 
            this.Cancel.HeaderText = "Cancel";
            this.Cancel.Name = "Cancel";
            this.Cancel.Text = "Cancel";
            this.Cancel.UseColumnTextForButtonValue = true;
            // 
            // RateE_btn
            // 
            this.RateE_btn.HeaderText = "Rate";
            this.RateE_btn.Name = "RateE_btn";
            this.RateE_btn.Text = "Rate";
            this.RateE_btn.UseColumnTextForButtonValue = true;
            // 
            // EmployeeEventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 330);
            this.Controls.Add(this.EmployeeEvents_tab);
            this.Controls.Add(this.Home_btn);
            this.Controls.Add(this.NameE_lbl);
            this.Controls.Add(this.HiE_lbl);
            this.Name = "EmployeeEventsForm";
            this.Text = "EmployeeEventsForm";
            this.Load += new System.EventHandler(this.EmployeeEventsForm_Load);
            this.EmployeeEvents_tab.ResumeLayout(false);
            this.MadeEvents_tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MadeEvents_grid)).EndInit();
            this.AttendedEvents_tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AttendedEvents_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameE_lbl;
        private System.Windows.Forms.Label HiE_lbl;
        private System.Windows.Forms.Button Home_btn;
        private System.Windows.Forms.TabControl EmployeeEvents_tab;
        private System.Windows.Forms.TabPage MadeEvents_tab;
        private System.Windows.Forms.TabPage AttendedEvents_tab;
        private System.Windows.Forms.DataGridView AttendedEvents_grid;
        private System.Windows.Forms.DataGridView MadeEvents_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn idd;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleE_colm;
        private System.Windows.Forms.DataGridViewTextBoxColumn DurationE_colm;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateE_colm;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocationE_colm;
        private System.Windows.Forms.DataGridViewTextBoxColumn RatingE_colm;
        private System.Windows.Forms.DataGridViewButtonColumn Cancel;
        private System.Windows.Forms.DataGridViewButtonColumn RateE_btn;
    }
}