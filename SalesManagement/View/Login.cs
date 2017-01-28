using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Management;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using MetroFramework.Forms;
using System.Collections.Specialized;
using System.Diagnostics;

namespace SalesManagement.View
{
    public partial class Login : MetroForm
    {
        Model.DB_access db = new Model.DB_access();

        // class properties
        Model._Users user = new Model._Users();
        DataTable dt = new DataTable();
        IDataReader dr;

        private static string userLoggedinFullName;
        //Single Instance
        private static Login frm;

        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }

        public static Login getMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new Login();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }


        public Login()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text) || string.IsNullOrWhiteSpace(txtUserPass.Text))
            {
                txtUserName.Focus();
                return;
            }
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                btnLogin.Enabled = false;
                txtUserName.Enabled = false;
                txtUserPass.Enabled = false;
                progressBar1.Increment(3);

                pbFinalCheck.Visible = true;

                if (progressBar1.Value >= 50)
                {
                    dt = user.Login(txtUserName.Text, txtUserPass.Text);
                    if (dt.Rows.Count > 0)
                    {
                        if (progressBar1.Value >= 75)
                            getUserPicture();

                        if (progressBar1.Value >= progressBar1.Maximum)
                        {
                            timer1.Stop();

                            // saving user full name for salesman and welcome notify
                            userLoggedinFullName = dt.Rows[0][3].ToString();

                            Program.SalesMan = userLoggedinFullName;
                            Program.UserID = Convert.ToInt32(dt.Rows[0][4]);

                            LoginNotify.ShowBalloonTip(7, "تم تسجيل الدخول",
                                                          ": المستخدم الحالى\n " + userLoggedinFullName,
                                                          ToolTipIcon.Info);
                            BrowserForm.getMainForm.ShowDialog();
                            this.Close();
                        }
                    }
                    else
                    {
                        timer1.Stop();
                        Cursor = Cursors.Default;
                        pbFinalCheck.Visible = false;
                        txtLoginMessage.Visible = true;
                        progressBar1.Value = 0;
                        btnLogin.Enabled = true;
                        txtUserName.Enabled = true;
                        txtUserPass.Enabled = true;
                        txtUserPass.Focus();
                        txtUserPass.SelectionStart = 0;
                        txtUserPass.SelectionLength = txtUserPass.TextLength;
                        return;
                    }
                }
            }
            catch(Exception ex)
            {
                timer1.Stop();
                MessageBox.Show(ex.Message + "\n"+"... خطأ فى إعدادات البرنامج", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        // get user picture
        private void getUserPicture()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "userLogin";
                cmd.Parameters.AddWithValue("@usrName", txtUserName.Text);
                cmd.Parameters.AddWithValue("@usrPass", txtUserPass.Text);
                cmd.Connection = db.DBConnection;

                db.DBConnection.Open();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    byte[] usrPic = (byte[])dr[2];
                    MemoryStream ms = new MemoryStream(usrPic);
                    pboxUserLoginPicture.Image = Image.FromStream(ms);
                }
                db.CloseConn();
                dr.Close();
            }
            catch 
            {
                return; 
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegisterFirstUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                FirstUserToAdd view = new FirstUserToAdd();
                view.ShowDialog();
                txtUserName.Text = view.txtFirstUserName.Text;
                txtUserPass.Text = view.txtFirstUserPass.Text;
                txtUserName.Focus();
                if (user.listUsers().Rows.Count >= 1)
                {
                    RegisterFirstUser.Visible = false;
                }
            }
            catch
            { return; }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                txtUserName.Focus();

                //CheckUSB();

                ProgramInitializing();

                checkAdmin();
            }
            catch
            {
                return;
            }
        }

        // add admin 
        private void checkAdmin()
        {
            try
            {
                if (user.listUsers().Rows.Count <= 0)
                {
                    MemoryStream ms = new MemoryStream();
                    pboxUserLoginPicture.Image.Save(ms, pboxUserLoginPicture.Image.RawFormat);
                    byte[] userPicture = ms.ToArray();
                    RegisterFirstUser.Visible = true;
                }
            }
            catch
            {
                return;
            }
        }

        // check USB
        public void CheckUSB()
        {
            // check usb drives count 1st..
            IEnumerable<DriveInfo> a = DriveInfo.GetDrives().Where(d => d.IsReady
            && d.DriveType == System.IO.DriveType.Removable);
            if (a.Count() <= 0)
            {
                if (MessageBox.Show("...وإعادة المحاولة USB يرجى إدخال الـ", 
                                    "USB لم يتم إدخال", 
                                    MessageBoxButtons.RetryCancel,
                                    MessageBoxIcon.Stop) == DialogResult.Retry)
                {
                    CheckUSB();
                }
                else
                {
                    this.Close();
                }
            }
            // check usb serial 2nd..
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                if (drive.DriveType == DriveType.Removable)
                {
                    USBSerialNumber usb = new USBSerialNumber();
                    string serial = usb.getSerialNumberFromDriveLetter(drive.Name.Remove(2, 1));
                    
                    if (serial != Program.USB_SERIAL)
                    {
                        if (MessageBox.Show("...البرنامج وإعادة المحاولة USB يرجى إدخال",
                                            "USB خطأ",
                                            MessageBoxButtons.RetryCancel,
                                            MessageBoxIcon.Stop) == DialogResult.Retry)
                        {
                            CheckUSB();
                        }
                        else
                        {
                            Close();
                        }
                    }
                }
            }
        }

        // initialize startup components
        private void ProgramInitializing()
        {
            try
            {
                // create database if not exists on server
                db.attach();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                                "خطأ فى الإتصال بالسيرفر",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                Close();
            } 
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void txtUserPass_MouseEnter(object sender, EventArgs e)
        {
            pbFinalCheck.Visible = false;
            txtLoginMessage.Visible = false;
            progressBar1.Value = 1;
        }

        private void txtUserPass_TextChanged(object sender, EventArgs e)
        {
            pbFinalCheck.Visible = false;
            txtLoginMessage.Visible = false;
            progressBar1.Value = 1;
        }
    }
}
