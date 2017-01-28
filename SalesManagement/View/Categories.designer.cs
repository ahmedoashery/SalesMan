namespace SalesManagement.View
{
    partial class Categories
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
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSearchResult = new System.Windows.Forms.TextBox();
            this.txtCategoriesCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearchCategory = new System.Windows.Forms.Button();
            this.txtSearchCategory = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCategoriesList = new System.Windows.Forms.DataGridView();
            this.btnDeleteAllCategories = new System.Windows.Forms.Button();
            this.btnRemoveCategory = new System.Windows.Forms.Button();
            this.btnEditCategory = new System.Windows.Forms.Button();
            this.btnNewCategory = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoriesList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCategoryName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(20, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(597, 113);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اضافة فئة جديدة :";
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(136, 32);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(262, 20);
            this.txtCategoryName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(404, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ادخل اسم الفئة :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSearchResult);
            this.groupBox2.Controls.Add(this.txtCategoriesCount);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnSearchCategory);
            this.groupBox2.Controls.Add(this.txtSearchCategory);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dgvCategoriesList);
            this.groupBox2.Location = new System.Drawing.Point(20, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(597, 317);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "قائمة الفئات :";
            // 
            // txtSearchResult
            // 
            this.txtSearchResult.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtSearchResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchResult.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Italic);
            this.txtSearchResult.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtSearchResult.Location = new System.Drawing.Point(190, 285);
            this.txtSearchResult.Multiline = true;
            this.txtSearchResult.Name = "txtSearchResult";
            this.txtSearchResult.ReadOnly = true;
            this.txtSearchResult.Size = new System.Drawing.Size(401, 20);
            this.txtSearchResult.TabIndex = 6;
            // 
            // txtCategoriesCount
            // 
            this.txtCategoriesCount.Location = new System.Drawing.Point(6, 285);
            this.txtCategoriesCount.Name = "txtCategoriesCount";
            this.txtCategoriesCount.ReadOnly = true;
            this.txtCategoriesCount.Size = new System.Drawing.Size(107, 20);
            this.txtCategoriesCount.TabIndex = 5;
            this.txtCategoriesCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "عدد الفئات :";
            // 
            // btnSearchCategory
            // 
            this.btnSearchCategory.BackColor = System.Drawing.SystemColors.Window;
            this.btnSearchCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchCategory.Enabled = false;
            this.btnSearchCategory.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSearchCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchCategory.Location = new System.Drawing.Point(128, 14);
            this.btnSearchCategory.Name = "btnSearchCategory";
            this.btnSearchCategory.Size = new System.Drawing.Size(51, 25);
            this.btnSearchCategory.TabIndex = 2;
            this.btnSearchCategory.Text = "بحث";
            this.btnSearchCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearchCategory.UseVisualStyleBackColor = true;
            this.btnSearchCategory.Click += new System.EventHandler(this.btnSearchCategory_Click);
            // 
            // txtSearchCategory
            // 
            this.txtSearchCategory.Location = new System.Drawing.Point(183, 19);
            this.txtSearchCategory.Name = "txtSearchCategory";
            this.txtSearchCategory.Size = new System.Drawing.Size(262, 20);
            this.txtSearchCategory.TabIndex = 3;
            this.txtSearchCategory.TextChanged += new System.EventHandler(this.txtSearchCategory_TextChanged);
            this.txtSearchCategory.Enter += new System.EventHandler(this.txtSearchCategory_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(451, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "بحث :";
            // 
            // dgvCategoriesList
            // 
            this.dgvCategoriesList.AllowUserToAddRows = false;
            this.dgvCategoriesList.AllowUserToDeleteRows = false;
            this.dgvCategoriesList.AllowUserToOrderColumns = true;
            this.dgvCategoriesList.AllowUserToResizeRows = false;
            this.dgvCategoriesList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategoriesList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvCategoriesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoriesList.Location = new System.Drawing.Point(6, 45);
            this.dgvCategoriesList.Name = "dgvCategoriesList";
            this.dgvCategoriesList.ReadOnly = true;
            this.dgvCategoriesList.RowHeadersWidth = 80;
            this.dgvCategoriesList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCategoriesList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategoriesList.Size = new System.Drawing.Size(585, 234);
            this.dgvCategoriesList.TabIndex = 0;
            this.dgvCategoriesList.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvCategoriesList_DataBindingComplete);
            this.dgvCategoriesList.Click += new System.EventHandler(this.dgvCategoriesList_Click);
            // 
            // btnDeleteAllCategories
            // 
            this.btnDeleteAllCategories.BackColor = System.Drawing.SystemColors.Control;
            this.btnDeleteAllCategories.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteAllCategories.FlatAppearance.BorderSize = 0;
            this.btnDeleteAllCategories.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(174)))), ((int)(((byte)(46)))));
            this.btnDeleteAllCategories.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(221)))), ((int)(((byte)(112)))));
            this.btnDeleteAllCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAllCategories.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnDeleteAllCategories.Image = global::SalesManagement.Properties.Resources.minus;
            this.btnDeleteAllCategories.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteAllCategories.Location = new System.Drawing.Point(98, 131);
            this.btnDeleteAllCategories.Margin = new System.Windows.Forms.Padding(5);
            this.btnDeleteAllCategories.Name = "btnDeleteAllCategories";
            this.btnDeleteAllCategories.Size = new System.Drawing.Size(95, 26);
            this.btnDeleteAllCategories.TabIndex = 13;
            this.btnDeleteAllCategories.Text = "حذف الكل";
            this.btnDeleteAllCategories.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteAllCategories.UseVisualStyleBackColor = true;
            this.btnDeleteAllCategories.Click += new System.EventHandler(this.btnDeleteAllCategories_Click_1);
            // 
            // btnRemoveCategory
            // 
            this.btnRemoveCategory.BackColor = System.Drawing.SystemColors.Control;
            this.btnRemoveCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveCategory.FlatAppearance.BorderSize = 0;
            this.btnRemoveCategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(174)))), ((int)(((byte)(46)))));
            this.btnRemoveCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(221)))), ((int)(((byte)(112)))));
            this.btnRemoveCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveCategory.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnRemoveCategory.Image = global::SalesManagement.Properties.Resources.deleteIcon;
            this.btnRemoveCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemoveCategory.Location = new System.Drawing.Point(203, 131);
            this.btnRemoveCategory.Margin = new System.Windows.Forms.Padding(5);
            this.btnRemoveCategory.Name = "btnRemoveCategory";
            this.btnRemoveCategory.Size = new System.Drawing.Size(71, 26);
            this.btnRemoveCategory.TabIndex = 11;
            this.btnRemoveCategory.Text = "حذف";
            this.btnRemoveCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveCategory.UseVisualStyleBackColor = true;
            this.btnRemoveCategory.Click += new System.EventHandler(this.btnRemoveCategory_Click_1);
            // 
            // btnEditCategory
            // 
            this.btnEditCategory.BackColor = System.Drawing.SystemColors.Control;
            this.btnEditCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditCategory.FlatAppearance.BorderSize = 0;
            this.btnEditCategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(174)))), ((int)(((byte)(46)))));
            this.btnEditCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(221)))), ((int)(((byte)(112)))));
            this.btnEditCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCategory.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnEditCategory.Image = global::SalesManagement.Properties.Resources.b_edit;
            this.btnEditCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditCategory.Location = new System.Drawing.Point(284, 131);
            this.btnEditCategory.Margin = new System.Windows.Forms.Padding(5);
            this.btnEditCategory.Name = "btnEditCategory";
            this.btnEditCategory.Size = new System.Drawing.Size(73, 26);
            this.btnEditCategory.TabIndex = 10;
            this.btnEditCategory.Text = "تعديل";
            this.btnEditCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditCategory.UseVisualStyleBackColor = true;
            this.btnEditCategory.Click += new System.EventHandler(this.btnEditCategory_Click_1);
            // 
            // btnNewCategory
            // 
            this.btnNewCategory.BackColor = System.Drawing.SystemColors.Control;
            this.btnNewCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewCategory.FlatAppearance.BorderSize = 0;
            this.btnNewCategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(174)))), ((int)(((byte)(46)))));
            this.btnNewCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(221)))), ((int)(((byte)(112)))));
            this.btnNewCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewCategory.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnNewCategory.Image = global::SalesManagement.Properties.Resources.b_snewtbl;
            this.btnNewCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewCategory.Location = new System.Drawing.Point(451, 131);
            this.btnNewCategory.Margin = new System.Windows.Forms.Padding(5);
            this.btnNewCategory.Name = "btnNewCategory";
            this.btnNewCategory.Size = new System.Drawing.Size(68, 26);
            this.btnNewCategory.TabIndex = 12;
            this.btnNewCategory.Text = "جديد";
            this.btnNewCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewCategory.UseVisualStyleBackColor = true;
            this.btnNewCategory.Click += new System.EventHandler(this.btnNewCategory_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCategory.Enabled = false;
            this.btnAddCategory.FlatAppearance.BorderSize = 0;
            this.btnAddCategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(174)))), ((int)(((byte)(46)))));
            this.btnAddCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(221)))), ((int)(((byte)(112)))));
            this.btnAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCategory.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnAddCategory.Image = global::SalesManagement.Properties.Resources.accept;
            this.btnAddCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddCategory.Location = new System.Drawing.Point(371, 131);
            this.btnAddCategory.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(68, 27);
            this.btnAddCategory.TabIndex = 8;
            this.btnAddCategory.Text = "اضافة";
            this.btnAddCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 502);
            this.Controls.Add(this.btnDeleteAllCategories);
            this.Controls.Add(this.btnNewCategory);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.btnRemoveCategory);
            this.Controls.Add(this.btnEditCategory);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Categories";
            this.Resizable = false;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "        ادارة الفئـــات";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Categories_FormClosed);
            this.Load += new System.EventHandler(this.Categories_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoriesList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.DataGridView dgvCategoriesList;
        public System.Windows.Forms.Button btnSearchCategory;
        public System.Windows.Forms.TextBox txtSearchCategory;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtCategoriesCount;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtSearchResult;
        public System.Windows.Forms.Button btnDeleteAllCategories;
        public System.Windows.Forms.Button btnNewCategory;
        public System.Windows.Forms.Button btnAddCategory;
        public System.Windows.Forms.Button btnRemoveCategory;
        public System.Windows.Forms.Button btnEditCategory;

    }
}