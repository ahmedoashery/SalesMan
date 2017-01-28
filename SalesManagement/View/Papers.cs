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
    public partial class Papers : MetroForm
    {
        Model._Papers pap = new Model._Papers();
        Model._Customers cus = new Model._Customers();
        Model._Providers prv = new Model._Providers();

        DataTable dt = new DataTable();

        public Papers()
        {
            InitializeComponent();
            SalesMan.Text = Program.SalesMan;
            SalesMan2.Text = Program.SalesMan;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnChooseCustomer_Click(object sender, EventArgs e)
        {
            try
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
                else
                {
                    view.ShowDialog();
                    if (Convert.ToInt32(view.dgvChooseCustomersList.CurrentRow.Cells[3].Value) < 1)
                    {
                        MessageBox.Show("لا يوجد رصيد مدين لهذا العميل لخصم قيمة سند قبض جديد", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    txtCustomerName.Text = view.dgvChooseCustomersList.CurrentRow.Cells[1].Value.ToString();
                }
            }
            catch
            {
                return;
            }
        }

        private void chooseProvider_Click(object sender, EventArgs e)
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
            else
            {
                view.ShowDialog();
                if (Convert.ToInt32(view.dgvChooseProvidersList.CurrentRow.Cells[4].Value) < 1)
                {
                    MessageBox.Show("لا يوجد رصيد دائن لهذا المورد لخصم قيمة سند دفع جديد", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                txtProviderName.Text = view.dgvChooseProvidersList.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void PaperValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            char DecimalSeparator = e.KeyChar;
            if (DecimalSeparator == 46 && PaperValue.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!char.IsDigit(DecimalSeparator) && DecimalSeparator != 8 && DecimalSeparator != 46)
            {
                e.Handled = true;
            }
        }

        private void paidValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            char DecimalSeparator = e.KeyChar;
            if (DecimalSeparator == 46 && paidValue.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!char.IsDigit(DecimalSeparator) && DecimalSeparator != 8 && DecimalSeparator != 46)
            {
                e.Handled = true;
            }
        }

        private void txtsClear()
        {
            PaperValue.Clear();
            txtCustomerName.Clear();
            Paper1Notes.Clear();
            txtProviderName.Clear();
            paper2Notes.Clear();
            paidValue.Clear();
        }

        private void btnNewRecievedPaper_Click(object sender, EventArgs e)
        {
            SaveRecievedPaper.Enabled = true;
            btnUndo.Enabled = true;
            btnNewRecievedPaper.Enabled = false;
        }

        private void SaveRecievedPaper_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCustomerName.Text) || !string.IsNullOrWhiteSpace(PaperValue.Text))
            {
                dt = cus.searchCustomer(txtCustomerName.Text);
                pap.newPaper(paper1Type.Text, PaperValue.Text, recievedPaperDate.Value, Paper1Notes.Text,
                                Convert.ToInt32(dt.Rows[0][0].ToString()), Convert.ToInt32("0"), "A");

                txtsClear();
                btnNewRecievedPaper.Enabled = true;
                SaveRecievedPaper.Enabled = false;
                btnUndo.Enabled = false;
                MessageBox.Show("تم حفظ البيانات", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SavPaidPaper_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtProviderName.Text) || !string.IsNullOrWhiteSpace(paidValue.Text))
            {
                dt = prv.searchProvider(txtProviderName.Text);
                pap.newPaper(paper2Type.Text, paidValue.Text, PaidPaperDate.Value, paper2Notes.Text,
                    Convert.ToInt32("0"), Convert.ToInt32(dt.Rows[0][0].ToString()), "B");

                txtsClear();
                newPaidPaper.Enabled = true;
                SavPaidPaper.Enabled = false;
                undoPaper.Enabled = false;
                MessageBox.Show("تم حفظ البيانات", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void newPaidPaper_Click(object sender, EventArgs e)
        {
            SavPaidPaper.Enabled = true;
            undoPaper.Enabled = true;
            newPaidPaper.Enabled = false;
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            SaveRecievedPaper.Enabled = false;
            btnUndo.Enabled = false;
            btnNewRecievedPaper.Enabled = true;
        }

        private void undoPaper_Click(object sender, EventArgs e)
        {
            SavPaidPaper.Enabled = false;
            undoPaper.Enabled = false;
            newPaidPaper.Enabled = true;
            txtsClear();
        }

        private void tpRecievedPapers_Leave(object sender, EventArgs e)
        {
            try
            {
                txtsClear();
                btnUndo_Click(sender, e);
            }
            catch
            {
                return;
            }
        }

        private void tpPaidPapers_Leave(object sender, EventArgs e)
        {
            try
            {
                undoPaper_Click(sender, e);
            }
            catch
            {
                return;
            }
        }

        private void PaperValue_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(PaperValue.Text) > Convert.ToInt32(cus.searchCustomer(txtCustomerName.Text).Rows[0][3]))
                {
                    MessageBox.Show("قيمة أكبر من إجمالى القيمة المدين بها ...", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    PaperValue.Focus();
                    PaperValue.SelectionStart = 0;
                    PaperValue.SelectionLength = PaperValue.TextLength;
                    return;
                }
            }
            catch
            { return; }
        }

        private void paidValue_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(paidValue.Text) > Convert.ToInt32(prv.searchProvider(txtProviderName.Text).Rows[0][4]))
                {
                    MessageBox.Show("قيمة أكبر من إجمالى القيمة المدين بها ...", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    paidValue.Focus();
                    paidValue.SelectionStart = 0;
                    paidValue.SelectionLength = paidValue.TextLength;
                    return;
                }
            }
            catch
            { return; }
        }
    }
}
