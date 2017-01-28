namespace SalesManagement.View
{
    partial class ProductsChooseList
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
            this.dgvChooseProductsList = new System.Windows.Forms.DataGridView();
            this.txtSearchProduct = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChooseProductsList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvChooseProductsList);
            this.groupBox1.Location = new System.Drawing.Point(5, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(711, 378);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dgvChooseProductsList
            // 
            this.dgvChooseProductsList.AllowUserToAddRows = false;
            this.dgvChooseProductsList.AllowUserToDeleteRows = false;
            this.dgvChooseProductsList.AllowUserToResizeRows = false;
            this.dgvChooseProductsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChooseProductsList.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvChooseProductsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChooseProductsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChooseProductsList.Location = new System.Drawing.Point(3, 16);
            this.dgvChooseProductsList.MultiSelect = false;
            this.dgvChooseProductsList.Name = "dgvChooseProductsList";
            this.dgvChooseProductsList.ReadOnly = true;
            this.dgvChooseProductsList.RowHeadersWidth = 80;
            this.dgvChooseProductsList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvChooseProductsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChooseProductsList.Size = new System.Drawing.Size(705, 359);
            this.dgvChooseProductsList.TabIndex = 0;
            this.dgvChooseProductsList.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvChooseProductsList_DataBindingComplete);
            this.dgvChooseProductsList.DoubleClick += new System.EventHandler(this.dgvChooseProductsList_DoubleClick);
            // 
            // txtSearchProduct
            // 
            this.txtSearchProduct.Location = new System.Drawing.Point(291, 53);
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.Size = new System.Drawing.Size(262, 20);
            this.txtSearchProduct.TabIndex = 15;
            this.txtSearchProduct.TextChanged += new System.EventHandler(this.txtSearchProduct_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(559, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "بحث :";
            // 
            // ProductsChooseList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 480);
            this.Controls.Add(this.txtSearchProduct);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductsChooseList";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.Text = "ادخال أصناف";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChooseProductsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView dgvChooseProductsList;
        public System.Windows.Forms.TextBox txtSearchProduct;
        private System.Windows.Forms.Label label7;
    }
}