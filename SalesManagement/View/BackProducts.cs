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
    public partial class BackProducts : MetroForm
    {
        Model._Products prd = new Model._Products();
        Model._Orders ord = new Model._Orders();
        Model._Customers cus = new Model._Customers();
        Model._Reports rpt = new Model._Reports();

        DataTable dt = new DataTable();
        DataTable dtDGV = new DataTable();

        int orderID;
        public BackProducts()
        {
            InitializeComponent();
            cmbProductName.DataSource = prd.searchProduct("");
            cmbProductName.ValueMember = "كود الصنف";
            cmbProductName.DisplayMember = "اسم الصنف";

            txtCusid.Text = "1";

            cmbUnit.DataSource = prd.listUnitTypes();
            cmbUnit.ValueMember = "كود الوحدة";
            cmbUnit.DisplayMember = "نوع الوحدة";

            txtSalesMan.Text = Program.SalesMan;

            DataRowsDGV();
            ResizeDGV();

            if (chGeneralPerson.Checked == true)
            {
                txtOrderPersonName.Enabled = false;
                txtOrderPersonName.Text = "عام";
            }

        }

        void CalculateTotalCost()
        {
            if (!string.IsNullOrWhiteSpace(txtUnitCost.Text) && !string.IsNullOrWhiteSpace(txtQuantity.Text))
            {
                txtTotalCost.Text = (Convert.ToDouble(txtUnitCost.Text) * Convert.ToInt32(txtQuantity.Text)).ToString();
            }
        }

        void DataRowsDGV()
        {
            dtDGV.Columns.Add("الصنف");
            dtDGV.Columns.Add("سعر الوحدة");
            dtDGV.Columns.Add("عدد");
            dtDGV.Columns.Add("وحدة");
            dtDGV.Columns.Add("إجمالى");
            dtDGV.Columns.Add("ملاحظات");

            dgvOrderProductsList.DataSource = dtDGV;
        }

        void ResizeDGV()
        {
            this.dgvOrderProductsList.Columns[0].Width = 201;
            this.dgvOrderProductsList.Columns[1].Width = 102;
            this.dgvOrderProductsList.Columns[2].Width = 66;
            this.dgvOrderProductsList.Columns[3].Width = 87;
            this.dgvOrderProductsList.Columns[4].Width = 94;
            this.dgvOrderProductsList.Columns[5].Width = 210;
        }

        void ClearTexts()
        {
            cmbProductName.SelectedText = "اختر صنف";
            txtUnitCost.Clear();
            txtQuantity.Clear();
            cmbUnit.Refresh();
            txtTotalCost.Clear();
            txtNotes.Clear();
            OrderType.Visible = false;
        }





        private void btnNewOrder_Click_1(object sender, EventArgs e)
        {
            btnNewOrder.Enabled = false;
            btnAddOrder.Enabled = true;
            OrderType.Visible = true;
            orderID = Convert.ToInt32(ord.getLastOrderID().Rows[0][0]);

            if (OrderLabel.Text == "مرتجع")
            {
                OrderType.Text = "RT_000" + orderID;
            }
            txtOrderPersonName.Focus();
        }

        // ADD ORDER    **************************************************************************
        //              **************************************************************************
        private void btnAddOrder_Click_1(object sender, EventArgs e)
        {
            try
            {
                //Check Values
                if (string.IsNullOrWhiteSpace(txtOrderDate.Text) || string.IsNullOrWhiteSpace(txtOrderPersonName.Text) ||
                        string.IsNullOrWhiteSpace(SumTotalCost.Text) || string.IsNullOrWhiteSpace(OrderType.Text))
                {
                    MessageBox.Show("ينبغي تسجيل بيانات الفاتورة كاملة", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtNotes.Text))
                {
                    txtNotes.Text = "لا توجد ملاحظات";
                } 

                if (OrderLabel.Text == "مرتجع")
                {
                    dt = cus.getCustomerByID(Convert.ToInt32(txtCusid.Text));
                    if (Convert.ToDouble(dt.Rows[0][4]) < Convert.ToDouble(SumTotalCost.Text))
                    {
                        MessageBox.Show("يجب أن تكون قيمة المسدودات أكبر من قيمة المرتجع", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    txtCusid.Text = cus.searchCustomer(txtOrderPersonName.Text).Rows[0][0].ToString();

                    ord.newOrder(orderID, OrderType.Text, txtOrderDate.Value, Convert.ToInt32("0"), 0, 0, Convert.ToDouble(SumTotalCost.Text), 0, Convert.ToInt32(txtCusid.Text), txtNotes.Text, txtSalesMan.Text, "R", "مرتجع");


                    //إضافة الأصناف 
                    for (int i = 0; i < dgvOrderProductsList.Rows.Count; i++)
                    {
                        ord.newOrderDetailes(
                                                orderID,
                                                Convert.ToInt32(prd.searchProduct(dgvOrderProductsList.Rows[i].Cells[0].Value.ToString()).Rows[0][0]),
                                                Convert.ToInt32(dgvOrderProductsList.Rows[i].Cells[2].Value),
                                                dgvOrderProductsList.Rows[i].Cells[1].Value.ToString(),
                                                dgvOrderProductsList.Rows[i].Cells[4].Value.ToString(), "B", Convert.ToInt32(cmbUnit.SelectedValue));

                    }

                    // update customer from order
                    ord.updateCustomerFromBackOrder(Convert.ToInt32(txtCusid.Text), SumTotalCost.Text);

                }

                ClearTexts();
                SumTotalCost.Clear();
                txtOrderPersonName.Clear();
                dtDGV.Clear();
                btnAddOrder.Enabled = false;
                btnNewOrder.Enabled = true;

                if (MessageBox.Show("تم حفظ الفاتورة طباعة الآن ؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // print order
                    btnPrinOrder_Click(sender, e);
                }
            }
            catch
            {
                MessageBox.Show("خطأ فى البيانات");
                this.Close();
            }
        }


        private void btnSaveProduct_Click_1(object sender, EventArgs e)
        {
            btnNewOrder.Enabled = true;
            btnAddOrder.Enabled = false;
            ClearTexts();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnChooseProducts_Click_1(object sender, EventArgs e)
        {
            try
            {
                ProductsChooseList view = new ProductsChooseList();
                if (view.dgvChooseProductsList.Rows.Count <= 0)
                {
                    if (MessageBox.Show(" لا توجد أصناف.. إضافة أصناف جديدة ؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Products viewForm = new Products();
                        viewForm.ShowDialog();
                        return;
                    }
                }

                view.ShowDialog();
                cmbProductName.Text = view.dgvChooseProductsList.CurrentRow.Cells[2].Value.ToString();
                txtUnitCost.Text = view.dgvChooseProductsList.CurrentRow.Cells[5].Value.ToString();
                txtQuantity.Text = view.dgvChooseProductsList.CurrentRow.Cells[3].Value.ToString();
                cmbUnit.Text = view.dgvChooseProductsList.CurrentRow.Cells[4].Value.ToString();

                txtUnitCost.Focus();
            }
            catch
            {
                return;
            }
        }

        private void cmbProductName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                dt = prd.searchProduct(cmbProductName.Text);
                txtUnitCost.Text = dt.Rows[0][5].ToString();
                txtQuantity.Text = dt.Rows[0][3].ToString();
                cmbUnit.Text = dt.Rows[0][4].ToString();
                txtUnitCost.Focus();
            }
            catch
            {
                return;
            }
        }


        private void txtOrderPersonName_TextChanged(object sender, EventArgs e)
        {
            if (txtOrderPersonName.Text != "عام")
            {
                chGeneralPerson.Checked = false;
                txtOrderPersonName.Enabled = true;
                txtOrderPersonName.Focus();
            }
        }

        private void dgvOrderProductsList_DataBindingComplete_1(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dgvOrderProductsList != null)
            {
                for (int r = 0; r < dgvOrderProductsList.Rows.Count; r++)
                {
                    dgvOrderProductsList.Rows[r].HeaderCell.Value = (r + 1).ToString();
                    dgvOrderProductsList.Refresh();
                }
            }
        }

        private void مسحالقائمةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dtDGV.Clear();
            dgvOrderProductsList.Refresh();
        }

        private void dgvOrderProductsList_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                cmbProductName.Text = this.dgvOrderProductsList.CurrentRow.Cells[0].Value.ToString();
                txtUnitCost.Text = this.dgvOrderProductsList.CurrentRow.Cells[1].Value.ToString();
                txtQuantity.Text = this.dgvOrderProductsList.CurrentRow.Cells[2].Value.ToString();
                cmbUnit.Text = this.dgvOrderProductsList.CurrentRow.Cells[3].Value.ToString();
                txtTotalCost.Text = this.dgvOrderProductsList.CurrentRow.Cells[4].Value.ToString();
                txtNotes.Text = this.dgvOrderProductsList.CurrentRow.Cells[5].Value.ToString();
                dgvOrderProductsList.Rows.RemoveAt(dgvOrderProductsList.CurrentRow.Index);
                dgvOrderProductsList.Enabled = false;
                txtQuantity.Focus();
            }
            catch
            {
                return;
            }
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dgvOrderProductsList.Rows.RemoveAt(dgvOrderProductsList.CurrentRow.Index);
            }
            catch
            { return; }
        }

        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dgvOrderProductsList_DoubleClick(sender, e);
            }
            catch
            { return; }
        }


        private void chGeneralPerson_Click(object sender, EventArgs e)
        {
            try
            {
                if (chGeneralPerson.Checked == true)
                {
                    txtOrderPersonName.Enabled = false;
                    txtOrderPersonName.Text = "عام";
                    txtCusid.Text = cus.searchCustomer(txtOrderPersonName.Text).Rows[0][0].ToString();
                }
                else
                {
                    txtOrderPersonName.Enabled = true;
                    txtOrderPersonName.Clear();
                    txtOrderPersonName.Focus();
                }
            }
            catch
            {
                return;
            }
        }


        private void btnChooseCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnChooseCustomer.Text == "اختر عميل")
                {
                    Customers view = new Customers();
                    if (view.dgvChooseCustomersList.Rows.Count <= 0)
                    {
                        if (MessageBox.Show(" لا يوجد عملاء", "", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
                        {
                            this.Close();
                        }
                    }
                    view.ShowDialog();
                    if (view.dgvChooseCustomersList != null || view.dgvChooseCustomersList.Rows.Count > 0)
                    {
                        txtCusid.Text = view.dgvChooseCustomersList.CurrentRow.Cells[0].Value.ToString();
                        txtOrderPersonName.Text = view.dgvChooseCustomersList.CurrentRow.Cells[1].Value.ToString();
                    }
                }
                else
                {
                    Providers view = new Providers();
                    if (view.dgvChooseProvidersList.Rows.Count <= 0)
                    {
                        if (MessageBox.Show(" لا يوجد موردين.. إضافة موردين  ؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            ProvidersManagement viewForm = new ProvidersManagement();
                            viewForm.ShowDialog();
                            return;
                        }
                    }
                    view.ShowDialog();
                    if (view.dgvChooseProvidersList != null)
                    {
                        txtCusid.Text = view.dgvChooseProvidersList.CurrentRow.Cells[0].Value.ToString();
                        txtOrderPersonName.Text = view.dgvChooseProvidersList.CurrentRow.Cells[1].Value.ToString();
                    }
                }
            }
            catch
            {
                return;
            }
        }

        private void txtNotes_KeyUp(object sender, KeyEventArgs e)
        {
            CalculateTotalCost();
        }

        private void txtNotes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(txtNotes.Text))
                {
                    txtNotes.Text = "لا توجد ملاحظات";
                }

                for (int c = 0; c < dgvOrderProductsList.Rows.Count; c++)
                {
                    if (dgvOrderProductsList.Rows[c].Cells[0].Value.ToString() == cmbProductName.Text)
                    {
                        MessageBox.Show("تم ادخال الصنف من قبل .. !", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }

                CalculateTotalCost();

                if (txtTotalCost.Text != "0")
                {

                    DataRow r = dtDGV.NewRow();

                    r[0] = cmbProductName.Text;
                    r[1] = txtUnitCost.Text;
                    r[2] = txtQuantity.Text;
                    r[3] = cmbUnit.Text;
                    r[4] = txtTotalCost.Text;
                    r[5] = txtNotes.Text;

                    dtDGV.Rows.Add(r);

                    ClearTexts();

                    SumTotalCost.Text =
                        (from DataGridViewRow row in dgvOrderProductsList.Rows
                         where (!string.IsNullOrWhiteSpace(row.Cells[4].FormattedValue.ToString()))
                         select Convert.ToDouble(row.Cells[4].FormattedValue)).Sum().ToString();

                    btnChooseProducts.Focus();
                    dgvOrderProductsList.Enabled = true;
                }
            }
        }


        private void txtQuantity_KeyUp(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtQuantity.Text))
            {
                CalculateTotalCost();
            }
        }

        private void txtQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtQuantity.Text) && e.KeyCode == Keys.Enter)
            {
                dt = prd.searchProduct(cmbProductName.Text);

                //if (ord.VerifyQuantity(Convert.ToInt32(dt.Rows[0][0]), Convert.ToInt32(txtQuantity.Text)).Rows.Count <= 0)
                //{
                //    MessageBox.Show(" الكمية غير متاحة يرجي التحقق من المخزون", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    txtQuantity.Focus();
                //    return;
                //}

                txtNotes.Focus();
            }
            else
            {
                txtQuantity.Focus();
                return;
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtQuantity_Leave(object sender, EventArgs e)
        {
            try
            {
                dt = prd.searchProduct(cmbProductName.Text);

                //if (ord.VerifyQuantity(Convert.ToInt32(dt.Rows[0][0]), Convert.ToInt32(txtQuantity.Text)).Rows.Count <= 0)
                //{
                //    MessageBox.Show(" الكمية غير متاحة يرجي التحقق من المخزون", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    txtQuantity.Focus();
                //    txtQuantity.SelectionStart = 0;
                //    txtQuantity.SelectionLength = txtQuantity.TextLength;
                //    return;
                //}
            }
            catch
            {
                return;
            }
        }


        private void txtUnitCost_KeyUp(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtUnitCost.Text))
            {
                CalculateTotalCost();
            }
        }

        private void txtUnitCost_KeyDown(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtUnitCost.Text) && e.KeyCode == Keys.Enter)
            {
                txtQuantity.Focus();
            }
            else
            {
                txtUnitCost.Focus();
                return;
            }
        }

        private void txtUnitCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            char DecimalSeparator = e.KeyChar;
            if (DecimalSeparator == 46 && txtUnitCost.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!char.IsDigit(DecimalSeparator) && DecimalSeparator != 8 && DecimalSeparator != 46)
            {
                e.Handled = true;
            }
        }

        private void btnPrinOrder_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Reports.rpt_LastBackOrderPrint report = new Reports.rpt_LastBackOrderPrint();
            report.SetDatabaseLogon(Program.ID,
                                        Program.Password,
                                        Program.Server,
                                        Program.Database);
            Reports.ReportsViewer view = new Reports.ReportsViewer();
            view.CRViewer.ReportSource = report;
            report.Refresh();
            view.ShowDialog();
            this.Cursor = Cursors.Default;
        }

        private void SumTotalCost_Leave(object sender, EventArgs e)
        {
            dt = cus.getCustomerByID(Convert.ToInt32(txtCusid.Text));
            if (Convert.ToDouble(dt.Rows[0][4]) < Convert.ToDouble(SumTotalCost.Text))
            {
                MessageBox.Show("يجب أن تكون قيمة المسدودات أكبر من قيمة المرتجع", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            btnNewOrder.Enabled = false;
            btnAddOrder.Enabled = true;
            OrderType.Visible = true;
            orderID = Convert.ToInt32(ord.getLastOrderID().Rows[0][0]);

            if (OrderLabel.Text == "مرتجع")
            {
                OrderType.Text = "RT_000" + orderID;
            }
            txtOrderPersonName.Focus();
        }
    }
}
