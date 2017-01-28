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
    public partial class Permissions : MetroForm
    {
        // instances...
        //========================
        Model._Users user = new Model._Users();

        BrowserForm form = new BrowserForm();

        DataTable forms = new DataTable();

        DataTable perms = new DataTable();
        
        // constructor
        public Permissions()
        {
            InitializeComponent();
            
            // get all forms initially
            forms = user.getAllForms();
        }

        // select user
        private void cb_users_list_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;

            gbPermissionsList.Enabled = true;

            // run getUserPermissions() here
            getUserPermissions(Convert.ToInt32(cb_users_list.SelectedValue));

            Cursor.Current = Cursors.Default;
        }

        // bind stored permisions for selected user
        public void getUserPermissions(int user_id)
        {
            try
            {
                perms = user.getUserPermissions(user_id, 1);
                if (perms.Rows[0][1].ToString() == "True")
                {
                    SalePerm.Checked = true;
                    Program.Sale = true;
                }
                else
                {
                    SalePerm.Checked = false;
                    Program.Sale = false;
                }

                perms = user.getUserPermissions(user_id, 2);
                if (perms.Rows[0][1].ToString() == "True")
                {
                    BuyPerm.Checked = true;
                    Program.Buy = true;
                }
                else
                {
                    BuyPerm.Checked = false;
                    Program.Buy = false;
                }

                perms = user.getUserPermissions(user_id, 3);
                if (perms.Rows[0][1].ToString() == "True")
                {
                    BackupPerm.Checked = true;
                    Program.Backup = true;
                }
                else
                {
                    BackupPerm.Checked = false;
                    Program.Backup = false;
                }

                perms = user.getUserPermissions(user_id, 4);
                if (perms.Rows[0][1].ToString() == "True")
                {
                    RestorePerm.Checked = true;
                    Program.Restore = true;
                }
                else
                {
                    RestorePerm.Checked = false;
                    Program.Restore = false;
                }

                perms = user.getUserPermissions(user_id, 5);
                if (perms.Rows[0][1].ToString() == "True")
                {
                    BackPerm.Checked = true;
                    Program.Back = true;
                }
                else
                {
                    BackPerm.Checked = false;
                    Program.Back = false;
                }

                perms = user.getUserPermissions(user_id, 6);
                if (perms.Rows[0][1].ToString() == "True")
                {
                    CustomersPerm.Checked = true;
                    Program.Customers = true;
                }
                else
                {
                    CustomersPerm.Checked = false;
                    Program.Customers = false;
                }

                perms = user.getUserPermissions(user_id, 7);
                if (perms.Rows[0][1].ToString() == "True")
                {
                    ProvidersPerm.Checked = true;
                    Program.Providers = true;
                }
                else
                {
                    ProvidersPerm.Checked = false;
                    Program.Providers = false;
                }

                perms = user.getUserPermissions(user_id, 8);
                if (perms.Rows[0][1].ToString() == "True")
                {
                    ProductsPerm.Checked = true;
                    Program.Products = true;
                }
                else
                {
                    ProductsPerm.Checked = false;
                    Program.Products = false;
                }

                perms = user.getUserPermissions(user_id, 9);
                if (perms.Rows[0][1].ToString() == "True")
                {
                    ReportsPerm.Checked = true;
                    Program.Reports = true;
                }
                else
                {
                    ReportsPerm.Checked = false;
                    Program.Reports = false;
                }

                perms = user.getUserPermissions(user_id, 10);
                if (perms.Rows[0][1].ToString() == "True")
                {
                    PapersPerm.Checked = true;
                    Program.Papers = true;
                }
                else
                {
                    PapersPerm.Checked = false;
                    Program.Papers = false;
                }

                perms = user.getUserPermissions(user_id, 11);
                if (perms.Rows[0][1].ToString() == "True")
                {
                    SettingsPerm.Checked = true;
                    Program.Settings = true;
                }
                else
                {
                    SettingsPerm.Checked = false;
                    Program.Settings = false;
                }

                perms = user.getUserPermissions(user_id, 12);
                if (perms.Rows[0][1].ToString() == "True")
                {
                    ExpensesPerm.Checked = true;
                    Program.Expenses = true;
                }
                else
                {
                    ExpensesPerm.Checked = false;
                    Program.Expenses = false;
                }
            }
            catch { return; }
        }

        private void cb_users_list_Click(object sender, EventArgs e)
        {
            // list users
            Cursor.Current = Cursors.Hand;

            cb_users_list.DataSource = user.listUsers();
            cb_users_list.DisplayMember = "اسم المستخدم";
            cb_users_list.ValueMember = "usr_id";

            Cursor.Current = Cursors.Default;
        }

        // save changes
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                user.UpdateUserPermissions(Convert.ToInt32(cb_users_list.SelectedValue),
                                            1,
                                            Convert.ToInt32(SalePerm.CheckState));
                user.UpdateUserPermissions(Convert.ToInt32(cb_users_list.SelectedValue),
                                            2,
                                            Convert.ToInt32(BuyPerm.CheckState));
                user.UpdateUserPermissions(Convert.ToInt32(cb_users_list.SelectedValue),
                                            3,
                                            Convert.ToInt32(BackupPerm.CheckState));
                user.UpdateUserPermissions(Convert.ToInt32(cb_users_list.SelectedValue),
                                            4,
                                            Convert.ToInt32(RestorePerm.CheckState));
                user.UpdateUserPermissions(Convert.ToInt32(cb_users_list.SelectedValue),
                                            5,
                                            Convert.ToInt32(BackPerm.CheckState));
                user.UpdateUserPermissions(Convert.ToInt32(cb_users_list.SelectedValue),
                                            6,
                                            Convert.ToInt32(CustomersPerm.CheckState));
                user.UpdateUserPermissions(Convert.ToInt32(cb_users_list.SelectedValue),
                                            7,
                                            Convert.ToInt32(ProvidersPerm.CheckState));
                user.UpdateUserPermissions(Convert.ToInt32(cb_users_list.SelectedValue),
                                            8,
                                            Convert.ToInt32(ProductsPerm.CheckState));
                user.UpdateUserPermissions(Convert.ToInt32(cb_users_list.SelectedValue),
                                            9,
                                            Convert.ToInt32(ReportsPerm.CheckState));
                user.UpdateUserPermissions(Convert.ToInt32(cb_users_list.SelectedValue),
                                            10,
                                            Convert.ToInt32(PapersPerm.CheckState));
                user.UpdateUserPermissions(Convert.ToInt32(cb_users_list.SelectedValue),
                                            11,
                                            Convert.ToInt32(SettingsPerm.CheckState));
                user.UpdateUserPermissions(Convert.ToInt32(cb_users_list.SelectedValue),
                                            12,
                                            Convert.ToInt32(ExpensesPerm.CheckState));

                MessageBox.Show("! تم حفظ البيانات", "",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                // refresh permissions intime
                BrowserForm.getMainForm.setPermissionsForLoggedInUser();

                Cursor.Current = Cursors.Default;
            }
            catch
            {
                Cursor.Current = Cursors.Default;

                MessageBox.Show("لم يتم حفظ البيانات", "",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }
        }
    }
}
