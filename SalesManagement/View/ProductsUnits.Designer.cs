namespace SalesManagement.View
{
    partial class ProductsUnits
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
            this.btnNewUnit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddNewUnit = new System.Windows.Forms.TextBox();
            this.btnDeleteUnit = new System.Windows.Forms.Button();
            this.btnEditUnit = new System.Windows.Forms.Button();
            this.btnAddUnit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvUnitsList = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnitsList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNewUnit);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtAddNewUnit);
            this.groupBox1.Controls.Add(this.btnDeleteUnit);
            this.groupBox1.Controls.Add(this.btnEditUnit);
            this.groupBox1.Controls.Add(this.btnAddUnit);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(20, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 122);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnNewUnit
            // 
            this.btnNewUnit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnNewUnit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewUnit.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnNewUnit.FlatAppearance.CheckedBackColor = System.Drawing.Color.YellowGreen;
            this.btnNewUnit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnNewUnit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            this.btnNewUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewUnit.Image = global::SalesManagement.Properties.Resources.b_snewtbl;
            this.btnNewUnit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewUnit.Location = new System.Drawing.Point(259, 78);
            this.btnNewUnit.Name = "btnNewUnit";
            this.btnNewUnit.Size = new System.Drawing.Size(61, 29);
            this.btnNewUnit.TabIndex = 36;
            this.btnNewUnit.Text = "جديد";
            this.btnNewUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewUnit.UseVisualStyleBackColor = false;
            this.btnNewUnit.Click += new System.EventHandler(this.btnNewUnit_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "ادخل نوع الوحدة";
            // 
            // txtAddNewUnit
            // 
            this.txtAddNewUnit.Location = new System.Drawing.Point(74, 42);
            this.txtAddNewUnit.Name = "txtAddNewUnit";
            this.txtAddNewUnit.Size = new System.Drawing.Size(246, 20);
            this.txtAddNewUnit.TabIndex = 33;
            // 
            // btnDeleteUnit
            // 
            this.btnDeleteUnit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeleteUnit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteUnit.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnDeleteUnit.FlatAppearance.BorderSize = 0;
            this.btnDeleteUnit.FlatAppearance.CheckedBackColor = System.Drawing.Color.YellowGreen;
            this.btnDeleteUnit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnDeleteUnit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            this.btnDeleteUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUnit.Image = global::SalesManagement.Properties.Resources.deleteIcon;
            this.btnDeleteUnit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteUnit.Location = new System.Drawing.Point(111, 78);
            this.btnDeleteUnit.Name = "btnDeleteUnit";
            this.btnDeleteUnit.Size = new System.Drawing.Size(68, 29);
            this.btnDeleteUnit.TabIndex = 32;
            this.btnDeleteUnit.Text = "حذف";
            this.btnDeleteUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteUnit.UseVisualStyleBackColor = false;
            this.btnDeleteUnit.Click += new System.EventHandler(this.btnDeleteUnit_Click);
            // 
            // btnEditUnit
            // 
            this.btnEditUnit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEditUnit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditUnit.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnEditUnit.FlatAppearance.BorderSize = 0;
            this.btnEditUnit.FlatAppearance.CheckedBackColor = System.Drawing.Color.YellowGreen;
            this.btnEditUnit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnEditUnit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            this.btnEditUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditUnit.Image = global::SalesManagement.Properties.Resources.b_edit;
            this.btnEditUnit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditUnit.Location = new System.Drawing.Point(46, 78);
            this.btnEditUnit.Name = "btnEditUnit";
            this.btnEditUnit.Size = new System.Drawing.Size(57, 29);
            this.btnEditUnit.TabIndex = 31;
            this.btnEditUnit.Text = "تعديل";
            this.btnEditUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditUnit.UseVisualStyleBackColor = false;
            this.btnEditUnit.Visible = false;
            this.btnEditUnit.Click += new System.EventHandler(this.btnEditUnit_Click);
            // 
            // btnAddUnit
            // 
            this.btnAddUnit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddUnit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddUnit.Enabled = false;
            this.btnAddUnit.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnAddUnit.FlatAppearance.BorderSize = 0;
            this.btnAddUnit.FlatAppearance.CheckedBackColor = System.Drawing.Color.YellowGreen;
            this.btnAddUnit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAddUnit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            this.btnAddUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUnit.Image = global::SalesManagement.Properties.Resources.s_okay;
            this.btnAddUnit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddUnit.Location = new System.Drawing.Point(188, 78);
            this.btnAddUnit.Name = "btnAddUnit";
            this.btnAddUnit.Size = new System.Drawing.Size(62, 29);
            this.btnAddUnit.TabIndex = 30;
            this.btnAddUnit.Text = "اضافة";
            this.btnAddUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddUnit.UseVisualStyleBackColor = false;
            this.btnAddUnit.Click += new System.EventHandler(this.btnNewUnit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvUnitsList);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(20, 182);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(415, 258);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "الوحدات المتواجدة";
            // 
            // dgvUnitsList
            // 
            this.dgvUnitsList.AllowUserToAddRows = false;
            this.dgvUnitsList.AllowUserToDeleteRows = false;
            this.dgvUnitsList.AllowUserToResizeRows = false;
            this.dgvUnitsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUnitsList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvUnitsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnitsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUnitsList.Location = new System.Drawing.Point(3, 16);
            this.dgvUnitsList.Name = "dgvUnitsList";
            this.dgvUnitsList.ReadOnly = true;
            this.dgvUnitsList.RowHeadersWidth = 100;
            this.dgvUnitsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUnitsList.Size = new System.Drawing.Size(409, 239);
            this.dgvUnitsList.TabIndex = 0;
            this.dgvUnitsList.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvUnitsList_DataBindingComplete);
            this.dgvUnitsList.Click += new System.EventHandler(this.dgvUnitsList_Click);
            // 
            // ProductsUnits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 460);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductsUnits";
            this.Resizable = false;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "قائمة الوحدات";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProductsUnits_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnitsList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Button btnDeleteUnit;
        public System.Windows.Forms.Button btnEditUnit;
        public System.Windows.Forms.Button btnAddUnit;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtAddNewUnit;
        public System.Windows.Forms.DataGridView dgvUnitsList;
        public System.Windows.Forms.Button btnNewUnit;
    }
}