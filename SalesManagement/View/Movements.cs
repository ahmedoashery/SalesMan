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
    public partial class Movements : MetroForm
    {

        Model._Reports rpt = new Model._Reports();

        public Movements()
        {
            InitializeComponent();
        }

        private void date2_ValueChanged(object sender, EventArgs e)
        {
            if (this.Text == "    حركة البيع")
            {
                this.dgvSalesMovements.DataSource = rpt.SalesMovements(date1.Value, date2.Value);

                this.txtTotalCost.Text =
                    (from DataGridViewRow row in dgvSalesMovements.Rows
                     where (!string.IsNullOrWhiteSpace(row.Cells[5].FormattedValue.ToString()))
                     select Convert.ToDouble(row.Cells[5].FormattedValue)).Sum().ToString();

                this.txtTotalPaids.Text =
                    (from DataGridViewRow row in dgvSalesMovements.Rows
                     where (!string.IsNullOrWhiteSpace(row.Cells[6].FormattedValue.ToString()))
                     select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();

                this.txtTotalChange.Text =
                    (from DataGridViewRow row in dgvSalesMovements.Rows
                     where (!string.IsNullOrWhiteSpace(row.Cells[7].FormattedValue.ToString()))
                     select Convert.ToDouble(row.Cells[7].FormattedValue)).Sum().ToString();
            }
            else
            {
                this.dgvSalesMovements.DataSource = rpt.BuysMovements(date1.Value, date2.Value);

                this.txtTotalCost.Text =
                    (from DataGridViewRow row in dgvSalesMovements.Rows
                     where (!string.IsNullOrWhiteSpace(row.Cells[5].FormattedValue.ToString()))
                     select Convert.ToDouble(row.Cells[5].FormattedValue)).Sum().ToString();

                this.txtTotalPaids.Text =
                    (from DataGridViewRow row in dgvSalesMovements.Rows
                     where (!string.IsNullOrWhiteSpace(row.Cells[6].FormattedValue.ToString()))
                     select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();

                this.txtTotalChange.Text =
                    (from DataGridViewRow row in dgvSalesMovements.Rows
                     where (!string.IsNullOrWhiteSpace(row.Cells[7].FormattedValue.ToString()))
                     select Convert.ToDouble(row.Cells[7].FormattedValue)).Sum().ToString();
            }
        }

        private void date1_ValueChanged(object sender, EventArgs e)
        {
            date2_ValueChanged(sender, e);
        }
    }
}
