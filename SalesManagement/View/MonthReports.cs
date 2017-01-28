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
    public partial class MonthReports : MetroForm
    {
        string dtmonth;

        Model._Reports rpt = new Model._Reports();
        DataTable dt = new DataTable();
        DataTable dtDGV = new DataTable();
        private string changeDgvData = "A";

        public MonthReports()
        {
            InitializeComponent();
        }

        private void dtMonth_ValueChanged(object sender, EventArgs e)
        {
            
            
        }

        private void btnShowSalesOrders_Click(object sender, EventArgs e)
        {
            changeDgvData = "A";
            dt.Clear();
            txtOrderNotes.Clear();
            txtsalesman2.Text = "";
            txtPerson.Text = "";
            dtmonth = dtMonth.Value.Year + "-0" + dtMonth.Value.Month.ToString();
            if (dtMonth.Value.Month > 9)
            { dtmonth = dtMonth.Value.Year + "-" + dtMonth.Value.Month.ToString(); }

            this.dgvMonthOrders.DataSource = rpt.MonthSalesOrders(dtmonth);

            this.txtSalesOrdersCount.Text = this.dgvMonthOrders.Rows.Count.ToString();

            this.txtSalesOrdersTotalCost.Text =
                ((from DataGridViewRow row in dgvMonthOrders.Rows
                          where (!string.IsNullOrWhiteSpace(row.Cells[4].FormattedValue.ToString()))
                          select Convert.ToDouble(row.Cells[4].FormattedValue)).Sum()).ToString();

            this.txtSalesOrdersTotalPaids.Text =
                ((from DataGridViewRow row in dgvMonthOrders.Rows
                  where (!string.IsNullOrWhiteSpace(row.Cells[5].FormattedValue.ToString()))
                  select Convert.ToDouble(row.Cells[5].FormattedValue)).Sum()).ToString();

            this.txtSalesOrdersTotalChange.Text =
                (from DataGridViewRow row in dgvMonthOrders.Rows
                 where (!string.IsNullOrWhiteSpace(row.Cells[6].FormattedValue.ToString()))
                 select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();
        }

        private void btnShowBuysOrders_Click(object sender, EventArgs e)
        {
            changeDgvData = "B";
            dt.Clear();
            txtOrderNotes.Clear();
            txtsalesman2.Text = "";
            txtPerson.Text = "";
            dtmonth = dtMonth.Value.Year + "-0" + dtMonth.Value.Month.ToString();
            if (dtMonth.Value.Month > 9)
            { dtmonth = dtMonth.Value.Year + "-" + dtMonth.Value.Month.ToString(); }

            this.dgvMonthOrders.DataSource = rpt.MonthBuysOrders(dtmonth);

            this.txtBuysOrdersCount.Text = this.dgvMonthOrders.Rows.Count.ToString();

            this.txtBuysOrdersTotalCost.Text = 
                ((from DataGridViewRow row in dgvMonthOrders.Rows
                          where (!string.IsNullOrWhiteSpace(row.Cells[4].FormattedValue.ToString()))
                          select Convert.ToDouble(row.Cells[4].FormattedValue)).Sum()).ToString();

            this.txtBuysOrdersTotaPaids.Text =
                ((from DataGridViewRow row in dgvMonthOrders.Rows
                  where (!string.IsNullOrWhiteSpace(row.Cells[5].FormattedValue.ToString()))
                  select Convert.ToDouble(row.Cells[5].FormattedValue)).Sum()).ToString();

            this.txtBuysOrdersTotalChange.Text =
                (from DataGridViewRow row in dgvMonthOrders.Rows
                 where (!string.IsNullOrWhiteSpace(row.Cells[6].FormattedValue.ToString()))
                 select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();
        }

        private void btnShowBackOrders_Click(object sender, EventArgs e)
        {
            changeDgvData = "C";
            dt.Clear();
            txtOrderNotes.Clear();
            txtsalesman2.Text = "";
            txtPerson.Text = "";
            dtmonth = dtMonth.Value.Year + "-0" + dtMonth.Value.Month.ToString();
            if (dtMonth.Value.Month > 9)
            { dtmonth = dtMonth.Value.Year + "-" + dtMonth.Value.Month.ToString(); }

            this.dgvMonthOrders.DataSource = rpt.MonthBackOrders(dtmonth);

            this.txtBackOrdersCount.Text = this.dgvMonthOrders.Rows.Count.ToString();

            this.txtBackOrdersTotalCost.Text = (from DataGridViewRow row in dgvMonthOrders.Rows
                                                where (!string.IsNullOrWhiteSpace(row.Cells[2].FormattedValue.ToString()))
                                                select Convert.ToDouble(row.Cells[2].FormattedValue)).Sum().ToString();
        }

        private void dgvMonthOrders_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //auto numbering header cell in datagridview
            if (dgvMonthOrders != null)
            {
                for (int i = 0; i < dgvMonthOrders.Rows.Count; i++)
                {
                    this.dgvMonthOrders.Rows[i].HeaderCell.Value = (i + 1).ToString();
                }
            }
        }

        private void dgvMonthOrders_Click(object sender, EventArgs e)
        {
            try
            {
                if (changeDgvData == "A")
                {
                    dt = rpt.MonthSalesOrdersDetailes(dtmonth, dgvMonthOrders.CurrentRow.Cells[1].Value.ToString());
                    dgvShowOrderDetailes.DataSource = dt;
                    dgvShowOrderDetailes.Columns[0].Visible = false;
                    dgvShowOrderDetailes.Columns[1].Visible = false;
                    dgvShowOrderDetailes.Columns[2].Visible = false;
                    dgvShowOrderDetailes.Columns[7].Visible = false;

                    person.Text = "العميل";
                    txtPerson.Text = dt.Rows[0][1].ToString();
                    txtSalesMan.Text = dt.Rows[0][2].ToString();
                    txtsalesman2.Text = dt.Rows[0][2].ToString();
                    txtOrderNotes.Text = dt.Rows[0][7].ToString();
                }
                if (changeDgvData == "B")
                {
                    dt = rpt.MonthBuysOrdersDetailes(dtmonth, dgvMonthOrders.CurrentRow.Cells[1].Value.ToString());
                    dgvShowOrderDetailes.DataSource = dt;
                    dgvShowOrderDetailes.Columns[0].Visible = false;
                    dgvShowOrderDetailes.Columns[1].Visible = false;
                    dgvShowOrderDetailes.Columns[2].Visible = false;
                    dgvShowOrderDetailes.Columns[7].Visible = false;


                    person.Text = dt.Rows[0][1].ToString();
                    person.Text = "المورد";
                    txtPerson.Text = dt.Rows[0][1].ToString();
                    txtsalesman2.Text = dt.Rows[0][2].ToString();
                    txtOrderNotes.Text = dt.Rows[0][7].ToString();
                    this.txtSalesMan.Text = dt.Rows[0][2].ToString();
                }

                if (changeDgvData == "C")
                {
                    dt = rpt.MonthBackOrdersDetailes(dtmonth, dgvMonthOrders.CurrentRow.Cells[1].Value.ToString());
                    dgvShowOrderDetailes.DataSource = dt;
                    dgvShowOrderDetailes.Columns[0].Visible = false;
                    dgvShowOrderDetailes.Columns[1].Visible = false;
                    dgvShowOrderDetailes.Columns[2].Visible = false;
                    dgvShowOrderDetailes.Columns[7].Visible = false;

                    person.Text = "العميل";
                    txtPerson.Text = dt.Rows[0][1].ToString();
                    txtsalesman2.Text = dt.Rows[0][2].ToString();
                    txtOrderNotes.Text = dt.Rows[0][7].ToString();
                    this.txtSalesMan.Text = dt.Rows[0][2].ToString();
                }

            }
            catch
            {
                return;
            }
        }

        private void btnPrintSalesOrders_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Reports.rpt_MonthSalesReports report = new Reports.rpt_MonthSalesReports();
            report.SetDatabaseLogon(Program.ID,
                                        Program.Password,
                                        Program.Server,
                                        Program.Database);
            Reports.ReportsViewer view = new Reports.ReportsViewer();
            report.SetDataSource(rpt.MonthSalesOrdersForPrint(dtmonth, "SO"));
            view.CRViewer.ReportSource = report;
            report.Refresh();
            view.ShowDialog();
            this.Cursor = Cursors.Default;
        }

        private void btnPrintBuysOrders_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Reports.rpt_MonthBuysReports report = new Reports.rpt_MonthBuysReports();
            report.SetDatabaseLogon(Program.ID,
                                        Program.Password,
                                        Program.Server,
                                        Program.Database);
            Reports.ReportsViewer view = new Reports.ReportsViewer();
            report.SetDataSource(rpt.MonthBuysOrdersForPrint(dtmonth, "BO"));
            view.CRViewer.ReportSource = report;
            report.Refresh();
            view.ShowDialog();
            this.Cursor = Cursors.Default;
        }

        private void btnBackOrdersPrint_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Reports.rpt_MonthBackReports report = new Reports.rpt_MonthBackReports();
            report.SetDatabaseLogon(Program.ID,
                                        Program.Password,
                                        Program.Server,
                                        Program.Database);
            Reports.ReportsViewer view = new Reports.ReportsViewer();
            report.SetDataSource(rpt.MonthBackOrdersForPrint(dtmonth, "RT"));
            view.CRViewer.ReportSource = report;
            report.Refresh();
            view.ShowDialog();
            this.Cursor = Cursors.Default;
        }
    }
}
