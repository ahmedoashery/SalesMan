namespace SalesManagement.View
{
    partial class OrderDetailes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CustomerName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OrderSalesMan = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOrderNotes = new System.Windows.Forms.TextBox();
            this.OrderCode = new System.Windows.Forms.Label();
            this.dgvShowOrders = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.CustomerName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.OrderSalesMan);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtOrderNotes);
            this.groupBox1.Controls.Add(this.OrderCode);
            this.groupBox1.Controls.Add(this.dgvShowOrders);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(20, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(615, 360);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(511, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "كود الفاتورة :";
            // 
            // CustomerName
            // 
            this.CustomerName.Location = new System.Drawing.Point(220, 16);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(108, 20);
            this.CustomerName.TabIndex = 9;
            this.CustomerName.Text = "اسم العميل هنا";
            this.CustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(334, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "العميل :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "المسئول :";
            // 
            // OrderSalesMan
            // 
            this.OrderSalesMan.Location = new System.Drawing.Point(12, 17);
            this.OrderSalesMan.Name = "OrderSalesMan";
            this.OrderSalesMan.Size = new System.Drawing.Size(116, 19);
            this.OrderSalesMan.TabIndex = 6;
            this.OrderSalesMan.Text = "اسم المسئول هنا";
            this.OrderSalesMan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(511, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "ملاحظـــات :";
            // 
            // txtOrderNotes
            // 
            this.txtOrderNotes.Location = new System.Drawing.Point(12, 309);
            this.txtOrderNotes.Name = "txtOrderNotes";
            this.txtOrderNotes.Size = new System.Drawing.Size(493, 20);
            this.txtOrderNotes.TabIndex = 4;
            // 
            // OrderCode
            // 
            this.OrderCode.Location = new System.Drawing.Point(402, 17);
            this.OrderCode.Name = "OrderCode";
            this.OrderCode.Size = new System.Drawing.Size(106, 18);
            this.OrderCode.TabIndex = 2;
            this.OrderCode.Text = "كود الفاتورة هنا";
            this.OrderCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvShowOrders
            // 
            this.dgvShowOrders.AllowUserToAddRows = false;
            this.dgvShowOrders.AllowUserToDeleteRows = false;
            this.dgvShowOrders.AllowUserToOrderColumns = true;
            this.dgvShowOrders.AllowUserToResizeRows = false;
            this.dgvShowOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShowOrders.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvShowOrders.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvShowOrders.Location = new System.Drawing.Point(12, 38);
            this.dgvShowOrders.MultiSelect = false;
            this.dgvShowOrders.Name = "dgvShowOrders";
            this.dgvShowOrders.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShowOrders.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvShowOrders.RowHeadersVisible = false;
            this.dgvShowOrders.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvShowOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShowOrders.Size = new System.Drawing.Size(560, 255);
            this.dgvShowOrders.TabIndex = 1;
            // 
            // OrderDetailes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 440);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderDetailes";
            this.Resizable = false;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "   تفاصيل فاتورة        ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView dgvShowOrders;
        public System.Windows.Forms.Label OrderCode;
        public System.Windows.Forms.Label OrderSalesMan;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtOrderNotes;
        public System.Windows.Forms.Label CustomerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
    }
}