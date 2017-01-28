using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace SalesManagement.Model
{
    class _Accounts
    {
        DB_access db = new DB_access();
        DataTable dt = new DataTable();

        // get customer account detailes
        public DataTable CustomerAccountDetailes(int cusID)
        {
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@cusID", SqlDbType.Int);
            param[0].Value = cusID;

            dt = db.RetrievData("CustomerAccountDetailes", param);
            return dt;
        }

        // get customer account orders
        public DataTable CustomerAccountOrders(int cusID)
        {
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@cusID", SqlDbType.Int);
            param[0].Value = cusID;

            dt = db.RetrievData("CustomerAccountOrders", param);
            return dt;
        }

        // get customer papers detailes
        public DataTable CustomerPapersDetailes(int cusID)
        {
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@cusID", SqlDbType.Int);
            param[0].Value = cusID;

            dt = db.RetrievData("CustomerPapersDetailes", param);
            return dt;
        }



        // get provider account detailes
        public DataTable ProviderAccountDetailes(int prvID)
        {
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@prvID", SqlDbType.Int);
            param[0].Value = prvID;

            dt = db.RetrievData("ProviderAccountDetailes", param);
            return dt;
        }

        // get provider account orders
        public DataTable ProviderAccountOrders(int prvID)
        {
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@prvID", SqlDbType.Int);
            param[0].Value = prvID;

            dt = db.RetrievData("ProviderAccountOrders", param);
            return dt;
        }

        // get provider papers detailes
        public DataTable ProviderPapersDetailes(int prvID)
        {
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@prvID", SqlDbType.Int);
            param[0].Value = prvID;

            dt = db.RetrievData("ProviderPapersDetailes", param);
            return dt;
        }
    }
}
