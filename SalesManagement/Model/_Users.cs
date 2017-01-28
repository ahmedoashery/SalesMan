using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SalesManagement.Model
{
    class _Users
    {
        // class properties
        DB_access db = new DB_access();
        DataTable dt = new DataTable();

        // class methods
        // 1. methode to login
        public DataTable Login(string usrName, string usrPass) {
            
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@usrName", SqlDbType.VarChar, 100);
            param[0].Value = usrName;

            param[1] = new SqlParameter("@usrPass", SqlDbType.VarChar, 100);
            param[1].Value = usrPass;

            dt = db.RetrievData("userLogin", param);
            

            return dt;
        }

        // 2. add new user
        public void NewUser(string usrName, string usrPass, string usrRealName, string usrType, byte[] usrPicture) {
            
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@usrName", SqlDbType.VarChar, 100);
            param[0].Value = usrName;
            
            param[1] = new SqlParameter("@usrPass", SqlDbType.VarChar, 100);
            param[1].Value = usrPass;
            
            param[2] = new SqlParameter("@usrRealName", SqlDbType.VarChar, 100);
            param[2].Value = usrRealName;
            
            param[3] = new SqlParameter("@usrType", SqlDbType.VarChar, 100);
            param[3].Value = usrType;

            param[4] = new SqlParameter("@usrPicture", SqlDbType.Image);
            param[4].Value = usrPicture;

            db.ExecCmd("newUser", param);
            
        }
        // 3. list all users
        public DataTable listUsers() {
            dt = db.RetrievData("listUsers", null);
            
            return dt;
        }

        // 4. update user
        public void updateUser(int usrID, string usrName, string usrPass, string usrRealName, string usrType, byte[] usrPicture) {
            
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@usrID", SqlDbType.Int);
            param[0].Value = usrID;

            param[1] = new SqlParameter("@usrName", SqlDbType.VarChar, 100);
            param[1].Value = usrName;

            param[2] = new SqlParameter("@usrPass", SqlDbType.VarChar, 100);
            param[2].Value = usrPass;

            param[3] = new SqlParameter("@usrRealName", SqlDbType.VarChar, 100);
            param[3].Value = usrRealName;

            param[4] = new SqlParameter("@usrType", SqlDbType.VarChar, 100);
            param[4].Value = usrType;


            param[5] = new SqlParameter("@usrPicture", SqlDbType.Image);
            param[5].Value = usrPicture;

            db.ExecCmd("updateUser", param);
            
        }

        // 5. delete one user
        public void deleteUser(int usrID) {
            
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@usrID", SqlDbType.Int);
            param[0].Value = usrID;

            db.ExecCmd("deleteUser", param);
            
        }

        // 5. delete all users
        public void deleteAllUsers() {
            
            SqlParameter[] param = new SqlParameter[0];

            db.ExecCmd("deleteAllUsers", null);
            
        }

        // get last user id
        public DataTable getLastUserID()
        {
            dt = db.RetrievData("getLastUserID", null);
            return dt;
        }

        // list all forms
        public DataTable getAllForms()
        {
            dt = db.RetrievData("getAllForms", null);

            return dt;
        }

        // add user permissions " InitialUserPermissions "
        public void InitialUserPermissions(int user_id)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@user_id", SqlDbType.Int);
            param[0].Value = user_id;

            db.ExecCmd("InitialUserPermissions", param);
        }

        // get user permissions
        public DataTable getUserPermissions(int user_id, int form_id)
        {
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@user_id", SqlDbType.Int);
            param[0].Value = user_id;

            param[1] = new SqlParameter("@form_id", SqlDbType.Int);
            param[1].Value = form_id;

            dt = db.RetrievData("getUserPermissions", param);
            return dt;
        }

        // update user permissions
        public void UpdateUserPermissions(int userID, int formID, int set)
        {

            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@userID", SqlDbType.Int);
            param[0].Value = userID;

            param[1] = new SqlParameter("@formID", SqlDbType.Int);
            param[1].Value = formID;

            param[2] = new SqlParameter("@set", SqlDbType.Int);
            param[2].Value = set;

            db.ExecCmd("UpdateUserPermissions", param);
        }
    }
}
