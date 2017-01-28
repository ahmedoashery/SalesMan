using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace SalesManagement.Model
{
    class _Providers
    {
        DB_access db = new DB_access();
        DataTable dt = new DataTable();

        // 1. list all providers
        public DataTable listProviders()
        {
            dt = db.RetrievData("listProviders", null);
            
            return dt;
        }

        // 2. add new provider
        public void newProvider(string prvName, string prvCompany,
                                int prvAccountNum, string prvCredits,
                                string prvPayments)
        {
            
            SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@prvName", SqlDbType.VarChar, 100);
            param[0].Value = prvName;

            param[1] = new SqlParameter("@prvCompany", SqlDbType.VarChar, 100);
            param[1].Value = prvCompany;

            param[2] = new SqlParameter("@prvAccountNum", SqlDbType.Int);
            param[2].Value = prvAccountNum;

            param[3] = new SqlParameter("@prvCredits", SqlDbType.VarChar, 100);
            param[3].Value = prvCredits;

            param[4] = new SqlParameter("@prvPayments", SqlDbType.VarChar, 100);
            param[4].Value = prvPayments;

            db.ExecCmd("newProvider", param);
            
        }

        // 3. update provider
        public void updateProvider(int prvID, string prvName, string prvCompany, int prvAccountNum, double credits, double paids)
        {
            
            SqlParameter[] param = new SqlParameter[6];

            param[0] = new SqlParameter("@prvID", SqlDbType.Int);
            param[0].Value = prvID;

            param[1] = new SqlParameter("@prvName", SqlDbType.VarChar, 100);
            param[1].Value = prvName;

            param[2] = new SqlParameter("@prvCompany", SqlDbType.VarChar, 100);
            param[2].Value = prvCompany;

            param[3] = new SqlParameter("@prvAccountNum", SqlDbType.Int);
            param[3].Value = prvAccountNum;

            param[4] = new SqlParameter("@credits", SqlDbType.Float);
            param[4].Value = credits;

            param[5] = new SqlParameter("@paids", SqlDbType.Float);
            param[5].Value = paids;

            db.ExecCmd("updateProvider", param);
            
        }

        // 4. delete one provider
        public void deleteProvider(int prvID)
        {
            
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@prvID", SqlDbType.Int);
            param[0].Value = prvID;

            db.ExecCmd("deleteProvider", param);
            
        }

        // 5. delete all providers
        public void deleteAllProviders()
        {
            
            SqlParameter[] param = new SqlParameter[0];

            db.ExecCmd("deleteAllProviders", null);
            
        }

        // 8. search provider
        public DataTable searchProvider(string searchText)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@searchText", SqlDbType.VarChar, 100);
            param[0].Value = searchText;

            dt = db.RetrievData("searchProvider", param);
            

            return dt;
        }
    }
}
