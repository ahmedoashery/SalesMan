using SalesManagement.View;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        // current user id
        public static int UserID;

        // current user as salesman
        public static string SalesMan;

        // global message for errors
        public static string errorMessage = "";

        // permisions for logged in user
        public static bool Sale = true;
        public static bool Buy = true;
        public static bool Backup = true;
        public static bool Restore = true;
        public static bool Back = true;
        public static bool Customers = true;
        public static bool Providers = true;
        public static bool Products = true;
        public static bool Reports = true;
        public static bool Papers = true;
        public static bool Settings = true;
        public static bool Expenses = true;
        

        public static string Server = "appServerDB";
        public static string Mode = "SQLAUTH";
        public static string Database = "products_db";
        public static string ID = "sa";
        public static string Password = "sapass";
        public static string USB_SERIAL = "0060E049DF72EF5170004744";

        [STAThread]
        static void Main()
        {
            Cursor.Current = Cursors.AppStarting;
            bool result;
            var mutex = new System.Threading.Mutex(true, "UniqueAppId", out result);

            if (!result)
            {
                MessageBox.Show("البرنامج قيد التشغيل بالفعل", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            GC.KeepAlive(mutex);      // mutex shouldn't be released - important line

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new View.Login());

            Cursor.Current = Cursors.Default;
        }
    }
}
