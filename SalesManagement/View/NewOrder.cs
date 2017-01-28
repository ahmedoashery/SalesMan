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

namespace SalesManagement.View
{
    public partial class NewOrder : MetroForm
    {

        Model._Products prd = new Model._Products();
        Model._Orders ord = new Model._Orders();
        Model._Customers cus = new Model._Customers();
        Model._Providers prv = new Model._Providers();
        Model._Reports rpt = new Model._Reports();

        Model.DB_access db = new Model.DB_access();

        DataTable dt = new DataTable();
        DataTable dtDGV = new DataTable();

        int orderID;

        public NewOrder()
        {
            InitializeComponent();
            cmbProductName.DataSource = prd.listProducts();
            cmbProductName.ValueMember = "كود الصنف";
            cmbProductName.DisplayMember = "اسم الصنف";

            txtCusid.Text = "1";
            txtDiscount.Text = "0";

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
            try
            {

                if (!string.IsNullOrWhiteSpace(txtUnitCost.Text) && !string.IsNullOrWhiteSpace(txtQuantity.Text))
                {
                    txtTotalCost.Text = (Convert.ToDouble(txtUnitCost.Text) * Convert.ToInt32(txtQuantity.Text)).ToString();
                }
            }
            catch
            {
                return;
            }
        }

        void DataRowsDGV()
        {
            dtDGV.Columns.Add("الصنف");
            dtDGV.Columns.Add("سعر الوحدة");
            dtDGV.Columns.Add("عدد");
            dtDGV.Columns.Add("وحدة");
            dtDGV.Columns.Add("إجمالى");

            dgvOrderProductsList.DataSource = dtDGV;
        }

        void ResizeDGV()
        {
            this.dgvOrderProductsList.Columns[0].Width = 216;
            this.dgvOrderProductsList.Columns[1].Width = 120;
            this.dgvOrderProductsList.Columns[2].Width = 74;
            this.dgvOrderProductsList.Columns[3].Width = 93;
            this.dgvOrderProductsList.Columns[4].Width = 117;
        }

        void ClearTexts()
        {
            chGeneralPerson.Checked = true;
            cmbProductName.SelectedText = "اختر صنف";
            txtUnitCost.Clear();
            txtQuantity.Clear();
            txtTotalCost.Clear();
            txtNotes.Clear();
            txtChangeCost.Clear();
            txtPaidPrice.Clear();
            txtDiscount.Clear();
            SumTotalCost.Text = "";
            OrderType.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ADD ORDER    **************************************************************************
        //              **************************************************************************

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            //Check Values
            if (string.IsNullOrWhiteSpace(txtOrderDate.Text) || string.IsNullOrWhiteSpace(cmbUnit.Text) || string.IsNullOrWhiteSpace(txtOrderPersonName.Text) ||
                    string.IsNullOrWhiteSpace(SumTotalCost.Text) || string.IsNullOrWhiteSpace(txtPaidPrice.Text) || string.IsNullOrWhiteSpace(txtChangeCost.Text)
                || string.IsNullOrWhiteSpace(OrderType.Text))
            {
                MessageBox.Show("يجب إدخال بيانات الفاتورة كاملة", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNotes.Text))
            {
                txtNotes.Text = "لا توجد ملاحظات";
            }

            if (OrderLabel.Text == "فـــاتـــورة  بيـــــع")
            {
                txtCusid.Text = cus.searchCustomer(txtOrderPersonName.Text).Rows[0][0].ToString();

                ord.newOrder(
                    orderID, 
                    OrderType.Text, 
                    txtOrderDate.Value, 
                    Convert.ToDouble(txtPaidPrice.Text), 
                    Convert.ToDouble(txtChangeCost.Text),
                    Convert.ToDouble(txtDiscount.Text), 
                    Convert.ToDouble(SumTotalCost.Text), 
                    Convert.ToInt32("0"),
                    Convert.ToInt32(txtCusid.Text), 
                    txtNotes.Text, 
                    txtSalesMan.Text, 
                    "A", 
                    "بيع");

                //إضافة الأصناف 
                for (int i = 0; i < dgvOrderProductsList.Rows.Count; i++)
                {
                    ord.newOrderDetailes(
                                            orderID,
                                            Convert.ToInt32(prd.searchProduct(dgvOrderProductsList.Rows[i].Cells[0].Value.ToString()).Rows[0][0]),
                                            Convert.ToInt32(dgvOrderProductsList.Rows[i].Cells[2].Value),
                                            dgvOrderProductsList.Rows[i].Cells[1].Value.ToString(),
                                            dgvOrderProductsList.Rows[i].Cells[4].Value.ToString(), 
                                            "A", 
                                            Convert.ToInt32(cmbUnit.SelectedValue));

                }

                // update customer from order
                ord.updateCustomerFromOrder(Convert.ToInt32(txtCusid.Text), txtChangeCost.Text, txtPaidPrice.Text);

            }

                // add order with provider ****************************************************/
            else
            {
                txtCusid.Text = prv.searchProvider(txtOrderPersonName.Text).Rows[0][0].ToString();

                ord.newOrder(
                    orderID, 
                    OrderType.Text, 
                    txtOrderDate.Value, 
                    Convert.ToDouble(txtPaidPrice.Text), 
                    Convert.ToDouble(txtChangeCost.Text), 
                    Convert.ToDouble(txtDiscount.Text), 
                    Convert.ToDouble(SumTotalCost.Text), 
                    Convert.ToInt32(txtCusid.Text), 
                    Convert.ToInt32("0"), 
                    txtNotes.Text, 
                    txtSalesMan.Text, 
                    "B", 
                    "شراء");


                //إضافة الأصناف 
                for (int i = 0; i < dgvOrderProductsList.Rows.Count; i++)
                {
                    ord.newOrderDetailes(
                                            orderID,
                                            Convert.ToInt32(prd.searchProduct(dgvOrderProductsList.Rows[i].Cells[0].Value.ToString()).Rows[0][0]),
                                            Convert.ToInt32(dgvOrderProductsList.Rows[i].Cells[2].Value),
                                            dgvOrderProductsList.Rows[i].Cells[1].Value.ToString(),
                                            dgvOrderProductsList.Rows[i].Cells[4].Value.ToString(), 
                                            "B", 
                                            Convert.ToInt32(cmbUnit.SelectedValue));

                }

                // update Provider from order
                ord.updateProviderFromOrder(Convert.ToInt32(txtCusid.Text), txtChangeCost.Text, txtPaidPrice.Text);

            }

            ClearTexts();
            SumTotalCost.Text = "";
            txtOrderPersonName.Clear();
            dtDGV.Clear();
            btnAddOrder.Enabled = false;
            btnNewOrder.Enabled = true;

            if (MessageBox.Show("تم حفظ الفاتورة طباعة الآن ؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    // print order
                    btnPrinOrder_Click(sender, e);
                }
                catch
                {
                    return;
                }
            }
        }

        private void btnChooseProducts_Click(object sender, EventArgs e)
        {
            try
            {
                ProductsChooseList view = new ProductsChooseList();
                if ((view.dgvChooseProductsList.Rows.Count) <= 0)
                {
                    if (MessageBox.Show(" لا توجد أصناف .. إضافة أصناف جديدة ؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Products viewForm = new Products();
                        viewForm.ShowDialog();
                    }
                    else
                    { return; }

                    view.dgvChooseProductsList.DataSource = prd.listProducts();
                    cmbProductName.DataSource = prd.listProducts();
                    cmbUnit.DataSource = prd.listUnitTypes();
                    cmbUnit.ValueMember = "كود الوحدة";
                    cmbUnit.DisplayMember = "نوع الوحدة";
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

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
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

        private void txtQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtQuantity.Text) && e.KeyCode == Keys.Enter)
            {
                dt = prd.searchProduct(cmbProductName.Text);
                if (OrderLabel.Text == "فـــاتـــورة  بيـــــع")
                {
                    if (ord.VerifyQuantity(Convert.ToInt32(dt.Rows[0][0]), Convert.ToInt32(txtQuantity.Text)).Rows.Count <= 0)
                    {
                        MessageBox.Show(" الكمية غير متاحة يرجي التحقق من المخزون", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtQuantity.Focus();
                        return;
                    }
                }

                txtNotes.Focus();


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
            else
            {
                txtQuantity.Focus();
                return;
            }
        }

        private void txtNotes_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txtPaidPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char DecimalSeparator = e.KeyChar;
            if (DecimalSeparator == 46 && txtPaidPrice.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!char.IsDigit(DecimalSeparator) && DecimalSeparator != 8 && DecimalSeparator != 46)
            {
                e.Handled = true;
            }
        }

        private void txtPaidPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtPaidPrice.Text) && e.KeyCode == Keys.Enter)
            {
                btnAddOrder.Focus();
            }
            else
            {
                txtPaidPrice.Focus();
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
                cmbUnit.DataSource = prd.listUnitTypes();
                cmbUnit.Text = dt.Rows[0][4].ToString();
                txtUnitCost.Focus();
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

        private void txtQuantity_KeyUp(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtQuantity.Text))
            {
                CalculateTotalCost();
            }
        }

        private void txtNotes_KeyUp(object sender, KeyEventArgs e)
        {
            CalculateTotalCost();
        }

        private void txtPaidPrice_TextChanged(object sender, EventArgs e)
        {
            
            try
            {
                if (!string.IsNullOrWhiteSpace(txtPaidPrice.Text) && Convert.ToDouble(SumTotalCost.Text) >= Convert.ToDouble(txtPaidPrice.Text))
                {
                    txtChangeCost.Text = (Convert.ToDouble(SumTotalCost.Text) - Convert.ToDouble(txtPaidPrice.Text)).ToString();
                }
                else
                {
                    txtPaidPrice.Focus();
                    txtPaidPrice.SelectionStart = 0;
                    txtPaidPrice.SelectionLength = txtPaidPrice.TextLength;
                    txtChangeCost.Clear();
                    return;
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
                        if (MessageBox.Show(" لا يوجد عملاء.. إضافة عملاء  ؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            CustomersManagement viewForm = new CustomersManagement();
                            viewForm.ShowDialog();
                            return;
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
        private void chGeneralPerson_Click(object sender, EventArgs e)
        {
            try
            {
                if (chGeneralPerson.Checked == true)
                {
                    txtOrderPersonName.Text = "عام";
                    txtCusid.Text = cus.searchCustomer(txtOrderPersonName.Text).Rows[0][0].ToString();
                    txtOrderPersonName.Enabled = false;
                    txtPaidPrice.ReadOnly = true;
                    txtPaidPrice.Text = SumTotalCost.Text;
                }
                else
                {
                    txtOrderPersonName.Enabled = true;
                    txtPaidPrice.ReadOnly = false;
                    txtOrderPersonName.Clear();
                    txtOrderPersonName.Focus();
                }
            }
            catch
            {
                return;
            }
        }

        private void txtOrderPersonName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtOrderPersonName.Text != "عام")
                {
                    chGeneralPerson.Checked = false;
                    txtPaidPrice.ReadOnly = false;
                    txtOrderPersonName.Enabled = true;
                    txtOrderPersonName.Focus();
                }
            }
            catch
            {
                return;
            }
        }

        private void txtQuantity_Leave(object sender, EventArgs e)
        {
            try
            {
                if (OrderLabel.Text == "فـــاتـــورة  بيـــــع")
                {
                    dt = prd.searchProduct(cmbProductName.Text);

                    if (ord.VerifyQuantity(Convert.ToInt32(dt.Rows[0][0]), Convert.ToInt32(txtQuantity.Text)).Rows.Count <= 0)
                    {
                        MessageBox.Show(" الكمية غير متاحة يرجي التحقق من المخزن", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtQuantity.Focus();
                        txtQuantity.SelectionStart = 0;
                        txtQuantity.SelectionLength = txtQuantity.TextLength;
                        return;
                    }
                }
                if (Convert.ToInt32(txtQuantity.Text) < 1)
                {
                    txtQuantity.Focus();
                    return;
                }
            }
            catch
            {
                return;
            }
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

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dgvOrderProductsList.Rows.RemoveAt(dgvOrderProductsList.CurrentRow.Index);
            }
            catch
            { return; }
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
                //txtNotes.Text = this.dgvOrderProductsList.CurrentRow.Cells[5].Value.ToString();
                dgvOrderProductsList.Rows.RemoveAt(dgvOrderProductsList.CurrentRow.Index);
                dgvOrderProductsList.Enabled = false;
                txtQuantity.Focus();
            }
            catch
            {
                return;
            }
        }

        private void مسحالقائمةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dtDGV.Clear();
            dgvOrderProductsList.Refresh();
        }

        private void dgvOrderProductsList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
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

        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            btnNewOrder.Enabled = true;
            btnAddOrder.Enabled = false;
            btnUndoProduct.Enabled = false;
            ClearTexts();
            chGeneralPerson.Checked = true;
            txtOrderPersonName.Text = "عام";
            txtOrderPersonName.Enabled = false;
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            dtDGV.Clear();
            dgvOrderProductsList.Refresh();
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            btnNewOrder.Enabled = false;
            btnAddOrder.Enabled = true;
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            OrderType.Visible = true;
            btnUndoProduct.Enabled = true;
            orderID = Convert.ToInt32(ord.getLastOrderID().Rows[0][0]);

            if (OrderLabel.Text == "فـــاتـــورة  بيـــــع")
            {
                OrderType.Text = "SO_00" + orderID;
            }
            else
            {
                OrderType.Text = "BO_00" + orderID;
            }
            txtOrderPersonName.Focus();
        }

        private void btnPrinOrder_Click(object sender, EventArgs e)
        {
            if (OrderLabel.Text == "فـــاتـــورة  بيـــــع")
            {
                this.Cursor = Cursors.WaitCursor;
                Reports.rpt_LastSalesOrderPrint report = new Reports.rpt_LastSalesOrderPrint();
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
            else
            {
                this.Cursor = Cursors.WaitCursor;
                Reports.rpt_LastBuysOrderPrint report = new Reports.rpt_LastBuysOrderPrint();
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
        }

        private void txtUnitCost_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txtUnitCost.Text) < 1)
                {
                    txtUnitCost.Focus();
                    return;
                }
            }
            catch
            {
                return;
            }
        }

        private void NewOrder_Load(object sender, EventArgs e)
        {
            try
            {
                //CheckUSB();

                if (chGeneralPerson.Checked == true || txtOrderPersonName.Text == "عام")
                {
                    txtPaidPrice.ReadOnly = true;
                }
            }
            catch
            {
                return;
            }
        }
        // check USB
        public void CheckUSB()
        {
            // check usb drives count 1st..
            IEnumerable<DriveInfo> a = DriveInfo.GetDrives().Where(d => d.IsReady
            && d.DriveType == System.IO.DriveType.Removable);

            // check usb serial 2nd..
            if (a.Count() > 0)
            {
                DriveInfo[] drives = DriveInfo.GetDrives();
                foreach (DriveInfo drive in drives)
                {
                    if (drive.DriveType == DriveType.Removable)
                    {
                        USBSerialNumber usb = new USBSerialNumber();
                        string serial = usb.getSerialNumberFromDriveLetter(drive.Name.Remove(2, 1));
                        if (serial != Program.USB_SERIAL)
                        {
                            if (MessageBox.Show("...برجاء توصيل فلاشة الترخيص وإعادة المحاولة", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Stop) == DialogResult.Retry)
                            {
                                CheckUSB();
                            }
                            else
                            {
                                this.Close();
                            }
                        }
                    }
                }
            }
            else
            {
                if (MessageBox.Show("...برجاء توصيل فلاشة الترخيص وإعادة المحاولة", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Stop) == DialogResult.Retry)
                {
                    CheckUSB();
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char DecimalSeparator = e.KeyChar;
            if (DecimalSeparator == 46 && txtDiscount.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!char.IsDigit(DecimalSeparator) && DecimalSeparator != 8 && DecimalSeparator != 46)
            {
                e.Handled = true;
            }
        }

        private void txtDiscount_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtDiscount.Text))
                {
                    double Discount = Convert.ToDouble(txtDiscount.Text);
                    double Amount = (from DataGridViewRow row in dgvOrderProductsList.Rows
                                     where (!string.IsNullOrWhiteSpace(row.Cells[4].FormattedValue.ToString()))
                                     select Convert.ToDouble(row.Cells[4].FormattedValue)).Sum();
                    double TotalAmount = Amount - (Amount * (Discount/100));
                    SumTotalCost.Text = TotalAmount.ToString();
                    txtPaidPrice.Text = SumTotalCost.Text;
                }
            }
            catch
            { return; }
        }

        private void txtDiscount_KeyDown(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtDiscount.Text) && e.KeyCode == Keys.Enter)
            {
                txtDiscount_KeyUp(sender, e);
                txtPaidPrice.Focus();
            }
        }

        private void txtDiscount_Leave(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtDiscount.Text))
                {
                    txtDiscount.Text = "0";
                }
                if (Convert.ToDouble(txtDiscount.Text) > 100)
                {
                    MessageBox.Show("قيمة الخصم غير صحيحة",
                                    "",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnAddOrder.Enabled = false;
                    txtDiscount.Focus();
                    txtDiscount.SelectionStart = 0;
                    txtDiscount.SelectionLength = txtDiscount.TextLength;
                    return;
                }
                else
                {
                    btnAddOrder.Enabled = true;
                }
            }
            catch
            {
                return;
            }
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            txtDiscount_Leave(sender, e);
        }

        private void txtBarcodeSearcher_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBarcodeSearcher.Text))
            {
                try
                {
                    dt = prd.getProductByBarcode(txtBarcodeSearcher.Text);
                    cmbProductName.Text = dt.Rows[0][2].ToString();
                    txtUnitCost.Text = dt.Rows[0][4].ToString();
                    txtQuantity.Text = dt.Rows[0][3].ToString();
                    cmbUnit.DataSource = prd.listUnitTypes();
                    cmbUnit.Text = dt.Rows[0][5].ToString();
                    txtUnitCost.Focus();
                }
                catch
                {
                    return;
                }
            }
        }

        private void SumTotalCost_TextChanged(object sender, EventArgs e)
        {
            txtPaidPrice.Text = SumTotalCost.Text;
        }
    }
}
