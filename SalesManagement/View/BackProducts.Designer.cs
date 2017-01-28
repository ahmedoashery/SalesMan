namespace SalesManagement.View
{
    partial class BackProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackProducts));
            this.label1 = new System.Windows.Forms.Label();
            this.txtUnitCost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SumTotalCost = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtTotalCost = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvOrderProductsList = new System.Windows.Forms.DataGridView();
            this.ctxEditOrderProductsList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.تعديلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مسحالقائمةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbProductName = new System.Windows.Forms.ComboBox();
            this.txtCusid = new System.Windows.Forms.TextBox();
            this.chGeneralPerson = new System.Windows.Forms.CheckBox();
            this.btnChooseCustomer = new System.Windows.Forms.Button();
            this.txtOrderDate = new System.Windows.Forms.DateTimePicker();
            this.OrderType = new System.Windows.Forms.Label();
            this.txtSalesMan = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtOrderPersonName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.btnSaveProduct = new System.Windows.Forms.Button();
            this.btnPrinOrder = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.OrderLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.btnChooseProducts = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderProductsList)).BeginInit();
            this.ctxEditOrderProductsList.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Courier New", 8F);
            this.label1.Location = new System.Drawing.Point(559, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "بيــــــــان الصنــف";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUnitCost
            // 
            this.txtUnitCost.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUnitCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUnitCost.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitCost.Location = new System.Drawing.Point(457, 47);
            this.txtUnitCost.Name = "txtUnitCost";
            this.txtUnitCost.Size = new System.Drawing.Size(102, 26);
            this.txtUnitCost.TabIndex = 2;
            this.txtUnitCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUnitCost.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUnitCost_KeyDown);
            this.txtUnitCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUnitCost_KeyPress);
            this.txtUnitCost.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtUnitCost_KeyUp);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Courier New", 8F);
            this.label3.Location = new System.Drawing.Point(304, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 48);
            this.label3.TabIndex = 34;
            this.label3.Text = "وحدة";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SumTotalCost
            // 
            this.SumTotalCost.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SumTotalCost.Enabled = false;
            this.SumTotalCost.Location = new System.Drawing.Point(413, 262);
            this.SumTotalCost.Name = "SumTotalCost";
            this.SumTotalCost.ReadOnly = true;
            this.SumTotalCost.Size = new System.Drawing.Size(194, 26);
            this.SumTotalCost.TabIndex = 6;
            this.SumTotalCost.TabStop = false;
            this.SumTotalCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SumTotalCost.Leave += new System.EventHandler(this.SumTotalCost_Leave);
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(607, 265);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(197, 23);
            this.label18.TabIndex = 27;
            this.label18.Text = "إجمالى قيمة المرتجعات :";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Courier New", 8F);
            this.label2.Location = new System.Drawing.Point(391, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 48);
            this.label2.TabIndex = 24;
            this.label2.Text = "عدد";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantity.Location = new System.Drawing.Point(391, 47);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(66, 26);
            this.txtQuantity.TabIndex = 3;
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuantity_KeyDown);
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            this.txtQuantity.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtQuantity_KeyUp);
            this.txtQuantity.Leave += new System.EventHandler(this.txtQuantity_Leave);
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalCost.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalCost.Enabled = false;
            this.txtTotalCost.Location = new System.Drawing.Point(210, 47);
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.ReadOnly = true;
            this.txtTotalCost.Size = new System.Drawing.Size(94, 26);
            this.txtTotalCost.TabIndex = 3;
            this.txtTotalCost.TabStop = false;
            this.txtTotalCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("Courier New", 8F);
            this.label11.Location = new System.Drawing.Point(265, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 24);
            this.label11.TabIndex = 20;
            this.label11.Text = "قرش";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Font = new System.Drawing.Font("Courier New", 8F);
            this.label12.Location = new System.Drawing.Point(210, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 24);
            this.label12.TabIndex = 19;
            this.label12.Text = "جنيه";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Courier New", 8F);
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(210, 48);
            this.label8.TabIndex = 15;
            this.label8.Text = "مـــلاحـظات";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNotes
            // 
            this.txtNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNotes.Location = new System.Drawing.Point(0, 47);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(210, 26);
            this.txtNotes.TabIndex = 5;
            this.txtNotes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNotes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNotes_KeyDown);
            this.txtNotes.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNotes_KeyUp);
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Courier New", 8F);
            this.label7.Location = new System.Drawing.Point(210, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "إجمالى";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Courier New", 8F);
            this.label6.Location = new System.Drawing.Point(508, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "قرش";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Courier New", 8F);
            this.label4.Location = new System.Drawing.Point(457, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "جنيه";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Courier New", 8F);
            this.label5.Location = new System.Drawing.Point(457, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "سعر الوحدة";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvOrderProductsList
            // 
            this.dgvOrderProductsList.AllowUserToAddRows = false;
            this.dgvOrderProductsList.AllowUserToDeleteRows = false;
            this.dgvOrderProductsList.AllowUserToResizeColumns = false;
            this.dgvOrderProductsList.AllowUserToResizeRows = false;
            this.dgvOrderProductsList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvOrderProductsList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvOrderProductsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderProductsList.ColumnHeadersVisible = false;
            this.dgvOrderProductsList.ContextMenuStrip = this.ctxEditOrderProductsList;
            this.dgvOrderProductsList.Location = new System.Drawing.Point(0, 73);
            this.dgvOrderProductsList.MultiSelect = false;
            this.dgvOrderProductsList.Name = "dgvOrderProductsList";
            this.dgvOrderProductsList.ReadOnly = true;
            this.dgvOrderProductsList.RowHeadersWidth = 45;
            this.dgvOrderProductsList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvOrderProductsList.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrderProductsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderProductsList.Size = new System.Drawing.Size(806, 187);
            this.dgvOrderProductsList.TabIndex = 0;
            this.dgvOrderProductsList.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvOrderProductsList_DataBindingComplete_1);
            this.dgvOrderProductsList.DoubleClick += new System.EventHandler(this.dgvOrderProductsList_DoubleClick);
            // 
            // ctxEditOrderProductsList
            // 
            this.ctxEditOrderProductsList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تعديلToolStripMenuItem,
            this.حذفToolStripMenuItem,
            this.مسحالقائمةToolStripMenuItem});
            this.ctxEditOrderProductsList.Name = "ctxEditOrderProductsList";
            this.ctxEditOrderProductsList.Size = new System.Drawing.Size(130, 70);
            // 
            // تعديلToolStripMenuItem
            // 
            this.تعديلToolStripMenuItem.Name = "تعديلToolStripMenuItem";
            this.تعديلToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.تعديلToolStripMenuItem.Text = "تعديل";
            this.تعديلToolStripMenuItem.Click += new System.EventHandler(this.تعديلToolStripMenuItem_Click);
            // 
            // حذفToolStripMenuItem
            // 
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
            this.cmbProductName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmbProductName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbProductName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbProductName.FormattingEnabled = true;
            this.cmbProductName.Location = new System.Drawing.Point(559, 46);
            this.cmbProductName.Name = "cmbProductName";
            this.cmbProductName.Size = new System.Drawing.Size(195, 26);
            this.cmbProductName.TabIndex = 1;
            this.cmbProductName.SelectionChangeCommitted += new System.EventHandler(this.cmbProductName_SelectionChangeCommitted);
            // 
            // txtCusid
            // 
            this.txtCusid.Font = new System.Drawing.Font("Tahoma", 8F);
            this.txtCusid.Location = new System.Drawing.Point(332, 45);
            this.txtCusid.Name = "txtCusid";
            this.txtCusid.Size = new System.Drawing.Size(109, 20);
            this.txtCusid.TabIndex = 37;
            this.txtCusid.Visible = false;
            // 
            // chGeneralPerson
            // 
            this.chGeneralPerson.AutoSize = true;
            this.chGeneralPerson.Checked = true;
            this.chGeneralPerson.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chGeneralPerson.Font = new System.Drawing.Font("Tahoma", 8F);
            this.chGeneralPerson.Location = new System.Drawing.Point(413, 74);
            this.chGeneralPerson.Name = "chGeneralPerson";
            this.chGeneralPerson.Size = new System.Drawing.Size(43, 17);
            this.chGeneralPerson.TabIndex = 36;
            this.chGeneralPerson.Text = "عام";
            this.chGeneralPerson.UseVisualStyleBackColor = false;
            this.chGeneralPerson.Click += new System.EventHandler(this.chGeneralPerson_Click);
            // 
            // btnChooseCustomer
            // 
            this.btnChooseCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnChooseCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChooseCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseCustomer.Font = new System.Drawing.Font("Tahoma", 8F);
            this.btnChooseCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChooseCustomer.Location = new System.Drawing.Point(332, 72);
            this.btnChooseCustomer.Name = "btnChooseCustomer";
            this.btnChooseCustomer.Size = new System.Drawing.Size(75, 27);
            this.btnChooseCustomer.TabIndex = 35;
            this.btnChooseCustomer.Text = "اختر عميل";
            this.btnChooseCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChooseCustomer.UseVisualStyleBackColor = true;
            this.btnChooseCustomer.Click += new System.EventHandler(this.btnChooseCustomer_Click);
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.Font = new System.Drawing.Font("Tahoma", 8F);
            this.txtOrderDate.Location = new System.Drawing.Point(551, 45);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtOrderDate.RightToLeftLayout = true;
            this.txtOrderDate.Size = new System.Drawing.Size(182, 20);
            this.txtOrderDate.TabIndex = 0;
            // 
            // OrderType
            // 
            this.OrderType.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderType.ForeColor = System.Drawing.Color.Brown;
            this.OrderType.Location = new System.Drawing.Point(6, 16);
            this.OrderType.Name = "OrderType";
            this.OrderType.Size = new System.Drawing.Size(292, 32);
            this.OrderType.TabIndex = 34;
            this.OrderType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSalesMan
            // 
            this.txtSalesMan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSalesMan.Enabled = false;
            this.txtSalesMan.Font = new System.Drawing.Font("Tahoma", 8F);
            this.txtSalesMan.Location = new System.Drawing.Point(13, 81);
            this.txtSalesMan.Name = "txtSalesMan";
            this.txtSalesMan.ReadOnly = true;
            this.txtSalesMan.Size = new System.Drawing.Size(197, 13);
            this.txtSalesMan.TabIndex = 32;
            this.txtSalesMan.TabStop = false;
            this.txtSalesMan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Tahoma", 8F);
            this.label21.Location = new System.Drawing.Point(216, 80);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(50, 13);
            this.label21.TabIndex = 33;
            this.label21.Text = "بواسطة :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 8F);
            this.label10.Location = new System.Drawing.Point(739, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "التاريخ فى :";
            // 
            // txtOrderPersonName
            // 
            this.txtOrderPersonName.Font = new System.Drawing.Font("Tahoma", 8F);
            this.txtOrderPersonName.Location = new System.Drawing.Point(462, 72);
            this.txtOrderPersonName.Name = "txtOrderPersonName";
            this.txtOrderPersonName.Size = new System.Drawing.Size(271, 20);
            this.txtOrderPersonName.TabIndex = 1;
            this.txtOrderPersonName.TextChanged += new System.EventHandler(this.txtOrderPersonName_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8F);
            this.label9.Location = new System.Drawing.Point(743, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "من السيد :";
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddOrder.Enabled = false;
            this.btnAddOrder.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddOrder.FlatAppearance.BorderSize = 0;
            this.btnAddOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(189)))), ((int)(((byte)(16)))));
            this.btnAddOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(221)))), ((int)(((byte)(112)))));
            this.btnAddOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOrder.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnAddOrder.Image = global::SalesManagement.Properties.Resources.b_save;
            this.btnAddOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddOrder.Location = new System.Drawing.Point(337, 472);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(75, 26);
            this.btnAddOrder.TabIndex = 14;
            this.btnAddOrder.Text = "حفظ";
            this.btnAddOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click_1);
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewOrder.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNewOrder.FlatAppearance.BorderSize = 0;
            this.btnNewOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(189)))), ((int)(((byte)(16)))));
            this.btnNewOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(221)))), ((int)(((byte)(112)))));
            this.btnNewOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewOrder.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnNewOrder.Image = ((System.Drawing.Image)(resources.GetObject("btnNewOrder.Image")));
            this.btnNewOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewOrder.Location = new System.Drawing.Point(552, 472);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(75, 26);
            this.btnNewOrder.TabIndex = 13;
            this.btnNewOrder.Text = "جديد";
            this.btnNewOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewOrder.UseVisualStyleBackColor = true;
            this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click_1);
            // 
            // btnSaveProduct
            // 
            this.btnSaveProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveProduct.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSaveProduct.FlatAppearance.BorderSize = 0;
            this.btnSaveProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(189)))), ((int)(((byte)(16)))));
            this.btnSaveProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(221)))), ((int)(((byte)(112)))));
            this.btnSaveProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveProduct.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnSaveProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveProduct.Image")));
            this.btnSaveProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveProduct.Location = new System.Drawing.Point(442, 472);
            this.btnSaveProduct.Name = "btnSaveProduct";
            this.btnSaveProduct.Size = new System.Drawing.Size(75, 26);
            this.btnSaveProduct.TabIndex = 16;
            this.btnSaveProduct.Text = "الغاء";
            this.btnSaveProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveProduct.UseVisualStyleBackColor = true;
            this.btnSaveProduct.Click += new System.EventHandler(this.btnSaveProduct_Click_1);
            // 
            // btnPrinOrder
            // 
            this.btnPrinOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrinOrder.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPrinOrder.FlatAppearance.BorderSize = 0;
            this.btnPrinOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(189)))), ((int)(((byte)(16)))));
            this.btnPrinOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(221)))), ((int)(((byte)(112)))));
            this.btnPrinOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrinOrder.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnPrinOrder.Image = global::SalesManagement.Properties.Resources.b_print;
            this.btnPrinOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrinOrder.Location = new System.Drawing.Point(188, 472);
            this.btnPrinOrder.Name = "btnPrinOrder";
            this.btnPrinOrder.Size = new System.Drawing.Size(120, 26);
            this.btnPrinOrder.TabIndex = 15;
            this.btnPrinOrder.Text = "طباعة الفاتورة";
            this.btnPrinOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrinOrder.UseVisualStyleBackColor = true;
            this.btnPrinOrder.Click += new System.EventHandler(this.btnPrinOrder_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.groupBox2.Controls.Add(this.txtCusid);
            this.groupBox2.Controls.Add(this.chGeneralPerson);
            this.groupBox2.Controls.Add(this.btnChooseCustomer);
            this.groupBox2.Controls.Add(this.txtOrderDate);
            this.groupBox2.Controls.Add(this.OrderType);
            this.groupBox2.Controls.Add(this.txtSalesMan);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtOrderPersonName);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(5, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(807, 110);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // OrderLabel
            // 
            this.OrderLabel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderLabel.Location = new System.Drawing.Point(442, 24);
            this.OrderLabel.Name = "OrderLabel";
            this.OrderLabel.Size = new System.Drawing.Size(94, 27);
            this.OrderLabel.TabIndex = 38;
            this.OrderLabel.Text = "مرتجع";
            this.OrderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OrderLabel.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbUnit);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtUnitCost);
            this.groupBox1.Controls.Add(this.SumTotalCost);
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
            this.groupBox1.Controls.Add(this.dgvOrderProductsList);
            this.groupBox1.Controls.Add(this.cmbProductName);
            this.groupBox1.Controls.Add(this.btnChooseProducts);
            this.groupBox1.Font = new System.Drawing.Font("Courier New", 12F);
            this.groupBox1.Location = new System.Drawing.Point(5, 166);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(807, 296);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // cmbUnit
            // 
            this.cmbUnit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Location = new System.Drawing.Point(304, 47);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(87, 26);
            this.cmbUnit.TabIndex = 36;
            // 
            // btnChooseProducts
            // 
            this.btnChooseProducts.BackColor = System.Drawing.Color.Lavender;
            this.btnChooseProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChooseProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseProducts.Font = new System.Drawing.Font("Courier New", 12F);
            this.btnChooseProducts.Image = ((System.Drawing.Image)(resources.GetObject("btnChooseProducts.Image")));
            this.btnChooseProducts.Location = new System.Drawing.Point(758, 47);
            this.btnChooseProducts.Name = "btnChooseProducts";
            this.btnChooseProducts.Size = new System.Drawing.Size(47, 27);
            this.btnChooseProducts.TabIndex = 0;
            this.btnChooseProducts.UseVisualStyleBackColor = false;
            this.btnChooseProducts.Click += new System.EventHandler(this.btnChooseProducts_Click_1);
            // 
            // BackProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 511);
            this.Controls.Add(this.OrderLabel);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.btnNewOrder);
            this.Controls.Add(this.btnSaveProduct);
            this.Controls.Add(this.btnPrinOrder);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BackProducts";
            this.Resizable = false;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "   فاتورة مرتجع";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderProductsList)).EndInit();
            this.ctxEditOrderProductsList.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtUnitCost;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox SumTotalCost;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtQuantity;
        public System.Windows.Forms.TextBox txtTotalCost;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.DataGridView dgvOrderProductsList;
        public System.Windows.Forms.ContextMenuStrip ctxEditOrderProductsList;
        private System.Windows.Forms.ToolStripMenuItem تعديلToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حذفToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem مسحالقائمةToolStripMenuItem;
        public System.Windows.Forms.ComboBox cmbProductName;
        public System.Windows.Forms.TextBox txtCusid;
        public System.Windows.Forms.CheckBox chGeneralPerson;
        public System.Windows.Forms.Button btnChooseCustomer;
        public System.Windows.Forms.DateTimePicker txtOrderDate;
        public System.Windows.Forms.Label OrderType;
        public System.Windows.Forms.TextBox txtSalesMan;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtOrderPersonName;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Button btnAddOrder;
        public System.Windows.Forms.Button btnNewOrder;
        public System.Windows.Forms.Button btnSaveProduct;
        public System.Windows.Forms.Button btnPrinOrder;
        public System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button btnChooseProducts;
        public System.Windows.Forms.Label OrderLabel;
        public System.Windows.Forms.ComboBox cmbUnit;
    }
}