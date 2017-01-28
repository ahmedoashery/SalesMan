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
using System.Data.SqlClient;

namespace SalesManagement.View
{
    public partial class ProductsUnits : MetroForm
    {
        Model._Products prd = new Model._Products();

        public ProductsUnits()
        {
            InitializeComponent();

            dgvUnitsList.DataSource = prd.listUnitTypes();
            dgvUnitsList.Columns[0].Visible = false;
        }

        private void btnNewUnit_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtAddNewUnit.Text))
                {
                    btnNewUnit.Enabled = false;

                    prd.newUnitType(txtAddNewUnit.Text);

                    txtAddNewUnit.Clear();
                    dgvUnitsList.DataSource = prd.listUnitTypes();

                    btnNewUnit.Enabled = true;
                    btnAddUnit.Enabled = false;

                }
                else
                {
                    txtAddNewUnit.Focus();
                    return;
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                    MessageBox.Show(" ! الوحدة موجود");
                else
                    MessageBox.Show(" ! خطأ غير معروف ");
                return;
            }
        }

        private void btnDeleteUnit_Click(object sender, EventArgs e)
        {
            if (dgvUnitsList.Rows.Count <= 0) {
                return;
            }
            foreach (DataGridViewRow row in dgvUnitsList.SelectedRows)
            {
                prd.deleteUnit(Convert.ToInt32(row.Cells[0].Value));
            }

            //MessageBox.Show("تم تحديث البيانات", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvUnitsList.DataSource = prd.listUnitTypes();
            txtAddNewUnit.Clear();
            return;
        }

        private void btnEditUnit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtAddNewUnit.Text)) {

                if (prd.ExistUnitType(txtAddNewUnit.Text).Rows.Count >= 1)
                {
                    MessageBox.Show("لم يتم تحديث اية بيانات او أن الوحدة موجودة بالفعل ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAddNewUnit.Focus();
                    return;
                }

                prd.updateUnit(Convert.ToInt32(dgvUnitsList.CurrentRow.Cells[0].Value), txtAddNewUnit.Text);
                MessageBox.Show("تم تحديث البيانات", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvUnitsList.DataSource = prd.listUnitTypes();
                txtAddNewUnit.Clear();
                return;
            }
        }

        private void dgvUnitsList_Click(object sender, EventArgs e)
        {
            txtAddNewUnit.Text = dgvUnitsList.CurrentRow.Cells[1].Value.ToString();
            txtAddNewUnit.Focus();
        }

        private void dgvUnitsList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //auto numbering header cell in datagridview
            if (dgvUnitsList != null)
            {
                for (int i = 0; i < dgvUnitsList.Rows.Count; i++)
                {

                    dgvUnitsList.Rows[i].HeaderCell.Value = (i + 1).ToString();
                }
            }
        }

        private void btnCancelProduct_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNewUnit_Click_1(object sender, EventArgs e)
        {
            btnAddUnit.Enabled = true;
            btnNewUnit.Enabled = false;
            txtAddNewUnit.Focus();
        }

        private void ProductsUnits_FormClosed(object sender, FormClosedEventArgs e)
        {
            Products.getProductsForm.cmbUnitType.DataSource = prd.listUnitTypes();
        }
    }
}
