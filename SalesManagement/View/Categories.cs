using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using MetroFramework.Forms;
using System.Data.SqlClient;

namespace SalesManagement.View
{
    public partial class Categories : MetroForm
    {
        Model._Categories cat = new Model._Categories();
        DataTable dt = new DataTable();
        public Categories()
        {
            InitializeComponent();
            this.dgvCategoriesList.DataSource = cat.listCategories();
            this.dgvCategoriesList.Columns[0].Visible = false;
            
        }

        private void dgvCategoriesList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //auto numbering header cell in datagridview
            if (dgvCategoriesList != null)
            {
                for (int i = 0; i < dgvCategoriesList.Rows.Count; i++)
                {
                    dgvCategoriesList.Rows[i].HeaderCell.Value = (i + 1).ToString();
                }
            }
        }

        private void txtSearchCategory_TextChanged(object sender, EventArgs e)
        {
            //dgvCategoriesList.DataSource = cat.searchCategory(txtSearchCategory.Text);
            //if (dgvCategoriesList.Rows.Count <= 0)
            //{
            //    txtSearchResult.Text = "   لا توجد نتائج للبحث عن : " + txtSearchCategory.Text;
            //    dgvCategoriesList.DataSource = cat.listCategories();
            //    txtSearchCategory.Focus();
            //}
        }

        private void Categories_Load(object sender, EventArgs e)
        {
            // count Categories from datagridview
            this.txtCategoriesCount.Text =
                (from DataGridViewRow row in dgvCategoriesList.Rows
                 where row.Cells[0].FormattedValue.ToString() != string.Empty
                 select Convert.ToDouble(row.Cells[0].FormattedValue)).Count().ToString();
        }

        private void dgvCategoriesList_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCategoriesList.Rows.Count >= 0)
                {
                    txtCategoryName.Text = dgvCategoriesList.CurrentRow.Cells[1].Value.ToString();
                    txtCategoryName.Focus();
                }
            }
            catch
            {
                return;
            }
        }

        private void btnSearchCategory_Click(object sender, EventArgs e)
        {
            dgvCategoriesList.DataSource = cat.searchCategory(txtSearchCategory.Text);

            if (dgvCategoriesList.Rows.Count <= 0)
            {
                txtSearchResult.Text = "   لا توجد نتائج للبحث عن : " + txtSearchCategory.Text;
                dgvCategoriesList.DataSource = cat.listCategories();
                txtSearchCategory.Focus();
            }
        }

        private void txtSearchCategory_Enter(object sender, EventArgs e)
        {
            btnSearchCategory.Enabled = true;
        }

        private void btnNewCategory_Click(object sender, EventArgs e)
        {
            btnAddCategory.Enabled = true;
            btnNewCategory.Enabled = false;
            txtCategoryName.Focus();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            try
            {
                btnNewCategory.Enabled = false;

                if (string.IsNullOrWhiteSpace(txtCategoryName.Text))
                {
                    txtCategoryName.Clear();
                    txtCategoryName.Focus();
                    return;
                }

                cat.newCategory(txtCategoryName.Text);
                this.dgvCategoriesList.DataSource = cat.listCategories();
                txtCategoryName.Clear();
                btnNewCategory.Enabled = true;
                btnAddCategory.Enabled = false;
            }
            catch(SqlException ex)
            {
                Cursor.Current = Cursors.Default;

                if (ex.Number == 2627)
                {
                    MessageBox.Show(" ! إسم الفئة موجود", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txtCategoryName.Focus();
                }
                else
                    MessageBox.Show(ex.Number + "خطأ غير معروف");
                
                btnNewCategory.Enabled = true;
                btnAddCategory.Enabled = false;
                return;
            }
        }

        private void btnEditCategory_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtCategoryName.Text))
                {
                    txtCategoryName.Focus();
                    return;
                }

                cat.updateCategory(Convert.ToInt32(this.dgvCategoriesList.CurrentRow.Cells[0].Value), txtCategoryName.Text);

                MessageBox.Show("تم تحديث البيانات.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCategoryName.Clear();
                this.dgvCategoriesList.DataSource = cat.listCategories();
                return;
            }
            catch (SqlException ex)
            {
                Cursor.Current = Cursors.Default;

                if (ex.Number == 2627)
                {
                    MessageBox.Show(" ! إسم الفئة موجود", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txtCategoryName.Focus();
                }
                else
                    return;
            }
        }

        private void btnRemoveCategory_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dgvCategoriesList.Rows.Count <= 0)
                {
                    //MessageBox.Show("لا توجد أصناف !", "خطـــــأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if ((MessageBox.Show("هل ترغب بالفعل فى حذف الصنف المحدد ..؟", "تحذير", MessageBoxButtons.YesNo) == DialogResult.Yes))
                {
                    foreach (DataGridViewRow row in dgvCategoriesList.SelectedRows)
                    {
                        cat.deleteCategory(Convert.ToInt32(row.Cells[0].Value));
                    }

                    //MessageBox.Show("تم حذف الصنف المحدد.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dgvCategoriesList.DataSource = cat.listCategories();
                    this.txtCategoriesCount.Text =
                    (from DataGridViewRow row in dgvCategoriesList.Rows
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

        private void btnDeleteAllCategories_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dgvCategoriesList.Rows.Count <= 0)
                {
                    //MessageBox.Show(" لا توجد أصناف !", "خطـــــأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if ((MessageBox.Show("هل ترغب بالفعل فى حذف كافة الأصناف ..؟", "تحذير", MessageBoxButtons.YesNo) == DialogResult.Yes))
                {

                    cat.deleteAllCategories();
                    
                    //MessageBox.Show("تم حذف جميع الأصناف.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dgvCategoriesList.DataSource = cat.listCategories();
                    this.txtCategoriesCount.Text =
                    (from DataGridViewRow row in dgvCategoriesList.Rows
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

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void Categories_FormClosed(object sender, FormClosedEventArgs e)
        {
            Products.getProductsForm.cmbCategoriesList.DataSource = cat.listCategories();
        }
    }
}
