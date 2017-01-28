using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System.Drawing.Imaging;
using MetroFramework.Forms;

namespace SalesManagement.View
{
    public partial class Settings : MetroForm
    {
        Model._Settings set = new Model._Settings();
        Model.DB_access db = new Model.DB_access();
        //  _Users class instance
        Model._Users user = new Model._Users();
        SqlDataReader dr;
        DataTable dt = new DataTable();


        public Settings()
        {
            InitializeComponent();
            getCompanyInfo();

            if (Program.UserID == 2)
            {
                btnPermissions.Visible = true;
                btnPermissions.Enabled = true;
            }
            else 
            {
                btnPermissions.Visible = false;
                btnPermissions.Enabled = false;
            }

            try
            {
                // user info
                dgvUsersList.DataSource = user.listUsers();
                dgvUsersList.Columns[0].Visible = false;
                dgvUsersList.Columns[5].Visible = false;
            }
            catch
            {
                return;
            }
            
        }

        private void getCompanyInfo()
        {
            try
            {
                // company settings
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "getCompanyInfo";
                cmd.Connection = db.DBConnection;

                db.DBConnection.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtComanyName.Text = dr.GetString(0);
                    txtComanyOwner.Text = dr.GetString(1);

                    byte[] img = (byte[])dr[3];
                    MemoryStream ms = new MemoryStream(img);
                    pboxCompany.Image = Image.FromStream(ms);


                    txtComanyAddress.Text = dr.GetString(2);
                    txtComanyBrand.Text = dr.GetString(4);
                    txtComanyPhone.Text = dr.GetString(5);
                    txtComanyFax.Text = dr.GetString(6);
                    txtComanyDescription.Text = dr.GetString(7);
                }

                dr.Close();
                db.DBConnection.Close();
            }
            catch
            {
                MessageBox.Show("خطأ فى الاتصال", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void txtsClear()
        {
            txtUserName.Clear();
            txtUserPass.Clear();
            txtRealName.Clear();
            txtUserConfirmPass.Clear();
        }

        private void btnSavCompany_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                dt = set.getCompanyInfo();
                string check;
                if (dt.Rows.Count <= 0)
                {
                    check = "none";
                }
                else
                {
                    check = "info";
                }

                MemoryStream ms = new MemoryStream();
                pboxCompany.Image.Save(ms, pboxCompany.Image.RawFormat);
                byte[] image = ms.ToArray();

                set.updateCompanyInfo(txtComanyName.Text, txtComanyOwner.Text, txtComanyAddress.Text,
                                        image, txtComanyBrand.Text, txtComanyPhone.Text,
                                        txtComanyFax.Text, txtComanyDescription.Text, check);

                MessageBox.Show("تم الحفظ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                getCompanyInfo();

                Cursor.Current = Cursors.Default;
            }
            catch
            {
                Cursor.Current = Cursors.Default;
                MessageBox.Show("لم يتم الحفظ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtComanyName.Focus();
                return;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnComanyLogo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = " |*.jpg; *.jpeg; *.bmb; *.png";
            if (openfile.ShowDialog() == DialogResult.OK) {
                pboxCompany.Image = Image.FromFile(openfile.FileName);  
            }
        }

        private void txtComanyPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) {
                e.Handled = true;
                return;
            }
        }

        private void txtComanyFax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUserPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK) {
                openFile.Filter = "images files|*.jpg; *.bmp; *.png; *.jpeg";
                pboxUser.Image = Image.FromFile(openFile.FileName);
            }
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            txtUserName.Enabled = true;
            txtUserPass.Enabled = true;
            txtUserConfirmPass.Enabled = true;
            txtUserType.Enabled = true;
            txtRealName.Enabled = true;

            btnAddUser.Enabled = true;
            btnNewUser.Enabled = false;
            btnUserPicture.Enabled = true;
            btnDeleteUser.Enabled = false;
            btnDeleteAllUsers.Enabled = false;
            btnSaveUser.Enabled = false;
            btnUndo.Enabled = true;

            txtsClear();
            pboxUser.Image = Properties.Resources.Lubin_2;
            txtUserName.Focus();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                if (string.IsNullOrWhiteSpace(txtUserName.Text) || string.IsNullOrWhiteSpace(txtUserPass.Text) ||
                    string.IsNullOrWhiteSpace(txtRealName.Text) || string.IsNullOrWhiteSpace(txtUserType.Text))
                {
                    MessageBox.Show("ادخل بيانات صحيحة", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserName.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtUserConfirmPass.Text) || txtUserConfirmPass.Text != txtUserPass.Text)
                {
                    MessageBox.Show("(يرجى تأكيد كلمة السر (لا يوجد تطابق", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUserConfirmPass.SelectionStart = 0;
                    txtUserConfirmPass.SelectionLength = txtUserConfirmPass.TextLength;
                    txtUserConfirmPass.Focus();
                    return;
                }

                MemoryStream ms = new MemoryStream();
                pboxUser.Image.Save(ms, pboxUser.Image.RawFormat);
                byte[] userPicture = ms.ToArray();

                // execute new user
                user.NewUser(txtUserName.Text, txtUserPass.Text, txtRealName.Text, txtUserType.Text, userPicture);

                dgvUsersList.DataSource = user.listUsers();

                // add initial permissions
                DataTable id = user.getLastUserID();
                user.InitialUserPermissions(Convert.ToInt32(id.Rows[0][0]));
                
                txtsClear();
                pboxUser.Image = Properties.Resources.Lubin_2;

                txtUserName.Enabled = false;
                txtUserPass.Enabled = false;
                txtUserConfirmPass.Enabled = false;
                txtUserType.Enabled = false;
                txtRealName.Enabled = false;

                btnUserPicture.Enabled = false;
                btnAddUser.Enabled = false;
                btnNewUser.Enabled = true;
                dgvUsersList.Enabled = true;
                btnUndo.Enabled = false;

                Cursor.Current = Cursors.Default;
            }
            catch(SqlException ex)
            {
                Cursor.Current = Cursors.Default;

                if (ex.Number == 2627)
                {
                    MessageBox.Show(" ! إسم المستخدم موجود", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txtUserName.Focus();
                }
                else
                    return;
            }
        }

        private void dgvUsersList_Click(object sender, EventArgs e)
        {
            if (dgvUsersList.Rows.Count > 0)
            {
                btnDeleteUser.Enabled = true;
                btnDeleteAllUsers.Enabled = true;
                btnUserPicture.Enabled = true;
                btnSaveUser.Enabled = true;
                btnUndo.Enabled = true;
                btnAddUser.Enabled = false;
                btnNewUser.Enabled = false;

                txtUserName.Enabled = true;
                txtUserPass.Enabled = true;
                txtUserConfirmPass.Enabled = true;
                txtUserType.Enabled = true;
                txtRealName.Enabled = true;

                txtUserName.Text = dgvUsersList.CurrentRow.Cells[1].Value.ToString();
                txtUserPass.Text = dgvUsersList.CurrentRow.Cells[2].Value.ToString();
                txtUserConfirmPass.Text = dgvUsersList.CurrentRow.Cells[2].Value.ToString();
                txtRealName.Text = dgvUsersList.CurrentRow.Cells[3].Value.ToString();
                txtUserType.Text = dgvUsersList.CurrentRow.Cells[4].Value.ToString();

                byte[] pic = (byte[])(dgvUsersList.CurrentRow.Cells[5].Value);
                MemoryStream ms = new MemoryStream(pic);
                pboxUser.Image = Image.FromStream(ms);
            }
        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                if (string.IsNullOrWhiteSpace(txtUserName.Text) || string.IsNullOrWhiteSpace(txtUserPass.Text) ||
                    string.IsNullOrWhiteSpace(txtRealName.Text) || string.IsNullOrWhiteSpace(txtUserType.Text))
                {
                    txtUserName.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtUserConfirmPass.Text) || txtUserConfirmPass.Text != txtUserPass.Text)
                {
                    MessageBox.Show("(يرجى تأكيد كلمة السر (لا يوجد تطابق", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUserConfirmPass.SelectionStart = 0;
                    txtUserConfirmPass.SelectionLength = txtUserConfirmPass.TextLength;
                    txtUserConfirmPass.Focus();
                    return;
                }

                MemoryStream ms = new MemoryStream();
                pboxUser.Image.Save(ms, pboxUser.Image.RawFormat);
                byte[] userpicture = ms.ToArray();

                user.updateUser(Convert.ToInt32(dgvUsersList.CurrentRow.Cells[0].Value),
                                txtUserName.Text,
                                txtUserPass.Text,
                                txtRealName.Text,
                                txtUserType.Text,
                                userpicture);

                MessageBox.Show("تم حفظ البيانات الجديدة",
                                "تحديث بيانات",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                
                dgvUsersList.DataSource = user.listUsers();

                txtsClear();
                button2_Click(sender, e);
                pboxUser.Image = Properties.Resources.Lubin_2;
                btnDeleteAllUsers.Enabled = false;
                btnDeleteUser.Enabled = false;

                Cursor.Current = Cursors.Default;
            }
            catch(SqlException ex)
            {
                Cursor.Current = Cursors.Default;

                if (ex.Number == 2627)
                {
                    MessageBox.Show(" ! إسم المستخدم موجود", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txtUserName.Focus();
                }
                else
                    return;
            }
            
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (dgvUsersList.Rows.Count > 0)
            {
                if (MessageBox.Show("حذف المستخدمين المحددين استمرار ؟", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dgvUsersList.SelectedRows)
                    {
                        user.deleteUser(Convert.ToInt32(row.Cells[0].Value));
                    }
                    dgvUsersList.DataSource = user.listUsers();
                    txtsClear();

                    btnDeleteUser.Enabled = false;
                }
                else
                {
                    return;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUserName.Enabled = false;
            txtUserPass.Enabled = false;
            txtUserConfirmPass.Enabled = false;
            txtUserType.Enabled = false;
            txtRealName.Enabled = false;

            btnDeleteUser.Enabled = false;
            btnDeleteAllUsers.Enabled = false;
            btnUserPicture.Enabled = false;
            btnSaveUser.Enabled = false;
            btnAddUser.Enabled = false;
            btnNewUser.Enabled = true;

            dgvUsersList.DataSource = user.listUsers();

            txtsClear();
            pboxUser.Image = Properties.Resources.Lubin_2;
            btnUndo.Enabled = false;
        }

        private void btnDeleteAllUsers_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("سوف يتم حذف جميع المستخدمين استمرار ؟", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                user.deleteAllUsers();
                txtsClear();
                dgvUsersList.DataSource = user.listUsers();
            }
        }

        private void dgvUsersList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvUsersList.Columns[e.ColumnIndex].Index == 2 && e.Value != null)
            {
                dgvUsersList.Rows[e.RowIndex].Tag = e.Value;
                e.Value = new String('*', e.Value.ToString().Length);
            }
        }

        private void dgvUsersList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dgvUsersList != null)
            {
                for (int r = 0; r < dgvUsersList.Rows.Count; r++)
                {
                    dgvUsersList.Rows[r].HeaderCell.Value = (r + 1).ToString();
                    dgvUsersList.Refresh();
                }
            }
        }

        private void btnPermissions_Click(object sender, EventArgs e)
        {
            Permissions perm = new Permissions();
            perm.ShowDialog();
        }
    }
}
