namespace SalesManagement.View
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LoginNotify = new System.Windows.Forms.NotifyIcon(this.components);
            this.RegisterFirstUser = new System.Windows.Forms.LinkLabel();
            this.txtUserPass = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtLoginMessage = new System.Windows.Forms.Label();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pboxUserLoginPicture = new System.Windows.Forms.PictureBox();
            this.pbFinalCheck = new System.Windows.Forms.PictureBox();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxUserLoginPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFinalCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.Coral;
            this.progressBar1.Location = new System.Drawing.Point(9, 347);
            this.progressBar1.MarqueeAnimationSpeed = 5;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(271, 10);
            this.progressBar1.Step = 5;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 5;
            this.progressBar1.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LoginNotify
            // 
            this.LoginNotify.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.LoginNotify.Icon = ((System.Drawing.Icon)(resources.GetObject("LoginNotify.Icon")));
            this.LoginNotify.Visible = true;
            // 
            // RegisterFirstUser
            // 
            this.RegisterFirstUser.AutoSize = true;
            this.RegisterFirstUser.BackColor = System.Drawing.Color.Transparent;
            this.RegisterFirstUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegisterFirstUser.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.RegisterFirstUser.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.RegisterFirstUser.Location = new System.Drawing.Point(120, 265);
            this.RegisterFirstUser.Name = "RegisterFirstUser";
            this.RegisterFirstUser.Size = new System.Drawing.Size(74, 13);
            this.RegisterFirstUser.TabIndex = 9;
            this.RegisterFirstUser.TabStop = true;
            this.RegisterFirstUser.Text = "مستخدم جديد";
            this.RegisterFirstUser.Visible = false;
            this.RegisterFirstUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RegisterFirstUser_LinkClicked);
            // 
            // txtUserPass
            // 
            this.txtUserPass.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserPass.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtUserPass.Location = new System.Drawing.Point(59, 197);
            this.txtUserPass.Name = "txtUserPass";
            this.txtUserPass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUserPass.Size = new System.Drawing.Size(202, 25);
            this.txtUserPass.TabIndex = 1;
            this.txtUserPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUserPass.UseSystemPasswordChar = true;
            this.txtUserPass.TextChanged += new System.EventHandler(this.txtUserPass_TextChanged);
            this.txtUserPass.MouseEnter += new System.EventHandler(this.txtUserPass_MouseEnter);
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtUserName.Location = new System.Drawing.Point(59, 163);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUserName.Size = new System.Drawing.Size(202, 25);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLoginMessage
            // 
            this.txtLoginMessage.AutoSize = true;
            this.txtLoginMessage.BackColor = System.Drawing.Color.Transparent;
            this.txtLoginMessage.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.txtLoginMessage.ForeColor = System.Drawing.Color.Maroon;
            this.txtLoginMessage.Location = new System.Drawing.Point(31, 285);
            this.txtLoginMessage.Name = "txtLoginMessage";
            this.txtLoginMessage.Size = new System.Drawing.Size(259, 17);
            this.txtLoginMessage.TabIndex = 11;
            this.txtLoginMessage.Text = "خطأ فى اسم المستخدم أو كلمة المرور";
            this.txtLoginMessage.Visible = false;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.btnLogin);
            this.metroPanel1.Controls.Add(this.pboxUserLoginPicture);
            this.metroPanel1.Controls.Add(this.progressBar1);
            this.metroPanel1.Controls.Add(this.txtUserName);
            this.metroPanel1.Controls.Add(this.RegisterFirstUser);
            this.metroPanel1.Controls.Add(this.txtUserPass);
            this.metroPanel1.Controls.Add(this.txtLoginMessage);
            this.metroPanel1.Controls.Add(this.pbFinalCheck);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(3, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(319, 313);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.BackgroundImage = global::SalesManagement.Properties.Resources.login_button;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(67)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(67)))));
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(166)))), ((int)(((byte)(33)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(109, 230);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(110, 28);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "تسجيل الدخول";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pboxUserLoginPicture
            // 
            this.pboxUserLoginPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboxUserLoginPicture.Image = global::SalesManagement.Properties.Resources.Lubin_2;
            this.pboxUserLoginPicture.Location = new System.Drawing.Point(91, 8);
            this.pboxUserLoginPicture.Name = "pboxUserLoginPicture";
            this.pboxUserLoginPicture.Size = new System.Drawing.Size(143, 149);
            this.pboxUserLoginPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxUserLoginPicture.TabIndex = 3;
            this.pboxUserLoginPicture.TabStop = false;
            // 
            // pbFinalCheck
            // 
            this.pbFinalCheck.BackColor = System.Drawing.SystemColors.Window;
            this.pbFinalCheck.Image = global::SalesManagement.Properties.Resources.AAfgU2v_1_;
            this.pbFinalCheck.Location = new System.Drawing.Point(59, 224);
            this.pbFinalCheck.Name = "pbFinalCheck";
            this.pbFinalCheck.Size = new System.Drawing.Size(44, 38);
            this.pbFinalCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbFinalCheck.TabIndex = 8;
            this.pbFinalCheck.TabStop = false;
            this.pbFinalCheck.Visible = false;
            // 
            // Login
            // 
            this.AcceptButton = this.btnLogin;
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 376);
            this.Controls.Add(this.metroPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Padding = new System.Windows.Forms.Padding(3, 60, 3, 3);
            this.Resizable = false;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "            تسجيل الدخول";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.Login_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxUserLoginPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFinalCheck)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.NotifyIcon LoginNotify;
        public System.Windows.Forms.PictureBox pbFinalCheck;
        public System.Windows.Forms.ProgressBar progressBar1;
        public System.Windows.Forms.PictureBox pboxUserLoginPicture;
        public System.Windows.Forms.TextBox txtUserPass;
        public System.Windows.Forms.Button btnLogin;
        public System.Windows.Forms.TextBox txtUserName;
        public System.Windows.Forms.LinkLabel RegisterFirstUser;
        public System.Windows.Forms.Label txtLoginMessage;
        public MetroFramework.Controls.MetroPanel metroPanel1;
    }
}