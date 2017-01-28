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
    public partial class Customers : MetroForm
    {
        Model._Customers cus = new Model._Customers();

        public Customers()
        {
            InitializeComponent();
            dgvChooseCustomersList.DataSource = cus.listCustomers();
            dgvChooseCustomersList.Columns[0].Visible = false;
            dgvChooseCustomersList.Columns[2].Visible = false;
            //dgvChooseCustomersList.Columns[4].Visible = false;
            dgvChooseCustomersList.Columns[5].Visible = false;
        }

        private void dgvChooseCustomersList_DoubleClick(object sender, EventArgs e)
        {
            if (dgvChooseCustomersList == null)
            {
                return;
            }

            Close();
        }

        // auto headers numbering
        private void dgvChooseCustomersList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dgvChooseCustomersList != null)
            {
                for (int i = 0; i < dgvChooseCustomersList.Rows.Count; i++)
                {
                    dgvChooseCustomersList.Rows[i].HeaderCell.Value = (i + 1).ToString();
                }
            }
        }

        private void txtSearchCustomer_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSearchCustomer.Text))
            {
                dgvChooseCustomersList.DataSource = cus.searchCustomer(txtSearchCustomer.Text);

                if ((dgvChooseCustomersList.Rows.Count) <= 0)
                {
                    txtSearchCustomer.Focus();
                    return;
                }
            }
            else
            {
                txtSearchCustomer.Focus();
                dgvChooseCustomersList.DataSource = cus.listCustomers();
                return;
            }
        }
    }
}
