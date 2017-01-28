namespace SalesManagement.View
{
    partial class CustomersManagement
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvCustomersList = new System.Windows.Forms.DataGridView();
            this.txtSearchCustomerResult = new System.Windows.Forms.TextBox();
            this.txtSearchCustomer = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtPaids = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtChangs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUndo = new System.Windows.Forms.Button();
            this.txtCustomerAccountNum = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnNewCustomer = new System.Windows.Forms.Button();
            this.btnDeleteAllCustomers = new System.Windows.Forms.Button();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.btnEditCustomer = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomersList)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvCustomersList);
            this.groupBox4.Controls.Add(this.txtSearchCustomerResult);
            this.groupBox4.Controls.Add(this.txtSearchCustomer);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(6, 64);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(428, 407);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "العملاء";
            // 
            // dgvCustomersList
            // 
            this.dgvCustomersList.AllowUserToAddRows = false;
            this.dgvCustomersList.AllowUserToDeleteRows = false;
            this.dgvCustomersList.AllowUserToResizeRows = false;
            this.dgvCustomersList.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgvCustomersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomersList.Location = new System.Drawing.Point(6, 51);
            this.dgvCustomersList.Name = "dgvCustomersList";
            this.dgvCustomersList.ReadOnly = true;
            this.dgvCustomersList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvCustomersList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomersList.Size = new System.Drawing.Size(416, 324);
            this.dgvCustomersList.TabIndex = 12;
            this.dgvCustomersList.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvCustomersList_DataBindingComplete);
            this.dgvCustomersList.Click += new System.EventHandler(this.dgvCustomersList_Click);
            // 
            // txtSearchCustomerResult
            // 
            this.txtSearchCustomerResult.BackColor = System.Drawing.Color.White;
            this.txtSearchCustomerResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchCustomerResult.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Italic);
            this.txtSearchCustomerResult.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtSearchCustomerResult.Location = new System.Drawing.Point(6, 381);
            this.txtSearchCustomerResult.Multiline = true;
            this.txtSearchCustomerResult.Name = "txtSearchCustomerResult";
            this.txtSearchCustomerResult.ReadOnly = true;
            this.txtSearchCustomerResult.Size = new System.Drawing.Size(416, 20);
            this.txtSearchCustomerResult.TabIndex = 11;
            this.txtSearchCustomerResult.Visible = false;
            // 
            // txtSearchCustomer
            // 
            this.txtSearchCustomer.Location = new System.Drawing.Point(73, 18);
            this.txtSearchCustomer.Name = "txtSearchCustomer";
            this.txtSearchCustomer.Size = new System.Drawing.Size(245, 21);
            this.txtSearchCustomer.TabIndex = 9;
            this.txtSearchCustomer.TextChanged += new System.EventHandler(this.txtSearchCustomer_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(321, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "بحث :";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtPaids);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.txtTotal);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.txtChangs);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.btnUndo);
            this.groupBox5.Controls.Add(this.txtCustomerAccountNum);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.btnNewCustomer);
            this.groupBox5.Controls.Add(this.btnDeleteAllCustomers);
            this.groupBox5.Controls.Add(this.txtCustomerName);
            this.groupBox5.Controls.Add(this.btnEditCustomer);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.btnDeleteCustomer);
            this.groupBox5.Location = new System.Drawing.Point(451, 64);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(320, 407);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "بيانات";
            // 
            // txtPaids
            // 
            this.txtPaids.Enabled = false;
            this.txtPaids.Location = new System.Drawing.Point(6, 105);
            this.txtPaids.Name = "txtPaids";
            this.txtPaids.Size = new System.Drawing.Size(196, 21);
            this.txtPaids.TabIndex = 26;
            this.txtPaids.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPaids.TextChanged += new System.EventHandler(this.txtPaids_TextChanged);
            this.txtPaids.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPaids_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "إجمالى سداد :";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(6, 159);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(196, 21);
            this.txtTotal.TabIndex = 24;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotal_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "إجمالى الحساب : ";
            // 
            // txtChangs
            // 
            this.txtChangs.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtChangs.Enabled = false;
            this.txtChangs.Location = new System.Drawing.Point(6, 132);
            this.txtChangs.Name = "txtChangs";
            this.txtChangs.Size = new System.Drawing.Size(196, 21);
            this.txtChangs.TabIndex = 22;
            this.txtChangs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtChangs.TextChanged += new System.EventHandler(this.txtChangs_TextChanged);
            this.txtChangs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtChangs_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "إجمالى باقى :";
            // 
            // btnUndo
            // 
            this.btnUndo.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUndo.Enabled = false;
            this.btnUndo.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnUndo.FlatAppearance.BorderSize = 0;
            this.btnUndo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OliveDrab;
            this.btnUndo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            this.btnUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUndo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUndo.ForeColor = System.Drawing.Color.White;
            this.btnUndo.Image = global::SalesManagement.Properties.Resources.s_reload;
            this.btnUndo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUndo.Location = new System.Drawing.Point(6, 245);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(81, 23);
            this.btnUndo.TabIndex = 20;
            this.btnUndo.Text = "إلغاء";
            this.btnUndo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUndo.UseVisualStyleBackColor = false;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // txtCustomerAccountNum
            // 
            this.txtCustomerAccountNum.Location = new System.Drawing.Point(6, 78);
            this.txtCustomerAccountNum.Name = "txtCustomerAccountNum";
            this.txtCustomerAccountNum.Size = new System.Drawing.Size(196, 21);
            this.txtCustomerAccountNum.TabIndex = 3;
            this.txtCustomerAccountNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCustomerAccountNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustomerAccountNum_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(219, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "رقم الحساب : ";
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.BackColor = System.Drawing.Color.SteelBlue;
            this.btnNewCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewCustomer.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnNewCustomer.FlatAppearance.BorderSize = 0;
            this.btnNewCustomer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OliveDrab;
            this.btnNewCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            this.btnNewCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewCustomer.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewCustomer.ForeColor = System.Drawing.Color.White;
            this.btnNewCustomer.Image = global::SalesManagement.Properties.Resources.b_snewtbl;
            this.btnNewCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewCustomer.Location = new System.Drawing.Point(189, 206);
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Size = new System.Drawing.Size(98, 23);
            this.btnNewCustomer.TabIndex = 16;
            this.btnNewCustomer.Text = "اضافة";
            this.btnNewCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewCustomer.UseVisualStyleBackColor = false;
            this.btnNewCustomer.Click += new System.EventHandler(this.btnNewCustomer_Click);
            // 
            // btnDeleteAllCustomers
            // 
            this.btnDeleteAllCustomers.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDeleteAllCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteAllCustomers.Enabled = false;
            this.btnDeleteAllCustomers.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnDeleteAllCustomers.FlatAppearance.BorderSize = 0;
            this.btnDeleteAllCustomers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OliveDrab;
            this.btnDeleteAllCustomers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            this.btnDeleteAllCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAllCustomers.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAllCustomers.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAllCustomers.Image = global::SalesManagement.Properties.Resources.minus;
            this.btnDeleteAllCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteAllCustomers.Location = new System.Drawing.Point(93, 245);
            this.btnDeleteAllCustomers.Name = "btnDeleteAllCustomers";
            this.btnDeleteAllCustomers.Size = new System.Drawing.Size(90, 23);
            this.btnDeleteAllCustomers.TabIndex = 19;
            this.btnDeleteAllCustomers.Text = "حذف الكل";
            this.btnDeleteAllCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteAllCustomers.UseVisualStyleBackColor = false;
            this.btnDeleteAllCustomers.Click += new System.EventHandler(this.btnDeleteAllCustomers_Click);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(6, 51);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(196, 21);
            this.txtCustomerName.TabIndex = 1;
            this.txtCustomerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEditCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditCustomer.Enabled = false;
            this.btnEditCustomer.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnEditCustomer.FlatAppearance.BorderSize = 0;
            this.btnEditCustomer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OliveDrab;
            this.btnEditCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            this.btnEditCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCustomer.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCustomer.ForeColor = System.Drawing.Color.White;
            this.btnEditCustomer.Image = global::SalesManagement.Properties.Resources.b_edit;
            this.btnEditCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditCustomer.Location = new System.Drawing.Point(93, 206);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(90, 23);
            this.btnEditCustomer.TabIndex = 17;
            this.btnEditCustomer.Text = "تعديل";
            this.btnEditCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditCustomer.UseVisualStyleBackColor = false;
            this.btnEditCustomer.Click += new System.EventHandler(this.btnEditCustomer_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(220, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "اسم العميل : ";
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDeleteCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteCustomer.Enabled = false;
            this.btnDeleteCustomer.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnDeleteCustomer.FlatAppearance.BorderSize = 0;
            this.btnDeleteCustomer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OliveDrab;
            this.btnDeleteCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            this.btnDeleteCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCustomer.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCustomer.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCustomer.Image = global::SalesManagement.Properties.Resources.deleteIcon;
            this.btnDeleteCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteCustomer.Location = new System.Drawing.Point(189, 245);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(98, 23);
            this.btnDeleteCustomer.TabIndex = 18;
            this.btnDeleteCustomer.Text = "حذف";
            this.btnDeleteCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteCustomer.UseVisualStyleBackColor = false;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // CustomersManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 478);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomersManagement";
            this.Resizable = false;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "ادارة العملاء";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomersList)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.DataGridView dgvCustomersList;
        public System.Windows.Forms.TextBox txtSearchCustomerResult;
        public System.Windows.Forms.TextBox txtSearchCustomer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox5;
        public System.Windows.Forms.TextBox txtCustomerAccountNum;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.Button btnNewCustomer;
        public System.Windows.Forms.TextBox txtCustomerName;
        public System.Windows.Forms.Button btnDeleteAllCustomers;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.Button btnDeleteCustomer;
        public System.Windows.Forms.Button btnEditCustomer;
        public System.Windows.Forms.Button btnUndo;
        public System.Windows.Forms.TextBox txtPaids;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtChangs;
        private System.Windows.Forms.Label label1;

    }
}