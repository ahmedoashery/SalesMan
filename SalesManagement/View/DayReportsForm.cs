using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using CrystalDecisions.ReportSource;
using CrystalDecisions.CrystalReports.Engine;
using System.IO;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using MetroFramework.Forms;

namespace SalesManagement.View
{
    public partial class DayReportsForm : MetroForm
    {
        Model._Reports rpt = new Model._Reports();
        DataTable dt = new DataTable();
        DataTable dtDGV = new DataTable();

        private string changeDgvData = "A";

        public DayReportsForm()
        {
            InitializeComponent();
        }

        void dgvResizeColumns()
        {
            this.dgvDayOrders.Columns[1].Width = 75;
            this.dgvDayOrders.Columns[2].Width = 120;
            this.dgvDayOrders.Columns[3].Width = 73;
            this.dgvDayOrders.Columns[4].Width = 73;
            this.dgvDayOrders.Columns[5].Width = 180;
        }

        private void btnPrintSalesOrders_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Reports.rpt_DayReports report = new Reports.rpt_DayReports();
            report.SetDatabaseLogon(Program.ID,
                                        Program.Password,
                                        Program.Server,
                                        Program.Database);
            Reports.ReportsViewer view = new Reports.ReportsViewer();
            report.SetDataSource(rpt.DaySalesOrders(dtdayreports.Value.Date, "SO"));
            view.CRViewer.ReportSource = report;
            report.Refresh();
            view.ShowDialog();
            this.Cursor = Cursors.Default;
        }

        private void btnShowSalesOrders_Click(object sender, EventArgs e)
        {
            changeDgvData = "A";
            dt.Clear();
            this.dgvDayOrders.DataSource = rpt.DaySalesOrders(dtdayreports.Value, "SO");
            dgvDayOrders.Columns[0].Visible = false;


            this.txtSalesOrdersCount.Text = this.dgvDayOrders.Rows.Count.ToString();

            this.txtSalesOrdersTotalCost.Text = ((from DataGridViewRow row in dgvDayOrders.Rows
                          where (!string.IsNullOrWhiteSpace(row.Cells[6].FormattedValue.ToString()))
                          select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum()).ToString();

            this.txtSalesOrdersTotalPaids.Text =
                ((from DataGridViewRow row in dgvDayOrders.Rows
                  where (!string.IsNullOrWhiteSpace(row.Cells[7].FormattedValue.ToString()))
                  select Convert.ToDouble(row.Cells[7].FormattedValue)).Sum()).ToString();

            this.txtSalesOrdersTotalChange.Text =
                (from DataGridViewRow row in dgvDayOrders.Rows
                 where (!string.IsNullOrWhiteSpace(row.Cells[8].FormattedValue.ToString()))
                 select Convert.ToDouble(row.Cells[8].FormattedValue)).Sum().ToString();
        }

        private void btnShowBuysOrders_Click(object sender, EventArgs e)
        {
            changeDgvData = "B";
            dt.Clear();
            this.dgvDayOrders.DataSource = rpt.DayBuysOrders(dtdayreports.Value, "BO");
            dgvDayOrders.Columns[0].Visible = false;
            
            this.txtBuysOrdersCount.Text = this.dgvDayOrders.Rows.Count.ToString();

            this.txtBuysOrdersTotalCost.Text =
                         ((from DataGridViewRow row in dgvDayOrders.Rows
                          where (!string.IsNullOrWhiteSpace(row.Cells[6].FormattedValue.ToString()))
                          select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum()).ToString();

            this.txtBuysOrdersTotaPaids.Text =
                ((from DataGridViewRow row in dgvDayOrders.Rows
                  where (!string.IsNullOrWhiteSpace(row.Cells[7].FormattedValue.ToString()))
                  select Convert.ToDouble(row.Cells[7].FormattedValue)).Sum()).ToString();

            this.txtBuysOrdersTotalChange.Text =
                (from DataGridViewRow row in dgvDayOrders.Rows
                 where (!string.IsNullOrWhiteSpace(row.Cells[8].FormattedValue.ToString()))
                 select Convert.ToDouble(row.Cells[8].FormattedValue)).Sum().ToString();
        }

        private void btnShowBackOrders_Click(object sender, EventArgs e)
        {
            changeDgvData = "C";
            dt.Clear();
            this.dgvDayOrders.DataSource = rpt.DayBackOrders(dtdayreports.Value, "RT");
            this.dgvDayOrders.Columns[0].Visible = false;

            this.txtBackOrdersCount.Text = this.dgvDayOrders.Rows.Count.ToString();

            this.txtBackOrdersTotalCost.Text = (from DataGridViewRow row in dgvDayOrders.Rows
                                                  where (!string.IsNullOrWhiteSpace(row.Cells[3].FormattedValue.ToString()))
                                                  select Convert.ToDouble(row.Cells[3].FormattedValue)).Sum().ToString();
        }

        private void btnPrintBuysOrders_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Reports.rpt_DayBuyReportss report = new Reports.rpt_DayBuyReportss();
            report.SetDatabaseLogon(Program.ID,
                                        Program.Password,
                                        Program.Server,
                                        Program.Database);
            Reports.ReportsViewer view = new Reports.ReportsViewer();
            report.SetDataSource(rpt.DayBuysOrders(dtdayreports.Value, "BO"));
            view.CRViewer.ReportSource = report;
            report.Refresh();
            view.ShowDialog();
            this.Cursor = Cursors.Default;
        }

        private void btnPrintBackOrders_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Reports.rpt_DayBackReports report = new Reports.rpt_DayBackReports();
            report.SetDatabaseLogon(Program.ID,
                                        Program.Password,
                                        Program.Server,
                                        Program.Database);
            Reports.ReportsViewer view = new Reports.ReportsViewer();
            report.SetDataSource(rpt.DayBackOrders(dtdayreports.Value.Date, "RT"));
            view.CRViewer.ReportSource = report;
            report.Refresh();
            view.ShowDialog();
            this.Cursor = Cursors.Default;
        }

        private void dgvDayOrders_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //auto numbering header cell in datagridview
            if (dgvDayOrders != null)
            {
                for (int i = 0; i < dgvDayOrders.Rows.Count; i++)
                {
                    this.dgvDayOrders.Rows[i].HeaderCell.Value = (i + 1).ToString();
                }
            }
        }

        private void dtdayreports_ValueChanged(object sender, EventArgs e)
        {
            dt.Clear();
            btnShowSalesOrders_Click(sender, e);
        }

        private void dgvDayOrders_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                OrderDetailes view = new OrderDetailes();
                if (changeDgvData == "A")
                {

                    dt = rpt.DaySalesOrdersDetailes(dtdayreports.Value, dgvDayOrders.CurrentRow.Cells[1].Value.ToString());
                    view.dgvShowOrders.DataSource = dt;
                    view.dgvShowOrders.Columns[0].Visible = false;
                    view.dgvShowOrders.Columns[1].Visible = false;
                    view.dgvShowOrders.Columns[2].Visible = false;
                    view.dgvShowOrders.Columns[7].Visible = false;
                    
                    view.OrderCode.Text = dgvDayOrders.CurrentRow.Cells[1].Value.ToString();
                    view.OrderSalesMan.Text = dt.Rows[0][1].ToString();
                    view.CustomerName.Text = dt.Rows[0][2].ToString();
                    view.txtOrderNotes.Text = dt.Rows[0][7].ToString();
                    view.ShowDialog();
                }
                if (changeDgvData == "B")
                {
                    dt = rpt.DayBuysOrdersDetailes(dtdayreports.Value, dgvDayOrders.CurrentRow.Cells[1].Value.ToString());
                    view.dgvShowOrders.DataSource = dt;
                    view.dgvShowOrders.Columns[0].Visible = false;
                    view.dgvShowOrders.Columns[1].Visible = false;
                    view.dgvShowOrders.Columns[2].Visible = false;
                    view.dgvShowOrders.Columns[6].Visible = false;

                    view.OrderSalesMan.Text = dt.Rows[0][1].ToString();
                    view.OrderCode.Text = dgvDayOrders.CurrentRow.Cells[1].Value.ToString();
                    view.CustomerName.Text = dt.Rows[0][2].ToString();
                    view.label3.Text = "المورد :";
                    view.txtOrderNotes.Text = dt.Rows[0][6].ToString();
                    
                    view.ShowDialog();
                }

                if (changeDgvData == "C")
                {
                    dt = rpt.DayBackOrdersDetailes(dtdayreports.Value, dgvDayOrders.CurrentRow.Cells[1].Value.ToString());
                    view.dgvShowOrders.DataSource = dt;
                    view.dgvShowOrders.Columns[0].Visible = false;
                    view.OrderCode.Text = dgvDayOrders.CurrentRow.Cells[1].Value.ToString();
                    view.CustomerName.Text = dgvDayOrders.CurrentRow.Cells[2].Value.ToString();
                    view.txtOrderNotes.Text = dgvDayOrders.CurrentRow.Cells[4].Value.ToString();
                    view.OrderSalesMan.Text = dgvDayOrders.CurrentRow.Cells[5].Value.ToString();
                    view.ShowDialog();
                }

            }
            catch
            {
                return;
            }
        }

    }
}
