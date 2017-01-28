namespace SalesManagement.View
{
    partial class DayReportsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnShowSalesOrders = new System.Windows.Forms.Button();
            this.dtdayreports = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPrintBackOrders = new System.Windows.Forms.Button();
            this.btnShowBackOrders = new System.Windows.Forms.Button();
            this.btnPrintBuysOrders = new System.Windows.Forms.Button();
            this.btnShowBuysOrders = new System.Windows.Forms.Button();
            this.btnPrintSalesOrders = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvDayOrders = new System.Windows.Forms.DataGridView();
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDayOrders)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShowSalesOrders
            // 
            this.btnShowSalesOrders.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnShowSalesOrders.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnShowSalesOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowSalesOrders.Location = new System.Drawing.Point(712, 168);
            this.btnShowSalesOrders.Name = "btnShowSalesOrders";
            this.btnShowSalesOrders.Size = new System.Drawing.Size(75, 23);
            this.btnShowSalesOrders.TabIndex = 0;
            this.btnShowSalesOrders.Text = "عرض";
            this.btnShowSalesOrders.UseVisualStyleBackColor = true;
            this.btnShowSalesOrders.Click += new System.EventHandler(this.btnShowSalesOrders_Click);
            // 
            // dtdayreports
            // 
            this.dtdayreports.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtdayreports.Location = new System.Drawing.Point(376, 30);
            this.dtdayreports.Name = "dtdayreports";
            this.dtdayreports.RightToLeftLayout = true;
            this.dtdayreports.Size = new System.Drawing.Size(125, 20);
            this.dtdayreports.TabIndex = 1;
            this.dtdayreports.ValueChanged += new System.EventHandler(this.dtdayreports_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPrintBackOrders);
            this.groupBox1.Controls.Add(this.btnShowBackOrders);
            this.groupBox1.Controls.Add(this.btnPrintBuysOrders);
            this.groupBox1.Controls.Add(this.btnShowBuysOrders);
            this.groupBox1.Controls.Add(this.btnPrintSalesOrders);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnShowSalesOrders);
            this.groupBox1.Location = new System.Drawing.Point(5, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(935, 460);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btnPrintBackOrders
            // 
            this.btnPrintBackOrders.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPrintBackOrders.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPrintBackOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintBackOrders.Location = new System.Drawing.Point(21, 168);
            this.btnPrintBackOrders.Name = "btnPrintBackOrders";
            this.btnPrintBackOrders.Size = new System.Drawing.Size(75, 23);
            this.btnPrintBackOrders.TabIndex = 12;
            this.btnPrintBackOrders.Text = "طباعة";
            this.btnPrintBackOrders.UseVisualStyleBackColor = true;
            this.btnPrintBackOrders.Click += new System.EventHandler(this.btnPrintBackOrders_Click);
            // 
            // btnShowBackOrders
            // 
            this.btnShowBackOrders.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnShowBackOrders.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnShowBackOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowBackOrders.Location = new System.Drawing.Point(102, 168);
            this.btnShowBackOrders.Name = "btnShowBackOrders";
            this.btnShowBackOrders.Size = new System.Drawing.Size(75, 23);
            this.btnShowBackOrders.TabIndex = 11;
            this.btnShowBackOrders.Text = "عرض";
            this.btnShowBackOrders.UseVisualStyleBackColor = true;
            this.btnShowBackOrders.Click += new System.EventHandler(this.btnShowBackOrders_Click);
            // 
            // btnPrintBuysOrders
            // 
            this.btnPrintBuysOrders.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPrintBuysOrders.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPrintBuysOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintBuysOrders.Location = new System.Drawing.Point(324, 168);
            this.btnPrintBuysOrders.Name = "btnPrintBuysOrders";
            this.btnPrintBuysOrders.Size = new System.Drawing.Size(75, 23);
            this.btnPrintBuysOrders.TabIndex = 10;
            this.btnPrintBuysOrders.Text = "طباعة";
            this.btnPrintBuysOrders.UseVisualStyleBackColor = true;
            this.btnPrintBuysOrders.Click += new System.EventHandler(this.btnPrintBuysOrders_Click);
            // 
            // btnShowBuysOrders
            // 
            this.btnShowBuysOrders.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnShowBuysOrders.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnShowBuysOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowBuysOrders.Location = new System.Drawing.Point(404, 168);
            this.btnShowBuysOrders.Name = "btnShowBuysOrders";
            this.btnShowBuysOrders.Size = new System.Drawing.Size(75, 23);
            this.btnShowBuysOrders.TabIndex = 9;
            this.btnShowBuysOrders.Text = "عرض";
            this.btnShowBuysOrders.UseVisualStyleBackColor = true;
            this.btnShowBuysOrders.Click += new System.EventHandler(this.btnShowBuysOrders_Click);
            // 
            // btnPrintSalesOrders
            // 
            this.btnPrintSalesOrders.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPrintSalesOrders.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPrintSalesOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintSalesOrders.Location = new System.Drawing.Point(631, 168);
            this.btnPrintSalesOrders.Name = "btnPrintSalesOrders";
            this.btnPrintSalesOrders.Size = new System.Drawing.Size(75, 23);
            this.btnPrintSalesOrders.TabIndex = 8;
            this.btnPrintSalesOrders.Text = "طباعة";
            this.btnPrintSalesOrders.UseVisualStyleBackColor = true;
            this.btnPrintSalesOrders.Click += new System.EventHandler(this.btnPrintSalesOrders_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvDayOrders);
            this.groupBox5.Location = new System.Drawing.Point(6, 196);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(921, 258);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "البيانات ";
            // 
            // dgvDayOrders
            // 
            this.dgvDayOrders.AllowUserToAddRows = false;
            this.dgvDayOrders.AllowUserToDeleteRows = false;
            this.dgvDayOrders.AllowUserToResizeRows = false;
            this.dgvDayOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDayOrders.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDayOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDayOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDayOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvDayOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDayOrders.Location = new System.Drawing.Point(3, 16);
            this.dgvDayOrders.MultiSelect = false;
            this.dgvDayOrders.Name = "dgvDayOrders";
            this.dgvDayOrders.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDayOrders.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDayOrders.RowHeadersWidth = 50;
            this.dgvDayOrders.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDayOrders.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvDayOrders.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvDayOrders.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.dgvDayOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDayOrders.Size = new System.Drawing.Size(915, 239);
            this.dgvDayOrders.TabIndex = 1;
            this.dgvDayOrders.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvDayOrders_DataBindingComplete);
            this.dgvDayOrders.DoubleClick += new System.EventHandler(this.dgvDayOrders_DoubleClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.txtBackOrdersTotalCost);
            this.groupBox4.Controls.Add(this.txtBackOrdersCount);
            this.groupBox4.Location = new System.Drawing.Point(6, 37);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(312, 121);
            this.groupBox4.TabIndex = 6;
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
            this.groupBox3.Location = new System.Drawing.Point(324, 38);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(301, 120);
            this.groupBox3.TabIndex = 6;
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
            this.groupBox2.Location = new System.Drawing.Point(631, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 122);
            this.groupBox2.TabIndex = 5;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(507, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "تاريخ اليوم :";
            // 
            // DayReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 519);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtdayreports);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DayReportsForm";
            this.Resizable = false;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "جرد اليومية";
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDayOrders)).EndInit();
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

        public System.Windows.Forms.DateTimePicker dtdayreports;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox5;
        public System.Windows.Forms.Button btnShowSalesOrders;
        public System.Windows.Forms.Button btnShowBuysOrders;
        public System.Windows.Forms.Button btnShowBackOrders;
        public System.Windows.Forms.Button btnPrintSalesOrders;
        public System.Windows.Forms.Button btnPrintBuysOrders;
        public System.Windows.Forms.Button btnPrintBackOrders;
        public System.Windows.Forms.TextBox txtBackOrdersTotalCost;
        public System.Windows.Forms.TextBox txtBackOrdersCount;
        public System.Windows.Forms.TextBox txtBuysOrdersTotalChange;
        public System.Windows.Forms.TextBox txtBuysOrdersTotaPaids;
        public System.Windows.Forms.TextBox txtBuysOrdersTotalCost;
        public System.Windows.Forms.TextBox txtBuysOrdersCount;
        public System.Windows.Forms.TextBox txtSalesOrdersTotalChange;
        public System.Windows.Forms.TextBox txtSalesOrdersTotalPaids;
        public System.Windows.Forms.TextBox txtSalesOrdersTotalCost;
        public System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox txtSalesOrdersCount;
        public System.Windows.Forms.DataGridView dgvDayOrders;
        public System.Windows.Forms.Label label22;
        public System.Windows.Forms.Label label23;
        public System.Windows.Forms.Label label18;
        public System.Windows.Forms.Label label19;
        public System.Windows.Forms.Label label20;
        public System.Windows.Forms.Label label21;
        public System.Windows.Forms.Label label17;
        public System.Windows.Forms.Label label16;
        public System.Windows.Forms.Label label15;
        public System.Windows.Forms.Label label14;
    }
}