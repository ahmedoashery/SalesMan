namespace SalesManagement.View
{
    partial class Database
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
            this.btnBackup = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBacupNewYear = new System.Windows.Forms.Button();
            this.infotips = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBackup
            // 
            this.btnBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackup.Location = new System.Drawing.Point(307, 57);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(166, 29);
            this.btnBackup.TabIndex = 0;
            this.btnBackup.Text = "نسخ قاعدة البيانات بتاريخ اليوم";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBacupNewYear);
            this.groupBox1.Controls.Add(this.btnBackup);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 271);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnBacupNewYear
            // 
            this.btnBacupNewYear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBacupNewYear.Location = new System.Drawing.Point(79, 57);
            this.btnBacupNewYear.Name = "btnBacupNewYear";
            this.btnBacupNewYear.Size = new System.Drawing.Size(166, 29);
            this.btnBacupNewYear.TabIndex = 1;
            this.btnBacupNewYear.Text = "إغلاق تعاملات بتاريخ اليوم";
            this.btnBacupNewYear.UseVisualStyleBackColor = true;
            this.btnBacupNewYear.MouseHover += new System.EventHandler(this.btnBacupNewYear_MouseHover);
            // 
            // Database
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 271);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Database";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "        أرشفة البيانات";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnBackup;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button btnBacupNewYear;
        public System.Windows.Forms.ToolTip infotips;
    }
}