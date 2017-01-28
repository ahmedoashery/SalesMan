using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using MetroFramework.Forms;

namespace SalesManagement.View
{
    public partial class Products : MetroForm
    {
        // 1. _Categories class instance
        Model._Categories cat = new Model._Categories();
        // 2. _Products class instance
        Model._Products prd = new Model._Products();

        DataTable dt = new DataTable();


        //Single Instance
        private static Products frm;

        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }

        public static Products getProductsForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new Products();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }

        public Products()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
            // categories
            cmbCategoriesList.DataSource = cat.listCategories();
            cmbCategoriesList.DisplayMember = "اسم الفئة";
            cmbCategoriesList.ValueMember = "كود الفئة";

            // products
            dgvProductsList.DataSource = prd.listProducts();
            dgvProductsList.Columns[0].Visible = false;

            // units
            this.cmbUnitType.DataSource = prd.listUnitTypes();
            this.cmbUnitType.DisplayMember = "نوع الوحدة";
            this.cmbUnitType.ValueMember = "كود الوحدة";
        }

        // clear text
        private void txtsClear()
        {
            txtProductName.Clear();
            txtStoredQuantity.Clear();
            txtUnitPrice.Clear();
            cmbCategoriesList.Text = string.Empty;
            cmbUnitType.Text = string.Empty;
            txtBarcode.Clear();
        }

        private void btnNewCategory_Click(object sender, EventArgs e)
        {
            Categories viewform = new Categories();
            viewform.ShowDialog();
            cmbCategoriesList.DataSource = cat.listCategories();
        }

        private void btnDeleteAllProducts_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProductsList.Rows.Count <= 0)
                {
                    return;
                }
                if ((MessageBox.Show("هل ترغب بالفعل فى حذف كافة الأصناف ..؟", "تحذير", MessageBoxButtons.YesNo) == DialogResult.Yes))
                {

                    prd.deleteAllProducts();
                    txtsClear();
                    //MessageBox.Show("تم حذف جميع المنتجات.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dgvProductsList.DataSource = prd.listProducts();
                    this.txtProductsCount.Text =
                    (from DataGridViewRow row in dgvProductsList.Rows
                     where row.Cells[0].FormattedValue.ToString() != string.Empty
                     select Convert.ToDouble(row.Cells[0].FormattedValue)).Count().ToString();
                    return;
                }
            }
            catch
            {
                return;
            }
        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProductsList.Rows.Count <= 0)
                {
                    return;
                }
                if ((MessageBox.Show("هل ترغب بالفعل فى حذف الأصناف المحددة ..؟", "تحذير", MessageBoxButtons.YesNo) == DialogResult.Yes))
                {
                    foreach (DataGridViewRow row in dgvProductsList.SelectedRows)
                    {
                        prd.deleteProduct(Convert.ToInt32(row.Cells[0].Value));
                    }
                    
                    this.dgvProductsList.DataSource = prd.listProducts();
                    txtsClear();

                    this.txtProductsCount.Text =
                    (from DataGridViewRow row in dgvProductsList.Rows
                     where row.Cells[0].FormattedValue.ToString() != string.Empty
                     select Convert.ToDouble(row.Cells[0].FormattedValue)).Count().ToString();
                    return;
                }
            }
            catch
            {
                return;
            }
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(cmbCategoriesList.Text) 
                    || string.IsNullOrWhiteSpace(txtProductName.Text)
                    || string.IsNullOrWhiteSpace(txtStoredQuantity.Text) 
                    || string.IsNullOrWhiteSpace(cmbUnitType.Text)
                    || string.IsNullOrWhiteSpace(txtUnitPrice.Text))
                {
                    txtProductName.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtBarcode.Text))
                {
                    txtBarcode.Text = "بدون باركود";
                }

                prd.updateProduct(Convert.ToInt32(dgvProductsList.CurrentRow.Cells[0].Value.ToString()),
                                  txtBarcode.Text,
                                  txtProductName.Text,
                                  Convert.ToInt32(txtStoredQuantity.Text)
                                  , Convert.ToInt32(cmbUnitType.SelectedValue),
                                  txtUnitPrice.Text,
                                  Convert.ToInt32(cmbCategoriesList.SelectedValue));

                MessageBox.Show("تم تحديث البيانات.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtsClear();
                this.dgvProductsList.DataSource = prd.listProducts();
                return;
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                    MessageBox.Show(" ! الصنف موجود");
                else
                    MessageBox.Show(" ! خطأ غير معروف ");
                return;
            }
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchProduct.Text) || txtSearchProduct.Text == string.Empty)
            {
                txtSearchProduct.Clear();
                txtSearchProductResult.Visible = false;
                return;
            }

            dgvProductsList.DataSource = prd.searchProduct(txtSearchProduct.Text);
            dgvProductsList.Columns[0].Visible = false;

            if ((prd.searchProduct(txtSearchProduct.Text).Rows.Count) <= 0)
            {
                txtSearchProductResult.Visible = true;
                txtSearchProductResult.Text = "   لا توجد نتائج للبحث عن : " + txtSearchProduct.Text;
                dgvProductsList.DataSource = prd.listProducts();
                txtSearchProduct.Focus();
            }
        }

        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            txtsClear();
            btnAddProduct.Enabled = true;
            btnNewProduct.Enabled = false;
            txtProductName.ReadOnly = false;
            txtProductName.Focus();
        }

        private void dgvProductsList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //auto numbering header cell in datagridview
            if (dgvProductsList != null)
            {
                for (int i = 0; i < dgvProductsList.Rows.Count; i++)
                {
                    dgvProductsList.Rows[i].HeaderCell.Value = (i + 1).ToString();
                    dgvProductsList.Refresh();
                }
            }
        }

        private void btnNewUnit_Click(object sender, EventArgs e)
        {
            ProductsUnits viewForm = new ProductsUnits();
            viewForm.ShowDialog();
            cmbUnitType.DataSource = prd.listUnitTypes();
        }

        private void txtStoredQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            char DecimalSeparator = e.KeyChar;
            
            if (!char.IsDigit(DecimalSeparator) && DecimalSeparator != 8)
            {
                e.Handled = true;
                return;
            }
        }

        private void txtUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char DecimalSeparator = e.KeyChar;
            if (DecimalSeparator == 46 && txtUnitPrice.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!char.IsDigit(DecimalSeparator) && DecimalSeparator != 8 && DecimalSeparator != 46)
            {
                e.Handled = true;
            }
        }

        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            btnSearchProduct_Click(sender, e);
            txtSearchProductResult.Visible = false;
            if(string.IsNullOrWhiteSpace(txtSearchProduct.Text))
                this.dgvProductsList.DataSource = prd.listProducts();
        }

        private void dgvProductsList_Click(object sender, EventArgs e)
        {
            if (dgvProductsList.Rows.Count > 0)
            {
                btnEditProduct.Enabled = true;
                btnNewProduct.Enabled = false;
                btnAddProduct.Enabled = false;
                btnDeleteAllProducts.Enabled = true;
                btnRemoveProduct.Enabled = true;
                txtBarcode.Text = dgvProductsList.CurrentRow.Cells[1].Value.ToString();
                txtProductName.Text = dgvProductsList.CurrentRow.Cells[2].Value.ToString();
                txtStoredQuantity.Text = dgvProductsList.CurrentRow.Cells[3].Value.ToString();
                cmbUnitType.Text = dgvProductsList.CurrentRow.Cells[4].Value.ToString();
                txtUnitPrice.Text = dgvProductsList.CurrentRow.Cells[5].Value.ToString();
                cmbCategoriesList.Text = dgvProductsList.CurrentRow.Cells[6].Value.ToString();
            }
            else
            {
                return;
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(cmbCategoriesList.Text) 
                    || string.IsNullOrWhiteSpace(txtProductName.Text)
                    || string.IsNullOrWhiteSpace(cmbUnitType.Text))
                {
                    txtProductName.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtStoredQuantity.Text) 
                    || string.IsNullOrWhiteSpace(txtUnitPrice.Text))
                {
                    txtStoredQuantity.Text = "0";
                    txtUnitPrice.Text = "0";
                }

                if (string.IsNullOrWhiteSpace(txtBarcode.Text))
                {
                    txtBarcode.Text = "بدون باركود";
                }

                prd.newProduct(txtBarcode.Text,
                               txtProductName.Text,
                               Convert.ToInt32(txtStoredQuantity.Text),
                               Convert.ToInt32(cmbUnitType.SelectedValue),
                               txtUnitPrice.Text,
                               Convert.ToInt32(cmbCategoriesList.SelectedValue));

                this.dgvProductsList.DataSource = prd.listProducts();
                txtsClear();
                btnNewProduct.Enabled = true;
                btnAddProduct.Enabled = false;
                // count Categories from datagridview
                this.txtProductsCount.Text =
                    (from DataGridViewRow row in dgvProductsList.Rows
                     where row.Cells[0].FormattedValue.ToString() != string.Empty
                     select Convert.ToDouble(row.Cells[0].FormattedValue)).Count().ToString();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                    MessageBox.Show(" ! الصنف موجود");
                else
                    MessageBox.Show(" ! خطأ غير معروف ");
                return;
            }
        }

        private void btnUndoProduct_Click(object sender, EventArgs e)
        {
            txtsClear();
            txtProductName.Enabled = true;
            btnEditProduct.Enabled = false;
            btnNewProduct.Enabled = true;
            btnAddProduct.Enabled = false;
            btnDeleteAllProducts.Enabled = false;
            btnRemoveProduct.Enabled = false;
        }

        private void txtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
                return;
            }
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvProductsList.Rows.Count <= 0)
            {
                MessageBox.Show(" لا توجد أصناف !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if ((MessageBox.Show("هل ترغب بالفعل فى حذف الأصناف المحددة ..؟", "تحذير", MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                foreach (DataGridViewRow row in dgvProductsList.SelectedRows)
                {
                    prd.deleteProduct(Convert.ToInt32(row.Cells[0].Value));
                }
                //MessageBox.Show("تم حذف المنتجات المحددة.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dgvProductsList.DataSource = prd.listProducts();
                txtsClear();
                this.txtProductsCount.Text =
                (from DataGridViewRow row in dgvProductsList.Rows
                 where row.Cells[0].FormattedValue.ToString() != string.Empty
                 select Convert.ToDouble(row.Cells[0].FormattedValue)).Count().ToString();
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
