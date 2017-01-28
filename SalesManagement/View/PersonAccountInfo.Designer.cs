namespace SalesManagement.View
{
    partial class PersonAccountInfo
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
            this.dgvPersonsList = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnPrintAccount = new System.Windows.Forms.Button();
            this.TotalCost = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PersonAccountNum = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PersonName = new System.Windows.Forms.Label();
            this.TotalPayments = new System.Windows.Forms.Label();
            this.TotalChange = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvPersonAccountInfo = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonsList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonAccountInfo)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPersonsList
            // 
            this.dgvPersonsList.AllowUserToAddRows = false;
            this.dgvPersonsList.AllowUserToDeleteRows = false;
            this.dgvPersonsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPersonsList.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgvPersonsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPersonsList.Location = new System.Drawing.Point(0, 0);
            this.dgvPersonsList.Name = "dgvPersonsList";
            this.dgvPersonsList.ReadOnly = true;
            this.dgvPersonsList.Size = new System.Drawing.Size(202, 346);
            this.dgvPersonsList.TabIndex = 0;
            this.dgvPersonsList.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvPersonsList_DataBindingComplete);
            this.dgvPersonsList.Click += new System.EventHandler(this.dgvPersonsList_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(13, 70);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(171, 20);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(707, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 488);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "قائمة العملاء";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgvPersonsList);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 139);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(202, 346);
            this.panel5.TabIndex = 15;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.txtSearch);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 16);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(202, 123);
            this.panel4.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "بحث عن عميل :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(681, 123);
            this.panel1.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnPrintAccount);
            this.panel3.Controls.Add(this.TotalCost);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.PersonAccountNum);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.PersonName);
            this.panel3.Controls.Add(this.TotalPayments);
            this.panel3.Controls.Add(this.TotalChange);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(3, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(678, 123);
            this.panel3.TabIndex = 0;
            // 
            // btnPrintAccount
            // 
            this.btnPrintAccount.Enabled = false;
            this.btnPrintAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPrintAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintAccount.Location = new System.Drawing.Point(495, 79);
            this.btnPrintAccount.Name = "btnPrintAccount";
            this.btnPrintAccount.Size = new System.Drawing.Size(93, 28);
            this.btnPrintAccount.TabIndex = 19;
            this.btnPrintAccount.Text = "طبـــاعـة";
            this.btnPrintAccount.UseVisualStyleBackColor = true;
            this.btnPrintAccount.Click += new System.EventHandler(this.btnPrintAccount_Click);
            // 
            // TotalCost
            // 
            this.TotalCost.BackColor = System.Drawing.SystemColors.Window;
            this.TotalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalCost.Font = new System.Drawing.Font("Tahoma", 12F);
            this.TotalCost.Location = new System.Drawing.Point(18, 15);
            this.TotalCost.Name = "TotalCost";
            this.TotalCost.Size = new System.Drawing.Size(208, 24);
            this.TotalCost.TabIndex = 16;
            this.TotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(594, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "اسم العميل /";
            // 
            // PersonAccountNum
            // 
            this.PersonAccountNum.BackColor = System.Drawing.SystemColors.Window;
            this.PersonAccountNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PersonAccountNum.Font = new System.Drawing.Font("Tahoma", 12F);
            this.PersonAccountNum.Location = new System.Drawing.Point(355, 46);
            this.PersonAccountNum.Name = "PersonAccountNum";
            this.PersonAccountNum.Size = new System.Drawing.Size(233, 24);
            this.PersonAccountNum.TabIndex = 21;
            this.PersonAccountNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "إجمالى الحساب /";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "إجمالى السداد  /";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(593, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "رقم الحساب /";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "إجمالى الباقى  /";
            // 
            // PersonName
            // 
            this.PersonName.BackColor = System.Drawing.SystemColors.Window;
            this.PersonName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PersonName.Font = new System.Drawing.Font("Tahoma", 12F);
            this.PersonName.Location = new System.Drawing.Point(355, 16);
            this.PersonName.Name = "PersonName";
            this.PersonName.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.PersonName.Size = new System.Drawing.Size(233, 24);
            this.PersonName.TabIndex = 18;
            this.PersonName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalPayments
            // 
            this.TotalPayments.BackColor = System.Drawing.SystemColors.Window;
            this.TotalPayments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalPayments.Font = new System.Drawing.Font("Tahoma", 12F);
            this.TotalPayments.Location = new System.Drawing.Point(18, 45);
            this.TotalPayments.Name = "TotalPayments";
            this.TotalPayments.Size = new System.Drawing.Size(208, 24);
            this.TotalPayments.TabIndex = 15;
            this.TotalPayments.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalChange
            // 
            this.TotalChange.BackColor = System.Drawing.SystemColors.Window;
            this.TotalChange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalChange.Font = new System.Drawing.Font("Tahoma", 12F);
            this.TotalChange.Location = new System.Drawing.Point(18, 75);
            this.TotalChange.Name = "TotalChange";
            this.TotalChange.Size = new System.Drawing.Size(208, 24);
            this.TotalChange.TabIndex = 17;
            this.TotalChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvPersonAccountInfo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 139);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(681, 346);
            this.panel2.TabIndex = 12;
            // 
            // dgvPersonAccountInfo
            // 
            this.dgvPersonAccountInfo.AllowUserToAddRows = false;
            this.dgvPersonAccountInfo.AllowUserToDeleteRows = false;
            this.dgvPersonAccountInfo.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgvPersonAccountInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonAccountInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPersonAccountInfo.Location = new System.Drawing.Point(0, 0);
            this.dgvPersonAccountInfo.MultiSelect = false;
            this.dgvPersonAccountInfo.Name = "dgvPersonAccountInfo";
            this.dgvPersonAccountInfo.ReadOnly = true;
            this.dgvPersonAccountInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonAccountInfo.Size = new System.Drawing.Size(681, 346);
            this.dgvPersonAccountInfo.TabIndex = 0;
            this.dgvPersonAccountInfo.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvPersonAccountInfo_DataBindingComplete);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(20, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(687, 488);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "تفاصيل الحساب";
            // 
            // PersonAccountInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 568);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "PersonAccountInfo";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "   كشف حساب العملاء";
            this.Load += new System.EventHandler(this.PersonAccountInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonsList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonAccountInfo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvPersonsList;
        public System.Windows.Forms.TextBox txtSearch;
        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.DataGridView dgvPersonAccountInfo;
        public System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Button btnPrintAccount;
        public System.Windows.Forms.Label TotalCost;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label PersonAccountNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label PersonName;
        public System.Windows.Forms.Label TotalPayments;
        public System.Windows.Forms.Label TotalChange;
        public System.Windows.Forms.Label label5;


    }
}