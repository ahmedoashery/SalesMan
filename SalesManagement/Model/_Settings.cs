using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.IO;
namespace SalesManagement.Model
{
    class _Settings
    {
        DB_access db = new DB_access();
        DataTable dt = new DataTable();
        
        // 1. list company info
        public DataTable getCompanyInfo()
        {
            dt = db.RetrievData("getCompanyInfo", null);
            
            return dt;
        }

        // 2. update company info
        public void updateCompanyInfo(string compName, string compOwner, string compAddress, byte[] compLogo , string compBrand,
                                    string compPhone, string compFax, string compDesc, string check)
        {
            
            SqlParameter[] param = new SqlParameter[9];

            param[0] = new SqlParameter("@compName", SqlDbType.VarChar, 100);
            param[0].Value = compName;

            param[1] = new SqlParameter("@compOwner", SqlDbType.VarChar, 100);
            param[1].Value = compOwner;

            param[2] = new SqlParameter("@compAddress", SqlDbType.VarChar, 100);
            param[2].Value = compAddress;

            param[3] = new SqlParameter("@compLogo", SqlDbType.Image);
            param[3].Value = compLogo;

            param[4] = new SqlParameter("@compBrand", SqlDbType.VarChar, 100);
            param[4].Value = compBrand;

            param[5] = new SqlParameter("@compPhone", SqlDbType.VarChar, 100);
            param[5].Value = compPhone;

            param[6] = new SqlParameter("@compFax", SqlDbType.VarChar, 100);
            param[6].Value = compFax;

            param[7] = new SqlParameter("@compDesc", SqlDbType.VarChar, 200);
            param[7].Value = compDesc;

            param[8] = new SqlParameter("@check", SqlDbType.VarChar, 100);
            param[8].Value = check;

            db.ExecCmd("updateCompanyInfo", param);
            
        }
    }
}
