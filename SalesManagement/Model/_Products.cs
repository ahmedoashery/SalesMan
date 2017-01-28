using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SalesManagement.Model
{
    class _Products
    {
        DB_access db = new DB_access();
        DataTable dt = new DataTable();

        // 0. list all products
        public DataTable listProducts()
        {
            dt = db.RetrievData("listProducts", null);
            
            return dt;
        }

        // 1. GET product BY BARCODE
        public DataTable getProductByBarcode(string prdBarcode)
        {
            SqlParameter[] param = new SqlParameter[1];
            
            param[0] = new SqlParameter("@prdBarcode", SqlDbType.VarChar, 100);
            param[0].Value = prdBarcode;

            dt = db.RetrievData("getProductByBarcode", param);
            return dt;
        }

        // 2. add new product
        public void newProduct(string prdBarcode, string prdName, int prdQuantity, int unitID, string prdUnitCost, int catID)
        {
            
            SqlParameter[] param = new SqlParameter[6];

            param[0] = new SqlParameter("@prdBarcode", SqlDbType.VarChar, 100);
            param[0].Value = prdBarcode;

            param[1] = new SqlParameter("@prdName", SqlDbType.VarChar, 100);
            param[1].Value = prdName;

            param[2] = new SqlParameter("@prdQuantity", SqlDbType.Int);
            param[2].Value = prdQuantity;

            param[3] = new SqlParameter("@unitID", SqlDbType.Int);
            param[3].Value = unitID;

            param[4] = new SqlParameter("@prdUnitCost", SqlDbType.VarChar, 100);
            param[4].Value = prdUnitCost;

            param[5] = new SqlParameter("@catID", SqlDbType.Int);
            param[5].Value = catID;

            db.ExecCmd("newProduct", param);
            
        }

        // 3. update product
        public void updateProduct(int prdID, string prdBarcode, string prdName, int prdQuantity, int unitID, string prdUnitCost, int catID)
        {
            
            SqlParameter[] param = new SqlParameter[7];

            param[0] = new SqlParameter("@prdID", SqlDbType.Int);
            param[0].Value = prdID;

            param[1] = new SqlParameter("@prdBarcode", SqlDbType.VarChar, 100);
            param[1].Value = prdBarcode;

            param[2] = new SqlParameter("@prdName", SqlDbType.VarChar, 100);
            param[2].Value = prdName;

            param[3] = new SqlParameter("@prdQuantity", SqlDbType.Int);
            param[3].Value = prdQuantity;

            param[4] = new SqlParameter("@unitID", SqlDbType.Int);
            param[4].Value = unitID;

            param[5] = new SqlParameter("@prdUnitCost", SqlDbType.VarChar, 100);
            param[5].Value = prdUnitCost;

            param[6] = new SqlParameter("@catID", SqlDbType.Int);
            param[6].Value = catID;

            db.ExecCmd("updateProduct", param);
            
        }

        // 4. delete one product
        public void deleteProduct(int prdID)
        {
            
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@prdID", SqlDbType.Int);
            param[0].Value = prdID;

            db.ExecCmd("deleteProduct", param);
            
        }

        // 5. delete all products
        public void deleteAllProducts()
        {
            
            SqlParameter[] param = new SqlParameter[0];

            db.ExecCmd("deleteAllProducts", null);
            
        }

        // 6. exist category
        public DataTable ExistProduct(string prdName)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@prdName", SqlDbType.VarChar, 100);
            param[0].Value = prdName;

            dt = db.RetrievData("ExistProduct", param);
            

            return dt;
        }

        // 7. Products Count
        public DataTable ProductsCount()
        {
            SqlParameter[] param = new SqlParameter[0];

            dt = db.RetrievData("ProductsCount", null);
            

            return dt;
        }

        // 8. search product
        public DataTable searchProduct(string searchText)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@searchText", SqlDbType.VarChar, 100);
            param[0].Value = searchText;

            dt = db.RetrievData("searchProduct", param);
            

            return dt;
        }

        // 9. list all unit types
        public DataTable listUnitTypes()
        {
            dt = db.RetrievData("listUnitTypes", null);
            
            return dt;
        }

        // 10. add new unit type
        public void newUnitType(string unitType)
        {
            
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@unitType", SqlDbType.VarChar, 100);
            param[0].Value = unitType;

            db.ExecCmd("newUnitType", param);
            
        }

        // 11. exist unit type
        public DataTable ExistUnitType(string unitType)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@unitType", SqlDbType.VarChar, 100);
            param[0].Value = unitType;

            dt = db.RetrievData("ExistUnitType", param);
            

            return dt;
        }

        // 12. delete one unit
        public void deleteUnit(int unitID)
        {
            
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@unitID", SqlDbType.Int);
            param[0].Value = unitID;

            db.ExecCmd("deleteUnit", param);
            
        }

        // 13. update unit
        public void updateUnit(int unitID, string unitType)
        {
            
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@unitID", SqlDbType.Int);
            param[0].Value = unitID;

            param[1] = new SqlParameter("@unitType", SqlDbType.VarChar, 100);
            param[1].Value = unitType;

            db.ExecCmd("updateUnit", param);
            
        }
    }
}
