namespace SalesManagement.View
{
    partial class NewOrder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewOrder));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chGeneralPerson = new System.Windows.Forms.CheckBox();
            this.btnChooseCustomer = new System.Windows.Forms.Button();
            this.txtOrderDate = new System.Windows.Forms.DateTimePicker();
            this.OrderType = new System.Windows.Forms.Label();
            this.txtSalesMan = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtOrderPersonName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCusid = new System.Windows.Forms.TextBox();
            this.OrderLabel = new System.Windows.Forms.Label();
            this.ctxEditOrderProductsList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.تعديلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مسحالقائمةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbProductName = new System.Windows.Forms.ComboBox();
            this.dgvOrderProductsList = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTotalCost = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtPaidPrice = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtChangeCost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUnitCost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBarcodeSearcher = new System.Windows.Forms.TextBox();
            this.SumTotalCost = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnChooseProducts = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.btnUndoProduct = new System.Windows.Forms.Button();
            this.btnPrinOrder = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.ctxEditOrderProductsList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderProductsList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chGeneralPerson);
            this.groupBox2.Controls.Add(this.btnChooseCustomer);
            this.groupBox2.Controls.Add(this.txtOrderDate);
            this.groupBox2.Controls.Add(this.OrderType);
            this.groupBox2.Controls.Add(this.txtSalesMan);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtOrderPersonName);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtCusid);
            this.groupBox2.Enabled = false;
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(5, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(820, 81);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // chGeneralPerson
            // 
            this.chGeneralPerson.AutoSize = true;
            this.chGeneralPerson.Checked = true;
            this.chGeneralPerson.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chGeneralPerson.Location = new System.Drawing.Point(385, 52);
            this.chGeneralPerson.Name = "chGeneralPerson";
            this.chGeneralPerson.Size = new System.Drawing.Size(47, 23);
            this.chGeneralPerson.TabIndex = 36;
            this.chGeneralPerson.Text = "عام";
            this.chGeneralPerson.UseVisualStyleBackColor = false;
            this.chGeneralPerson.Click += new System.EventHandler(this.chGeneralPerson_Click);
            // 
            // btnChooseCustomer
            // 
            this.btnChooseCustomer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnChooseCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnChooseCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChooseCustomer.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnChooseCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnChooseCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChooseCustomer.Location = new System.Drawing.Point(292, 47);
            this.btnChooseCustomer.Name = "btnChooseCustomer";
            this.btnChooseCustomer.Size = new System.Drawing.Size(87, 28);
            this.btnChooseCustomer.TabIndex = 35;
            this.btnChooseCustomer.Text = "اختر عميل";
            this.btnChooseCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChooseCustomer.UseVisualStyleBackColor = true;
            this.btnChooseCustomer.Click += new System.EventHandler(this.btnChooseCustomer_Click);
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtOrderDate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderDate.Location = new System.Drawing.Point(550, 23);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtOrderDate.RightToLeftLayout = true;
            this.txtOrderDate.Size = new System.Drawing.Size(197, 21);
            this.txtOrderDate.TabIndex = 0;
            // 
            // OrderType
            // 
            this.OrderType.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderType.ForeColor = System.Drawing.Color.Brown;
            this.OrderType.Location = new System.Drawing.Point(7, 14);
            this.OrderType.Name = "OrderType";
            this.OrderType.Size = new System.Drawing.Size(304, 33);
            this.OrderType.TabIndex = 34;
            this.OrderType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSalesMan
            // 
            this.txtSalesMan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSalesMan.Enabled = false;
            this.txtSalesMan.Location = new System.Drawing.Point(7, 54);
            this.txtSalesMan.Name = "txtSalesMan";
            this.txtSalesMan.ReadOnly = true;
            this.txtSalesMan.Size = new System.Drawing.Size(187, 19);
            this.txtSalesMan.TabIndex = 32;
            this.txtSalesMan.TabStop = false;
            this.txtSalesMan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(203, 55);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(51, 16);
            this.label21.TabIndex = 33;
            this.label21.Text = "بواسطة :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(750, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "التاريخ فى :";
            // 
            // txtOrderPersonName
            // 
            this.txtOrderPersonName.Location = new System.Drawing.Point(438, 50);
            this.txtOrderPersonName.Name = "txtOrderPersonName";
            this.txtOrderPersonName.Size = new System.Drawing.Size(309, 26);
            this.txtOrderPersonName.TabIndex = 1;
            this.txtOrderPersonName.TextChanged += new System.EventHandler(this.txtOrderPersonName_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(754, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "إلى السيد :";
            // 
            // txtCusid
            // 
            this.txtCusid.Location = new System.Drawing.Point(435, 18);
            this.txtCusid.Name = "txtCusid";
            this.txtCusid.Size = new System.Drawing.Size(109, 26);
            this.txtCusid.TabIndex = 37;
            this.txtCusid.Visible = false;
            // 
            // OrderLabel
            // 
            this.OrderLabel.Location = new System.Drawing.Point(414, 10);
            this.OrderLabel.Name = "OrderLabel";
            this.OrderLabel.Size = new System.Drawing.Size(100, 25);
            this.OrderLabel.TabIndex = 31;
            this.OrderLabel.Text = "فـــاتـــورة  بيـــــع";
            this.OrderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ctxEditOrderProductsList
            // 
            this.ctxEditOrderProductsList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تعديلToolStripMenuItem,
            this.حذفToolStripMenuItem,
            this.مسحالقائمةToolStripMenuItem});
            this.ctxEditOrderProductsList.Name = "ctxEditOrderProductsList";
            this.ctxEditOrderProductsList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ctxEditOrderProductsList.Size = new System.Drawing.Size(130, 70);
            // 
            // تعديلToolStripMenuItem
            // 
            this.تعديلToolStripMenuItem.Image = global::SalesManagement.Properties.Resources.b_edit;
            this.تعديلToolStripMenuItem.Name = "تعديلToolStripMenuItem";
            this.تعديلToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.تعديلToolStripMenuItem.Text = "تعديل";
            this.تعديلToolStripMenuItem.Click += new System.EventHandler(this.تعديلToolStripMenuItem_Click);
            // 
            // حذفToolStripMenuItem
            // 
            this.حذفToolStripMenuItem.Image = global::SalesManagement.Properties.Resources.delete2_1_;
            this.حذفToolStripMenuItem.Name = "حذفToolStripMenuItem";
            this.حذفToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.حذفToolStripMenuItem.Text = "حذف";
            this.حذفToolStripMenuItem.Click += new System.EventHandler(this.حذفToolStripMenuItem_Click);
            // 
            // مسحالقائمةToolStripMenuItem
            // 
            this.مسحالقائمةToolStripMenuItem.Name = "مسحالقائمةToolStripMenuItem";
            this.مسحالقائمةToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.مسحالقائمةToolStripMenuItem.Text = "مسح القائمة";
            this.مسحالقائمةToolStripMenuItem.Click += new System.EventHandler(this.مسحالقائمةToolStripMenuItem_Click);
            // 
            // cmbProductName
            // 
            this.cmbProductName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbProductName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbProductName.FormattingEnabled = true;
            this.cmbProductName.Location = new System.Drawing.Point(559, 48);
            this.cmbProductName.Name = "cmbProductName";
            this.cmbProductName.Size = new System.Drawing.Size(215, 26);
            this.cmbProductName.TabIndex = 1;
            this.cmbProductName.SelectionChangeCommitted += new System.EventHandler(this.cmbProductName_SelectionChangeCommitted);
            // 
            // dgvOrderProductsList
            // 
            this.dgvOrderProductsList.AllowUserToAddRows = false;
            this.dgvOrderProductsList.AllowUserToDeleteRows = false;
            this.dgvOrderProductsList.AllowUserToResizeColumns = false;
            this.dgvOrderProductsList.AllowUserToResizeRows = false;
            this.dgvOrderProductsList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvOrderProductsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderProductsList.ColumnHeadersVisible = false;
            this.dgvOrderProductsList.ContextMenuStrip = this.ctxEditOrderProductsList;
            this.dgvOrderProductsList.Location = new System.Drawing.Point(153, 74);
            this.dgvOrderProductsList.MultiSelect = false;
            this.dgvOrderProductsList.Name = "dgvOrderProductsList";
            this.dgvOrderProductsList.ReadOnly = true;
            this.dgvOrderProductsList.RowHeadersWidth = 45;
            this.dgvOrderProductsList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvOrderProductsList.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrderProductsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderProductsList.Size = new System.Drawing.Size(667, 179);
            this.dgvOrderProductsList.TabIndex = 0;
            this.dgvOrderProductsList.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvOrderProductsList_DataBindingComplete);
            this.dgvOrderProductsList.DoubleClick += new System.EventHandler(this.dgvOrderProductsList_DoubleClick);
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(439, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "سعر الوحدة";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(439, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "جنيه";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(488, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "قرش";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(153, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "إجمالى";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNotes
            // 
            this.txtNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNotes.BackColor = System.Drawing.SystemColors.Window;
            this.txtNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNotes.Location = new System.Drawing.Point(6, 74);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(147, 179);
            this.txtNotes.TabIndex = 5;
            this.txtNotes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNotes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNotes_KeyDown);
            this.txtNotes.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNotes_KeyUp);
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 74);
            this.label8.TabIndex = 15;
            this.label8.Text = "مـــلاحـظات";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(153, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 24);
            this.label12.TabIndex = 19;
            this.label12.Text = "جنيه";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(238, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 24);
            this.label11.TabIndex = 20;
            this.label11.Text = "قرش";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalCost.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalCost.Enabled = false;
            this.txtTotalCost.Location = new System.Drawing.Point(153, 48);
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.ReadOnly = true;
            this.txtTotalCost.Size = new System.Drawing.Size(119, 26);
            this.txtTotalCost.TabIndex = 3;
            this.txtTotalCost.TabStop = false;
            this.txtTotalCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantity.Location = new System.Drawing.Point(364, 48);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(75, 26);
            this.txtQuantity.TabIndex = 3;
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuantity_KeyDown);
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            this.txtQuantity.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtQuantity_KeyUp);
            this.txtQuantity.Leave += new System.EventHandler(this.txtQuantity_Leave);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(365, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 48);
            this.label2.TabIndex = 24;
            this.label2.Text = "عدد";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(70, 257);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(205, 23);
            this.label18.TabIndex = 27;
            this.label18.Text = "إجمالى قيمة الفاتورة :";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(532, 257);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 26);
            this.label19.TabIndex = 29;
            this.label19.Text = "مدفوع :";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPaidPrice
            // 
            this.txtPaidPrice.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaidPrice.Location = new System.Drawing.Point(355, 259);
            this.txtPaidPrice.Name = "txtPaidPrice";
            this.txtPaidPrice.Size = new System.Drawing.Size(171, 23);
            this.txtPaidPrice.TabIndex = 7;
            this.txtPaidPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPaidPrice.TextChanged += new System.EventHandler(this.txtPaidPrice_TextChanged);
            this.txtPaidPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPaidPrice_KeyDown);
            this.txtPaidPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPaidPrice_KeyPress);
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(534, 291);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(69, 26);
            this.label20.TabIndex = 31;
            this.label20.Text = "باقى :";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtChangeCost
            // 
            this.txtChangeCost.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtChangeCost.Enabled = false;
            this.txtChangeCost.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChangeCost.Location = new System.Drawing.Point(355, 293);
            this.txtChangeCost.Name = "txtChangeCost";
            this.txtChangeCost.ReadOnly = true;
            this.txtChangeCost.Size = new System.Drawing.Size(171, 23);
            this.txtChangeCost.TabIndex = 8;
            this.txtChangeCost.TabStop = false;
            this.txtChangeCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(272, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 48);
            this.label3.TabIndex = 34;
            this.label3.Text = "وحدة";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUnitCost
            // 
            this.txtUnitCost.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUnitCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUnitCost.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitCost.Location = new System.Drawing.Point(439, 48);
            this.txtUnitCost.Name = "txtUnitCost";
            this.txtUnitCost.Size = new System.Drawing.Size(120, 26);
            this.txtUnitCost.TabIndex = 2;
            this.txtUnitCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUnitCost.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUnitCost_KeyDown);
            this.txtUnitCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUnitCost_KeyPress);
            this.txtUnitCost.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtUnitCost_KeyUp);
            this.txtUnitCost.Leave += new System.EventHandler(this.txtUnitCost_Leave);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(559, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "بيــــــــان الصنــف";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvOrderProductsList);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBarcodeSearcher);
            this.groupBox1.Controls.Add(this.SumTotalCost);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.txtDiscount);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtUnitCost);
            this.groupBox1.Controls.Add(this.txtChangeCost);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.txtPaidPrice);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtQuantity);
            this.groupBox1.Controls.Add(this.txtTotalCost);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtNotes);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbProductName);
            this.groupBox1.Controls.Add(this.btnChooseProducts);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.cmbUnit);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Courier New", 12F);
            this.groupBox1.Location = new System.Drawing.Point(5, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(820, 331);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // txtBarcodeSearcher
            // 
            this.txtBarcodeSearcher.BackColor = System.Drawing.Color.FloralWhite;
            this.txtBarcodeSearcher.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarcodeSearcher.Location = new System.Drawing.Point(559, 26);
            this.txtBarcodeSearcher.Name = "txtBarcodeSearcher";
            this.txtBarcodeSearcher.ReadOnly = true;
            this.txtBarcodeSearcher.Size = new System.Drawing.Size(215, 22);
            this.txtBarcodeSearcher.TabIndex = 43;
            this.txtBarcodeSearcher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBarcodeSearcher.TextChanged += new System.EventHandler(this.txtBarcodeSearcher_TextChanged);
            // 
            // SumTotalCost
            // 
            this.SumTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SumTotalCost.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.SumTotalCost.Location = new System.Drawing.Point(50, 280);
            this.SumTotalCost.Name = "SumTotalCost";
            this.SumTotalCost.Size = new System.Drawing.Size(222, 37);
            this.SumTotalCost.TabIndex = 42;
            this.SumTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SumTotalCost.TextChanged += new System.EventHandler(this.SumTotalCost_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.label16.Location = new System.Drawing.Point(632, 277);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(22, 21);
            this.label16.TabIndex = 41;
            this.label16.Text = "%";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Location = new System.Drawing.Point(658, 280);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(70, 23);
            this.txtDiscount.TabIndex = 39;
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            this.txtDiscount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDiscount_KeyDown);
            this.txtDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiscount_KeyPress);
            this.txtDiscount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDiscount_KeyUp);
            this.txtDiscount.Leave += new System.EventHandler(this.txtDiscount_Leave);
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(734, 276);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 26);
            this.label14.TabIndex = 40;
            this.label14.Text = "خصم :";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnChooseProducts
            // 
            this.btnChooseProducts.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnChooseProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChooseProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseProducts.Font = new System.Drawing.Font("Courier New", 12F);
            this.btnChooseProducts.Image = ((System.Drawing.Image)(resources.GetObject("btnChooseProducts.Image")));
            this.btnChooseProducts.Location = new System.Drawing.Point(774, 48);
            this.btnChooseProducts.Name = "btnChooseProducts";
            this.btnChooseProducts.Size = new System.Drawing.Size(46, 27);
            this.btnChooseProducts.TabIndex = 0;
            this.btnChooseProducts.UseVisualStyleBackColor = false;
            this.btnChooseProducts.Click += new System.EventHandler(this.btnChooseProducts_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 298);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 18);
            this.label13.TabIndex = 36;
            this.label13.Text = "ج.م";
            // 
            // label22
            // 
            this.label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label22.Location = new System.Drawing.Point(773, 26);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(47, 24);
            this.label22.TabIndex = 44;
            this.label22.Text = "باركود";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbUnit
            // 
            this.cmbUnit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbUnit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Location = new System.Drawing.Point(271, 49);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(94, 26);
            this.cmbUnit.TabIndex = 35;
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewOrder.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNewOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnNewOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewOrder.Image = global::SalesManagement.Properties.Resources.plus;
            this.btnNewOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewOrder.Location = new System.Drawing.Point(540, 453);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(75, 28);
            this.btnNewOrder.TabIndex = 11;
            this.btnNewOrder.Text = "جديد";
            this.btnNewOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click);
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddOrder.Enabled = false;
            this.btnAddOrder.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOrder.Image = global::SalesManagement.Properties.Resources.b_save;
            this.btnAddOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddOrder.Location = new System.Drawing.Point(414, 453);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(99, 29);
            this.btnAddOrder.TabIndex = 7;
            this.btnAddOrder.Text = "حفظ الفاتورة";
            this.btnAddOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // btnUndoProduct
            // 
            this.btnUndoProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUndoProduct.Enabled = false;
            this.btnUndoProduct.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUndoProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnUndoProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUndoProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnUndoProduct.Image")));
            this.btnUndoProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUndoProduct.Location = new System.Drawing.Point(315, 453);
            this.btnUndoProduct.Name = "btnUndoProduct";
            this.btnUndoProduct.Size = new System.Drawing.Size(75, 29);
            this.btnUndoProduct.TabIndex = 9;
            this.btnUndoProduct.Text = "الغاء";
            this.btnUndoProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUndoProduct.Click += new System.EventHandler(this.btnSaveProduct_Click);
            // 
            // btnPrinOrder
            // 
            this.btnPrinOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrinOrder.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPrinOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPrinOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrinOrder.Image = global::SalesManagement.Properties.Resources.b_print;
            this.btnPrinOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrinOrder.Location = new System.Drawing.Point(166, 453);
            this.btnPrinOrder.Name = "btnPrinOrder";
            this.btnPrinOrder.Size = new System.Drawing.Size(126, 29);
            this.btnPrinOrder.TabIndex = 8;
            this.btnPrinOrder.Text = "طباعة أخر الفاتورة";
            this.btnPrinOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrinOrder.Click += new System.EventHandler(this.btnPrinOrder_Click);
            // 
            // NewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(844, 498);
            this.Controls.Add(this.btnNewOrder);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.btnUndoProduct);
            this.Controls.Add(this.btnPrinOrder);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.OrderLabel);
            this.Controls.Add(this.groupBox1);
            this.DisplayHeader = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewOrder";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "  فاتورة جديدة";
            this.Load += new System.EventHandler(this.NewOrder_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ctxEditOrderProductsList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderProductsList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox txtOrderPersonName;
        public System.Windows.Forms.Button btnAddOrder;
        public System.Windows.Forms.Button btnUndoProduct;
        public System.Windows.Forms.Button btnPrinOrder;
        public System.Windows.Forms.TextBox txtSalesMan;
        private System.Windows.Forms.Label label21;
        public System.Windows.Forms.DateTimePicker txtOrderDate;
        public System.Windows.Forms.Label OrderType;
        public System.Windows.Forms.Button btnChooseCustomer;
        public System.Windows.Forms.CheckBox chGeneralPerson;
        public System.Windows.Forms.TextBox txtCusid;
        public System.Windows.Forms.Label OrderLabel;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.ContextMenuStrip ctxEditOrderProductsList;
        private System.Windows.Forms.ToolStripMenuItem تعديلToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حذفToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem مسحالقائمةToolStripMenuItem;
        public System.Windows.Forms.Button btnChooseProducts;
        public System.Windows.Forms.ComboBox cmbProductName;
        public System.Windows.Forms.DataGridView dgvOrderProductsList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txtTotalCost;
        public System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        public System.Windows.Forms.TextBox txtPaidPrice;
        private System.Windows.Forms.Label label20;
        public System.Windows.Forms.TextBox txtChangeCost;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtUnitCost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button btnNewOrder;
        public System.Windows.Forms.ComboBox cmbUnit;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.Label SumTotalCost;
        public System.Windows.Forms.TextBox txtBarcodeSearcher;
        private System.Windows.Forms.Label label22;

    }
}