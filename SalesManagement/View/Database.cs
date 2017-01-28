using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SalesManagement.View
{
    public partial class Database : Form
    {
        // db
        Model.DB_access db = new Model.DB_access();

        public Database()
        {
            InitializeComponent();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {

        }

        private void btnBacupNewYear_MouseHover(object sender, EventArgs e)
        {
            infotips.Show("يتم إغلاق السنة المالية من فواتير - \n مع بقاء العملاء والموردين وبيانات الأصناف",btnBacupNewYear);
        }
    }
}
