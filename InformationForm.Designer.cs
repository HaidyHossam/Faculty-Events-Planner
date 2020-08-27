namespace FacultyEventsPlanner
{
    partial class InformationForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.InfoWelcome_lbl = new System.Windows.Forms.Label();
            this.back_lbl = new System.Windows.Forms.Label();
            this.BackToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.Halls_grid = new System.Windows.Forms.DataGridView();
            this.HallName_colm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location_colm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Report_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Halls_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // InfoWelcome_lbl
            // 
            this.InfoWelcome_lbl.AutoSize = true;
            this.InfoWelcome_lbl.Font = new System.Drawing.Font("Andalus", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoWelcome_lbl.ForeColor = System.Drawing.Color.Teal;
            this.InfoWelcome_lbl.Location = new System.Drawing.Point(17, 30);
            this.InfoWelcome_lbl.Name = "InfoWelcome_lbl";
            this.InfoWelcome_lbl.Size = new System.Drawing.Size(432, 24);
            this.InfoWelcome_lbl.TabIndex = 1;
            this.InfoWelcome_lbl.Text = "Welcome, Here Are All The Halls You Want To Know About";
            // 
            // back_lbl
            // 
            this.back_lbl.AutoSize = true;
            this.back_lbl.BackColor = System.Drawing.Color.Silver;
            this.back_lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.back_lbl.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_lbl.ForeColor = System.Drawing.Color.White;
            this.back_lbl.Location = new System.Drawing.Point(434, -1);
            this.back_lbl.Name = "back_lbl";
            this.back_lbl.Size = new System.Drawing.Size(34, 21);
            this.back_lbl.TabIndex = 2;
            this.back_lbl.Text = "--->";
            this.back_lbl.Click += new System.EventHandler(this.back_lbl_Click);
            this.back_lbl.MouseEnter += new System.EventHandler(this.back_lbl_MouseEnter);
            this.back_lbl.MouseHover += new System.EventHandler(this.back_lbl_MouseHover);
            this.back_lbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.back_lbl_MouseMove);
            // 
            // BackToolTip
            // 
            this.BackToolTip.BackColor = System.Drawing.Color.Silver;
            this.BackToolTip.ForeColor = System.Drawing.Color.Black;
            // 
            // Halls_grid
            // 
            this.Halls_grid.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.Halls_grid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Halls_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.Halls_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Halls_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Halls_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Halls_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HallName_colm,
            this.Location_colm});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Halls_grid.DefaultCellStyle = dataGridViewCellStyle4;
            this.Halls_grid.Location = new System.Drawing.Point(11, 74);
            this.Halls_grid.Name = "Halls_grid";
            this.Halls_grid.Size = new System.Drawing.Size(444, 215);
            this.Halls_grid.TabIndex = 3;
            // 
            // HallName_colm
            // 
            this.HallName_colm.HeaderText = "Hall Name";
            this.HallName_colm.Name = "HallName_colm";
            this.HallName_colm.ReadOnly = true;
            this.HallName_colm.Width = 150;
            // 
            // Location_colm
            // 
            this.Location_colm.HeaderText = "Location";
            this.Location_colm.Name = "Location_colm";
            this.Location_colm.ReadOnly = true;
            this.Location_colm.Width = 250;
            // 
            // Report_btn
            // 
            this.Report_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Report_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Report_btn.Location = new System.Drawing.Point(0, 0);
            this.Report_btn.Name = "Report_btn";
            this.Report_btn.Size = new System.Drawing.Size(104, 23);
            this.Report_btn.TabIndex = 4;
            this.Report_btn.Text = "Show Reports";
            this.Report_btn.UseVisualStyleBackColor = true;
            this.Report_btn.Click += new System.EventHandler(this.Report_btn_Click);
            // 
            // InformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 333);
            this.Controls.Add(this.Report_btn);
            this.Controls.Add(this.Halls_grid);
            this.Controls.Add(this.back_lbl);
            this.Controls.Add(this.InfoWelcome_lbl);
            this.Name = "InformationForm";
            this.Text = "Information";
            this.Load += new System.EventHandler(this.InformationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Halls_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label InfoWelcome_lbl;
        private System.Windows.Forms.Label back_lbl;
        private System.Windows.Forms.ToolTip BackToolTip;
        private System.Windows.Forms.DataGridView Halls_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn HallName_colm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location_colm;
        private System.Windows.Forms.Button Report_btn;
    }
}