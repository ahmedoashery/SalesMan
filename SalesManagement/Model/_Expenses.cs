using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace SalesManagement.Model
{
    class _Expenses
    {
        DB_access db = new DB_access();
        DataTable dt = new DataTable();


        public DataTable getAllExpenses()
        {
            dt = db.RetrievData("getAllExpenses", null);
            return dt;
        }

        public DataTable getMoneyInSafe()
        {
            dt = db.RetrievData("getMoneyInSafe", null);
            return dt;
        }

        // initialize safe money
        public void initializeSafeMoney(double initialMoney)
        {
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@initialMoney", SqlDbType.Float);
            param[0].Value = initialMoney;

            db.ExecCmd("initializeSafeMoney", param);
        }

        public void newExpense(double ammount, string desc, DateTime date, string by, double moneyInSafe)
        {
            SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@ammount", SqlDbType.Float);
            param[0].Value = ammount;

            param[1] = new SqlParameter("@desc", SqlDbType.VarChar, 255);
            param[1].Value = desc;

            param[2] = new SqlParameter("@date", SqlDbType.DateTime);
            param[2].Value = date;

            param[3] = new SqlParameter("@by", SqlDbType.VarChar, 100);
            param[3].Value = by;

            param[4] = new SqlParameter("@moneyInSafe", SqlDbType.Float);
            param[4].Value = moneyInSafe;

            db.ExecCmd("newExpense", param);
        }
    }
}
