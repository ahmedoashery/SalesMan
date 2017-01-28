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
    public partial class FirstUserToAdd : MetroForm
    {
        Model._Users user = new Model._Users();

        public FirstUserToAdd()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstUserName.Text) 
                || string.IsNullOrWhiteSpace(txtFirstUserPass.Text)
                || string.IsNullOrWhiteSpace(txtFirstUserConfirmPass.Text) 
                || string.IsNullOrWhiteSpace(txtFirstUserRealName.Text)
                || string.IsNullOrWhiteSpace(txtFirstUserType.Text))
            {
                txtFirstUserName.Focus();
                return;
            }
            else
            {
                if (txtFirstUserConfirmPass.Text != txtFirstUserPass.Text)
                {
                    txtFirstUserConfirmPass.Focus();
                    txtFirstUserConfirmPass.SelectionStart = 0;
                    txtFirstUserConfirmPass.SelectionLength = txtFirstUserConfirmPass.TextLength;
                    return;
                }
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byte[] userPicture = ms.ToArray();

                user.NewUser(txtFirstUserName.Text, txtFirstUserPass.Text, txtFirstUserRealName.Text, txtFirstUserType.Text, userPicture);
                // add permissions
                DataTable id = user.getLastUserID();
                user.InitialUserPermissions(Convert.ToInt32(id.Rows[0][0]));

                MessageBox.Show("تم اضافة المدير العام قم بتسجيل الدخول", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
