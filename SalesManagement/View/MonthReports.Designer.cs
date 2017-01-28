namespace SalesManagement.View
{
    partial class MonthReports
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtMonth = new System.Windows.Forms.DateTimePicker();
            this.btnShowBackOrders = new System.Windows.Forms.Button();
            this.btnPrintBuysOrders = new System.Windows.Forms.Button();
            this.btnShowBuysOrders = new System.Windows.Forms.Button();
            this.btnPrintSalesOrders = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtsalesman2 = new System.Windows.Forms.Label();
            this.salesman = new System.Windows.Forms.Label();
            this.txtPerson = new System.Windows.Forms.Label();
            this.person = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtOrderNotes = new System.Windows.Forms.TextBox();
            this.dgvMonthOrders = new System.Windows.Forms.DataGridView();
            this.dgvShowOrderDetailes = new System.Windows.Forms.DataGridView();
            this.label25 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBackOrdersTotalCost = new System.Windows.Forms.TextBox();
            this.txtBackOrdersCount = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtBuysOrdersTotalChange = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtBuysOrdersTotaPaids = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBuysOrdersTotalCost = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBuysOrdersCount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSalesOrdersCount = new System.Windows.Forms.TextBox();
            this.txtSalesOrdersTotalChange = new System.Windows.Forms.TextBox();
            this.txtSalesOrdersTotalPaids = new System.Windows.Forms.TextBox();
            this.txtSalesOrdersTotalCost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnShowSalesOrders = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSalesMan = new System.Windows.Forms.TextBox();
            this.btnBackOrdersPrint = new System.Windows.Forms.Button();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonthOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowOrderDetailes)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtMonth
            // 
            this.dtMonth.Checked = false;
            this.dtMonth.CustomFormat = "MMM  -  yyyy";
            this.dtMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtMonth.Location = new System.Drawing.Point(382, 54);
            this.dtMonth.Name = "dtMonth";
            this.dtMonth.RightToLeftLayout = true;
            this.dtMonth.Size = new System.Drawing.Size(168, 20);
            this.dtMonth.TabIndex = 0;
            this.dtMonth.ValueChanged += new System.EventHandler(this.dtMonth_ValueChanged);
            // 
            // btnShowBackOrders
            // 
            this.btnShowBackOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowBackOrders.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnShowBackOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowBackOrders.Location = new System.Drawing.Point(142, 212);
            this.btnShowBackOrders.Name = "btnShowBackOrders";
            this.btnShowBackOrders.Size = new System.Drawing.Size(75, 23);
            this.btnShowBackOrders.TabIndex = 20;
            this.btnShowBackOrders.Text = "عرض";
            this.btnShowBackOrders.UseVisualStyleBackColor = true;
            this.btnShowBackOrders.Click += new System.EventHandler(this.btnShowBackOrders_Click);
            // 
            // btnPrintBuysOrders
            // 
            this.btnPrintBuysOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintBuysOrders.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPrintBuysOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintBuysOrders.Location = new System.Drawing.Point(360, 212);
            this.btnPrintBuysOrders.Name = "btnPrintBuysOrders";
            this.btnPrintBuysOrders.Size = new System.Drawing.Size(75, 23);
            this.btnPrintBuysOrders.TabIndex = 19;
            this.btnPrintBuysOrders.Text = "طباعة";
            this.btnPrintBuysOrders.UseVisualStyleBackColor = true;
            this.btnPrintBuysOrders.Click += new System.EventHandler(this.btnPrintBuysOrders_Click);
            // 
            // btnShowBuysOrders
            // 
            this.btnShowBuysOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowBuysOrders.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnShowBuysOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowBuysOrders.Location = new System.Drawing.Point(440, 212);
            this.btnShowBuysOrders.Name = "btnShowBuysOrders";
            this.btnShowBuysOrders.Size = new System.Drawing.Size(75, 23);
            this.btnShowBuysOrders.TabIndex = 18;
            this.btnShowBuysOrders.Text = "عرض";
            this.btnShowBuysOrders.UseVisualStyleBackColor = true;
            this.btnShowBuysOrders.Click += new System.EventHandler(this.btnShowBuysOrders_Click);
            // 
            // btnPrintSalesOrders
            // 
            this.btnPrintSalesOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintSalesOrders.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPrintSalesOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintSalesOrders.Location = new System.Drawing.Point(666, 212);
            this.btnPrintSalesOrders.Name = "btnPrintSalesOrders";
            this.btnPrintSalesOrders.Size = new System.Drawing.Size(75, 23);
            this.btnPrintSalesOrders.TabIndex = 17;
            this.btnPrintSalesOrders.Text = "طباعة";
            this.btnPrintSalesOrders.UseVisualStyleBackColor = true;
            this.btnPrintSalesOrders.Click += new System.EventHandler(this.btnPrintSalesOrders_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtsalesman2);
            this.groupBox5.Controls.Add(this.salesman);
            this.groupBox5.Controls.Add(this.txtPerson);
            this.groupBox5.Controls.Add(this.person);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.txtOrderNotes);
            this.groupBox5.Controls.Add(this.dgvMonthOrders);
            this.groupBox5.Controls.Add(this.dgvShowOrderDetailes);
            this.groupBox5.Controls.Add(this.label25);
            this.groupBox5.Location = new System.Drawing.Point(7, 239);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(930, 292);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "البيانات ";
            // 
            // txtsalesman2
            // 
            this.txtsalesman2.BackColor = System.Drawing.Color.White;
            this.txtsalesman2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsalesman2.Location = new System.Drawing.Point(6, 224);
            this.txtsalesman2.Name = "txtsalesman2";
            this.txtsalesman2.Size = new System.Drawing.Size(164, 18);
            this.txtsalesman2.TabIndex = 29;
            this.txtsalesman2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // salesman
            // 
            this.salesman.BackColor = System.Drawing.Color.White;
            this.salesman.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.salesman.Location = new System.Drawing.Point(6, 205);
            this.salesman.Name = "salesman";
            this.salesman.Size = new System.Drawing.Size(165, 18);
            this.salesman.TabIndex = 28;
            this.salesman.Text = "المسئول";
            this.salesman.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPerson
            // 
            this.txtPerson.BackColor = System.Drawing.Color.White;
            this.txtPerson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPerson.Location = new System.Drawing.Point(170, 224);
            this.txtPerson.Name = "txtPerson";
            this.txtPerson.Size = new System.Drawing.Size(182, 18);
            this.txtPerson.TabIndex = 27;
            this.txtPerson.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // person
            // 
            this.person.BackColor = System.Drawing.Color.White;
            this.person.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.person.Location = new System.Drawing.Point(170, 205);
            this.person.Name = "person";
            this.person.Size = new System.Drawing.Size(182, 18);
            this.person.TabIndex = 26;
            this.person.Text = "العميل";
            this.person.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Location = new System.Drawing.Point(297, 244);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 31);
            this.label12.TabIndex = 20;
            this.label12.Text = "ملاحظات";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtOrderNotes
            // 
            this.txtOrderNotes.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtOrderNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOrderNotes.Location = new System.Drawing.Point(6, 244);
            this.txtOrderNotes.Multiline = true;
            this.txtOrderNotes.Name = "txtOrderNotes";
            this.txtOrderNotes.ReadOnly = true;
            this.txtOrderNotes.Size = new System.Drawing.Size(292, 31);
            this.txtOrderNotes.TabIndex = 19;
            this.txtOrderNotes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvMonthOrders
            // 
            this.dgvMonthOrders.AllowUserToAddRows = false;
            this.dgvMonthOrders.AllowUserToDeleteRows = false;
            this.dgvMonthOrders.AllowUserToResizeRows = false;
            this.dgvMonthOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMonthOrders.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMonthOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMonthOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonthOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvMonthOrders.Location = new System.Drawing.Point(375, 18);
            this.dgvMonthOrders.MultiSelect = false;
            this.dgvMonthOrders.Name = "dgvMonthOrders";
            this.dgvMonthOrders.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMonthOrders.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMonthOrders.RowHeadersWidth = 50;
            this.dgvMonthOrders.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvMonthOrders.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvMonthOrders.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvMonthOrders.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.dgvMonthOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMonthOrders.Size = new System.Drawing.Size(549, 257);
            this.dgvMonthOrders.TabIndex = 1;
            this.dgvMonthOrders.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvMonthOrders_DataBindingComplete);
            this.dgvMonthOrders.Click += new System.EventHandler(this.dgvMonthOrders_Click);
            // 
            // dgvShowOrderDetailes
            // 
            this.dgvShowOrderDetailes.AllowUserToAddRows = false;
            this.dgvShowOrderDetailes.AllowUserToDeleteRows = false;
            this.dgvShowOrderDetailes.AllowUserToOrderColumns = true;
            this.dgvShowOrderDetailes.AllowUserToResizeRows = false;
            this.dgvShowOrderDetailes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShowOrderDetailes.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvShowOrderDetailes.Location = new System.Drawing.Point(6, 18);
            this.dgvShowOrderDetailes.MultiSelect = false;
            this.dgvShowOrderDetailes.Name = "dgvShowOrderDetailes";
            this.dgvShowOrderDetailes.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShowOrderDetailes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvShowOrderDetailes.RowHeadersVisible = false;
            this.dgvShowOrderDetailes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvShowOrderDetailes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShowOrderDetailes.Size = new System.Drawing.Size(346, 186);
            this.dgvShowOrderDetailes.TabIndex = 0;
            // 
            // label25
            // 
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Location = new System.Drawing.Point(352, 75);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(24, 17);
            this.label25.TabIndex = 25;
            this.label25.Text = "=>";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.txtBackOrdersTotalCost);
            this.groupBox4.Controls.Add(this.txtBackOrdersCount);
            this.groupBox4.Location = new System.Drawing.Point(26, 79);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(297, 121);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "مرتجعات";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(4, 52);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(25, 13);
            this.label22.TabIndex = 28;
            this.label22.Text = "ج.م";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(194, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "عدد العمليات :";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(4, 28);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(25, 13);
            this.label23.TabIndex = 27;
            this.label23.Text = "ج.م";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(158, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "إجمالى قيمة المرتجع :";
            // 
            // txtBackOrdersTotalCost
            // 
            this.txtBackOrdersTotalCost.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBackOrdersTotalCost.Location = new System.Drawing.Point(35, 51);
            this.txtBackOrdersTotalCost.Name = "txtBackOrdersTotalCost";
            this.txtBackOrdersTotalCost.ReadOnly = true;
            this.txtBackOrdersTotalCost.Size = new System.Drawing.Size(117, 20);
            this.txtBackOrdersTotalCost.TabIndex = 16;
            this.txtBackOrdersTotalCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBackOrdersCount
            // 
            this.txtBackOrdersCount.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBackOrdersCount.Location = new System.Drawing.Point(35, 25);
            this.txtBackOrdersCount.Name = "txtBackOrdersCount";
            this.txtBackOrdersCount.ReadOnly = true;
            this.txtBackOrdersCount.Size = new System.Drawing.Size(117, 20);
            this.txtBackOrdersCount.TabIndex = 15;
            this.txtBackOrdersCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.txtBuysOrdersTotalChange);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.txtBuysOrdersTotaPaids);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtBuysOrdersTotalCost);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtBuysOrdersCount);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(329, 80);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(301, 120);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "مشتريات";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(4, 93);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(25, 13);
            this.label18.TabIndex = 26;
            this.label18.Text = "ج.م";
            // 
            // txtBuysOrdersTotalChange
            // 
            this.txtBuysOrdersTotalChange.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBuysOrdersTotalChange.Location = new System.Drawing.Point(31, 91);
            this.txtBuysOrdersTotalChange.Name = "txtBuysOrdersTotalChange";
            this.txtBuysOrdersTotalChange.ReadOnly = true;
            this.txtBuysOrdersTotalChange.Size = new System.Drawing.Size(117, 20);
            this.txtBuysOrdersTotalChange.TabIndex = 18;
            this.txtBuysOrdersTotalChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(3, 71);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(25, 13);
            this.label19.TabIndex = 25;
            this.label19.Text = "ج.م";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(195, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "إجمالى الباقى :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(3, 45);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(25, 13);
            this.label20.TabIndex = 24;
            this.label20.Text = "ج.م";
            // 
            // txtBuysOrdersTotaPaids
            // 
            this.txtBuysOrdersTotaPaids.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBuysOrdersTotaPaids.Location = new System.Drawing.Point(31, 67);
            this.txtBuysOrdersTotaPaids.Name = "txtBuysOrdersTotaPaids";
            this.txtBuysOrdersTotaPaids.ReadOnly = true;
            this.txtBuysOrdersTotaPaids.Size = new System.Drawing.Size(117, 20);
            this.txtBuysOrdersTotaPaids.TabIndex = 17;
            this.txtBuysOrdersTotaPaids.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(3, 21);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(25, 13);
            this.label21.TabIndex = 23;
            this.label21.Text = "ج.م";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(201, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "عدد العمليات :";
            // 
            // txtBuysOrdersTotalCost
            // 
            this.txtBuysOrdersTotalCost.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBuysOrdersTotalCost.Location = new System.Drawing.Point(31, 43);
            this.txtBuysOrdersTotalCost.Name = "txtBuysOrdersTotalCost";
            this.txtBuysOrdersTotalCost.ReadOnly = true;
            this.txtBuysOrdersTotalCost.Size = new System.Drawing.Size(117, 20);
            this.txtBuysOrdersTotalCost.TabIndex = 16;
            this.txtBuysOrdersTotalCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(188, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "إجمالى المدفوع :";
            // 
            // txtBuysOrdersCount
            // 
            this.txtBuysOrdersCount.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBuysOrdersCount.Location = new System.Drawing.Point(31, 19);
            this.txtBuysOrdersCount.Name = "txtBuysOrdersCount";
            this.txtBuysOrdersCount.ReadOnly = true;
            this.txtBuysOrdersCount.Size = new System.Drawing.Size(117, 20);
            this.txtBuysOrdersCount.TabIndex = 15;
            this.txtBuysOrdersCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(150, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "إجمالى قيمة المشتريات :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtSalesOrdersCount);
            this.groupBox2.Controls.Add(this.txtSalesOrdersTotalChange);
            this.groupBox2.Controls.Add(this.txtSalesOrdersTotalPaids);
            this.groupBox2.Controls.Add(this.txtSalesOrdersTotalCost);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(636, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(301, 122);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "مبيعات";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 94);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(25, 13);
            this.label17.TabIndex = 22;
            this.label17.Text = "ج.م";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(5, 72);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(25, 13);
            this.label16.TabIndex = 21;
            this.label16.Text = "ج.م";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(5, 46);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(25, 13);
            this.label15.TabIndex = 20;
            this.label15.Text = "ج.م";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(5, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(25, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "ج.م";
            // 
            // txtSalesOrdersCount
            // 
            this.txtSalesOrdersCount.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtSalesOrdersCount.Location = new System.Drawing.Point(30, 19);
            this.txtSalesOrdersCount.Name = "txtSalesOrdersCount";
            this.txtSalesOrdersCount.ReadOnly = true;
            this.txtSalesOrdersCount.Size = new System.Drawing.Size(117, 20);
            this.txtSalesOrdersCount.TabIndex = 15;
            this.txtSalesOrdersCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSalesOrdersTotalChange
            // 
            this.txtSalesOrdersTotalChange.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtSalesOrdersTotalChange.Location = new System.Drawing.Point(30, 91);
            this.txtSalesOrdersTotalChange.Name = "txtSalesOrdersTotalChange";
            this.txtSalesOrdersTotalChange.ReadOnly = true;
            this.txtSalesOrdersTotalChange.Size = new System.Drawing.Size(117, 20);
            this.txtSalesOrdersTotalChange.TabIndex = 14;
            this.txtSalesOrdersTotalChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSalesOrdersTotalPaids
            // 
            this.txtSalesOrdersTotalPaids.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtSalesOrdersTotalPaids.Location = new System.Drawing.Point(30, 67);
            this.txtSalesOrdersTotalPaids.Name = "txtSalesOrdersTotalPaids";
            this.txtSalesOrdersTotalPaids.ReadOnly = true;
            this.txtSalesOrdersTotalPaids.Size = new System.Drawing.Size(117, 20);
            this.txtSalesOrdersTotalPaids.TabIndex = 13;
            this.txtSalesOrdersTotalPaids.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSalesOrdersTotalCost
            // 
            this.txtSalesOrdersTotalCost.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtSalesOrdersTotalCost.Location = new System.Drawing.Point(30, 43);
            this.txtSalesOrdersTotalCost.Name = "txtSalesOrdersTotalCost";
            this.txtSalesOrdersTotalCost.ReadOnly = true;
            this.txtSalesOrdersTotalCost.Size = new System.Drawing.Size(117, 20);
            this.txtSalesOrdersTotalCost.TabIndex = 12;
            this.txtSalesOrdersTotalCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(187, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "إجمالى الباقى:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "إجمالى ما تم تحصيله :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "إجمالى قيمة المبيعات :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "عدد العمليات :";
            // 
            // btnShowSalesOrders
            // 
            this.btnShowSalesOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowSalesOrders.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnShowSalesOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowSalesOrders.Location = new System.Drawing.Point(747, 212);
            this.btnShowSalesOrders.Name = "btnShowSalesOrders";
            this.btnShowSalesOrders.Size = new System.Drawing.Size(75, 23);
            this.btnShowSalesOrders.TabIndex = 12;
            this.btnShowSalesOrders.Text = "عرض";
            this.btnShowSalesOrders.UseVisualStyleBackColor = true;
            this.btnShowSalesOrders.Click += new System.EventHandler(this.btnShowSalesOrders_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(881, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "المسئول :";
            // 
            // txtSalesMan
            // 
            this.txtSalesMan.Location = new System.Drawing.Point(723, 52);
            this.txtSalesMan.Name = "txtSalesMan";
            this.txtSalesMan.ReadOnly = true;
            this.txtSalesMan.Size = new System.Drawing.Size(152, 20);
            this.txtSalesMan.TabIndex = 21;
            this.txtSalesMan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnBackOrdersPrint
            // 
            this.btnBackOrdersPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackOrdersPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnBackOrdersPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackOrdersPrint.Location = new System.Drawing.Point(61, 212);
            this.btnBackOrdersPrint.Name = "btnBackOrdersPrint";
            this.btnBackOrdersPrint.Size = new System.Drawing.Size(75, 23);
            this.btnBackOrdersPrint.TabIndex = 23;
            this.btnBackOrdersPrint.Text = "طباعة";
            this.btnBackOrdersPrint.UseVisualStyleBackColor = true;
            this.btnBackOrdersPrint.Click += new System.EventHandler(this.btnBackOrdersPrint_Click);
            // 
            // MonthReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 543);
            this.Controls.Add(this.btnBackOrdersPrint);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtSalesMan);
            this.Controls.Add(this.btnShowBackOrders);
            this.Controls.Add(this.btnPrintBuysOrders);
            this.Controls.Add(this.btnShowBuysOrders);
            this.Controls.Add(this.btnPrintSalesOrders);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnShowSalesOrders);
            this.Controls.Add(this.dtMonth);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MonthReports";
            this.Resizable = false;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "   تقرير شهر - جرد شهري";
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonthOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowOrderDetailes)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DateTimePicker dtMonth;
        public System.Windows.Forms.Button btnShowBackOrders;
        public System.Windows.Forms.Button btnPrintBuysOrders;
        public System.Windows.Forms.Button btnShowBuysOrders;
        public System.Windows.Forms.Button btnPrintSalesOrders;
        private System.Windows.Forms.GroupBox groupBox5;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox txtOrderNotes;
        public System.Windows.Forms.DataGridView dgvMonthOrders;
        public System.Windows.Forms.DataGridView dgvShowOrderDetailes;
        public System.Windows.Forms.Label label25;
        public System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.Label label22;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label label23;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox txtBackOrdersTotalCost;
        public System.Windows.Forms.TextBox txtBackOrdersCount;
        public System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.Label label18;
        public System.Windows.Forms.TextBox txtBuysOrdersTotalChange;
        public System.Windows.Forms.Label label19;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label20;
        public System.Windows.Forms.TextBox txtBuysOrdersTotaPaids;
        public System.Windows.Forms.Label label21;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtBuysOrdersTotalCost;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtBuysOrdersCount;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Label label17;
        public System.Windows.Forms.Label label16;
        public System.Windows.Forms.Label label15;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.TextBox txtSalesOrdersCount;
        public System.Windows.Forms.TextBox txtSalesOrdersTotalChange;
        public System.Windows.Forms.TextBox txtSalesOrdersTotalPaids;
        public System.Windows.Forms.TextBox txtSalesOrdersTotalCost;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnShowSalesOrders;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtSalesMan;
        public System.Windows.Forms.Button btnBackOrdersPrint;
        public System.Windows.Forms.Label txtsalesman2;
        public System.Windows.Forms.Label salesman;
        public System.Windows.Forms.Label txtPerson;
        public System.Windows.Forms.Label person;
    }
}