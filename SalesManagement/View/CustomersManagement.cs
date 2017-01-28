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
    public partial class CustomersManagement : MetroForm
    {
        // _customers class instance
        Model._Customers cus = new Model._Customers();

        DataTable dt = new DataTable();

        public CustomersManagement()
        {
            InitializeComponent();

            try
            {
                // customers
                txtCustomerName.Focus();

                dgvCustomersList.DataSource = cus.listCustomers();
                dgvCustomersList.Columns[0].Visible = false;
                //dgvCustomersList.Columns[3].Visible = false;
                //dgvCustomersList.Columns[4].Visible = false;
                //dgvCustomersList.Columns[5].Visible = false;
            }
            catch
            {
                return;
            }
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                if (string.IsNullOrWhiteSpace(txtCustomerName.Text))
                {
                    txtCustomerName.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtCustomerAccountNum.Text)
                    || string.IsNullOrWhiteSpace(txtChangs.Text)
                    || string.IsNullOrWhiteSpace(txtPaids.Text)
                    )
                {
                    txtCustomerAccountNum.Text = "0";
                    txtChangs.Text = "0";
                    txtPaids.Text = "0";
                }
                cus.newCustomer(txtCustomerName.Text,
                                Convert.ToInt32(txtCustomerAccountNum.Text),
                                txtChangs.Text,
                                txtPaids.Text);

                this.dgvCustomersList.DataSource = cus.listCustomers();

                txtCustomerName.Clear();
                txtCustomerAccountNum.Clear();
                txtTotal.Clear();
                txtPaids.Clear();
                txtChangs.Clear();
                txtCustomerName.Focus();

                Cursor.Current = Cursors.Default;

            }
            catch(SqlException ex)
            {
                Cursor.Current = Cursors.Default;

                if (ex.Number == 2627)
                {
                    MessageBox.Show(" ! إسم العميل موجود", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txtCustomerName.Focus();
                }
                else
                    MessageBox.Show(ex.Number + "خطأ غير معروف");

                return;
            }
        }

        private void dgvCustomersList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //auto numbering header cell in datagridview
            if (dgvCustomersList != null)
            {
                for (int i = 0; i < dgvCustomersList.Rows.Count; i++)
                {
                    dgvCustomersList.Rows[i].HeaderCell.Value = (i + 1).ToString();
                }
            }
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtCustomerName.Text) 
                    || string.IsNullOrWhiteSpace(txtChangs.Text)
                    || string.IsNullOrWhiteSpace(txtPaids.Text))
                {
                    txtCustomerName.Focus();
                    return;
                }

                cus.updateCustomer(
                                    Convert.ToInt32(dgvCustomersList.CurrentRow.Cells[0].Value.ToString())
                                    , txtCustomerName.Text
                                    , Convert.ToInt32(txtCustomerAccountNum.Text)
                                    , Convert.ToDouble(txtPaids.Text)
                                    , Convert.ToDouble(txtChangs.Text)
                                    );

                MessageBox.Show("تم الحفظ");
                this.dgvCustomersList.DataSource = cus.listCustomers();

                btnUndo_Click(sender, e);
                return;
            }
            catch (SqlException ex)
            {
                Cursor.Current = Cursors.Default;

                if (ex.Number == 2627)
                {
                    MessageBox.Show(" ! إسم العميل موجود", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txtCustomerName.Focus();
                }
                else
                    MessageBox.Show(ex.Number + "خطأ غير معروف");

                return;
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCustomersList.Rows.Count <= 0)
                {
                    return;
                }
                if ((MessageBox.Show("هل ترغب بالفعل فى حذف العملاء المحددين ..؟", "تحذير", MessageBoxButtons.YesNo) == DialogResult.Yes))
                {
                    foreach (DataGridViewRow row in dgvCustomersList.SelectedRows)
                    {
                        cus.deleteCustomer(Convert.ToInt32(row.Cells[0].Value));
                    }

                    btnUndo_Click(sender, e);

                    this.dgvCustomersList.DataSource = cus.listCustomers();

                    if (dgvCustomersList.Rows.Count <= 0)
                    {
                        txtCustomerName.Enabled = true;
                        return;
                    }
                    return;
                }
            }
            catch
            {
                return;
            }
        }

        private void btnDeleteAllCustomers_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCustomersList.Rows.Count <= 0)
                {
                    return;
                }
                if ((MessageBox.Show("هل ترغب بالفعل فى حذف جميع العملاء الحاليين ..؟", "", MessageBoxButtons.YesNo) == DialogResult.Yes))
                {
                    cus.deleteAllCustomers();
                    this.dgvCustomersList.DataSource = cus.listCustomers();

                    btnUndo_Click(sender, e);

                    if (dgvCustomersList.Rows.Count <= 0)
                    {
                        txtCustomerName.Enabled = true;
                        return;
                    }
                    return;
                }
            }
            catch
            {
                return;
            }
        }

        private void dgvCustomersList_Click(object sender, EventArgs e)
        {
            if (dgvCustomersList.Rows.Count > 0)
            {
                btnDeleteCustomer.Enabled = true;
                btnEditCustomer.Enabled = true;
                btnDeleteAllCustomers.Enabled = true;
                btnUndo.Enabled = true;

                txtPaids.Enabled = true;
                txtChangs.Enabled = true;
                txtTotal.Enabled = true;

                txtCustomerName.Text = dgvCustomersList.CurrentRow.Cells[1].Value.ToString();
                txtCustomerAccountNum.Text = dgvCustomersList.CurrentRow.Cells[2].Value.ToString();
                txtChangs.Text = dgvCustomersList.CurrentRow.Cells[3].Value.ToString();
                txtPaids.Text = dgvCustomersList.CurrentRow.Cells[4].Value.ToString();
                txtTotal.Text = dgvCustomersList.CurrentRow.Cells[5].Value.ToString();
                txtCustomerName.Focus();
            }
            else
            {
                return;
            }
        }

        private void txtSearchCustomer_TextChanged(object sender, EventArgs e)
        {
            txtSearchCustomerResult.Visible = false;
            if (!string.IsNullOrWhiteSpace(txtSearchCustomer.Text))
            {
                dgvCustomersList.DataSource = cus.searchCustomer(txtSearchCustomer.Text);
                if ((dgvCustomersList.Rows.Count) <= 0)
                {
                    txtSearchCustomerResult.Visible = true;
                    txtSearchCustomerResult.Text = "لا توجد نتائج للبحث ";
                    txtSearchCustomer.Focus();
                }
            }
            else
            {
                txtSearchCustomer.Focus();
                dgvCustomersList.DataSource = cus.listCustomers();
                return;
            }
        }

        private void txtCustomerAccountNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
                return;
            }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            txtCustomerName.Clear();
            txtCustomerAccountNum.Clear();
            txtTotal.Clear();
            txtPaids.Clear();
            txtChangs.Clear();
            txtCustomerName.Enabled = true;
            btnDeleteCustomer.Enabled = false;
            btnEditCustomer.Enabled = false;
            btnDeleteAllCustomers.Enabled = false;
            btnUndo.Enabled = false;

            txtPaids.Enabled = false;
            txtChangs.Enabled = false;
            txtTotal.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            char DecimalSeparator = e.KeyChar;
            if (DecimalSeparator == 46 && txtTotal.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!char.IsDigit(DecimalSeparator) && DecimalSeparator != 8 && DecimalSeparator != 46)
            {
                e.Handled = true;
            }
        }

        private void txtPaids_KeyPress(object sender, KeyPressEventArgs e)
        {
            char DecimalSeparator = e.KeyChar;
            if (DecimalSeparator == 46 && txtPaids.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!char.IsDigit(DecimalSeparator) && DecimalSeparator != 8 && DecimalSeparator != 46)
            {
                e.Handled = true;
            }
        }

        private void txtChangs_KeyPress(object sender, KeyPressEventArgs e)
        {
            char DecimalSeparator = e.KeyChar;
            if (DecimalSeparator == 46 && txtChangs.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!char.IsDigit(DecimalSeparator) && DecimalSeparator != 8 && DecimalSeparator != 46)
            {
                e.Handled = true;
            }
        }

        private void txtChangs_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double paids = Convert.ToDouble(txtPaids.Text);
                double changs = Convert.ToDouble(txtChangs.Text);
                double total = paids + changs;
                txtTotal.Text = total.ToString();
            }
            catch
            { return; }
        }

        private void txtPaids_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double paids = Convert.ToDouble(txtPaids.Text);
                double changs = Convert.ToDouble(txtChangs.Text);
                double total = paids + changs;
                txtTotal.Text = total.ToString();
            }
            catch { return; }
        }
    }
}
