namespace FacultyEventsPlanner
{
    partial class StudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Hi_lbl = new System.Windows.Forms.Label();
            this.Name_lbl = new System.Windows.Forms.Label();
            this.SMenuStrip_mnu = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myEventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editThemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Notif_mnu = new System.Windows.Forms.ToolStripMenuItem();
            this.LogOutS_btn = new System.Windows.Forms.Button();
            this.Search_btn = new System.Windows.Forms.Button();
            this.TitleSearch_txt = new System.Windows.Forms.TextBox();
            this.TitleSearch_lbl = new System.Windows.Forms.Label();
            this.Events_tab = new System.Windows.Forms.TabControl();
            this.SearchResult_tab = new System.Windows.Forms.TabPage();
            this.SearchEvents_grp = new System.Windows.Forms.GroupBox();
            this.SearchEvents_grid = new System.Windows.Forms.DataGridView();
            this.AllEvents_tab = new System.Windows.Forms.TabPage();
            this.EventsS_grp = new System.Windows.Forms.GroupBox();
            this.Events_grid = new System.Windows.Forms.DataGridView();
            this.RecommenEvents_tab = new System.Windows.Forms.TabPage();
            this.RecommendEvents_grp = new System.Windows.Forms.GroupBox();
            this.RecommendEvents_grid = new System.Windows.Forms.DataGridView();
            this.RTitle_colm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RDuration_colm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RDate_colm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RLocation_colm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RJoin_brn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.SMenuStrip_mnu.SuspendLayout();
            this.Events_tab.SuspendLayout();
            this.SearchResult_tab.SuspendLayout();
            this.SearchEvents_grp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchEvents_grid)).BeginInit();
            this.AllEvents_tab.SuspendLayout();
            this.EventsS_grp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Events_grid)).BeginInit();
            this.RecommenEvents_tab.SuspendLayout();
            this.RecommendEvents_grp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RecommendEvents_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // Hi_lbl
            // 
            this.Hi_lbl.AutoSize = true;
            this.Hi_lbl.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hi_lbl.ForeColor = System.Drawing.Color.Teal;
            this.Hi_lbl.Location = new System.Drawing.Point(9, 30);
            this.Hi_lbl.Name = "Hi_lbl";
            this.Hi_lbl.Size = new System.Drawing.Size(36, 19);
            this.Hi_lbl.TabIndex = 0;
            this.Hi_lbl.Text = "Hi, ";
            // 
            // Name_lbl
            // 
            this.Name_lbl.AutoSize = true;
            this.Name_lbl.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_lbl.ForeColor = System.Drawing.Color.Teal;
            this.Name_lbl.Location = new System.Drawing.Point(40, 30);
            this.Name_lbl.Name = "Name_lbl";
            this.Name_lbl.Size = new System.Drawing.Size(57, 19);
            this.Name_lbl.TabIndex = 1;
            this.Name_lbl.Text = "Name";
            // 
            // SMenuStrip_mnu
            // 
            this.SMenuStrip_mnu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.SMenuStrip_mnu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.Notif_mnu});
            this.SMenuStrip_mnu.Location = new System.Drawing.Point(0, 0);
            this.SMenuStrip_mnu.Name = "SMenuStrip_mnu";
            this.SMenuStrip_mnu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.SMenuStrip_mnu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.SMenuStrip_mnu.Size = new System.Drawing.Size(577, 24);
            this.SMenuStrip_mnu.TabIndex = 3;
            this.SMenuStrip_mnu.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myAccountToolStripMenuItem,
            this.myEventsToolStripMenuItem,
            this.notificationToolStripMenuItem,
            this.editThemeToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // myAccountToolStripMenuItem
            // 
            this.myAccountToolStripMenuItem.Name = "myAccountToolStripMenuItem";
            this.myAccountToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.myAccountToolStripMenuItem.Text = "My Account";
            this.myAccountToolStripMenuItem.Click += new System.EventHandler(this.myAccountToolStripMenuItem_Click);
            // 
            // myEventsToolStripMenuItem
            // 
            this.myEventsToolStripMenuItem.Name = "myEventsToolStripMenuItem";
            this.myEventsToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.myEventsToolStripMenuItem.Text = "My Events";
            this.myEventsToolStripMenuItem.Click += new System.EventHandler(this.myEventsToolStripMenuItem_Click);
            // 
            // notificationToolStripMenuItem
            // 
            this.notificationToolStripMenuItem.Name = "notificationToolStripMenuItem";
            this.notificationToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.notificationToolStripMenuItem.Text = "Notification";
            this.notificationToolStripMenuItem.Click += new System.EventHandler(this.notificationToolStripMenuItem_Click);
            // 
            // editThemeToolStripMenuItem
            // 
            this.editThemeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defaultToolStripMenuItem,
            this.darkToolStripMenuItem});
            this.editThemeToolStripMenuItem.Name = "editThemeToolStripMenuItem";
            this.editThemeToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.editThemeToolStripMenuItem.Text = "Edit Theme";
            // 
            // defaultToolStripMenuItem
            // 
            this.defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
            this.defaultToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.defaultToolStripMenuItem.Text = "Default";
            this.defaultToolStripMenuItem.Click += new System.EventHandler(this.defaultToolStripMenuItem_Click);
            // 
            // darkToolStripMenuItem
            // 
            this.darkToolStripMenuItem.Name = "darkToolStripMenuItem";
            this.darkToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.darkToolStripMenuItem.Text = "Dark";
            this.darkToolStripMenuItem.Click += new System.EventHandler(this.darkToolStripMenuItem_Click);
            // 
            // Notif_mnu
            // 
            this.Notif_mnu.Enabled = false;
            this.Notif_mnu.Name = "Notif_mnu";
            this.Notif_mnu.Size = new System.Drawing.Size(237, 20);
            this.Notif_mnu.Text = "| you got a new notification, Check it out!";
            // 
            // LogOutS_btn
            // 
            this.LogOutS_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LogOutS_btn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LogOutS_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LogOutS_btn.Location = new System.Drawing.Point(501, 26);
            this.LogOutS_btn.Name = "LogOutS_btn";
            this.LogOutS_btn.Size = new System.Drawing.Size(72, 23);
            this.LogOutS_btn.TabIndex = 7;
            this.LogOutS_btn.Text = "Log Out";
            this.LogOutS_btn.UseVisualStyleBackColor = true;
            this.LogOutS_btn.Click += new System.EventHandler(this.LogOutS_btn_Click);
            // 
            // Search_btn
            // 
            this.Search_btn.Image = ((System.Drawing.Image)(resources.GetObject("Search_btn.Image")));
            this.Search_btn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Search_btn.Location = new System.Drawing.Point(517, 69);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(29, 27);
            this.Search_btn.TabIndex = 15;
            this.Search_btn.UseVisualStyleBackColor = true;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // TitleSearch_txt
            // 
            this.TitleSearch_txt.Location = new System.Drawing.Point(69, 73);
            this.TitleSearch_txt.Name = "TitleSearch_txt";
            this.TitleSearch_txt.Size = new System.Drawing.Size(442, 20);
            this.TitleSearch_txt.TabIndex = 14;
            // 
            // TitleSearch_lbl
            // 
            this.TitleSearch_lbl.AutoSize = true;
            this.TitleSearch_lbl.Location = new System.Drawing.Point(5, 76);
            this.TitleSearch_lbl.Name = "TitleSearch_lbl";
            this.TitleSearch_lbl.Size = new System.Drawing.Size(58, 13);
            this.TitleSearch_lbl.TabIndex = 13;
            this.TitleSearch_lbl.Text = "Event Title";
            // 
            // Events_tab
            // 
            this.Events_tab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Events_tab.Controls.Add(this.SearchResult_tab);
            this.Events_tab.Controls.Add(this.AllEvents_tab);
            this.Events_tab.Controls.Add(this.RecommenEvents_tab);
            this.Events_tab.Location = new System.Drawing.Point(0, 99);
            this.Events_tab.Name = "Events_tab";
            this.Events_tab.SelectedIndex = 0;
            this.Events_tab.Size = new System.Drawing.Size(577, 302);
            this.Events_tab.TabIndex = 16;
            // 
            // SearchResult_tab
            // 
            this.SearchResult_tab.BackColor = System.Drawing.SystemColors.Control;
            this.SearchResult_tab.Controls.Add(this.SearchEvents_grp);
            this.SearchResult_tab.Location = new System.Drawing.Point(4, 22);
            this.SearchResult_tab.Name = "SearchResult_tab";
            this.SearchResult_tab.Padding = new System.Windows.Forms.Padding(3);
            this.SearchResult_tab.Size = new System.Drawing.Size(569, 276);
            this.SearchResult_tab.TabIndex = 0;
            this.SearchResult_tab.Text = "Search Result";
            // 
            // SearchEvents_grp
            // 
            this.SearchEvents_grp.Controls.Add(this.SearchEvents_grid);
            this.SearchEvents_grp.Location = new System.Drawing.Point(7, 3);
            this.SearchEvents_grp.Name = "SearchEvents_grp";
            this.SearchEvents_grp.Size = new System.Drawing.Size(559, 271);
            this.SearchEvents_grp.TabIndex = 15;
            this.SearchEvents_grp.TabStop = false;
            this.SearchEvents_grp.Text = "| Events |";
            // 
            // SearchEvents_grid
            // 
            this.SearchEvents_grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchEvents_grid.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.SearchEvents_grid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SearchEvents_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.SearchEvents_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SearchEvents_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.SearchEvents_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SearchEvents_grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.SearchEvents_grid.Location = new System.Drawing.Point(6, 18);
            this.SearchEvents_grid.Name = "SearchEvents_grid";
            this.SearchEvents_grid.Size = new System.Drawing.Size(544, 247);
            this.SearchEvents_grid.TabIndex = 0;
            this.SearchEvents_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SearchEvents_grid_CellContentClick);
            // 
            // AllEvents_tab
            // 
            this.AllEvents_tab.BackColor = System.Drawing.SystemColors.Control;
            this.AllEvents_tab.Controls.Add(this.EventsS_grp);
            this.AllEvents_tab.Location = new System.Drawing.Point(4, 22);
            this.AllEvents_tab.Name = "AllEvents_tab";
            this.AllEvents_tab.Padding = new System.Windows.Forms.Padding(3);
            this.AllEvents_tab.Size = new System.Drawing.Size(569, 276);
            this.AllEvents_tab.TabIndex = 1;
            this.AllEvents_tab.Text = "All Events";
            // 
            // EventsS_grp
            // 
            this.EventsS_grp.Controls.Add(this.Events_grid);
            this.EventsS_grp.Location = new System.Drawing.Point(7, 3);
            this.EventsS_grp.Name = "EventsS_grp";
            this.EventsS_grp.Size = new System.Drawing.Size(559, 271);
            this.EventsS_grp.TabIndex = 14;
            this.EventsS_grp.TabStop = false;
            this.EventsS_grp.Text = "| Upcoming Events |";
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Events_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Events_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Events_grid.DefaultCellStyle = dataGridViewCellStyle4;
            this.Events_grid.Location = new System.Drawing.Point(6, 18);
            this.Events_grid.Name = "Events_grid";
            this.Events_grid.Size = new System.Drawing.Size(544, 247);
            this.Events_grid.TabIndex = 0;
            this.Events_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Events_grid_CellContentClick_1);
            // 
            // RecommenEvents_tab
            // 
            this.RecommenEvents_tab.BackColor = System.Drawing.SystemColors.Control;
            this.RecommenEvents_tab.Controls.Add(this.RecommendEvents_grp);
            this.RecommenEvents_tab.Location = new System.Drawing.Point(4, 22);
            this.RecommenEvents_tab.Name = "RecommenEvents_tab";
            this.RecommenEvents_tab.Size = new System.Drawing.Size(569, 276);
            this.RecommenEvents_tab.TabIndex = 2;
            this.RecommenEvents_tab.Text = "Recommended Events";
            // 
            // RecommendEvents_grp
            // 
            this.RecommendEvents_grp.Controls.Add(this.RecommendEvents_grid);
            this.RecommendEvents_grp.Location = new System.Drawing.Point(7, 3);
            this.RecommendEvents_grp.Name = "RecommendEvents_grp";
            this.RecommendEvents_grp.Size = new System.Drawing.Size(559, 271);
            this.RecommendEvents_grp.TabIndex = 15;
            this.RecommendEvents_grp.TabStop = false;
            this.RecommendEvents_grp.Text = "| Events You May Like |";
            // 
            // RecommendEvents_grid
            // 
            this.RecommendEvents_grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RecommendEvents_grid.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.RecommendEvents_grid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RecommendEvents_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.RecommendEvents_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RecommendEvents_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.RecommendEvents_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RecommendEvents_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RTitle_colm,
            this.RDuration_colm,
            this.RDate_colm,
            this.RLocation_colm,
            this.RJoin_brn});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RecommendEvents_grid.DefaultCellStyle = dataGridViewCellStyle6;
            this.RecommendEvents_grid.Location = new System.Drawing.Point(6, 18);
            this.RecommendEvents_grid.Name = "RecommendEvents_grid";
            this.RecommendEvents_grid.Size = new System.Drawing.Size(544, 247);
            this.RecommendEvents_grid.TabIndex = 15;
            this.RecommendEvents_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RecommendEvents_grid_CellContentClick);
            // 
            // RTitle_colm
            // 
            this.RTitle_colm.HeaderText = "Title";
            this.RTitle_colm.Name = "RTitle_colm";
            this.RTitle_colm.ReadOnly = true;
            // 
            // RDuration_colm
            // 
            this.RDuration_colm.HeaderText = "Duration";
            this.RDuration_colm.Name = "RDuration_colm";
            this.RDuration_colm.ReadOnly = true;
            // 
            // RDate_colm
            // 
            this.RDate_colm.HeaderText = "Date";
            this.RDate_colm.Name = "RDate_colm";
            this.RDate_colm.ReadOnly = true;
            // 
            // RLocation_colm
            // 
            this.RLocation_colm.HeaderText = "Location";
            this.RLocation_colm.Name = "RLocation_colm";
            this.RLocation_colm.ReadOnly = true;
            // 
            // RJoin_brn
            // 
            this.RJoin_brn.HeaderText = "Join";
            this.RJoin_brn.Name = "RJoin_brn";
            this.RJoin_brn.Text = "Join";
            this.RJoin_brn.UseColumnTextForButtonValue = true;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 401);
            this.Controls.Add(this.Events_tab);
            this.Controls.Add(this.Search_btn);
            this.Controls.Add(this.TitleSearch_txt);
            this.Controls.Add(this.TitleSearch_lbl);
            this.Controls.Add(this.LogOutS_btn);
            this.Controls.Add(this.Name_lbl);
            this.Controls.Add(this.Hi_lbl);
            this.Controls.Add(this.SMenuStrip_mnu);
            this.MainMenuStrip = this.SMenuStrip_mnu;
            this.Name = "StudentForm";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.SMenuStrip_mnu.ResumeLayout(false);
            this.SMenuStrip_mnu.PerformLayout();
            this.Events_tab.ResumeLayout(false);
            this.SearchResult_tab.ResumeLayout(false);
            this.SearchEvents_grp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SearchEvents_grid)).EndInit();
            this.AllEvents_tab.ResumeLayout(false);
            this.EventsS_grp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Events_grid)).EndInit();
            this.RecommenEvents_tab.ResumeLayout(false);
            this.RecommendEvents_grp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RecommendEvents_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Hi_lbl;
        private System.Windows.Forms.Label Name_lbl;
        private System.Windows.Forms.MenuStrip SMenuStrip_mnu;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myEventsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notificationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editThemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defaultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkToolStripMenuItem;
        private System.Windows.Forms.Button LogOutS_btn;
        private System.Windows.Forms.ToolStripMenuItem Notif_mnu;
        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.TextBox TitleSearch_txt;
        private System.Windows.Forms.Label TitleSearch_lbl;
        private System.Windows.Forms.TabControl Events_tab;
        private System.Windows.Forms.TabPage SearchResult_tab;
        private System.Windows.Forms.GroupBox SearchEvents_grp;
        private System.Windows.Forms.DataGridView SearchEvents_grid;
        private System.Windows.Forms.TabPage AllEvents_tab;
        private System.Windows.Forms.GroupBox EventsS_grp;
        private System.Windows.Forms.DataGridView Events_grid;
        private System.Windows.Forms.TabPage RecommenEvents_tab;
        private System.Windows.Forms.GroupBox RecommendEvents_grp;
        private System.Windows.Forms.DataGridView RecommendEvents_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn RTitle_colm;
        private System.Windows.Forms.DataGridViewTextBoxColumn RDuration_colm;
        private System.Windows.Forms.DataGridViewTextBoxColumn RDate_colm;
        private System.Windows.Forms.DataGridViewTextBoxColumn RLocation_colm;
        private System.Windows.Forms.DataGridViewButtonColumn RJoin_brn;
    }
}