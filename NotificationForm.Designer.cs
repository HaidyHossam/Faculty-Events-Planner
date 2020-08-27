namespace FacultyEventsPlanner
{
    partial class NotificationForm
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
            this.JoinedEvents_grp = new System.Windows.Forms.GroupBox();
            this.JoinedEvents_grid = new System.Windows.Forms.DataGridView();
            this.Title_colm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration_colm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_colm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location_colm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Home_btn = new System.Windows.Forms.Button();
            this.NotificationHi_lbl = new System.Windows.Forms.Label();
            this.JoinedEvents_grp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JoinedEvents_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // JoinedEvents_grp
            // 
            this.JoinedEvents_grp.Controls.Add(this.JoinedEvents_grid);
            this.JoinedEvents_grp.Location = new System.Drawing.Point(12, 64);
            this.JoinedEvents_grp.Name = "JoinedEvents_grp";
            this.JoinedEvents_grp.Size = new System.Drawing.Size(457, 271);
            this.JoinedEvents_grp.TabIndex = 9;
            this.JoinedEvents_grp.TabStop = false;
            this.JoinedEvents_grp.Text = "Events You Joined";
            // 
            // JoinedEvents_grid
            // 
            this.JoinedEvents_grid.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.JoinedEvents_grid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.JoinedEvents_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.JoinedEvents_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.JoinedEvents_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.JoinedEvents_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.JoinedEvents_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title_colm,
            this.Duration_colm,
            this.Date_colm,
            this.Location_colm});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.JoinedEvents_grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.JoinedEvents_grid.Location = new System.Drawing.Point(6, 19);
            this.JoinedEvents_grid.Name = "JoinedEvents_grid";
            this.JoinedEvents_grid.Size = new System.Drawing.Size(443, 247);
            this.JoinedEvents_grid.TabIndex = 0;
            // 
            // Title_colm
            // 
            this.Title_colm.HeaderText = "Title";
            this.Title_colm.Name = "Title_colm";
            this.Title_colm.ReadOnly = true;
            // 
            // Duration_colm
            // 
            this.Duration_colm.HeaderText = "Duration";
            this.Duration_colm.Name = "Duration_colm";
            this.Duration_colm.ReadOnly = true;
            // 
            // Date_colm
            // 
            this.Date_colm.HeaderText = "Date";
            this.Date_colm.Name = "Date_colm";
            this.Date_colm.ReadOnly = true;
            // 
            // Location_colm
            // 
            this.Location_colm.HeaderText = "Location";
            this.Location_colm.Name = "Location_colm";
            this.Location_colm.ReadOnly = true;
            // 
            // Home_btn
            // 
            this.Home_btn.ForeColor = System.Drawing.Color.Black;
            this.Home_btn.Location = new System.Drawing.Point(398, 12);
            this.Home_btn.Name = "Home_btn";
            this.Home_btn.Size = new System.Drawing.Size(75, 23);
            this.Home_btn.TabIndex = 10;
            this.Home_btn.Text = "Home";
            this.Home_btn.UseVisualStyleBackColor = true;
            this.Home_btn.Click += new System.EventHandler(this.Home_btn_Click);
            // 
            // NotificationHi_lbl
            // 
            this.NotificationHi_lbl.AutoSize = true;
            this.NotificationHi_lbl.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotificationHi_lbl.ForeColor = System.Drawing.Color.Teal;
            this.NotificationHi_lbl.Location = new System.Drawing.Point(8, 9);
            this.NotificationHi_lbl.Name = "NotificationHi_lbl";
            this.NotificationHi_lbl.Size = new System.Drawing.Size(283, 36);
            this.NotificationHi_lbl.TabIndex = 11;
            this.NotificationHi_lbl.Text = "Make sure you don\'t miss any events! :)\r\nHere are the upcoming ones:";
            // 
            // NotificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 347);
            this.Controls.Add(this.NotificationHi_lbl);
            this.Controls.Add(this.Home_btn);
            this.Controls.Add(this.JoinedEvents_grp);
            this.Name = "NotificationForm";
            this.Text = "NotificationForm";
            this.JoinedEvents_grp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.JoinedEvents_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox JoinedEvents_grp;
        private System.Windows.Forms.DataGridView JoinedEvents_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title_colm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration_colm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_colm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location_colm;
        private System.Windows.Forms.Button Home_btn;
        private System.Windows.Forms.Label NotificationHi_lbl;
    }
}