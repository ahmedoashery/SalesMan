namespace SalesManagement.View
{
    partial class Providers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvChooseProvidersList = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSearchProvider = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChooseProvidersList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvChooseProvidersList
            // 
            this.dgvChooseProvidersList.AllowUserToAddRows = false;
            this.dgvChooseProvidersList.AllowUserToDeleteRows = false;
            this.dgvChooseProvidersList.AllowUserToResizeColumns = false;
            this.dgvChooseProvidersList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvChooseProvidersList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvChooseProvidersList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChooseProvidersList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChooseProvidersList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvChooseProvidersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChooseProvidersList.Location = new System.Drawing.Point(10, 110);
            this.dgvChooseProvidersList.MultiSelect = false;
            this.dgvChooseProvidersList.Name = "dgvChooseProvidersList";
            this.dgvChooseProvidersList.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChooseProvidersList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvChooseProvidersList.RowHeadersWidth = 80;
            this.dgvChooseProvidersList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvChooseProvidersList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvChooseProvidersList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChooseProvidersList.Size = new System.Drawing.Size(395, 426);
            this.dgvChooseProvidersList.TabIndex = 1;
            this.dgvChooseProvidersList.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvChooseProvidersList_DataBindingComplete);
            this.dgvChooseProvidersList.DoubleClick += new System.EventHandler(this.dgvChooseProvidersList_DoubleClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(319, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "بحث :";
            // 
            // txtSearchProvider
            // 
            this.txtSearchProvider.Location = new System.Drawing.Point(72, 84);
            this.txtSearchProvider.Name = "txtSearchProvider";
            this.txtSearchProvider.Size = new System.Drawing.Size(241, 20);
            this.txtSearchProvider.TabIndex = 16;
            this.txtSearchProvider.TextChanged += new System.EventHandler(this.txtSearchProvider_TextChanged);
            // 
            // Providers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 559);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSearchProvider);
            this.Controls.Add(this.dgvChooseProvidersList);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Providers";
            this.Resizable = false;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.Text = "   قائمة الموردين";
            ((System.ComponentModel.ISupportInitialize)(this.dgvChooseProvidersList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvChooseProvidersList;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtSearchProvider;
    }
}