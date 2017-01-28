using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace SalesManagement.View
{
    public partial class ReportsCategories : MetroForm
    {
        public ReportsCategories()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            View.DayReportsForm view = new DayReportsForm();
            view.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            View.MonthReports view = new MonthReports();
            view.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Movements view = new Movements();
            view.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Movements view = new Movements();
            view.Text = "حركة الشـــراء";
            view.label3.Text = "إجمالى المشتريات :";
            view.label4.Text = "إجمالى السداد :";
            view.label5.Text = "إجمالى المتبقى :";
            view.ShowDialog();
        }
    }
}
