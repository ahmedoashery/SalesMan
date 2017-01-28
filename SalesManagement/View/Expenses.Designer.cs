namespace SalesManagement.View
{
    partial class Expenses
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvExpenses = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBy = new System.Windows.Forms.TextBox();
            this.btnSaveExpense = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtExpenseAmmount = new System.Windows.Forms.TextBox();
            this.txtMoneyInSafe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtExpenseDesc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtExpense = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(20, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(637, 429);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvExpenses);
            this.groupBox3.Location = new System.Drawing.Point(19, 163);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(599, 260);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "بيانات المصروفات :";
            // 
            // dgvExpenses
            // 
            this.dgvExpenses.AllowUserToAddRows = false;
            this.dgvExpenses.AllowUserToDeleteRows = false;
            this.dgvExpenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExpenses.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpenses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExpenses.Location = new System.Drawing.Point(3, 16);
            this.dgvExpenses.Name = "dgvExpenses";
            this.dgvExpenses.ReadOnly = true;
            this.dgvExpenses.Size = new System.Drawing.Size(593, 241);
            this.dgvExpenses.TabIndex = 0;
            this.dgvExpenses.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBy);
            this.groupBox2.Controls.Add(this.btnSaveExpense);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtExpenseAmmount);
            this.groupBox2.Controls.Add(this.txtMoneyInSafe);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtExpenseDesc);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dtExpense);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(19, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(599, 144);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " مصروف جديد :";
            // 
            // txtBy
            // 
            this.txtBy.Enabled = false;
            this.txtBy.Location = new System.Drawing.Point(16, 77);
            this.txtBy.Name = "txtBy";
            this.txtBy.Size = new System.Drawing.Size(151, 20);
            this.txtBy.TabIndex = 6;
            this.txtBy.TabStop = false;
            this.txtBy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSaveExpense
            // 
            this.btnSaveExpense.Location = new System.Drawing.Point(16, 113);
            this.btnSaveExpense.Name = "btnSaveExpense";
            this.btnSaveExpense.Size = new System.Drawing.Size(86, 27);
            this.btnSaveExpense.TabIndex = 1;
            this.btnSaveExpense.Text = "حفظ";
            this.btnSaveExpense.UseVisualStyleBackColor = true;
            this.btnSaveExpense.Click += new System.EventHandler(this.btnSaveExpense_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(210, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "بواسطة :";
            // 
            // txtExpenseAmmount
            // 
            this.txtExpenseAmmount.Location = new System.Drawing.Point(279, 51);
            this.txtExpenseAmmount.MaxLength = 100;
            this.txtExpenseAmmount.Name = "txtExpenseAmmount";
            this.txtExpenseAmmount.Size = new System.Drawing.Size(243, 20);
            this.txtExpenseAmmount.TabIndex = 0;
            this.txtExpenseAmmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtExpenseAmmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExpenseAmmount_KeyPress);
            // 
            // txtMoneyInSafe
            // 
            this.txtMoneyInSafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoneyInSafe.Location = new System.Drawing.Point(16, 24);
            this.txtMoneyInSafe.Multiline = true;
            this.txtMoneyInSafe.Name = "txtMoneyInSafe";
            this.txtMoneyInSafe.Size = new System.Drawing.Size(151, 43);
            this.txtMoneyInSafe.TabIndex = 1;
            this.txtMoneyInSafe.TabStop = false;
            this.txtMoneyInSafe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMoneyInSafe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMoneyInSafe_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "الخزينة / النقدية :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(534, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "القيمة :";
            // 
            // txtExpenseDesc
            // 
            this.txtExpenseDesc.Location = new System.Drawing.Point(279, 77);
            this.txtExpenseDesc.MaxLength = 255;
            this.txtExpenseDesc.Multiline = true;
            this.txtExpenseDesc.Name = "txtExpenseDesc";
            this.txtExpenseDesc.Size = new System.Drawing.Size(243, 46);
            this.txtExpenseDesc.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(529, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "الوصف :";
            // 
            // dtExpense
            // 
            this.dtExpense.Location = new System.Drawing.Point(279, 24);
            this.dtExpense.Name = "dtExpense";
            this.dtExpense.RightToLeftLayout = true;
            this.dtExpense.Size = new System.Drawing.Size(243, 20);
            this.dtExpense.TabIndex = 8;
            this.dtExpense.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(528, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "التاريخ :";
            // 
            // Expenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 509);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Expenses";
            this.Resizable = false;
            this.Text = "المصروفات";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox txtMoneyInSafe;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtExpenseAmmount;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtExpenseDesc;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DateTimePicker dtExpense;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnSaveExpense;
        public System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.DataGridView dgvExpenses;
        public System.Windows.Forms.TextBox txtBy;
        private System.Windows.Forms.Label label5;
    }
}