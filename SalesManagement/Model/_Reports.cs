using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SalesManagement.Model
{
    class _Reports
    {
        Model.DB_access db = new DB_access();
        DataTable dt = new DataTable();


        /*********************************************************************************************/
        /**************                             Day Orders                     *******************/
        /*********************************************************************************************/


        // Day sales orders
        public DataTable DaySalesOrders(DateTime date, string ordType)
        {
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@date", SqlDbType.Date);
            param[0].Value = date;

            param[1] = new SqlParameter("@ordType", SqlDbType.VarChar, 100);
            param[1].Value = ordType;

            dt = db.RetrievData("DaySalesOrders", param);

            return dt;
        }

        // sales orders Detailes
        public DataTable DaySalesOrdersDetailes(DateTime date, string ordType)
        {
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@date", SqlDbType.Date);
            param[0].Value = date;

            param[1] = new SqlParameter("@ordType", SqlDbType.VarChar, 100);
            param[1].Value = ordType;

            dt = db.RetrievData("DaySalesOrdersDetailes", param);
            return dt;
        }



        // buys orders
        public DataTable DayBuysOrders(DateTime date, string ordType)
        {
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@date", SqlDbType.Date);
            param[0].Value = date;

            param[1] = new SqlParameter("@ordType", SqlDbType.VarChar, 100);
            param[1].Value = ordType;

            dt = db.RetrievData("DayBuysOrders", param);

            return dt;
        }

        // buys orders Detailes
        public DataTable DayBuysOrdersDetailes(DateTime date, string ordType)
        {
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@date", SqlDbType.Date);
            param[0].Value = date;

            param[1] = new SqlParameter("@ordType", SqlDbType.VarChar, 100);
            param[1].Value = ordType;

            dt = db.RetrievData("DayBuysOrdersDetailes", param);
            return dt;
        }




        // day back orders for current date
        public DataTable DayBackOrders(DateTime date, string ordType)
        {
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@date", SqlDbType.Date);
            param[0].Value = date;

            param[1] = new SqlParameter("@ordType", SqlDbType.VarChar, 100);
            param[1].Value = ordType;

            dt = db.RetrievData("DayBackOrders", param);

            return dt;
        }

        // back orders Detailes for current date
        public DataTable DayBackOrdersDetailes(DateTime date, string ordType)
        {
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@date", SqlDbType.Date);
            param[0].Value = date;

            param[1] = new SqlParameter("@ordType", SqlDbType.VarChar, 100);
            param[1].Value = ordType;

            dt = db.RetrievData("DayBackOrdersDetailes", param);
            return dt;
        }



        /*********************************************************************************************/
        /**************                             Day Reports                    *******************/
        /*********************************************************************************************/

        // Day Sales Reports
        public DataTable DaySalesReports(DateTime ordDate, string ordType)
        {
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@ordDate", SqlDbType.Date);
            param[0].Value = ordDate;

            param[1] = new SqlParameter("@ordType", SqlDbType.VarChar, 100);
            param[1].Value = ordType;

            dt = db.RetrievData("DaySalesReports", param);

            return dt;
        }



        // Day Buys Reports
        public DataTable DayBuysReports(DateTime ordDate, string ordType)
        {
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@ordDate", SqlDbType.Date);
            param[0].Value = ordDate;

            param[1] = new SqlParameter("@ordType", SqlDbType.VarChar, 100);
            param[1].Value = ordType;

            dt = db.RetrievData("DayBuysReports", param);

            return dt;
        }


       






        /*********************************************************************************************/
        /**************                             Month Orders                  *******************/
        /*********************************************************************************************/



        // Month sales orders
        public DataTable MonthSalesOrders(string date)
        {
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@date", SqlDbType.VarChar, 100);
            param[0].Value = date;


            dt = db.RetrievData("MonthSalesOrders", param);

            return dt;
        }

        // Month sales orders Detailes for current date
        public DataTable MonthSalesOrdersDetailes(string date, string ordType)
        {
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@date", SqlDbType.VarChar, 100);
            param[0].Value = date;

            param[1] = new SqlParameter("@ordType", SqlDbType.VarChar, 100);
            param[1].Value = ordType;

            dt = db.RetrievData("MonthSalesOrdersDetailes", param);
            return dt;
        }

        // Month buys orders for current date
        public DataTable MonthBuysOrders(string date)
        {
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@date", SqlDbType.VarChar, 100);
            param[0].Value = date;


            dt = db.RetrievData("MonthBuysOrders", param);

            return dt;
        }

        // Month Buys orders Detailes for current date
        public DataTable MonthBuysOrdersDetailes(string date, string ordType)
        {
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@date", SqlDbType.VarChar, 100);
            param[0].Value = date;

            param[1] = new SqlParameter("@ordType", SqlDbType.VarChar, 100);
            param[1].Value = ordType;

            dt = db.RetrievData("MonthBuysOrdersDetailes", param);
            return dt;
        }

        // Month buys orders for current date
        public DataTable MonthBackOrders(string date)
        {
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@date", SqlDbType.VarChar, 100);
            param[0].Value = date;


            dt = db.RetrievData("MonthBackOrders", param);

            return dt;
        }

        // Month back orders Detailes for current date
        public DataTable MonthBackOrdersDetailes(string date, string ordType)
        {
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@date", SqlDbType.VarChar, 100);
            param[0].Value = date;

            param[1] = new SqlParameter("@ordType", SqlDbType.VarChar, 100);
            param[1].Value = ordType;

            dt = db.RetrievData("MonthBackOrdersDetailes", param);
            return dt;
        }




        /*********************************************************************************************/
        /**************                             Month Reports                  *******************/
        /*********************************************************************************************/

        

        // Month Sales Reports
        public DataTable MonthSalesOrdersForPrint(string date, string ordType)
        {
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@date", SqlDbType.VarChar, 100);
            param[0].Value = date;

            param[1] = new SqlParameter("@ordType", SqlDbType.VarChar, 100);
            param[1].Value = ordType;

            dt = db.RetrievData("MonthSalesOrdersForPrint", param);

            return dt;
        }

        // Month Buys Reports
        public DataTable MonthBuysOrdersForPrint(string date, string ordType)
        {
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@date", SqlDbType.VarChar, 100);
            param[0].Value = date;

            param[1] = new SqlParameter("@ordType", SqlDbType.VarChar, 100);
            param[1].Value = ordType;

            dt = db.RetrievData("MonthBuysOrdersForPrint", param);

            return dt;
        }

        // Month Back Reports
        public DataTable MonthBackOrdersForPrint(string date, string ordType)
        {
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@date", SqlDbType.VarChar, 100);
            param[0].Value = date;

            param[1] = new SqlParameter("@ordType", SqlDbType.VarChar, 100);
            param[1].Value = ordType;

            dt = db.RetrievData("MonthBackOrdersForPrint", param);

            return dt;
        }






        /*********************************************************************************************/
        /**************                             Movements                *******************/
        /*********************************************************************************************/

        // Sales Movements
        public DataTable SalesMovements(DateTime date1, DateTime date2)
        {
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@date1", SqlDbType.Date);
            param[0].Value = date1;

            param[1] = new SqlParameter("@date2", SqlDbType.Date);
            param[1].Value = date2;

            dt = db.RetrievData("SalesMovements", param);

            return dt;
        }

        // Buys Movements
        public DataTable BuysMovements(DateTime date1, DateTime date2)
        {
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@date1", SqlDbType.Date);
            param[0].Value = date1;

            param[1] = new SqlParameter("@date2", SqlDbType.Date);
            param[1].Value = date2;

            dt = db.RetrievData("BuysMovements", param);

            return dt;
        }
    }
}
