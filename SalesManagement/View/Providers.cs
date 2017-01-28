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
    public partial class Providers : MetroForm
    {
        Model._Providers prv = new Model._Providers();

        public Providers()
        {
            InitializeComponent();
            dgvChooseProvidersList.DataSource = prv.listProviders();
            dgvChooseProvidersList.Columns[0].Visible = false;
            dgvChooseProvidersList.Columns[2].Visible = false;
            dgvChooseProvidersList.Columns[3].Visible = false;
            //dgvChooseProvidersList.Columns[4].Visible = false;
            //dgvChooseProvidersList.Columns[5].Visible = false;
        }

        private void dgvChooseProvidersList_DoubleClick(object sender, EventArgs e)
        {
            if (dgvChooseProvidersList == null)
            {
                return;
            }

            Close();
        }

        // auto rows headers numbering
        private void dgvChooseProvidersList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dgvChooseProvidersList != null)
            {
                for (int i = 0; i < dgvChooseProvidersList.Rows.Count; i++)
                {
                    dgvChooseProvidersList.Rows[i].HeaderCell.Value = (i + 1).ToString();
                }
            }
        }

        private void txtSearchProvider_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSearchProvider.Text))
            {
                dgvChooseProvidersList.DataSource = prv.searchProvider(txtSearchProvider.Text);
                if ((dgvChooseProvidersList.Rows.Count) <= 0)
                {
                    return;
                }
            }
            else
            {
                txtSearchProvider.Focus();
                dgvChooseProvidersList.DataSource = prv.listProviders();
                return;
            }
        }
    }
}
