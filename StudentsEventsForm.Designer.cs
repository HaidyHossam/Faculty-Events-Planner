namespace FacultyEventsPlanner
{
    partial class StudentsEventsForm
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
            this.EventsS_grp = new System.Windows.Forms.GroupBox();
            this.Events_grid = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitleS_colm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DurationS_colm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateS_colm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocationS_colm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cancel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.RateS_btn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Home_btn = new System.Windows.Forms.Button();
            this.Hi_lbl = new System.Windows.Forms.Label();
            this.Name_lbl = new System.Windows.Forms.Label();
            this.StudentEvents_pnl = new System.Windows.Forms.Panel();
            this.EventsS_grp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Events_grid)).BeginInit();
            this.StudentEvents_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // EventsS_grp
            // 
            this.EventsS_grp.Controls.Add(this.Events_grid);
            this.EventsS_grp.Location = new System.Drawing.Point(6, 50);
            this.EventsS_grp.Name = "EventsS_grp";
            this.EventsS_grp.Size = new System.Drawing.Size(649, 271);
            this.EventsS_grp.TabIndex = 1;
            this.EventsS_grp.TabStop = false;
            this.EventsS_grp.Text = "Events";
            // 
            // Events_grid
            // 
            this.Events_grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Events_grid.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.Events_grid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Events_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.Events_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Events_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Events_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Events_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.TitleS_colm,
            this.DurationS_colm,
            this.DateS_colm,
            this.LocationS_colm,
            this.Rating,
            this.Cancel,
            this.RateS_btn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Events_grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.Events_grid.Location = new System.Drawing.Point(6, 18);
            this.Events_grid.Name = "Events_grid";
            this.Events_grid.Size = new System.Drawing.Size(643, 247);
            this.Events_grid.TabIndex = 0;
            this.Events_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Events_grid_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // TitleS_colm
            // 
            this.TitleS_colm.HeaderText = "Title";
            this.TitleS_colm.Name = "TitleS_colm";
            this.TitleS_colm.ReadOnly = true;
            // 
            // DurationS_colm
            // 
            this.DurationS_colm.HeaderText = "Duration";
            this.DurationS_colm.Name = "DurationS_colm";
            this.DurationS_colm.ReadOnly = true;
            // 
            // DateS_colm
            // 
            this.DateS_colm.HeaderText = "Date";
            this.DateS_colm.Name = "DateS_colm";
            this.DateS_colm.ReadOnly = true;
            // 
            // LocationS_colm
            // 
            this.LocationS_colm.HeaderText = "Location";
            this.LocationS_colm.Name = "LocationS_colm";
            this.LocationS_colm.ReadOnly = true;
            // 
            // Rating
            // 
            this.Rating.HeaderText = "Rating";
            this.Rating.Name = "Rating";
            // 
            // Cancel
            // 
            this.Cancel.HeaderText = "Cancel";
            this.Cancel.Name = "Cancel";
            this.Cancel.Text = "Cancel";
            this.Cancel.UseColumnTextForButtonValue = true;
            // 
            // RateS_btn
            // 
            this.RateS_btn.HeaderText = "Rate";
            this.RateS_btn.Name = "RateS_btn";
            this.RateS_btn.Text = "Rate";
            this.RateS_btn.UseColumnTextForButtonValue = true;
            // 
            // Home_btn
            // 
            this.Home_btn.ForeColor = System.Drawing.Color.Black;
            this.Home_btn.Location = new System.Drawing.Point(590, 3);
            this.Home_btn.Name = "Home_btn";
            this.Home_btn.Size = new System.Drawing.Size(75, 23);
            this.Home_btn.TabIndex = 8;
            this.Home_btn.Text = "Home";
            this.Home_btn.UseVisualStyleBackColor = true;
            this.Home_btn.Click += new System.EventHandler(this.Home_btn_Click);
            // 
            // Hi_lbl
            // 
            this.Hi_lbl.AutoSize = true;
            this.Hi_lbl.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hi_lbl.ForeColor = System.Drawing.Color.Teal;
            this.Hi_lbl.Location = new System.Drawing.Point(13, 13);
            this.Hi_lbl.Name = "Hi_lbl";
            this.Hi_lbl.Size = new System.Drawing.Size(36, 19);
            this.Hi_lbl.TabIndex = 9;
            this.Hi_lbl.Text = "Hi, ";
            // 
            // Name_lbl
            // 
            this.Name_lbl.AutoSize = true;
            this.Name_lbl.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_lbl.ForeColor = System.Drawing.Color.Teal;
            this.Name_lbl.Location = new System.Drawing.Point(44, 13);
            this.Name_lbl.Name = "Name_lbl";
            this.Name_lbl.Size = new System.Drawing.Size(57, 19);
            this.Name_lbl.TabIndex = 10;
            this.Name_lbl.Text = "Name";
            // 
            // StudentEvents_pnl
            // 
            this.StudentEvents_pnl.Controls.Add(this.Name_lbl);
            this.StudentEvents_pnl.Controls.Add(this.Hi_lbl);
            this.StudentEvents_pnl.Controls.Add(this.Home_btn);
            this.StudentEvents_pnl.Controls.Add(this.EventsS_grp);
            this.StudentEvents_pnl.Location = new System.Drawing.Point(6, 3);
            this.StudentEvents_pnl.Name = "StudentEvents_pnl";
            this.StudentEvents_pnl.Size = new System.Drawing.Size(668, 330);
            this.StudentEvents_pnl.TabIndex = 0;
            // 
            // StudentsEventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 337);
            this.Controls.Add(this.StudentEvents_pnl);
            this.Name = "StudentsEventsForm";
            this.Text = "My Events";
            this.Load += new System.EventHandler(this.StudentsEventsForm_Load);
            this.EventsS_grp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Events_grid)).EndInit();
            this.StudentEvents_pnl.ResumeLayout(false);
            this.StudentEvents_pnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox EventsS_grp;
        private System.Windows.Forms.DataGridView Events_grid;
        private System.Windows.Forms.Button Home_btn;
        private System.Windows.Forms.Label Hi_lbl;
        private System.Windows.Forms.Label Name_lbl;
        private System.Windows.Forms.Panel StudentEvents_pnl;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleS_colm;
        private System.Windows.Forms.DataGridViewTextBoxColumn DurationS_colm;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateS_colm;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocationS_colm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rating;
        private System.Windows.Forms.DataGridViewButtonColumn Cancel;
        private System.Windows.Forms.DataGridViewButtonColumn RateS_btn;
    }
}