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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvPersonsList = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PersonAccountNum = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PersonName = new System.Windows.Forms.Label();
            this.TotalChange = new System.Windows.Forms.Label();
            this.TotalCost = new System.Windows.Forms.Label();
            this.TotalPayments = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPersonAccountInfo = new System.Windows.Forms.DataGridView();
            this.btnPrintAccount = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonsList)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonAccountInfo)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.dgvPersonsList);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(690, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 422);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "قائمة العملاء";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(6, 27);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(194, 20);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dgvPersonsList
            // 
            this.dgvPersonsList.AllowUserToAddRows = false;
            this.dgvPersonsList.AllowUserToDeleteRows = false;
            this.dgvPersonsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPersonsList.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgvPersonsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonsList.Location = new System.Drawing.Point(6, 55);
            this.dgvPersonsList.Name = "dgvPersonsList";
            this.dgvPersonsList.ReadOnly = true;
            this.dgvPersonsList.Size = new System.Drawing.Size(197, 333);
            this.dgvPersonsList.TabIndex = 0;
            this.dgvPersonsList.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvPersonsList_DataBindingComplete);
            this.dgvPersonsList.Click += new System.EventHandler(this.dgvPersonsList_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(20, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(670, 422);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "تفاصيل الحساب";
            // 
            // PersonAccountNum
            // 
            this.PersonAccountNum.BackColor = System.Drawing.SystemColors.Window;
            this.PersonAccountNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PersonAccountNum.Font = new System.Drawing.Font("Tahoma", 12F);
            this.PersonAccountNum.Location = new System.Drawing.Point(324, 61);
            this.PersonAccountNum.Name = "PersonAccountNum";
            this.PersonAccountNum.Size = new System.Drawing.Size(254, 24);
            this.PersonAccountNum.TabIndex = 10;
            this.PersonAccountNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(583, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "رقم الحساب /";
            // 
            // PersonName
            // 
            this.PersonName.BackColor = System.Drawing.SystemColors.Window;
            this.PersonName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PersonName.Font = new System.Drawing.Font("Tahoma", 12F);
            this.PersonName.Location = new System.Drawing.Point(324, 31);
            this.PersonName.Name = "PersonName";
            this.PersonName.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.PersonName.Size = new System.Drawing.Size(254, 24);
            this.PersonName.TabIndex = 8;
            this.PersonName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalChange
            // 
            this.TotalChange.BackColor = System.Drawing.SystemColors.Window;
            this.TotalChange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalChange.Font = new System.Drawing.Font("Tahoma", 12F);
            this.TotalChange.Location = new System.Drawing.Point(13, 76);
            this.TotalChange.Name = "TotalChange";
            this.TotalChange.Size = new System.Drawing.Size(180, 24);
            this.TotalChange.TabIndex = 7;
            this.TotalChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalCost
            // 
            this.TotalCost.BackColor = System.Drawing.SystemColors.Window;
            this.TotalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalCost.Font = new System.Drawing.Font("Tahoma", 12F);
            this.TotalCost.Location = new System.Drawing.Point(13, 16);
            this.TotalCost.Name = "TotalCost";
            this.TotalCost.Size = new System.Drawing.Size(180, 24);
            this.TotalCost.TabIndex = 6;
            this.TotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalPayments
            // 
            this.TotalPayments.BackColor = System.Drawing.SystemColors.Window;
            this.TotalPayments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalPayments.Font = new System.Drawing.Font("Tahoma", 12F);
            this.TotalPayments.Location = new System.Drawing.Point(13, 46);
            this.TotalPayments.Name = "TotalPayments";
            this.TotalPayments.Size = new System.Drawing.Size(180, 24);
            this.TotalPayments.TabIndex = 5;
            this.TotalPayments.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "إجمالى الباقى  /";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "إجمالى السداد  /";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "إجمالى الحساب /";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(584, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "اسم العميل /";
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
            this.dgvPersonAccountInfo.Size = new System.Drawing.Size(664, 300);
            this.dgvPersonAccountInfo.TabIndex = 0;
            this.dgvPersonAccountInfo.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvPersonAccountInfo_DataBindingComplete);
            // 
            // btnPrintAccount
            // 
            this.btnPrintAccount.Enabled = false;
            this.btnPrintAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPrintAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintAccount.Location = new System.Drawing.Point(348, 7);
            this.btnPrintAccount.Name = "btnPrintAccount";
            this.btnPrintAccount.Size = new System.Drawing.Size(75, 28);
            this.btnPrintAccount.TabIndex = 9;
            this.btnPrintAccount.Text = "طبـــاعـة";
            this.btnPrintAccount.UseVisualStyleBackColor = true;
            this.btnPrintAccount.Click += new System.EventHandler(this.btnPrintAccount_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TotalCost);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.PersonAccountNum);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.PersonName);
            this.panel1.Controls.Add(this.TotalPayments);
            this.panel1.Controls.Add(this.TotalChange);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(664, 103);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvPersonAccountInfo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 119);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(664, 300);
            this.panel2.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnPrintAccount);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 377);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(664, 42);
            this.panel3.TabIndex = 13;
            // 
            // PersonAccountInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 502);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "PersonAccountInfo";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "   كشف حساب العملاء";
            this.Load += new System.EventHandler(this.PersonAccountInfo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonsList)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonAccountInfo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvPersonsList;
        public System.Windows.Forms.DataGridView dgvPersonAccountInfo;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Label PersonName;
        public System.Windows.Forms.Label TotalChange;
        public System.Windows.Forms.Label TotalCost;
        public System.Windows.Forms.Label TotalPayments;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnPrintAccount;
        public System.Windows.Forms.Label PersonAccountNum;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtSearch;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}