using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using MetroFramework.Forms;

namespace SalesManagement.View
{
    public partial class ProductsChooseList : MetroForm
    {
        Model._Products prd = new Model._Products();

        public ProductsChooseList()
        {
            InitializeComponent();
            this.dgvChooseProductsList.DataSource = prd.listProducts();
            this.dgvChooseProductsList.Columns[0].Visible = false;
        }

        private void dgvChooseProductsList_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvChooseProductsList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // auto numbering headr cell
            if (dgvChooseProductsList != null)
            {
                for (int r = 0; r < dgvChooseProductsList.Rows.Count; r++)
                {
                    dgvChooseProductsList.Rows[r].HeaderCell.Value = (r + 1).ToString();
                }
            }
        }

        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchProduct.Text) || txtSearchProduct.Text == string.Empty)
            {
                dgvChooseProductsList.DataSource = prd.listProducts();
            }

            dgvChooseProductsList.DataSource = prd.searchProduct(txtSearchProduct.Text);
            dgvChooseProductsList.Columns[0].Visible = false;

            if ((prd.searchProduct(txtSearchProduct.Text).Rows.Count) <= 0)
            {
                txtSearchProduct.Focus();
            }
        }
    }
}
