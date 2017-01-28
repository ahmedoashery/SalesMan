namespace SalesManagement.View
{
    partial class ProvidersManagement
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
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSearchProviderResult = new System.Windows.Forms.TextBox();
            this.txtSearchProvider = new System.Windows.Forms.TextBox();
            this.dgvProvidersList = new System.Windows.Forms.DataGridView();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnNewProvider = new System.Windows.Forms.Button();
            this.btnDeleteAllProviders = new System.Windows.Forms.Button();
            this.btnDeleteProvider = new System.Windows.Forms.Button();
            this.btnEditProvider = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtPaids = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtChangs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProviderCompany = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtProviderAccountNum = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtProviderName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvidersList)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox8.Controls.Add(this.label9);
            this.groupBox8.Controls.Add(this.txtSearchProviderResult);
            this.groupBox8.Controls.Add(this.txtSearchProvider);
            this.groupBox8.Controls.Add(this.dgvProvidersList);
            this.groupBox8.Location = new System.Drawing.Point(12, 63);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(510, 456);
            this.groupBox8.TabIndex = 21;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "الموردين";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(345, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "بحث :";
            // 
            // txtSearchProviderResult
            // 
            this.txtSearchProviderResult.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSearchProviderResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchProviderResult.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Italic);
            this.txtSearchProviderResult.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtSearchProviderResult.Location = new System.Drawing.Point(6, 429);
            this.txtSearchProviderResult.Multiline = true;
            this.txtSearchProviderResult.Name = "txtSearchProviderResult";
            this.txtSearchProviderResult.ReadOnly = true;
            this.txtSearchProviderResult.Size = new System.Drawing.Size(498, 20);
            this.txtSearchProviderResult.TabIndex = 14;
            this.txtSearchProviderResult.Visible = false;
            // 
            // txtSearchProvider
            // 
            this.txtSearchProvider.Location = new System.Drawing.Point(98, 19);
            this.txtSearchProvider.Name = "txtSearchProvider";
            this.txtSearchProvider.Size = new System.Drawing.Size(241, 20);
            this.txtSearchProvider.TabIndex = 13;
            this.txtSearchProvider.TextChanged += new System.EventHandler(this.txtSearchProvider_TextChanged);
            // 
            // dgvProvidersList
            // 
            this.dgvProvidersList.AllowUserToAddRows = false;
            this.dgvProvidersList.AllowUserToDeleteRows = false;
            this.dgvProvidersList.AllowUserToResizeRows = false;
            this.dgvProvidersList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProvidersList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvProvidersList.Location = new System.Drawing.Point(6, 45);
            this.dgvProvidersList.Name = "dgvProvidersList";
            this.dgvProvidersList.ReadOnly = true;
            this.dgvProvidersList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProvidersList.Size = new System.Drawing.Size(498, 379);
            this.dgvProvidersList.TabIndex = 2;
            this.dgvProvidersList.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvProvidersList_DataBindingComplete);
            this.dgvProvidersList.Click += new System.EventHandler(this.dgvProvidersList_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox7.Controls.Add(this.btnUndo);
            this.groupBox7.Controls.Add(this.btnNewProvider);
            this.groupBox7.Controls.Add(this.btnDeleteAllProviders);
            this.groupBox7.Controls.Add(this.btnDeleteProvider);
            this.groupBox7.Controls.Add(this.btnEditProvider);
            this.groupBox7.Location = new System.Drawing.Point(528, 278);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(349, 241);
            this.groupBox7.TabIndex = 20;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "عمليات";
            // 
            // btnUndo
            // 
            this.btnUndo.Enabled = false;
            this.btnUndo.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gainsboro;
            this.btnUndo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnUndo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            this.btnUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUndo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUndo.Image = global::SalesManagement.Properties.Resources.s_reload;
            this.btnUndo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUndo.Location = new System.Drawing.Point(139, 91);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(75, 29);
            this.btnUndo.TabIndex = 21;
            this.btnUndo.Text = "إلغاء";
            this.btnUndo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnNewProvider
            // 
            this.btnNewProvider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewProvider.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gainsboro;
            this.btnNewProvider.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnNewProvider.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            this.btnNewProvider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewProvider.Image = global::SalesManagement.Properties.Resources.b_snewtbl;
            this.btnNewProvider.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewProvider.Location = new System.Drawing.Point(229, 50);
            this.btnNewProvider.Name = "btnNewProvider";
            this.btnNewProvider.Size = new System.Drawing.Size(75, 28);
            this.btnNewProvider.TabIndex = 12;
            this.btnNewProvider.Text = "اضافة";
            this.btnNewProvider.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewProvider.UseVisualStyleBackColor = true;
            this.btnNewProvider.Click += new System.EventHandler(this.btnNewProvider_Click);
            // 
            // btnDeleteAllProviders
            // 
            this.btnDeleteAllProviders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteAllProviders.Enabled = false;
            this.btnDeleteAllProviders.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gainsboro;
            this.btnDeleteAllProviders.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnDeleteAllProviders.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            this.btnDeleteAllProviders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAllProviders.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteAllProviders.Location = new System.Drawing.Point(229, 91);
            this.btnDeleteAllProviders.Name = "btnDeleteAllProviders";
            this.btnDeleteAllProviders.Size = new System.Drawing.Size(75, 29);
            this.btnDeleteAllProviders.TabIndex = 15;
            this.btnDeleteAllProviders.Text = "حذف الكل";
            this.btnDeleteAllProviders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteAllProviders.UseVisualStyleBackColor = true;
            this.btnDeleteAllProviders.Click += new System.EventHandler(this.btnDeleteAllProviders_Click);
            // 
            // btnDeleteProvider
            // 
            this.btnDeleteProvider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteProvider.Enabled = false;
            this.btnDeleteProvider.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gainsboro;
            this.btnDeleteProvider.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnDeleteProvider.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            this.btnDeleteProvider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteProvider.Image = global::SalesManagement.Properties.Resources.deleteIcon;
            this.btnDeleteProvider.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteProvider.Location = new System.Drawing.Point(46, 51);
            this.btnDeleteProvider.Name = "btnDeleteProvider";
            this.btnDeleteProvider.Size = new System.Drawing.Size(75, 28);
            this.btnDeleteProvider.TabIndex = 14;
            this.btnDeleteProvider.Text = "ازالة";
            this.btnDeleteProvider.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteProvider.UseVisualStyleBackColor = true;
            this.btnDeleteProvider.Click += new System.EventHandler(this.btnDeleteProvider_Click);
            // 
            // btnEditProvider
            // 
            this.btnEditProvider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditProvider.Enabled = false;
            this.btnEditProvider.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gainsboro;
            this.btnEditProvider.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnEditProvider.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            this.btnEditProvider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditProvider.Image = global::SalesManagement.Properties.Resources.b_edit;
            this.btnEditProvider.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditProvider.Location = new System.Drawing.Point(139, 50);
            this.btnEditProvider.Name = "btnEditProvider";
            this.btnEditProvider.Size = new System.Drawing.Size(75, 29);
            this.btnEditProvider.TabIndex = 13;
            this.btnEditProvider.Text = "تعديل";
            this.btnEditProvider.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditProvider.UseVisualStyleBackColor = true;
            this.btnEditProvider.Click += new System.EventHandler(this.btnEditProvider_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox6.Controls.Add(this.txtPaids);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.txtTotal);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.txtChangs);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.txtProviderCompany);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.txtProviderAccountNum);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.txtProviderName);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Location = new System.Drawing.Point(528, 63);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(349, 209);
            this.groupBox6.TabIndex = 19;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "البيانات";
            // 
            // txtPaids
            // 
            this.txtPaids.Enabled = false;
            this.txtPaids.Location = new System.Drawing.Point(19, 118);
            this.txtPaids.Name = "txtPaids";
            this.txtPaids.Size = new System.Drawing.Size(183, 20);
            this.txtPaids.TabIndex = 32;
            this.txtPaids.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPaids.TextChanged += new System.EventHandler(this.txtPaids_TextChanged);
            this.txtPaids.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPaids_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "إجمالى سداد :";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(19, 172);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(183, 20);
            this.txtTotal.TabIndex = 30;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "إجمالى الحساب : ";
            // 
            // txtChangs
            // 
            this.txtChangs.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtChangs.Enabled = false;
            this.txtChangs.Location = new System.Drawing.Point(19, 145);
            this.txtChangs.Name = "txtChangs";
            this.txtChangs.Size = new System.Drawing.Size(183, 20);
            this.txtChangs.TabIndex = 28;
            this.txtChangs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtChangs.TextChanged += new System.EventHandler(this.txtChangs_TextChanged);
            this.txtChangs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtChangs_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "إجمالى باقى :";
            // 
            // txtProviderCompany
            // 
            this.txtProviderCompany.Location = new System.Drawing.Point(19, 53);
            this.txtProviderCompany.Name = "txtProviderCompany";
            this.txtProviderCompany.Size = new System.Drawing.Size(183, 20);
            this.txtProviderCompany.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(230, 58);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 13);
            this.label17.TabIndex = 14;
            this.label17.Text = "الــشـــركة :";
            // 
            // txtProviderAccountNum
            // 
            this.txtProviderAccountNum.Location = new System.Drawing.Point(63, 79);
            this.txtProviderAccountNum.Name = "txtProviderAccountNum";
            this.txtProviderAccountNum.Size = new System.Drawing.Size(139, 20);
            this.txtProviderAccountNum.TabIndex = 2;
            this.txtProviderAccountNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProviderAccountNum_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(219, 82);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 13);
            this.label15.TabIndex = 12;
            this.label15.Text = "رقم الحساب : ";
            // 
            // txtProviderName
            // 
            this.txtProviderName.Location = new System.Drawing.Point(19, 27);
            this.txtProviderName.Name = "txtProviderName";
            this.txtProviderName.Size = new System.Drawing.Size(183, 20);
            this.txtProviderName.TabIndex = 0;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(224, 30);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 13);
            this.label16.TabIndex = 10;
            this.label16.Text = "اسم المورد : ";
            // 
            // ProvidersManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 536);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProvidersManagement";
            this.Resizable = false;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "ادارة الموردين";
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvidersList)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox7;
        public System.Windows.Forms.Button btnNewProvider;
        public System.Windows.Forms.Button btnDeleteAllProviders;
        public System.Windows.Forms.Button btnDeleteProvider;
        public System.Windows.Forms.Button btnEditProvider;
        private System.Windows.Forms.GroupBox groupBox6;
        public System.Windows.Forms.TextBox txtProviderCompany;
        private System.Windows.Forms.Label label17;
        public System.Windows.Forms.TextBox txtProviderAccountNum;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.TextBox txtProviderName;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.TextBox txtSearchProviderResult;
        public System.Windows.Forms.TextBox txtSearchProvider;
        public System.Windows.Forms.DataGridView dgvProvidersList;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Button btnUndo;
        public System.Windows.Forms.TextBox txtPaids;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtChangs;
        private System.Windows.Forms.Label label1;
    }
}