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
    public partial class PersonAccountInfo : MetroForm
    {

        Model._Customers cus = new Model._Customers();
        Model._Providers prv = new Model._Providers();
        Model._Reports rpt = new Model._Reports();
        Model._Accounts acc = new Model._Accounts();

        public PersonAccountInfo()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPersonsList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // auto numbering
            if (dgvPersonsList != null)
            {
                for (int r = 0; r < dgvPersonsList.Rows.Count; r++)
                {
                    dgvPersonsList.Rows[r].HeaderCell.Value = (r + 1).ToString();
                    dgvPersonsList.Refresh();
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (this.Text == "   كشف حساب العملاء")
            {
                if (!string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    this.dgvPersonsList.DataSource = cus.searchCustomer(txtSearch.Text);
                    this.dgvPersonsList.Columns[0].Visible = false;
                    this.dgvPersonsList.Columns[2].Visible = false;
                    this.dgvPersonsList.Columns[3].Visible = false;
                    this.dgvPersonsList.Columns[4].Visible = false;
                    this.dgvPersonsList.Columns[5].Visible = false;
                }
                else
                    this.dgvPersonsList.DataSource = cus.searchCustomer(txtSearch.Text);
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    this.dgvPersonsList.DataSource = prv.searchProvider(txtSearch.Text);
                    this.dgvPersonsList.Columns[0].Visible = false;
                    this.dgvPersonsList.Columns[2].Visible = false;
                    this.dgvPersonsList.Columns[3].Visible = false;
                    this.dgvPersonsList.Columns[4].Visible = false;
                    this.dgvPersonsList.Columns[5].Visible = false;
                    this.dgvPersonsList.Columns[6].Visible = false;
                }
                else
                    this.dgvPersonsList.DataSource = prv.searchProvider(txtSearch.Text);
            }
        }

        private void dgvPersonsList_Click(object sender, EventArgs e)
        {
            if (dgvPersonsList == null || dgvPersonsList.Rows.Count <= 0)
            {
                return;
            }
            btnPrintAccount.Enabled = true;
            if (this.Text == "   كشف حساب العملاء")
            {
                PersonName.Text = dgvPersonsList.CurrentRow.Cells[1].Value.ToString();
                PersonAccountNum.Text = dgvPersonsList.CurrentRow.Cells[2].Value.ToString();
                TotalChange.Text = dgvPersonsList.CurrentRow.Cells[3].Value.ToString();
                TotalPayments.Text = dgvPersonsList.CurrentRow.Cells[4].Value.ToString();
                TotalCost.Text = dgvPersonsList.CurrentRow.Cells[5].Value.ToString();

                // get account orders
                int cusId = Convert.ToInt32(dgvPersonsList.CurrentRow.Cells[0].Value);
                dgvPersonAccountInfo.DataSource = acc.CustomerAccountOrders(cusId);

            }
            else
            {
                PersonName.Text = dgvPersonsList.CurrentRow.Cells[1].Value.ToString();
                PersonAccountNum.Text = dgvPersonsList.CurrentRow.Cells[3].Value.ToString();
                TotalChange.Text = dgvPersonsList.CurrentRow.Cells[4].Value.ToString();
                TotalPayments.Text = dgvPersonsList.CurrentRow.Cells[5].Value.ToString();
                TotalCost.Text = dgvPersonsList.CurrentRow.Cells[6].Value.ToString();

                // get account detailes
                int prvId = Convert.ToInt32(dgvPersonsList.CurrentRow.Cells[0].Value);
                dgvPersonAccountInfo.DataSource = acc.ProviderAccountOrders(prvId);
            }
        }

        private void PersonAccountInfo_Load(object sender, EventArgs e)
        {
            if (this.Text == "   كشف حساب العملاء")
            {
                this.dgvPersonsList.DataSource = cus.listCustomers();
                this.dgvPersonsList.Columns[0].Visible = false;
                this.dgvPersonsList.Columns[2].Visible = false;
                this.dgvPersonsList.Columns[3].Visible = false;
                this.dgvPersonsList.Columns[4].Visible = false;
                this.dgvPersonsList.Columns[5].Visible = false;
            }
            else
            {
                this.dgvPersonsList.DataSource = prv.listProviders();
                this.dgvPersonsList.Columns[0].Visible = false;
                this.dgvPersonsList.Columns[2].Visible = false;
                this.dgvPersonsList.Columns[3].Visible = false;
                this.dgvPersonsList.Columns[4].Visible = false;
                this.dgvPersonsList.Columns[5].Visible = false;
                this.dgvPersonsList.Columns[6].Visible = false;
            }
        }

        private void dgvPersonAccountInfo_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // auto numbering
            if (dgvPersonAccountInfo != null)
            {
                for (int r = 0; r < dgvPersonAccountInfo.Rows.Count; r++)
                {
                    dgvPersonAccountInfo.Rows[r].HeaderCell.Value = (r + 1).ToString();
                    dgvPersonAccountInfo.Refresh();
                }
            }
        }

        private void btnPrintAccount_Click(object sender, EventArgs e)
        {
            if (this.Text == "   كشف حساب العملاء")
            {
                this.Cursor = Cursors.WaitCursor;
                int cusId = Convert.ToInt32(dgvPersonsList.CurrentRow.Cells[0].Value);
                Reports.ReportsViewer view = new Reports.ReportsViewer();
                Reports.rpt_CustomerPapersReport subreport = new Reports.rpt_CustomerPapersReport();
                Reports.rpt_CustomerAccountReport report = new Reports.rpt_CustomerAccountReport();
                report.SetDatabaseLogon(Program.ID,
                                        Program.Password,
                                        Program.Server,
                                        Program.Database);
                report.SetDataSource(acc.CustomerAccountDetailes(cusId));
                subreport.SetDataSource(acc.CustomerPapersDetailes(cusId));
                view.CRViewer.ReportSource = report;
                report.Refresh();
                view.ShowDialog();
                this.Cursor = Cursors.Default;
            }
            else
            {
                this.Cursor = Cursors.WaitCursor;
                int prvId = Convert.ToInt32(dgvPersonsList.CurrentRow.Cells[0].Value);
                Reports.ReportsViewer view = new Reports.ReportsViewer();
                Reports.rpt_ProviderAccountReport report = new Reports.rpt_ProviderAccountReport();
                report.SetDatabaseLogon(Program.ID,
                                        Program.Password,
                                        Program.Server,
                                        Program.Database);
                Reports.rpt_ProviderrPapersReport subreport = new Reports.rpt_ProviderrPapersReport();
                report.SetDataSource(acc.ProviderAccountDetailes(prvId));
                subreport.SetDataSource(acc.ProviderPapersDetailes(prvId));
                view.CRViewer.ReportSource = report;
                report.Refresh();
                view.ShowDialog();
                this.Cursor = Cursors.Default;
            }
        }
    }
}
