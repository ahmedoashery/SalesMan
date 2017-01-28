using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace SalesManagement.Model
{
    class _Papers
    {
        DB_access db = new DB_access();
        DataTable dt = new DataTable();


        // 1. new paper
        public void newPaper(string papType, string papValue, DateTime papDate, string papNotes, int cusID, int prvID, string papLabel)
        {
            
            SqlParameter[] param = new SqlParameter[7];

            param[0] = new SqlParameter("@papType", SqlDbType.VarChar, 100);
            param[0].Value = papType;

            param[1] = new SqlParameter("@papValue", SqlDbType.VarChar, 100);
            param[1].Value = papValue;

            param[2] = new SqlParameter("@papDate", SqlDbType.DateTime);
            param[2].Value = papDate;

            param[3] = new SqlParameter("@papNotes", SqlDbType.VarChar, 100);
            param[3].Value = papNotes;

            param[4] = new SqlParameter("@cusID", SqlDbType.Int);
            param[4].Value = cusID;

            param[5] = new SqlParameter("@prvID", SqlDbType.Int);
            param[5].Value = prvID;

            param[6] = new SqlParameter("@papLabel", SqlDbType.VarChar, 100);
            param[6].Value = papLabel;

            db.ExecCmd("newPaper", param);
            
        }
    }
}
