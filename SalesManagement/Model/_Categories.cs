using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SalesManagement.Model
{
    class _Categories
    {
        DB_access db = new DB_access();
        DataTable dt = new DataTable();

        // 1. list all categories
        public DataTable listCategories () {
            dt = db.RetrievData("listCategories", null);
            return dt;
        }

        // 2. add new category
        public void newCategory (string catName) {
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@catName", SqlDbType.VarChar, 100);
            param[0].Value = catName;

            db.ExecCmd("newCategory", param);
        }

        // 3. update category
        public void updateCategory (int catID, string catName)
        {
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@catID", SqlDbType.Int);
            param[0].Value = catID;

            param[1] = new SqlParameter("@catName", SqlDbType.VarChar, 100);
            param[1].Value = catName;

            db.ExecCmd("updateCategory", param);
        }

        // 4. delete one category
        public void deleteCategory (int catID)
        {
            
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@catID", SqlDbType.Int);
            param[0].Value = catID;

            db.ExecCmd("deleteCategory", param);
            
        }

        // 5. delete all categories
        public void deleteAllCategories ()
        {
            
            SqlParameter[] param = new SqlParameter[0];

            db.ExecCmd("deleteAllCategories", null);
            
        }

        // 6. exist category
        public DataTable ExistCategory(string catName)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@catName", SqlDbType.VarChar, 100);
            param[0].Value = catName;

            dt = db.RetrievData("ExistCategory", param);
            

            return dt;
        }

        // 7. category Products Count
        public DataTable categoryProductsCount(int catID)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@catID", SqlDbType.Int);
            param[0].Value = catID;

            dt = db.RetrievData("categoryProductsCount", param);
            

            return dt;
        }

        // 8. search category
        public DataTable searchCategory(string searchText)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@searchText", SqlDbType.VarChar, 100);
            param[0].Value = searchText;

            dt = db.RetrievData("searchCategory", param);
            

            return dt;
        }
    }
}
