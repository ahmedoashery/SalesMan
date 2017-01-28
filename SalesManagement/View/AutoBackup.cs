using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace SalesManagement.View
{
    public partial class AutoBackup : Form
    {
        Model.DB_access db = new Model.DB_access();

        public AutoBackup()
        {
            InitializeComponent();
        }

        private void AutoBackup_Load(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                string path = Application.StartupPath +
                                                "\\Backups\\" +
                                                DateTime.Now.ToString("yyyy") +
                                                "\\" +
                                                DateTime.Now.ToString("MMMM");
                Directory.CreateDirectory(path);
                // now copy database files
                db.backup(path);

                MessageBox.Show("تم حفظ نسخة إحتياطية من البيانات", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Cursor = Cursors.Default;
            }
            catch
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show("! لا توجد صلاحيات كافية ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
