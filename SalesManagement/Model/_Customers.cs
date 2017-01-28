using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SalesManagement.Model
{
    class _Customers
    {
        DB_access db = new DB_access();
        DataTable dt = new DataTable();

        // 1. list all customers
        public DataTable listCustomers()
        {
            dt = db.RetrievData("listCustomers", null);
            
            return dt;
        }

        // 2. add new customer
        public void newCustomer(string cusName, int cusAccountNum, string cusDepts, string cusPayments)
        {
            
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@cusName", SqlDbType.VarChar, 100);
            param[0].Value = cusName;

            param[1] = new SqlParameter("@cusAccountNum", SqlDbType.Int);
            param[1].Value = cusAccountNum;

            param[2] = new SqlParameter("@cusDepts", SqlDbType.VarChar, 100);
            param[2].Value = cusDepts;

            param[3] = new SqlParameter("@cusPayments", SqlDbType.VarChar, 100);
            param[3].Value = cusPayments;

            db.ExecCmd("newCustomer", param);
            
        }

        // 3. update customer
        public void updateCustomer(int cusID, string cusName, int cusAccountNum, double paids, double changs)
        {
            
            SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@cusID", SqlDbType.Int);
            param[0].Value = cusID;

            param[1] = new SqlParameter("@cusName", SqlDbType.VarChar, 100);
            param[1].Value = cusName;

            param[2] = new SqlParameter("@cusAccountNum", SqlDbType.Int);
            param[2].Value = cusAccountNum;

            param[3] = new SqlParameter("@paids", SqlDbType.Float);
            param[3].Value = paids;

            param[4] = new SqlParameter("@changs", SqlDbType.Float);
            param[4].Value = changs;

            db.ExecCmd("updateCustomer", param);
            
        }

        // 4. delete one customer
        public void deleteCustomer(int cusID)
        {
            
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@cusID", SqlDbType.Int);
            param[0].Value = cusID;

            db.ExecCmd("deleteCustomer", param);
            
        }

        // 5. delete all customers
        public void deleteAllCustomers()
        {
            
            SqlParameter[] param = new SqlParameter[0];

            db.ExecCmd("deleteAllCustomers", null);
            
        }

        //  get customer by ID
        public DataTable getCustomerByID(int cusID)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@cusID", SqlDbType.Int);
            param[0].Value = cusID;

            dt = db.RetrievData("getCustomerByID", param);

            return dt;
        }

        // 8. search customer
        public DataTable searchCustomer(string searchText)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@searchText", SqlDbType.VarChar, 100);
            param[0].Value = searchText;

            dt = db.RetrievData("searchCustomer", param);
            

            return dt;
        }
    }
}
