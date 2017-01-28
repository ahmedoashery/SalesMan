namespace SalesManagement.View
{
    partial class Products
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
            this.btnDeleteAllProducts = new System.Windows.Forms.Button();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSearchProductResult = new System.Windows.Forms.TextBox();
            this.txtProductsCount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSearchProduct = new System.Windows.Forms.Button();
            this.txtSearchProduct = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvProductsList = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnNewProduct = new System.Windows.Forms.Button();
            this.btnUndoProduct = new System.Windows.Forms.Button();
            this.txtStoredQuantity = new System.Windows.Forms.TextBox();
            this.btnRemoveProduct = new System.Windows.Forms.Button();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.cmbCategoriesList = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnNewUnit = new System.Windows.Forms.Button();
            this.cmbUnitType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNewCategory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.حذفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsList)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDeleteAllProducts
            // 
            this.btnDeleteAllProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteAllProducts.Enabled = false;
            this.btnDeleteAllProducts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnDeleteAllProducts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            this.btnDeleteAllProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAllProducts.Image = global::SalesManagement.Properties.Resources.minus;
            this.btnDeleteAllProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteAllProducts.Location = new System.Drawing.Point(132, 355);
            this.btnDeleteAllProducts.Name = "btnDeleteAllProducts";
            this.btnDeleteAllProducts.Size = new System.Drawing.Size(85, 25);
            this.btnDeleteAllProducts.TabIndex = 4;
            this.btnDeleteAllProducts.Text = "حذف الكل";
            this.btnDeleteAllProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteAllProducts.UseVisualStyleBackColor = true;
            this.btnDeleteAllProducts.Click += new System.EventHandler(this.btnDeleteAllProducts_Click);
            // 
            // txtBarcode
            // 
            this.txtBarcode.BackColor = System.Drawing.Color.Ivory;
            this.txtBarcode.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtBarcode.Location = new System.Drawing.Point(31, 243);
            this.txtBarcode.Multiline = true;
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(240, 46);
            this.txtBarcode.TabIndex = 0;
            this.txtBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarcode_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSearchProductResult);
            this.groupBox2.Controls.Add(this.txtProductsCount);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnSearchProduct);
            this.groupBox2.Controls.Add(this.txtSearchProduct);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dgvProductsList);
            this.groupBox2.Location = new System.Drawing.Point(8, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(461, 467);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "المنتجـــــــــــات";
            // 
            // txtSearchProductResult
            // 
            this.txtSearchProductResult.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtSearchProductResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchProductResult.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Italic);
            this.txtSearchProductResult.ForeColor = System.Drawing.Color.Red;
            this.txtSearchProductResult.Location = new System.Drawing.Point(200, 436);
            this.txtSearchProductResult.Multiline = true;
            this.txtSearchProductResult.Name = "txtSearchProductResult";
            this.txtSearchProductResult.ReadOnly = true;
            this.txtSearchProductResult.Size = new System.Drawing.Size(250, 23);
            this.txtSearchProductResult.TabIndex = 17;
            this.txtSearchProductResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearchProductResult.Visible = false;
            // 
            // txtProductsCount
            // 
            this.txtProductsCount.Location = new System.Drawing.Point(6, 436);
            this.txtProductsCount.Name = "txtProductsCount";
            this.txtProductsCount.ReadOnly = true;
            this.txtProductsCount.Size = new System.Drawing.Size(107, 20);
            this.txtProductsCount.TabIndex = 16;
            this.txtProductsCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(119, 439);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "عدد المنتجات :";
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSearchProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            this.btnSearchProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchProduct.Image = global::SalesManagement.Properties.Resources._1484704212_Search;
            this.btnSearchProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearchProduct.Location = new System.Drawing.Point(86, 16);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Size = new System.Drawing.Size(59, 23);
            this.btnSearchProduct.TabIndex = 13;
            this.btnSearchProduct.Text = "بحث";
            this.btnSearchProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchProduct.UseVisualStyleBackColor = true;
            this.btnSearchProduct.Click += new System.EventHandler(this.btnSearchProduct_Click);
            // 
            // txtSearchProduct
            // 
            this.txtSearchProduct.Location = new System.Drawing.Point(151, 19);
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.Size = new System.Drawing.Size(262, 20);
            this.txtSearchProduct.TabIndex = 12;
            this.txtSearchProduct.TextChanged += new System.EventHandler(this.txtSearchProduct_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(419, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "بحث :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // dgvProductsList
            // 
            this.dgvProductsList.AllowUserToAddRows = false;
            this.dgvProductsList.AllowUserToDeleteRows = false;
            this.dgvProductsList.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgvProductsList.Location = new System.Drawing.Point(6, 45);
            this.dgvProductsList.Name = "dgvProductsList";
            this.dgvProductsList.ReadOnly = true;
            this.dgvProductsList.RowHeadersWidth = 80;
            this.dgvProductsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductsList.Size = new System.Drawing.Size(444, 385);
            this.dgvProductsList.StandardTab = true;
            this.dgvProductsList.TabIndex = 2;
            this.dgvProductsList.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvProductsList_DataBindingComplete);
            this.dgvProductsList.Click += new System.EventHandler(this.dgvProductsList_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtUnitPrice);
            this.groupBox1.Controls.Add(this.btnAddProduct);
            this.groupBox1.Controls.Add(this.btnNewProduct);
            this.groupBox1.Controls.Add(this.btnDeleteAllProducts);
            this.groupBox1.Controls.Add(this.btnUndoProduct);
            this.groupBox1.Controls.Add(this.txtStoredQuantity);
            this.groupBox1.Controls.Add(this.btnRemoveProduct);
            this.groupBox1.Controls.Add(this.txtProductName);
            this.groupBox1.Controls.Add(this.btnEditProduct);
            this.groupBox1.Controls.Add(this.cmbCategoriesList);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnNewUnit);
            this.groupBox1.Controls.Add(this.cmbUnitType);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnNewCategory);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBarcode);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(475, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(371, 467);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "البيانات";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(57, 146);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(214, 20);
            this.txtUnitPrice.TabIndex = 41;
            this.txtUnitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUnitPrice_KeyPress);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProduct.Enabled = false;
            this.btnAddProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAddProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Image = global::SalesManagement.Properties.Resources.s_success;
            this.btnAddProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddProduct.Location = new System.Drawing.Point(132, 313);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(85, 25);
            this.btnAddProduct.TabIndex = 1;
            this.btnAddProduct.Text = "اضافة";
            this.btnAddProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnNewProduct
            // 
            this.btnNewProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnNewProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            this.btnNewProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewProduct.Image = global::SalesManagement.Properties.Resources.plus;
            this.btnNewProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewProduct.Location = new System.Drawing.Point(227, 313);
            this.btnNewProduct.Name = "btnNewProduct";
            this.btnNewProduct.Size = new System.Drawing.Size(75, 25);
            this.btnNewProduct.TabIndex = 0;
            this.btnNewProduct.Text = "جديد";
            this.btnNewProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewProduct.Click += new System.EventHandler(this.btnNewProduct_Click);
            // 
            // btnUndoProduct
            // 
            this.btnUndoProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUndoProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnUndoProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            this.btnUndoProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUndoProduct.Image = global::SalesManagement.Properties.Resources.s_reload;
            this.btnUndoProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUndoProduct.Location = new System.Drawing.Point(47, 355);
            this.btnUndoProduct.Name = "btnUndoProduct";
            this.btnUndoProduct.Size = new System.Drawing.Size(75, 25);
            this.btnUndoProduct.TabIndex = 5;
            this.btnUndoProduct.Text = "الغاء";
            this.btnUndoProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUndoProduct.UseVisualStyleBackColor = true;
            this.btnUndoProduct.Click += new System.EventHandler(this.btnUndoProduct_Click);
            // 
            // txtStoredQuantity
            // 
            this.txtStoredQuantity.Location = new System.Drawing.Point(57, 92);
            this.txtStoredQuantity.Name = "txtStoredQuantity";
            this.txtStoredQuantity.Size = new System.Drawing.Size(214, 20);
            this.txtStoredQuantity.TabIndex = 38;
            this.txtStoredQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStoredQuantity_KeyPress);
            // 
            // btnRemoveProduct
            // 
            this.btnRemoveProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveProduct.Enabled = false;
            this.btnRemoveProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnRemoveProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            this.btnRemoveProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveProduct.Image = global::SalesManagement.Properties.Resources.deleteIcon;
            this.btnRemoveProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemoveProduct.Location = new System.Drawing.Point(227, 355);
            this.btnRemoveProduct.Name = "btnRemoveProduct";
            this.btnRemoveProduct.Size = new System.Drawing.Size(75, 25);
            this.btnRemoveProduct.TabIndex = 3;
            this.btnRemoveProduct.Text = "ازالة";
            this.btnRemoveProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveProduct.UseVisualStyleBackColor = true;
            this.btnRemoveProduct.Click += new System.EventHandler(this.btnRemoveProduct_Click);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(57, 65);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(214, 20);
            this.txtProductName.TabIndex = 36;
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditProduct.Enabled = false;
            this.btnEditProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnEditProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            this.btnEditProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditProduct.Image = global::SalesManagement.Properties.Resources.b_edit;
            this.btnEditProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditProduct.Location = new System.Drawing.Point(47, 313);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(75, 25);
            this.btnEditProduct.TabIndex = 2;
            this.btnEditProduct.Text = "تعديل";
            this.btnEditProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditProduct.UseVisualStyleBackColor = true;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // cmbCategoriesList
            // 
            this.cmbCategoriesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoriesList.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cmbCategoriesList.FormattingEnabled = true;
            this.cmbCategoriesList.Location = new System.Drawing.Point(57, 38);
            this.cmbCategoriesList.Name = "cmbCategoriesList";
            this.cmbCategoriesList.Size = new System.Drawing.Size(214, 24);
            this.cmbCategoriesList.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "ج.م";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(277, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "سعــر الوحدة :";
            // 
            // btnNewUnit
            // 
            this.btnNewUnit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewUnit.FlatAppearance.BorderSize = 0;
            this.btnNewUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewUnit.Image = global::SalesManagement.Properties.Resources.b_snewtbl;
            this.btnNewUnit.Location = new System.Drawing.Point(31, 119);
            this.btnNewUnit.Name = "btnNewUnit";
            this.btnNewUnit.Size = new System.Drawing.Size(18, 18);
            this.btnNewUnit.TabIndex = 42;
            this.btnNewUnit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewUnit.UseVisualStyleBackColor = true;
            this.btnNewUnit.Click += new System.EventHandler(this.btnNewUnit_Click);
            // 
            // cmbUnitType
            // 
            this.cmbUnitType.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbUnitType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnitType.FormattingEnabled = true;
            this.cmbUnitType.Location = new System.Drawing.Point(57, 118);
            this.cmbUnitType.Name = "cmbUnitType";
            this.cmbUnitType.Size = new System.Drawing.Size(214, 21);
            this.cmbUnitType.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "نوع الوحدة :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "الكمــــية :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "اسم الصنف :";
            // 
            // btnNewCategory
            // 
            this.btnNewCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewCategory.FlatAppearance.BorderSize = 0;
            this.btnNewCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewCategory.Image = global::SalesManagement.Properties.Resources.b_snewtbl;
            this.btnNewCategory.Location = new System.Drawing.Point(24, 39);
            this.btnNewCategory.Name = "btnNewCategory";
            this.btnNewCategory.Size = new System.Drawing.Size(23, 21);
            this.btnNewCategory.TabIndex = 37;
            this.btnNewCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewCategory.UseVisualStyleBackColor = true;
            this.btnNewCategory.Click += new System.EventHandler(this.btnNewCategory_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "الفـئـــة : ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::SalesManagement.Properties.Resources._13_barcode;
            this.pictureBox1.Location = new System.Drawing.Point(31, 186);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.حذفToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(96, 26);
            // 
            // حذفToolStripMenuItem
            // 
            this.حذفToolStripMenuItem.Name = "حذفToolStripMenuItem";
            this.حذفToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.حذفToolStripMenuItem.Text = "حذف";
            this.حذفToolStripMenuItem.Click += new System.EventHandler(this.حذفToolStripMenuItem_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(297, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 48;
            this.label9.Text = "بــــاركـود :";
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 542);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Products";
            this.Resizable = false;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.Text = "الأصنـــاف";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnAddProduct;
        public System.Windows.Forms.Button btnNewProduct;
        public System.Windows.Forms.Button btnDeleteAllProducts;
        public System.Windows.Forms.Button btnUndoProduct;
        public System.Windows.Forms.Button btnRemoveProduct;
        public System.Windows.Forms.Button btnEditProduct;
        public System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.DataGridView dgvProductsList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox txtSearchProductResult;
        public System.Windows.Forms.TextBox txtProductsCount;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Button btnSearchProduct;
        public System.Windows.Forms.TextBox txtSearchProduct;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtUnitPrice;
        public System.Windows.Forms.TextBox txtStoredQuantity;
        public System.Windows.Forms.TextBox txtProductName;
        public System.Windows.Forms.ComboBox cmbCategoriesList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button btnNewUnit;
        public System.Windows.Forms.ComboBox cmbUnitType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnNewCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem حذفToolStripMenuItem;
        private System.Windows.Forms.Label label9;
    }
}