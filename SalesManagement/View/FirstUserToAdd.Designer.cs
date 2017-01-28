namespace SalesManagement.View
{
    partial class FirstUserToAdd
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtFirstUserType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFirstUserRealName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFirstUserConfirmPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFirstUserPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirstUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txtFirstUserType);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtFirstUserRealName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtFirstUserConfirmPass);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtFirstUserPass);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtFirstUserName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 186);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SalesManagement.Properties.Resources.Lubin_2;
            this.pictureBox1.Location = new System.Drawing.Point(11, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // txtFirstUserType
            // 
            this.txtFirstUserType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtFirstUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtFirstUserType.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtFirstUserType.FormattingEnabled = true;
            this.txtFirstUserType.Items.AddRange(new object[] {
            "المدير العام"});
            this.txtFirstUserType.Location = new System.Drawing.Point(191, 137);
            this.txtFirstUserType.Name = "txtFirstUserType";
            this.txtFirstUserType.Size = new System.Drawing.Size(145, 22);
            this.txtFirstUserType.Sorted = true;
            this.txtFirstUserType.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(349, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "نوع المستخدم :";
            // 
            // txtFirstUserRealName
            // 
            this.txtFirstUserRealName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtFirstUserRealName.Location = new System.Drawing.Point(128, 111);
            this.txtFirstUserRealName.Name = "txtFirstUserRealName";
            this.txtFirstUserRealName.Size = new System.Drawing.Size(208, 20);
            this.txtFirstUserRealName.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(344, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "تأكيد كلمة السر :";
            // 
            // txtFirstUserConfirmPass
            // 
            this.txtFirstUserConfirmPass.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtFirstUserConfirmPass.Location = new System.Drawing.Point(128, 85);
            this.txtFirstUserConfirmPass.Name = "txtFirstUserConfirmPass";
            this.txtFirstUserConfirmPass.Size = new System.Drawing.Size(208, 20);
            this.txtFirstUserConfirmPass.TabIndex = 5;
            this.txtFirstUserConfirmPass.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(344, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "الاسم الحقيقي :";
            // 
            // txtFirstUserPass
            // 
            this.txtFirstUserPass.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtFirstUserPass.Location = new System.Drawing.Point(128, 59);
            this.txtFirstUserPass.Name = "txtFirstUserPass";
            this.txtFirstUserPass.Size = new System.Drawing.Size(208, 20);
            this.txtFirstUserPass.TabIndex = 3;
            this.txtFirstUserPass.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "كلمة السر :";
            // 
            // txtFirstUserName
            // 
            this.txtFirstUserName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtFirstUserName.Location = new System.Drawing.Point(128, 33);
            this.txtFirstUserName.Name = "txtFirstUserName";
            this.txtFirstUserName.Size = new System.Drawing.Size(208, 20);
            this.txtFirstUserName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(342, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم المستخدم :";
            // 
            // btnOk
            // 
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.btnOk.Location = new System.Drawing.Point(18, 246);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 26);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "حفظ";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // FirstUserToAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 282);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FirstUserToAdd";
            this.Resizable = false;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "المستخدم الاساسي";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ComboBox txtFirstUserType;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtFirstUserRealName;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtFirstUserConfirmPass;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtFirstUserPass;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtFirstUserName;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnOk;
        public System.Windows.Forms.PictureBox pictureBox1;
    }
}