namespace FacultyEventsPlanner
{
    partial class SignOrLog_frm
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
            this.PassLogIn_lbl = new System.Windows.Forms.Label();
            this.PassLogIn_txt = new System.Windows.Forms.TextBox();
            this.noAccount_lbl = new System.Windows.Forms.Label();
            this.Create_lbl = new System.Windows.Forms.Label();
            this.Register_pnl = new System.Windows.Forms.Panel();
            this.GeneralInfo_grp = new System.Windows.Forms.GroupBox();
            this.LName_txt = new System.Windows.Forms.TextBox();
            this.Interests_grp = new System.Windows.Forms.GroupBox();
            this.Email_txt = new System.Windows.Forms.TextBox();
            this.FName_txt = new System.Windows.Forms.TextBox();
            this.Interests_cmbo = new System.Windows.Forms.ComboBox();
            this.LName_lbl = new System.Windows.Forms.Label();
            this.FName_lbl = new System.Windows.Forms.Label();
            this.SSN_lbl = new System.Windows.Forms.Label();
            this.Interest_lbl = new System.Windows.Forms.Label();
            this.UserNameReg_txt = new System.Windows.Forms.TextBox();
            this.PassReg_lbl = new System.Windows.Forms.Label();
            this.SSN_txt = new System.Windows.Forms.TextBox();
            this.Email_lbl = new System.Windows.Forms.Label();
            this.PassReg_txt = new System.Windows.Forms.TextBox();
            this.Choice_lbl = new System.Windows.Forms.Label();
            this.Choice_cmbo = new System.Windows.Forms.ComboBox();
            this.UsrName_lbl = new System.Windows.Forms.Label();
            this.SignUp_btn = new System.Windows.Forms.Button();
            this.LogIn_pnl = new System.Windows.Forms.Panel();
            this.SSNLogIn_lbl = new System.Windows.Forms.Label();
            this.SSNLogIn_txt = new System.Windows.Forms.TextBox();
            this.LogIn_btn = new System.Windows.Forms.Button();
            this.Welcome_lbl = new System.Windows.Forms.Label();
            this.Info_lbl = new System.Windows.Forms.Label();
            this.back_lbl = new System.Windows.Forms.Label();
            this.BackToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.Register_pnl.SuspendLayout();
            this.GeneralInfo_grp.SuspendLayout();
            this.LogIn_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // PassLogIn_lbl
            // 
            this.PassLogIn_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PassLogIn_lbl.AutoSize = true;
            this.PassLogIn_lbl.Location = new System.Drawing.Point(89, 148);
            this.PassLogIn_lbl.Name = "PassLogIn_lbl";
            this.PassLogIn_lbl.Size = new System.Drawing.Size(53, 13);
            this.PassLogIn_lbl.TabIndex = 1;
            this.PassLogIn_lbl.Text = "Password";
            // 
            // PassLogIn_txt
            // 
            this.PassLogIn_txt.Location = new System.Drawing.Point(87, 164);
            this.PassLogIn_txt.Name = "PassLogIn_txt";
            this.PassLogIn_txt.PasswordChar = '*';
            this.PassLogIn_txt.Size = new System.Drawing.Size(195, 20);
            this.PassLogIn_txt.TabIndex = 2;
            // 
            // noAccount_lbl
            // 
            this.noAccount_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noAccount_lbl.AutoSize = true;
            this.noAccount_lbl.Location = new System.Drawing.Point(84, 240);
            this.noAccount_lbl.Name = "noAccount_lbl";
            this.noAccount_lbl.Size = new System.Drawing.Size(122, 13);
            this.noAccount_lbl.TabIndex = 4;
            this.noAccount_lbl.Text = "Don\'t have an account?";
            // 
            // Create_lbl
            // 
            this.Create_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Create_lbl.AutoSize = true;
            this.Create_lbl.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create_lbl.ForeColor = System.Drawing.Color.SteelBlue;
            this.Create_lbl.Location = new System.Drawing.Point(201, 240);
            this.Create_lbl.Name = "Create_lbl";
            this.Create_lbl.Size = new System.Drawing.Size(81, 13);
            this.Create_lbl.TabIndex = 5;
            this.Create_lbl.Text = "Create account";
            this.Create_lbl.Click += new System.EventHandler(this.Create_lbl_Click);
            this.Create_lbl.MouseHover += new System.EventHandler(this.Create_lbl_MouseHover);
            this.Create_lbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Create_lbl_MouseMove);
            // 
            // Register_pnl
            // 
            this.Register_pnl.Controls.Add(this.GeneralInfo_grp);
            this.Register_pnl.Controls.Add(this.SignUp_btn);
            this.Register_pnl.Location = new System.Drawing.Point(12, 28);
            this.Register_pnl.Name = "Register_pnl";
            this.Register_pnl.Size = new System.Drawing.Size(477, 351);
            this.Register_pnl.TabIndex = 6;
            // 
            // GeneralInfo_grp
            // 
            this.GeneralInfo_grp.Controls.Add(this.LName_txt);
            this.GeneralInfo_grp.Controls.Add(this.Interests_grp);
            this.GeneralInfo_grp.Controls.Add(this.Email_txt);
            this.GeneralInfo_grp.Controls.Add(this.FName_txt);
            this.GeneralInfo_grp.Controls.Add(this.Interests_cmbo);
            this.GeneralInfo_grp.Controls.Add(this.LName_lbl);
            this.GeneralInfo_grp.Controls.Add(this.FName_lbl);
            this.GeneralInfo_grp.Controls.Add(this.SSN_lbl);
            this.GeneralInfo_grp.Controls.Add(this.Interest_lbl);
            this.GeneralInfo_grp.Controls.Add(this.UserNameReg_txt);
            this.GeneralInfo_grp.Controls.Add(this.PassReg_lbl);
            this.GeneralInfo_grp.Controls.Add(this.SSN_txt);
            this.GeneralInfo_grp.Controls.Add(this.Email_lbl);
            this.GeneralInfo_grp.Controls.Add(this.PassReg_txt);
            this.GeneralInfo_grp.Controls.Add(this.Choice_lbl);
            this.GeneralInfo_grp.Controls.Add(this.Choice_cmbo);
            this.GeneralInfo_grp.Controls.Add(this.UsrName_lbl);
            this.GeneralInfo_grp.Location = new System.Drawing.Point(12, 13);
            this.GeneralInfo_grp.Name = "GeneralInfo_grp";
            this.GeneralInfo_grp.Size = new System.Drawing.Size(452, 306);
            this.GeneralInfo_grp.TabIndex = 10;
            this.GeneralInfo_grp.TabStop = false;
            this.GeneralInfo_grp.Text = "General Info";
            // 
            // LName_txt
            // 
            this.LName_txt.Location = new System.Drawing.Point(251, 91);
            this.LName_txt.Name = "LName_txt";
            this.LName_txt.Size = new System.Drawing.Size(176, 20);
            this.LName_txt.TabIndex = 17;
            // 
            // Interests_grp
            // 
            this.Interests_grp.Location = new System.Drawing.Point(13, 240);
            this.Interests_grp.Name = "Interests_grp";
            this.Interests_grp.Size = new System.Drawing.Size(414, 60);
            this.Interests_grp.TabIndex = 18;
            this.Interests_grp.TabStop = false;
            this.Interests_grp.Text = "| Interests |";
            // 
            // Email_txt
            // 
            this.Email_txt.Location = new System.Drawing.Point(251, 38);
            this.Email_txt.Name = "Email_txt";
            this.Email_txt.Size = new System.Drawing.Size(176, 20);
            this.Email_txt.TabIndex = 16;
            // 
            // FName_txt
            // 
            this.FName_txt.Location = new System.Drawing.Point(13, 91);
            this.FName_txt.Name = "FName_txt";
            this.FName_txt.Size = new System.Drawing.Size(176, 20);
            this.FName_txt.TabIndex = 15;
            // 
            // Interests_cmbo
            // 
            this.Interests_cmbo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Interests_cmbo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Interests_cmbo.FormattingEnabled = true;
            this.Interests_cmbo.Items.AddRange(new object[] {
            "AI",
            "Machine learning",
            "Web",
            "Embedded",
            "Robotics",
            "Bio Medical",
            "Andriod"});
            this.Interests_cmbo.Location = new System.Drawing.Point(253, 200);
            this.Interests_cmbo.Name = "Interests_cmbo";
            this.Interests_cmbo.Size = new System.Drawing.Size(174, 21);
            this.Interests_cmbo.TabIndex = 9;
            this.Interests_cmbo.SelectedIndexChanged += new System.EventHandler(this.Interests_cmbo_SelectedIndexChanged);
            // 
            // LName_lbl
            // 
            this.LName_lbl.AutoSize = true;
            this.LName_lbl.Location = new System.Drawing.Point(252, 75);
            this.LName_lbl.Name = "LName_lbl";
            this.LName_lbl.Size = new System.Drawing.Size(58, 13);
            this.LName_lbl.TabIndex = 13;
            this.LName_lbl.Text = "Last Name";
            // 
            // FName_lbl
            // 
            this.FName_lbl.AutoSize = true;
            this.FName_lbl.Location = new System.Drawing.Point(16, 75);
            this.FName_lbl.Name = "FName_lbl";
            this.FName_lbl.Size = new System.Drawing.Size(57, 13);
            this.FName_lbl.TabIndex = 14;
            this.FName_lbl.Text = "First Name";
            // 
            // SSN_lbl
            // 
            this.SSN_lbl.AutoSize = true;
            this.SSN_lbl.Location = new System.Drawing.Point(16, 27);
            this.SSN_lbl.Name = "SSN_lbl";
            this.SSN_lbl.Size = new System.Drawing.Size(29, 13);
            this.SSN_lbl.TabIndex = 12;
            this.SSN_lbl.Text = "SSN";
            // 
            // Interest_lbl
            // 
            this.Interest_lbl.AutoSize = true;
            this.Interest_lbl.Location = new System.Drawing.Point(252, 187);
            this.Interest_lbl.Name = "Interest_lbl";
            this.Interest_lbl.Size = new System.Drawing.Size(47, 13);
            this.Interest_lbl.TabIndex = 3;
            this.Interest_lbl.Text = "Interests";
            // 
            // UserNameReg_txt
            // 
            this.UserNameReg_txt.Location = new System.Drawing.Point(11, 147);
            this.UserNameReg_txt.Name = "UserNameReg_txt";
            this.UserNameReg_txt.Size = new System.Drawing.Size(174, 20);
            this.UserNameReg_txt.TabIndex = 1;
            // 
            // PassReg_lbl
            // 
            this.PassReg_lbl.AutoSize = true;
            this.PassReg_lbl.Location = new System.Drawing.Point(252, 131);
            this.PassReg_lbl.Name = "PassReg_lbl";
            this.PassReg_lbl.Size = new System.Drawing.Size(53, 13);
            this.PassReg_lbl.TabIndex = 1;
            this.PassReg_lbl.Text = "Password";
            // 
            // SSN_txt
            // 
            this.SSN_txt.Location = new System.Drawing.Point(13, 43);
            this.SSN_txt.Name = "SSN_txt";
            this.SSN_txt.Size = new System.Drawing.Size(176, 20);
            this.SSN_txt.TabIndex = 11;
            // 
            // Email_lbl
            // 
            this.Email_lbl.AutoSize = true;
            this.Email_lbl.Location = new System.Drawing.Point(252, 25);
            this.Email_lbl.Name = "Email_lbl";
            this.Email_lbl.Size = new System.Drawing.Size(32, 13);
            this.Email_lbl.TabIndex = 11;
            this.Email_lbl.Text = "Email";
            // 
            // PassReg_txt
            // 
            this.PassReg_txt.Location = new System.Drawing.Point(251, 147);
            this.PassReg_txt.Name = "PassReg_txt";
            this.PassReg_txt.PasswordChar = '*';
            this.PassReg_txt.Size = new System.Drawing.Size(176, 20);
            this.PassReg_txt.TabIndex = 2;
            // 
            // Choice_lbl
            // 
            this.Choice_lbl.AutoSize = true;
            this.Choice_lbl.Location = new System.Drawing.Point(16, 187);
            this.Choice_lbl.Name = "Choice_lbl";
            this.Choice_lbl.Size = new System.Drawing.Size(30, 13);
            this.Choice_lbl.TabIndex = 0;
            this.Choice_lbl.Text = "I am:";
            // 
            // Choice_cmbo
            // 
            this.Choice_cmbo.FormattingEnabled = true;
            this.Choice_cmbo.Items.AddRange(new object[] {
            "Student",
            "Employee"});
            this.Choice_cmbo.Location = new System.Drawing.Point(13, 200);
            this.Choice_cmbo.Name = "Choice_cmbo";
            this.Choice_cmbo.Size = new System.Drawing.Size(176, 21);
            this.Choice_cmbo.TabIndex = 1;
            // 
            // UsrName_lbl
            // 
            this.UsrName_lbl.AutoSize = true;
            this.UsrName_lbl.Location = new System.Drawing.Point(16, 131);
            this.UsrName_lbl.Name = "UsrName_lbl";
            this.UsrName_lbl.Size = new System.Drawing.Size(57, 13);
            this.UsrName_lbl.TabIndex = 0;
            this.UsrName_lbl.Text = "UserName";
            // 
            // SignUp_btn
            // 
            this.SignUp_btn.Location = new System.Drawing.Point(399, 325);
            this.SignUp_btn.Name = "SignUp_btn";
            this.SignUp_btn.Size = new System.Drawing.Size(75, 23);
            this.SignUp_btn.TabIndex = 11;
            this.SignUp_btn.Text = "Sign Up";
            this.SignUp_btn.UseVisualStyleBackColor = true;
            this.SignUp_btn.Click += new System.EventHandler(this.SignUp_btn_Click);
            // 
            // LogIn_pnl
            // 
            this.LogIn_pnl.Controls.Add(this.SSNLogIn_lbl);
            this.LogIn_pnl.Controls.Add(this.SSNLogIn_txt);
            this.LogIn_pnl.Controls.Add(this.LogIn_btn);
            this.LogIn_pnl.Controls.Add(this.Welcome_lbl);
            this.LogIn_pnl.Controls.Add(this.PassLogIn_lbl);
            this.LogIn_pnl.Controls.Add(this.Create_lbl);
            this.LogIn_pnl.Controls.Add(this.PassLogIn_txt);
            this.LogIn_pnl.Controls.Add(this.noAccount_lbl);
            this.LogIn_pnl.Location = new System.Drawing.Point(87, 25);
            this.LogIn_pnl.Name = "LogIn_pnl";
            this.LogIn_pnl.Size = new System.Drawing.Size(362, 294);
            this.LogIn_pnl.TabIndex = 7;
            // 
            // SSNLogIn_lbl
            // 
            this.SSNLogIn_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SSNLogIn_lbl.AutoSize = true;
            this.SSNLogIn_lbl.Location = new System.Drawing.Point(89, 98);
            this.SSNLogIn_lbl.Name = "SSNLogIn_lbl";
            this.SSNLogIn_lbl.Size = new System.Drawing.Size(29, 13);
            this.SSNLogIn_lbl.TabIndex = 10;
            this.SSNLogIn_lbl.Text = "SSN";
            // 
            // SSNLogIn_txt
            // 
            this.SSNLogIn_txt.Location = new System.Drawing.Point(87, 114);
            this.SSNLogIn_txt.Name = "SSNLogIn_txt";
            this.SSNLogIn_txt.Size = new System.Drawing.Size(195, 20);
            this.SSNLogIn_txt.TabIndex = 11;
            // 
            // LogIn_btn
            // 
            this.LogIn_btn.Location = new System.Drawing.Point(140, 198);
            this.LogIn_btn.Name = "LogIn_btn";
            this.LogIn_btn.Size = new System.Drawing.Size(75, 23);
            this.LogIn_btn.TabIndex = 9;
            this.LogIn_btn.Text = "Log In";
            this.LogIn_btn.UseVisualStyleBackColor = true;
            this.LogIn_btn.Click += new System.EventHandler(this.LogIn_btn_Click);
            // 
            // Welcome_lbl
            // 
            this.Welcome_lbl.AutoSize = true;
            this.Welcome_lbl.BackColor = System.Drawing.Color.Transparent;
            this.Welcome_lbl.Font = new System.Drawing.Font("Berlin Sans FB Demi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome_lbl.ForeColor = System.Drawing.Color.DarkCyan;
            this.Welcome_lbl.Location = new System.Drawing.Point(25, 54);
            this.Welcome_lbl.Name = "Welcome_lbl";
            this.Welcome_lbl.Size = new System.Drawing.Size(313, 23);
            this.Welcome_lbl.TabIndex = 8;
            this.Welcome_lbl.Text = "Welcome! Got any events today? :)";
            // 
            // Info_lbl
            // 
            this.Info_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Info_lbl.AutoSize = true;
            this.Info_lbl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Info_lbl.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Info_lbl.Location = new System.Drawing.Point(9, 9);
            this.Info_lbl.Name = "Info_lbl";
            this.Info_lbl.Size = new System.Drawing.Size(30, 16);
            this.Info_lbl.TabIndex = 12;
            this.Info_lbl.Text = "Info";
            this.Info_lbl.Click += new System.EventHandler(this.Info_lbl_Click);
            this.Info_lbl.MouseHover += new System.EventHandler(this.Info_lbl_MouseHover);
            this.Info_lbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Info_lbl_MouseMove);
            // 
            // back_lbl
            // 
            this.back_lbl.AutoSize = true;
            this.back_lbl.BackColor = System.Drawing.Color.Silver;
            this.back_lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.back_lbl.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_lbl.ForeColor = System.Drawing.Color.White;
            this.back_lbl.Location = new System.Drawing.Point(468, -1);
            this.back_lbl.Name = "back_lbl";
            this.back_lbl.Size = new System.Drawing.Size(34, 21);
            this.back_lbl.TabIndex = 12;
            this.back_lbl.Text = "--->";
            this.back_lbl.Click += new System.EventHandler(this.back_lbl_Click);
            this.back_lbl.MouseHover += new System.EventHandler(this.back_lbl_MouseHover);
            this.back_lbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.back_lbl_MouseMove);
            // 
            // SignOrLog_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 382);
            this.Controls.Add(this.back_lbl);
            this.Controls.Add(this.Info_lbl);
            this.Controls.Add(this.Register_pnl);
            this.Controls.Add(this.LogIn_pnl);
            this.Name = "SignOrLog_frm";
            this.Text = "Welcome";
            this.Register_pnl.ResumeLayout(false);
            this.GeneralInfo_grp.ResumeLayout(false);
            this.GeneralInfo_grp.PerformLayout();
            this.LogIn_pnl.ResumeLayout(false);
            this.LogIn_pnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label PassLogIn_lbl;
        private System.Windows.Forms.TextBox PassLogIn_txt;
        private System.Windows.Forms.Label noAccount_lbl;
        private System.Windows.Forms.Label Create_lbl;
        private System.Windows.Forms.Panel Register_pnl;
        private System.Windows.Forms.TextBox PassReg_txt;
        private System.Windows.Forms.Label PassReg_lbl;
        private System.Windows.Forms.ComboBox Choice_cmbo;
        private System.Windows.Forms.Label Choice_lbl;
        private System.Windows.Forms.Panel LogIn_pnl;
        private System.Windows.Forms.Label Welcome_lbl;
        private System.Windows.Forms.Button SignUp_btn;
        private System.Windows.Forms.Button LogIn_btn;
        private System.Windows.Forms.GroupBox GeneralInfo_grp;
        private System.Windows.Forms.TextBox LName_txt;
        private System.Windows.Forms.TextBox Email_txt;
        private System.Windows.Forms.TextBox FName_txt;
        private System.Windows.Forms.ComboBox Interests_cmbo;
        private System.Windows.Forms.Label LName_lbl;
        private System.Windows.Forms.Label FName_lbl;
        private System.Windows.Forms.Label SSN_lbl;
        private System.Windows.Forms.Label Interest_lbl;
        private System.Windows.Forms.TextBox UserNameReg_txt;
        private System.Windows.Forms.TextBox SSN_txt;
        private System.Windows.Forms.Label UsrName_lbl;
        private System.Windows.Forms.Label SSNLogIn_lbl;
        private System.Windows.Forms.TextBox SSNLogIn_txt;
        private System.Windows.Forms.Label Info_lbl;
        private System.Windows.Forms.Label back_lbl;
        private System.Windows.Forms.ToolTip BackToolTip;
        private System.Windows.Forms.GroupBox Interests_grp;
        private System.Windows.Forms.Label Email_lbl;
    }
}

