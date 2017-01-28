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
    public partial class ProvidersManagement : MetroForm
    {
        //  _providers class instance
        Model._Providers prv = new Model._Providers();

        DataTable dt = new DataTable();

        public ProvidersManagement()
        {
            InitializeComponent();

            try
            {
                // providers
                dgvProvidersList.DataSource = prv.listProviders();
                dgvProvidersList.Columns[0].Visible = false;
                //dgvProvidersList.Columns[4].Visible = false;
                //dgvProvidersList.Columns[5].Visible = false;
                //dgvProvidersList.Columns[6].Visible = false;
            }
            catch
            {
                return;
            }
        }

        private void btnNewProvider_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                if (string.IsNullOrWhiteSpace(txtProviderName.Text))
                {
                    txtProviderName.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtProviderAccountNum.Text) 
                    || string.IsNullOrWhiteSpace(txtProviderCompany.Text)
                    || string.IsNullOrWhiteSpace(txtChangs.Text)
                    || string.IsNullOrWhiteSpace(txtPaids.Text))
                {
                    txtProviderCompany.Text = "";
                    txtProviderAccountNum.Text = "0";
                    txtChangs.Text = "0";
                    txtPaids.Text = "0";
                }

                prv.newProvider(txtProviderName.Text,
                                txtProviderCompany.Text,
                                Convert.ToInt32(txtProviderAccountNum.Text),
                                txtChangs.Text,
                                txtPaids.Text);

                this.dgvProvidersList.DataSource = prv.listProviders();

                btnUndo_Click(sender, e);
                Cursor.Current = Cursors.Default;
            }
            catch(SqlException ex)
            {
                Cursor.Current = Cursors.Default;

                if (ex.Number == 2627)
                {
                    MessageBox.Show(" ! إسم المورد موجود", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txtProviderName.Focus();
                }
                else
                    MessageBox.Show(ex.Number + "خطأ غير معروف");

                return;
            }
        }

        private void btnEditProvider_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtProviderName.Text))
                {
                    txtProviderName.Focus();
                    return;
                }

                prv.updateProvider(
                                    Convert.ToInt32(dgvProvidersList.CurrentRow.Cells[0].Value.ToString())
                                    ,txtProviderName.Text
                                    , txtProviderCompany.Text
                                    ,Convert.ToInt32(txtProviderAccountNum.Text)
                                    ,Convert.ToDouble(txtChangs.Text)
                                    ,Convert.ToDouble(txtPaids.Text));

                this.dgvProvidersList.DataSource = prv.listProviders();

                btnUndo_Click(sender, e);

            }
            catch (SqlException ex)
            {
                Cursor.Current = Cursors.Default;

                if (ex.Number == 2627)
                {
                    MessageBox.Show(" ! إسم المورد موجود", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txtProviderName.Focus();
                }
                else
                    MessageBox.Show(ex.Number + "خطأ غير معروف");

                return;
            }
        }

        private void btnDeleteProvider_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProvidersList.Rows.Count <= 0)
                {
                    return;
                }
                if ((MessageBox.Show("هل ترغب بالفعل فى حذف المورد المحدد ..؟", "", MessageBoxButtons.YesNo) == DialogResult.Yes))
                {
                    foreach (DataGridViewRow row in dgvProvidersList.SelectedRows)
                    {
                        prv.deleteProvider(Convert.ToInt32(row.Cells[0].Value));
                    }
                    

                    this.dgvProvidersList.DataSource = prv.listProviders();

                    btnUndo_Click(sender, e);

                    if (dgvProvidersList.Rows.Count <= 0)
                    {
                        txtProviderName.Enabled = true;
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

        private void btnDeleteAllProviders_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProvidersList.Rows.Count <= 0)
                {
                    return;
                }
                if ((MessageBox.Show("هل ترغب بالفعل فى حذف جميع الموردين ..؟", "تحذير", MessageBoxButtons.YesNo) == DialogResult.Yes))
                {

                    prv.deleteAllProviders();

                    this.dgvProvidersList.DataSource = prv.listProviders();
                    
                    btnUndo_Click(sender, e);

                    if (dgvProvidersList.Rows.Count <= 0)
                    {
                        txtProviderName.Enabled = true;
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

        private void dgvProvidersList_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProvidersList.Rows.Count > 0)
                {
                    btnDeleteAllProviders.Enabled = true;
                    btnEditProvider.Enabled = true;
                    btnDeleteProvider.Enabled = true;
                    btnUndo.Enabled = true;

                    txtPaids.Enabled = true;
                    txtChangs.Enabled = true;
                    txtTotal.Enabled = true;

                    txtProviderName.Text = dgvProvidersList.CurrentRow.Cells[1].Value.ToString();
                    txtProviderCompany.Text = dgvProvidersList.CurrentRow.Cells[2].Value.ToString();
                    txtProviderAccountNum.Text = dgvProvidersList.CurrentRow.Cells[3].Value.ToString();
                    txtChangs.Text = dgvProvidersList.CurrentRow.Cells[4].Value.ToString();
                    txtPaids.Text = dgvProvidersList.CurrentRow.Cells[5].Value.ToString();
                    txtTotal.Text = dgvProvidersList.CurrentRow.Cells[6].Value.ToString();
                }
            }
            catch
            {
                return;
            }
        }

        private void txtProviderAccountNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
                return;
            }
        }

        private void txtSearchProvider_TextChanged(object sender, EventArgs e)
        {
            txtSearchProviderResult.Visible = false;
            if (!string.IsNullOrWhiteSpace(txtSearchProvider.Text))
            {
                dgvProvidersList.DataSource = prv.searchProvider(txtSearchProvider.Text);
                if ((dgvProvidersList.Rows.Count) <= 0)
                {
                    txtSearchProviderResult.Visible = true;
                    txtSearchProviderResult.Text = "لا توجد نتائج للبحث  ";
                    txtSearchProvider.Focus();
                }
            }
            else
            {
                txtSearchProvider.Focus();
                dgvProvidersList.DataSource = prv.listProviders();
                return;
            }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            txtProviderName.Clear();
            txtProviderCompany.Clear();
            txtProviderAccountNum.Clear();
            txtTotal.Clear();
            txtPaids.Clear();
            txtChangs.Clear();

            btnDeleteAllProviders.Enabled = false;
            btnEditProvider.Enabled = false;
            btnDeleteProvider.Enabled = false;
            btnUndo.Enabled = false;

            txtPaids.Enabled = false;
            txtChangs.Enabled = false;
            txtTotal.Enabled = false;
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

        private void dgvProvidersList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //auto numbering header cell in datagridview
            if (dgvProvidersList != null)
            {
                for (int i = 0; i < dgvProvidersList.Rows.Count; i++)
                {
                    dgvProvidersList.Rows[i].HeaderCell.Value = (i + 1).ToString();
                }
            }
        }
    }
}
