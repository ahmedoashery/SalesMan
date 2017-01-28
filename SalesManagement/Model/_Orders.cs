using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SalesManagement.Model
{
    class _Orders
    {
        DB_access db = new DB_access();
        DataTable dt = new DataTable();



        // 0. get last order id
        public DataTable getLastOrderID()
        {
            dt = db.RetrievData("getLastOrderID", null);
            
            return dt;
        }

        // 1. New Order
        public void newOrder(int ordID, string ordType, DateTime ordDate, double ordPaid, double ordChange, double ordDiscount, 
            double ordTotalCost, int prvID, int cusID, string ordNotes, string ordSalesMan, string ordlabel, string ordTypeName)
        {
            
            SqlParameter[] param = new SqlParameter[13];

            param[0] = new SqlParameter("@ordID", SqlDbType.Int);
            param[0].Value = ordID;

            param[1] = new SqlParameter("@ordType", SqlDbType.VarChar, 100);
            param[1].Value = ordType;

            param[2] = new SqlParameter("@ordDate", SqlDbType.DateTime);
            param[2].Value = ordDate;

            param[3] = new SqlParameter("@ordPaid", SqlDbType.Float);
            param[3].Value = ordPaid;

            param[4] = new SqlParameter("@ordChange", SqlDbType.Float);
            param[4].Value = ordChange;

            param[5] = new SqlParameter("@ordDiscount", SqlDbType.Float);
            param[5].Value = ordDiscount;

            param[6] = new SqlParameter("@ordTotalCost", SqlDbType.Float);
            param[6].Value = ordTotalCost;

            param[7] = new SqlParameter("@prvID", SqlDbType.Int);
            param[7].Value = prvID;

            param[8] = new SqlParameter("@cusID", SqlDbType.Int);
            param[8].Value = cusID;

            param[9] = new SqlParameter("@ordNotes", SqlDbType.VarChar, 100);
            param[9].Value = ordNotes;

            param[10] = new SqlParameter("@ordSalesMan", SqlDbType.VarChar, 100);
            param[10].Value = ordSalesMan;

            param[11] = new SqlParameter("@ordlabel", SqlDbType.VarChar, 100);
            param[11].Value = ordlabel;

            param[12] = new SqlParameter("@ordTypeName", SqlDbType.VarChar, 100);
            param[12].Value = ordTypeName;

            db.ExecCmd("newOrder", param);
            
        }

        // .....  Order Detailes
        public void newOrderDetailes(int ordID, int prdID, int ordQuantity, string ordUnitCost, string ordTotalCost, string ordlabel, int prdUnit)
        {
            
            SqlParameter[] param = new SqlParameter[7];

            param[0] = new SqlParameter("@ordID", SqlDbType.Int);
            param[0].Value = ordID;

            param[1] = new SqlParameter("@prdID", SqlDbType.Int);
            param[1].Value = prdID;

            param[2] = new SqlParameter("@ordQuantity", SqlDbType.Int);
            param[2].Value = ordQuantity;

            param[3] = new SqlParameter("@ordUnitCost", SqlDbType.VarChar, 100);
            param[3].Value = ordUnitCost;

            param[4] = new SqlParameter("@ordTotalCost", SqlDbType.VarChar, 100);
            param[4].Value = ordTotalCost;

            param[5] = new SqlParameter("@ordlabel", SqlDbType.VarChar, 100);
            param[5].Value = ordlabel;

            param[6] = new SqlParameter("@prdUnit", SqlDbType.Int);
            param[6].Value = prdUnit;

            db.ExecCmd("newOrderDetailes", param);
            
        }

        // 2. verify quantity
        public DataTable VerifyQuantity(int prdID, int insertedQuantity)
        {
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@prdID", SqlDbType.Int);
            param[0].Value = prdID;

            param[1] = new SqlParameter("@insertedQuantity", SqlDbType.Int);
            param[1].Value = insertedQuantity;

            dt = db.RetrievData("VerifyQuantity", param);
            
            return dt;
        }

        // 3. update Customer from order
        public void updateCustomerFromOrder(int cusID, string ordChange, string ordPaid)
        {
            
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@cusID", SqlDbType.Int);
            param[0].Value = cusID;

            param[1] = new SqlParameter("@ordChange", SqlDbType.VarChar, 100);
            param[1].Value = ordChange;

            param[2] = new SqlParameter("@ordPaid", SqlDbType.VarChar, 100);
            param[2].Value = ordPaid;

            db.ExecCmd("updateCustomerFromOrder", param);
            
        }

        // 4. update provider from order
        public void updateProviderFromOrder(int prvID, string ordChange, string ordPaid)
        {
            
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@prvID", SqlDbType.Int);
            param[0].Value = prvID;

            param[1] = new SqlParameter("@ordChange", SqlDbType.VarChar, 100);
            param[1].Value = ordChange;

            param[2] = new SqlParameter("@ordPaid", SqlDbType.VarChar, 100);
            param[2].Value = ordPaid;

            db.ExecCmd("updateProviderFromOrder", param);
            
        }

        // 3. update Customer from back order
        public void updateCustomerFromBackOrder(int cusID, string TotalValue)
        {
            
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@cusID", SqlDbType.Int);
            param[0].Value = cusID;

            param[1] = new SqlParameter("@TotalValue", SqlDbType.VarChar, 100);
            param[1].Value = TotalValue;


            db.ExecCmd("updateCustomerFromBackOrder", param);
            
        }
    }
}
