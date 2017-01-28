namespace SalesManagement.View
{
    partial class Papers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Papers));
            this.tabControlPapers = new System.Windows.Forms.TabControl();
            this.tpRecievedPapers = new System.Windows.Forms.TabPage();
            this.SaveRecievedPaper = new System.Windows.Forms.Button();
            this.btnNewRecievedPaper = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Paper1Notes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SalesMan = new System.Windows.Forms.TextBox();
            this.btnChooseCustomer = new System.Windows.Forms.Button();
            this.PaperValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.recievedPaperDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.paper1Type = new System.Windows.Forms.Label();
            this.tpPaidPapers = new System.Windows.Forms.TabPage();
            this.SavPaidPaper = new System.Windows.Forms.Button();
            this.newPaidPaper = new System.Windows.Forms.Button();
            this.undoPaper = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.paper2Notes = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SalesMan2 = new System.Windows.Forms.TextBox();
            this.chooseProvider = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.paidValue = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.PaidPaperDate = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.txtProviderName = new System.Windows.Forms.TextBox();
            this.paper2Type = new System.Windows.Forms.Label();
            this.tabControlPapers.SuspendLayout();
            this.tpRecievedPapers.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tpPaidPapers.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlPapers
            // 
            this.tabControlPapers.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControlPapers.Controls.Add(this.tpRecievedPapers);
            this.tabControlPapers.Controls.Add(this.tpPaidPapers);
            this.tabControlPapers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControlPapers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPapers.Font = new System.Drawing.Font("Tahoma", 9F);
            this.tabControlPapers.Location = new System.Drawing.Point(20, 60);
            this.tabControlPapers.Multiline = true;
            this.tabControlPapers.Name = "tabControlPapers";
            this.tabControlPapers.RightToLeftLayout = true;
            this.tabControlPapers.SelectedIndex = 0;
            this.tabControlPapers.Size = new System.Drawing.Size(661, 312);
            this.tabControlPapers.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlPapers.TabIndex = 0;
            // 
            // tpRecievedPapers
            // 
            this.tpRecievedPapers.BackColor = System.Drawing.Color.White;
            this.tpRecievedPapers.Controls.Add(this.SaveRecievedPaper);
            this.tpRecievedPapers.Controls.Add(this.btnNewRecievedPaper);
            this.tpRecievedPapers.Controls.Add(this.btnUndo);
            this.tpRecievedPapers.Controls.Add(this.groupBox1);
            this.tpRecievedPapers.Location = new System.Drawing.Point(4, 26);
            this.tpRecievedPapers.Name = "tpRecievedPapers";
            this.tpRecievedPapers.Padding = new System.Windows.Forms.Padding(3);
            this.tpRecievedPapers.Size = new System.Drawing.Size(653, 282);
            this.tpRecievedPapers.TabIndex = 0;
            this.tpRecievedPapers.Text = "سنــــد قبض";
            this.tpRecievedPapers.Leave += new System.EventHandler(this.tpRecievedPapers_Leave);
            // 
            // SaveRecievedPaper
            // 
            this.SaveRecievedPaper.BackColor = System.Drawing.Color.SteelBlue;
            this.SaveRecievedPaper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveRecievedPaper.Enabled = false;
            this.SaveRecievedPaper.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SaveRecievedPaper.FlatAppearance.BorderSize = 0;
            this.SaveRecievedPaper.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(162)))), ((int)(((byte)(107)))));
            this.SaveRecievedPaper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveRecievedPaper.ForeColor = System.Drawing.Color.White;
            this.SaveRecievedPaper.Image = global::SalesManagement.Properties.Resources.save;
            this.SaveRecievedPaper.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SaveRecievedPaper.Location = new System.Drawing.Point(484, 235);
            this.SaveRecievedPaper.Name = "SaveRecievedPaper";
            this.SaveRecievedPaper.Size = new System.Drawing.Size(75, 27);
            this.SaveRecievedPaper.TabIndex = 2;
            this.SaveRecievedPaper.Text = "حفظ";
            this.SaveRecievedPaper.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveRecievedPaper.UseVisualStyleBackColor = false;
            this.SaveRecievedPaper.Click += new System.EventHandler(this.SaveRecievedPaper_Click);
            // 
            // btnNewRecievedPaper
            // 
            this.btnNewRecievedPaper.BackColor = System.Drawing.Color.SteelBlue;
            this.btnNewRecievedPaper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewRecievedPaper.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNewRecievedPaper.FlatAppearance.BorderSize = 0;
            this.btnNewRecievedPaper.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(162)))), ((int)(((byte)(107)))));
            this.btnNewRecievedPaper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewRecievedPaper.ForeColor = System.Drawing.Color.White;
            this.btnNewRecievedPaper.Image = global::SalesManagement.Properties.Resources.plus;
            this.btnNewRecievedPaper.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewRecievedPaper.Location = new System.Drawing.Point(565, 235);
            this.btnNewRecievedPaper.Name = "btnNewRecievedPaper";
            this.btnNewRecievedPaper.Size = new System.Drawing.Size(75, 27);
            this.btnNewRecievedPaper.TabIndex = 1;
            this.btnNewRecievedPaper.Text = "جديد";
            this.btnNewRecievedPaper.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewRecievedPaper.UseVisualStyleBackColor = false;
            this.btnNewRecievedPaper.Click += new System.EventHandler(this.btnNewRecievedPaper_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUndo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUndo.Enabled = false;
            this.btnUndo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUndo.FlatAppearance.BorderSize = 0;
            this.btnUndo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(162)))), ((int)(((byte)(107)))));
            this.btnUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUndo.ForeColor = System.Drawing.Color.White;
            this.btnUndo.Image = ((System.Drawing.Image)(resources.GetObject("btnUndo.Image")));
            this.btnUndo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUndo.Location = new System.Drawing.Point(403, 235);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(75, 27);
            this.btnUndo.TabIndex = 3;
            this.btnUndo.Text = "الغاء";
            this.btnUndo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUndo.UseVisualStyleBackColor = false;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.Paper1Notes);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.SalesMan);
            this.groupBox1.Controls.Add(this.btnChooseCustomer);
            this.groupBox1.Controls.Add(this.PaperValue);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.recievedPaperDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCustomerName);
            this.groupBox1.Controls.Add(this.paper1Type);
            this.groupBox1.Location = new System.Drawing.Point(6, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(641, 229);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(278, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 14);
            this.label8.TabIndex = 33;
            this.label8.Text = "المبلغ :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(264, 170);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 14);
            this.label15.TabIndex = 14;
            this.label15.Text = "ملاحظات :";
            // 
            // Paper1Notes
            // 
            this.Paper1Notes.Location = new System.Drawing.Point(6, 167);
            this.Paper1Notes.Name = "Paper1Notes";
            this.Paper1Notes.Size = new System.Drawing.Size(246, 22);
            this.Paper1Notes.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(264, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 14);
            this.label5.TabIndex = 10;
            this.label5.Text = "المستلم :";
            // 
            // SalesMan
            // 
            this.SalesMan.Location = new System.Drawing.Point(6, 140);
            this.SalesMan.Name = "SalesMan";
            this.SalesMan.ReadOnly = true;
            this.SalesMan.Size = new System.Drawing.Size(246, 22);
            this.SalesMan.TabIndex = 4;
            this.SalesMan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnChooseCustomer
            // 
            this.btnChooseCustomer.BackColor = System.Drawing.Color.Transparent;
            this.btnChooseCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChooseCustomer.FlatAppearance.BorderSize = 0;
            this.btnChooseCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(162)))), ((int)(((byte)(87)))));
            this.btnChooseCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseCustomer.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnChooseCustomer.Location = new System.Drawing.Point(457, 168);
            this.btnChooseCustomer.Name = "btnChooseCustomer";
            this.btnChooseCustomer.Size = new System.Drawing.Size(98, 23);
            this.btnChooseCustomer.TabIndex = 2;
            this.btnChooseCustomer.Text = "اختر من العملاء";
            this.btnChooseCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChooseCustomer.UseVisualStyleBackColor = false;
            this.btnChooseCustomer.Click += new System.EventHandler(this.btnChooseCustomer_Click);
            // 
            // PaperValue
            // 
            this.PaperValue.Location = new System.Drawing.Point(86, 113);
            this.PaperValue.Name = "PaperValue";
            this.PaperValue.Size = new System.Drawing.Size(166, 22);
            this.PaperValue.TabIndex = 3;
            this.PaperValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PaperValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PaperValue_KeyPress);
            this.PaperValue.Leave += new System.EventHandler(this.PaperValue_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(565, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "تحريراً فى :";
            // 
            // recievedPaperDate
            // 
            this.recievedPaperDate.Location = new System.Drawing.Point(399, 110);
            this.recievedPaperDate.Name = "recievedPaperDate";
            this.recievedPaperDate.RightToLeftLayout = true;
            this.recievedPaperDate.Size = new System.Drawing.Size(155, 22);
            this.recievedPaperDate.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(563, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "من العميل :";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCustomerName.Location = new System.Drawing.Point(342, 140);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(212, 22);
            this.txtCustomerName.TabIndex = 1;
            this.txtCustomerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // paper1Type
            // 
            this.paper1Type.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paper1Type.Location = new System.Drawing.Point(289, 32);
            this.paper1Type.Name = "paper1Type";
            this.paper1Type.Size = new System.Drawing.Size(102, 21);
            this.paper1Type.TabIndex = 1;
            this.paper1Type.Text = "سنـــد قبض";
            this.paper1Type.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tpPaidPapers
            // 
            this.tpPaidPapers.BackColor = System.Drawing.SystemColors.Window;
            this.tpPaidPapers.Controls.Add(this.SavPaidPaper);
            this.tpPaidPapers.Controls.Add(this.newPaidPaper);
            this.tpPaidPapers.Controls.Add(this.undoPaper);
            this.tpPaidPapers.Controls.Add(this.groupBox2);
            this.tpPaidPapers.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpPaidPapers.Location = new System.Drawing.Point(4, 26);
            this.tpPaidPapers.Name = "tpPaidPapers";
            this.tpPaidPapers.Padding = new System.Windows.Forms.Padding(3);
            this.tpPaidPapers.Size = new System.Drawing.Size(653, 282);
            this.tpPaidPapers.TabIndex = 1;
            this.tpPaidPapers.Text = "سنـــد دفــع";
            this.tpPaidPapers.Leave += new System.EventHandler(this.tpPaidPapers_Leave);
            // 
            // SavPaidPaper
            // 
            this.SavPaidPaper.BackColor = System.Drawing.Color.SteelBlue;
            this.SavPaidPaper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SavPaidPaper.Enabled = false;
            this.SavPaidPaper.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SavPaidPaper.FlatAppearance.BorderSize = 0;
            this.SavPaidPaper.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(162)))), ((int)(((byte)(107)))));
            this.SavPaidPaper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SavPaidPaper.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavPaidPaper.ForeColor = System.Drawing.Color.White;
            this.SavPaidPaper.Image = global::SalesManagement.Properties.Resources.save;
            this.SavPaidPaper.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SavPaidPaper.Location = new System.Drawing.Point(484, 235);
            this.SavPaidPaper.Name = "SavPaidPaper";
            this.SavPaidPaper.Size = new System.Drawing.Size(75, 27);
            this.SavPaidPaper.TabIndex = 16;
            this.SavPaidPaper.Text = "حفظ";
            this.SavPaidPaper.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SavPaidPaper.UseVisualStyleBackColor = false;
            this.SavPaidPaper.Click += new System.EventHandler(this.SavPaidPaper_Click);
            // 
            // newPaidPaper
            // 
            this.newPaidPaper.BackColor = System.Drawing.Color.SteelBlue;
            this.newPaidPaper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newPaidPaper.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.newPaidPaper.FlatAppearance.BorderSize = 0;
            this.newPaidPaper.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(162)))), ((int)(((byte)(107)))));
            this.newPaidPaper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newPaidPaper.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPaidPaper.ForeColor = System.Drawing.Color.White;
            this.newPaidPaper.Image = global::SalesManagement.Properties.Resources.plus;
            this.newPaidPaper.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.newPaidPaper.Location = new System.Drawing.Point(565, 235);
            this.newPaidPaper.Name = "newPaidPaper";
            this.newPaidPaper.Size = new System.Drawing.Size(75, 27);
            this.newPaidPaper.TabIndex = 15;
            this.newPaidPaper.Text = "جديد";
            this.newPaidPaper.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newPaidPaper.UseVisualStyleBackColor = false;
            this.newPaidPaper.Click += new System.EventHandler(this.newPaidPaper_Click);
            // 
            // undoPaper
            // 
            this.undoPaper.BackColor = System.Drawing.Color.SteelBlue;
            this.undoPaper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.undoPaper.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.undoPaper.FlatAppearance.BorderSize = 0;
            this.undoPaper.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(162)))), ((int)(((byte)(107)))));
            this.undoPaper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.undoPaper.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.undoPaper.ForeColor = System.Drawing.Color.White;
            this.undoPaper.Image = ((System.Drawing.Image)(resources.GetObject("undoPaper.Image")));
            this.undoPaper.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.undoPaper.Location = new System.Drawing.Point(403, 235);
            this.undoPaper.Name = "undoPaper";
            this.undoPaper.Size = new System.Drawing.Size(75, 27);
            this.undoPaper.TabIndex = 17;
            this.undoPaper.Text = "الغاء";
            this.undoPaper.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.undoPaper.UseVisualStyleBackColor = false;
            this.undoPaper.Click += new System.EventHandler(this.undoPaper_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.paper2Notes);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.SalesMan2);
            this.groupBox2.Controls.Add(this.chooseProvider);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.paidValue);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.PaidPaperDate);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtProviderName);
            this.groupBox2.Controls.Add(this.paper2Type);
            this.groupBox2.Location = new System.Drawing.Point(6, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(641, 229);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(264, 170);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 14);
            this.label16.TabIndex = 16;
            this.label16.Text = "ملاحظات :";
            // 
            // paper2Notes
            // 
            this.paper2Notes.Location = new System.Drawing.Point(6, 167);
            this.paper2Notes.Name = "paper2Notes";
            this.paper2Notes.Size = new System.Drawing.Size(246, 22);
            this.paper2Notes.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(264, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 14);
            this.label10.TabIndex = 10;
            this.label10.Text = "المستلم :";
            // 
            // SalesMan2
            // 
            this.SalesMan2.Location = new System.Drawing.Point(6, 140);
            this.SalesMan2.Name = "SalesMan2";
            this.SalesMan2.ReadOnly = true;
            this.SalesMan2.Size = new System.Drawing.Size(246, 22);
            this.SalesMan2.TabIndex = 9;
            this.SalesMan2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chooseProvider
            // 
            this.chooseProvider.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.chooseProvider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chooseProvider.FlatAppearance.BorderSize = 0;
            this.chooseProvider.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.chooseProvider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chooseProvider.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chooseProvider.Location = new System.Drawing.Point(457, 168);
            this.chooseProvider.Name = "chooseProvider";
            this.chooseProvider.Size = new System.Drawing.Size(98, 23);
            this.chooseProvider.TabIndex = 8;
            this.chooseProvider.Text = "اختر من الموردين";
            this.chooseProvider.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chooseProvider.UseVisualStyleBackColor = false;
            this.chooseProvider.Click += new System.EventHandler(this.chooseProvider_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(278, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 14);
            this.label11.TabIndex = 7;
            this.label11.Text = "المبلغ :";
            // 
            // paidValue
            // 
            this.paidValue.Location = new System.Drawing.Point(88, 113);
            this.paidValue.Name = "paidValue";
            this.paidValue.Size = new System.Drawing.Size(164, 22);
            this.paidValue.TabIndex = 6;
            this.paidValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.paidValue_KeyPress);
            this.paidValue.Leave += new System.EventHandler(this.paidValue_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(565, 116);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 14);
            this.label12.TabIndex = 5;
            this.label12.Text = "تحريراً فى :";
            // 
            // PaidPaperDate
            // 
            this.PaidPaperDate.Location = new System.Drawing.Point(399, 110);
            this.PaidPaperDate.Name = "PaidPaperDate";
            this.PaidPaperDate.RightToLeftLayout = true;
            this.PaidPaperDate.Size = new System.Drawing.Size(155, 22);
            this.PaidPaperDate.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(563, 143);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 14);
            this.label13.TabIndex = 3;
            this.label13.Text = "الى المورد :";
            // 
            // txtProviderName
            // 
            this.txtProviderName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtProviderName.Location = new System.Drawing.Point(342, 140);
            this.txtProviderName.Name = "txtProviderName";
            this.txtProviderName.ReadOnly = true;
            this.txtProviderName.Size = new System.Drawing.Size(212, 22);
            this.txtProviderName.TabIndex = 2;
            // 
            // paper2Type
            // 
            this.paper2Type.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paper2Type.Location = new System.Drawing.Point(292, 31);
            this.paper2Type.Name = "paper2Type";
            this.paper2Type.Size = new System.Drawing.Size(94, 23);
            this.paper2Type.TabIndex = 1;
            this.paper2Type.Text = "سنـــد دفع";
            this.paper2Type.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Papers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 392);
            this.Controls.Add(this.tabControlPapers);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Papers";
            this.Resizable = false;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.Text = "تعاملات";
            this.tabControlPapers.ResumeLayout(false);
            this.tpRecievedPapers.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tpPaidPapers.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl tabControlPapers;
        public System.Windows.Forms.TabPage tpRecievedPapers;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox PaperValue;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DateTimePicker recievedPaperDate;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtCustomerName;
        public System.Windows.Forms.Label paper1Type;
        public System.Windows.Forms.Button btnChooseCustomer;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox SalesMan;
        public System.Windows.Forms.Button SaveRecievedPaper;
        public System.Windows.Forms.Button btnNewRecievedPaper;
        public System.Windows.Forms.Button btnUndo;
        public System.Windows.Forms.Label label15;
        public System.Windows.Forms.TextBox Paper1Notes;
        public System.Windows.Forms.TabPage tpPaidPapers;
        public System.Windows.Forms.Button SavPaidPaper;
        public System.Windows.Forms.Button newPaidPaper;
        public System.Windows.Forms.Button undoPaper;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Label label16;
        public System.Windows.Forms.TextBox paper2Notes;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox SalesMan2;
        public System.Windows.Forms.Button chooseProvider;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox paidValue;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.DateTimePicker PaidPaperDate;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox txtProviderName;
        public System.Windows.Forms.Label paper2Type;
        private System.Windows.Forms.Label label8;
    }
}