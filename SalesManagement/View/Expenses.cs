using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SalesManagement.View
{
    public partial class Expenses : MetroForm
    {
        Model._Expenses exp = new Model._Expenses();

        public Expenses()
        {
            InitializeComponent();
            // get all expenses
            dgvExpenses.DataSource = exp.getAllExpenses();

            // initialize safe money for first time
            if (exp.getMoneyInSafe().Rows.Count <= 0)
                exp.initializeSafeMoney(Convert.ToDouble(0));

            txtMoneyInSafe.Text = exp.getMoneyInSafe().Rows[0][0].ToString();

            txtBy.Text = Program.SalesMan;
        }

        private void txtExpenseAmmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char DecimalSeparator = e.KeyChar;
            if (DecimalSeparator == 46 && txtExpenseAmmount.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!char.IsDigit(DecimalSeparator) && DecimalSeparator != 8 && DecimalSeparator != 46)
            {
                e.Handled = true;
            }
        }

        private void txtMoneyInSafe_KeyPress(object sender, KeyPressEventArgs e)
        {
            char DecimalSeparator = e.KeyChar;
            if (DecimalSeparator == 46 && txtMoneyInSafe.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!char.IsDigit(DecimalSeparator) && DecimalSeparator != 8 && DecimalSeparator != 46)
            {
                e.Handled = true;
            }
        }

        private void btnSaveExpense_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtExpenseAmmount.Text) && !string.IsNullOrWhiteSpace(txtExpenseDesc.Text))
            {
                exp.newExpense(Convert.ToDouble(txtExpenseAmmount.Text),
                               txtExpenseDesc.Text,
                               Convert.ToDateTime(dtExpense.Text),
                               txtBy.Text,
                               Convert.ToDouble(txtMoneyInSafe.Text));

                txtExpenseAmmount.Clear();
                txtExpenseDesc.Clear();
                
                dgvExpenses.DataSource = exp.getAllExpenses();
                txtMoneyInSafe.Text = exp.getMoneyInSafe().Rows[0][0].ToString();
            }
            else
            {
                txtExpenseAmmount.Focus();
                txtExpenseAmmount.SelectionStart = 0;
                txtExpenseAmmount.SelectionLength = txtExpenseAmmount.TextLength;
                return;
            }
        }
    }
}
