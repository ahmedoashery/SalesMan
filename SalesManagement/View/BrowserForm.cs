using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Management;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System.Runtime.InteropServices;
using MetroFramework.Components;
using MetroFramework.Forms;
using MetroFramework;


namespace SalesManagement.View
{
    public partial class BrowserForm : Form
    {
        Model.DB_access db = new Model.DB_access();

        DataTable dt = new DataTable();

        OpenFileDialog restore = new OpenFileDialog();
        SqlCommand cmd;

        //Single Instance
        private static BrowserForm frm;

        // form close event fire
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }

        public static BrowserForm getMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new BrowserForm();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }

        // constructor
        public BrowserForm()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;

            statusCurrentUser.BackColor = Color.Transparent;
            statusCurrentUser.Text = "المستخدم الحالى : " + Program.SalesMan; ;
        }

        

        private void BrowserForm_Load(object sender, EventArgs e)
        {
            Login.getMainForm.Visible = false;

            // load permissions for logged in user
            setPermissionsForLoggedInUser();
        }

        // set permissions for logged in user
        public void setPermissionsForLoggedInUser()
        {
            
            Permissions perm = new Permissions();
            perm.getUserPermissions(Program.UserID);

            if (Program.Sale == true)
            {
                btnSaleOrder.Enabled = true;
                بيـــعToolStripMenuItem.Enabled = true;
            }
            else
            {
                btnSaleOrder.Enabled = false;
                بيـــعToolStripMenuItem.Enabled = false;
            }

            if (Program.Buy == true)
            {
                btnBuyOrder.Enabled = true;
                شــــراءToolStripMenuItem.Enabled = true;
            }
            else
            {
                btnBuyOrder.Enabled = false;
                شــــراءToolStripMenuItem.Enabled = false;
            }

            if (Program.Backup == true)
            {
                نسخاحتياطىToolStripMenuItem.Enabled = true;
            }
            else
            {
                نسخاحتياطىToolStripMenuItem.Enabled = false;
            }

            if (Program.Restore == true)
            {
                استعادةToolStripMenuItem1.Enabled = true;
            }
            else
            {
                استعادةToolStripMenuItem1.Enabled = false;
            }

            if (Program.Back == true)
            {
                ادخالمرتجعاتToolStripMenuItem.Enabled = true;
            }
            else
            {
                ادخالمرتجعاتToolStripMenuItem.Enabled = false;
            }

            if (Program.Customers == true)
            {
                btnCustomers.Enabled = true;
                عمـــلاءToolStripMenuItem.Enabled = true;
            }
            else
            {
                btnCustomers.Enabled = false;
                عمـــلاءToolStripMenuItem.Enabled = false;
            }

            if (Program.Providers == true)
            {
                btnProviders.Enabled = true;
                مــورديـــــنToolStripMenuItem.Enabled = true;
            }
            else
            {
                btnProviders.Enabled = false;
                مــورديـــــنToolStripMenuItem.Enabled = false;
            }

            if (Program.Products == true)
            {
                btnCategories.Enabled = true;
                إدارةالأصنافToolStripMenuItem.Enabled = true;
            }
            else
            {
                btnCategories.Enabled = false;
                إدارةالأصنافToolStripMenuItem.Enabled = false;
            }

            if (Program.Reports == true)
            {
                btnReports.Enabled = true;
                معلوماتToolStripMenuItem.Enabled = true;
            }
            else
            {
                btnReports.Enabled = false;
                معلوماتToolStripMenuItem.Enabled = false;
            }

            if (Program.Papers == true)
            {
                btnWorkSpace.Enabled = true;
                WorkSpaceItemMenu.Enabled = true;
            }
            else
            {
                btnWorkSpace.Enabled = false;
                WorkSpaceItemMenu.Enabled = false;
            }

            if (Program.Settings == true)
            {
                btnSettings.Enabled = true;
                اعداداتToolStripMenuItem2.Enabled = true;
            }
            else
            {
                btnSettings.Enabled = false;
                اعداداتToolStripMenuItem2.Enabled = false;
            }

            if (Program.Expenses == true)
            {
                مصروفاتToolStripMenuItem.Enabled = true;
            }
            else
            {
                مصروفاتToolStripMenuItem.Enabled = false;
            }
        }


        // buttons
        private void btnSaleOrder_Click_1(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            NewOrder viewForm = null;
            if (viewForm == null)
            {
                viewForm = new NewOrder();

                if (this.ActiveMdiChild != null)
                    this.ActiveMdiChild.Close();

                viewForm.MdiParent = this;
            }
            viewForm.Show();

            Cursor.Current = Cursors.Default;
        }

        private void btnBuyOrder_Click_1(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            NewOrder viewForm = null;
            if (viewForm == null)
            {
                viewForm = new NewOrder();

                if (this.ActiveMdiChild != null)
                    this.ActiveMdiChild.Close();

                viewForm.MdiParent = this;

            }
            viewForm.OrderLabel.Text = "فـــاتـورة شـــراء";
            viewForm.label9.Text = "من السيد:";
            viewForm.btnChooseCustomer.Text = "اختر مورد";
            viewForm.Show();

            Cursor.Current = Cursors.Default;
        }

        private void btnProviders_Click_1(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            ProvidersManagement viewForm = null;
            if (viewForm == null)
            {
                viewForm = new ProvidersManagement();

                if (this.ActiveMdiChild != null)
                    this.ActiveMdiChild.Close();

                viewForm.MdiParent = this;
            }
            viewForm.Show();

            Cursor.Current = Cursors.Default;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            Settings viewForm = null;
            if (viewForm == null)
            {
                viewForm = new Settings();

                if (this.ActiveMdiChild != null)
                    this.ActiveMdiChild.Close();

                viewForm.MdiParent = this;
            }
            viewForm.Show();

            Cursor.Current = Cursors.Default;
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            CustomersManagement viewForm = null;
            if (viewForm == null)
            {
                viewForm = new CustomersManagement();

                if (this.ActiveMdiChild != null)
                    this.ActiveMdiChild.Close();

                viewForm.MdiParent = this;
            }
            viewForm.Show();

            Cursor.Current = Cursors.Default;
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            Products viewForm = null;
            if (viewForm == null)
            {
                viewForm = new Products();

                if (this.ActiveMdiChild != null)
                    this.ActiveMdiChild.Close();

                viewForm.MdiParent = this;
            }
            viewForm.Show();

            Cursor.Current = Cursors.Default;
        }

        private void btnWorkSpace_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            Papers viewForm = null;
            if (viewForm == null)
            {
                viewForm = new Papers();

                if (this.ActiveMdiChild != null)
                    this.ActiveMdiChild.Close();

                viewForm.MdiParent = this;
            }
            viewForm.Show();

            Cursor.Current = Cursors.Default;
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            ReportsCategories viewForm = null;
            if (viewForm == null)
            {
                viewForm = new ReportsCategories();

                if (this.ActiveMdiChild != null)
                    this.ActiveMdiChild.Close();

                viewForm.MdiParent = this;
            }
            viewForm.Show();

            Cursor.Current = Cursors.Default;
        }


        // tool strips
        private void خروجToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void اعداداتToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            btnSettings_Click(sender, e);
        }

        private void بيـــعToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnSaleOrder_Click_1(sender, e);
        }

        private void شــــراءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnBuyOrder_Click_1(sender, e);
        }

        private void إدارةالأصنافToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnCategories_Click(sender, e);
        }

        private void إدارةالعملاءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnCustomers_Click(sender, e);
        }

        private void إدارةالموردينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnProviders_Click_1(sender, e);
        }

        private void نسخاحتياطىToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackupData();
        }

        // backup action
        public void BackupData()
        {
            try
            {

                if (this.ActiveMdiChild != null)
                    this.ActiveMdiChild.Close();

                FolderBrowserDialog ofd = new FolderBrowserDialog();

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    string path = ofd.SelectedPath +
                                                    "\\Backups\\" +
                                                    DateTime.Now.ToString("yyyy") +
                                                    "\\" +
                                                    DateTime.Now.ToString("MMMM");
                    Directory.CreateDirectory(path);
                    // now copy database files
                    db.backup(path);

                    MessageBox.Show("تم حفظ البيانات", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Cursor = Cursors.Default;
                }
            }
            catch
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show(" \n لا توجد صلاحيات كافية \n", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void استعادةToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ActiveMdiChild != null)
                    this.ActiveMdiChild.Close();

                restore.Filter = "Backup Files(*.bak)|*.bak;";
                restore.FilterIndex = 0;

                if (restore.ShowDialog() == DialogResult.OK)
                {
                    this.Cursor = Cursors.WaitCursor;

                    string filePath = restore.FileName;
                    string databaseName = Program.Database;

                    string strQuery = "ALTER Database " + databaseName
                                    + " SET OFFLINE WITH ROLLBACK IMMEDIATE; Restore Database "
                                    + databaseName + " From Disk='" + filePath + "'";

                    
                    db.OpenConn();

                    cmd = new SqlCommand(strQuery, db.DBConnection);
                    cmd.ExecuteNonQuery();
                    
                    db.CloseConn();

                    MessageBox.Show("تم استعادة البيانات بنجاح ! ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Cursor = Cursors.Default;
                }
            }
            catch
            {
                MessageBox.Show("فشل فى استعادة البيانات المحفوظة", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Cursor = Cursors.Default;
                return;
            }
        }

        private void ادخالمرتجعاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            BackProducts viewForm = null;
            if (viewForm == null)
            {
                viewForm = new BackProducts();

                if (this.ActiveMdiChild != null)
                    this.ActiveMdiChild.Close();

                viewForm.MdiParent = this;
            }
            viewForm.Show();

            Cursor.Current = Cursors.Default;
        }

        private void جرداليوميةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            View.DayReportsForm viewForm = null;
            if (viewForm == null)
            {
                viewForm = new DayReportsForm();

                if (this.ActiveMdiChild != null)
                    this.ActiveMdiChild.Close();

                viewForm.MdiParent = this;
            }
            viewForm.Show();

            Cursor.Current = Cursors.Default;
        }

        private void جردسنوىToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            MonthReports viewForm = null;
            if (viewForm == null)
            {
                viewForm = new MonthReports();

                if (this.ActiveMdiChild != null)
                    this.ActiveMdiChild.Close();

                viewForm.MdiParent = this;
            }
            viewForm.Show();

            Cursor.Current = Cursors.Default;
        }

        private void حركةالبيـــعToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            Movements viewForm = null;
            if (viewForm == null)
            {
                viewForm = new Movements();

                if (this.ActiveMdiChild != null)
                    this.ActiveMdiChild.Close();

                viewForm.MdiParent = this;
            }
            viewForm.Show();

            Cursor.Current = Cursors.Default;
        }

        private void حركةالشـــراءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            Movements viewForm = null;
            if (viewForm == null)
            {
                viewForm = new Movements();

                if (this.ActiveMdiChild != null)
                    this.ActiveMdiChild.Close();

                viewForm.MdiParent = this;
            }
            viewForm.Text = "حركة الشـــراء";
            viewForm.label3.Text = "إجمالى المشتريات :";
            viewForm.label4.Text = "إجمالى السداد :";
            viewForm.label5.Text = "إجمالى المتبقى :";
            viewForm.Show();

            Cursor.Current = Cursors.Default;
        }

        private void كشفحسابعميلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            PersonAccountInfo viewForm = null;
            if (viewForm == null)
            {
                viewForm = new PersonAccountInfo();

                if (this.ActiveMdiChild != null)
                    this.ActiveMdiChild.Close();

                viewForm.MdiParent = this;
            }
            viewForm.Show();

            Cursor.Current = Cursors.Default;
        }

        private void كشفحسابموردToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            PersonAccountInfo viewForm = null;
            if (viewForm == null)
            {
                viewForm = new PersonAccountInfo();

                if (this.ActiveMdiChild != null)
                    this.ActiveMdiChild.Close();

                viewForm.MdiParent = this;
            }
            viewForm.Text = "كشف حساب الموردين";
            viewForm.groupBox1.Text = "قائمة الموردين";
            viewForm.label1.Text = "اسم المورد / الشركة :";
            viewForm.Show();

            Cursor.Current = Cursors.Default;
        }

        private void بياناتالعملاءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            Reports.ReportsViewer view = new Reports.ReportsViewer();
            Reports.rpt_AllCustomersDetailes report = new Reports.rpt_AllCustomersDetailes();
            report.SetDatabaseLogon(Program.ID,
                                        Program.Password,
                                        Program.Server,
                                        Program.Database);
            
            view.CRViewer.ReportSource = report;
            view.ShowDialog();

            Cursor = Cursors.Default;
        }

        private void بياناتالموردينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            Reports.ReportsViewer view = new Reports.ReportsViewer();
            Reports.rpt_AllProvidersDetailes report = new Reports.rpt_AllProvidersDetailes();
            report.SetDatabaseLogon(Program.ID,
                                        Program.Password,
                                        Program.Server,
                                        Program.Database);

            view.CRViewer.ReportSource = report;
            view.ShowDialog();

            Cursor = Cursors.Default;
        }

        private void عنالبرنامجToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AboutHelpe view = new AboutHelpe();
            view.ShowDialog();
        }

        private void WorkSpaceItemMenu_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            Papers viewForm = null;
            if (viewForm == null)
            {
                viewForm = new Papers();

                if (this.ActiveMdiChild != null)
                    this.ActiveMdiChild.Close();

                viewForm.MdiParent = this;
            }
            viewForm.Show();

            Cursor.Current = Cursors.Default;
        }

        private void DataBackupForPeriod_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            Database viewForm = null;
            if (viewForm == null)
            {
                viewForm = new Database();

                if (this.ActiveMdiChild != null)
                    this.ActiveMdiChild.Close();

                viewForm.MdiParent = this;
            }
            viewForm.Show();

            Cursor.Current = Cursors.Default;
        }

        private void BrowserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AutoBackup view = new AutoBackup();
            view.Show();
        }

        private void مصروفاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            Expenses viewForm = null;
            if (viewForm == null)
            {
                viewForm = new Expenses();

                if (this.ActiveMdiChild != null)
                    this.ActiveMdiChild.Close();

                viewForm.MdiParent = this;
            }
            viewForm.Show();

            Cursor.Current = Cursors.Default;
        }
    }
}
