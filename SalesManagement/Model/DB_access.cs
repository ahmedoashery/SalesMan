using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Specialized;
using Microsoft.SqlServer.Management.Smo;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace SalesManagement.Model
{
    class DB_access
    {

        // server instance
        Server server;

        public SqlConnection DBConnection;
        // Inisialize the connection object
        //--------------------------------------
        public DB_access()
        {
            string mode = Program.Mode;

            if (mode == "SQLAUTH")
            {
                DBConnection = new SqlConnection(@"Server=.\" + Program.Server +
                                                  "; Database=" + Program.Database +
                                                  "; Integrated Security=false;" +
                                                  "; User ID=" + Program.ID +
                                                  "; Password=" + Program.Password + ";");
            }
            else
            {
                DBConnection = new SqlConnection(@"Server=.\" + Program.Server +
                                                  "; Database=" + Program.Database +
                                                  "; Integrated Security=true;");
            }
        }

        // Open Connection With DB
        //--------------------------------------
        public void OpenConn()
        {
            try
            {
                if (DBConnection.State != ConnectionState.Open)
                {
                    DBConnection.Open();
                }
            }
            catch (SqlException ex)
            {
                throw (new Exception(ex.Number + "خطأ فى الاتصال بقاعدة البيانات"));
            }
        }

        // Close Connection With DB
        //--------------------------------------
        public void CloseConn()
        {
            try
            {
                if (DBConnection.State == ConnectionState.Open)
                {
                    DBConnection.Close();
                }
            }
            catch(SqlException ex)
            {
                throw new Exception(ex.Number + "خطأ فى الاتصال بقاعدة البيانات");
            }

        }

        // Retriev Data From DB
        //--------------------------------------
        public DataTable RetrievData(string stored_procedure, SqlParameter[] use_param)
        {
            try
            {
                OpenConn();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = stored_procedure;
                cmd.Connection = DBConnection;
                // check param
                if (use_param != null)
                {
                    for (int p = 0; p < use_param.Length; p++)
                    {
                        cmd.Parameters.Add(use_param[p]);
                    }
                }
                // start retrieving data
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                CloseConn();
                return (dt);
            }
            catch (Exception)
            { return null; }
        }

        // insert update and delete into/frm DB
        //--------------------------------------
        public void ExecCmd(string stored_procedure, SqlParameter[] use_param)
        {
            OpenConn();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = stored_procedure;
            cmd.Connection = DBConnection;

            // check param
            if (use_param != null)
            {
                cmd.Parameters.AddRange(use_param);
            }

            // start executing
            cmd.ExecuteNonQuery();
            CloseConn();
        }

        // connection to master db
        public SqlConnection master_connection()
        {
            DBConnection = new SqlConnection(@"Server=.\" + Program.Server +
                                                  "; Database=master" +
                                                  "; Integrated Security=false;" +
                                                  "; User ID=" + Program.ID +
                                                  "; Password=" + Program.Password + ";");
            return DBConnection;
        }

        // detach DB
        //--------------------------------------
        public void detach(string dbname = "")
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@dbname", SqlDbType.VarChar);
            param[0].Value = dbname;

            Program.Database = "master";
            ExecCmd("sys.sp_detach_db", param);
        }

        // attach DB
        //--------------------------------------
        public void attach(string dbname = "", string filesPath = "")
        {
            // configure server
            server = new Server(".\\" + Program.Server);

            //set database name
            dbname = Program.Database;

            // check if db already exists
            if (server.Databases.Contains(dbname))
            {
                // deleting initial files if exists
                if(Directory.Exists(Application.StartupPath + "\\Initial"))
                    Directory.Delete(Application.StartupPath + "\\Initial", true);
                return;
            }

            // extract if files are not there
            if (!Directory.Exists(Application.StartupPath + "\\Initial"))
                Process.Start(Application.StartupPath + "\\Initial.exe").WaitForExit();

            // files path
            filesPath = server.Databases[0].PrimaryFilePath;

            // copy db files to server data path
            File.Copy(Application.StartupPath + "\\Initial\\database files\\products_db.mdf", filesPath + "\\products_db.mdf", true);
            File.Copy(Application.StartupPath + "\\Initial\\database files\\products_db_log.ldf", filesPath + "\\products_db_log.ldf", true);
            

            // connect to master db
            master_connection();

            // now create database on attached files
            string query = "CREATE DATABASE " + dbname;
                   query += " ON (FILENAME = '" + filesPath + "\\" + dbname + ".mdf'),";
                   query += "(FILENAME = '" + filesPath + "\\" + dbname + "_Log.ldf')";
                   query += " FOR ATTACH;";

            SqlCommand cmd = new SqlCommand(query, DBConnection);
            try
            {
                // connect
                OpenConn();

                // execute
                cmd.ExecuteNonQuery();

                // exit
                CloseConn();
            }
            catch
            {
                throw new Exception("فشل إنشاء قاعدة البيانات");
            }
        }

        // online DB
        //--------------------------------------
        public void online(string dbname = "")
        {
            master_connection();

            SqlCommand cmd1 = new SqlCommand("ALTER DATABASE " + dbname + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE", DBConnection);
            SqlCommand cmd2 = new SqlCommand("ALTER DATABASE " + dbname + " SET Online", DBConnection);

            OpenConn();
            cmd1.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            CloseConn();
        }

        // offline DB
        //--------------------------------------
        public void offline(string dbname = "")
        {
            master_connection();

            SqlCommand cmd1 = new SqlCommand("ALTER DATABASE " + dbname + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE", DBConnection);
            SqlCommand cmd2 = new SqlCommand("ALTER DATABASE " + dbname + " SET Offline", DBConnection);

            OpenConn();
            cmd1.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            CloseConn();
        }

        // backup DB
        //--------------------------------------
        public void CopyMdfLdf(string CopyToPath = "")
        {
            try
            {
                // configure server
                this.server = new Server(".\\" + Program.Server);

                string FilesPath = server.Databases[0].PrimaryFilePath;

                // set db offline
                server.Databases[Program.Database].SetOffline();
                
                // copy database files to server DATA path
                File.Copy(FilesPath + "\\" + Program.Database + ".mdf",
                        CopyToPath + "\\" + Program.Database + ".mdf",
                        true);
                File.Copy(FilesPath + "\\" + Program.Database + ".mdf",
                        CopyToPath + "\\" + Program.Database + "_log.ldf",
                        true);
                // set db online again
                server.Databases[Program.Database].SetOnline();
            }
            catch (Exception ex) 
            { MessageBox.Show(ex.Message); }
        }

        public void backup(string CopyToPath = "")
        {
            try
            {
                // server
                this.server = new Server(".\\" + Program.Server);

                Backup bkpDBFull = new Backup();

                /* Specify whether you want to back up database or files or log */
                bkpDBFull.Action = BackupActionType.Database;

                /* Specify the name of the database to back up */
                bkpDBFull.Database = Program.Database;

                /* You can take backup on several media type (disk or tape), here I am
                 * using File type and storing backup on the file system */
                bkpDBFull.Devices.AddDevice(CopyToPath + "\\" +
                                                        DateTime.Now.ToString("dd-MM-yyyy") + " - " +
                                                        DateTime.Now.ToLongTimeString().Replace(':', '-') + ".bak", DeviceType.File);
                
                bkpDBFull.BackupSetName = Program.Database + " database Backup";
                bkpDBFull.BackupSetDescription = Program.Database + " database - Full Backup";
                
                /* You can specify Initialize = false (default) to create a new 
                 * backup set which will be appended as last backup set on the media. You
                 * can specify Initialize = true to make the backup as first set on the
                 * medium and to overwrite any other existing backup sets if the all the
                 * backup sets have expired and specified backup set name matches with
                 * the name on the medium */
                bkpDBFull.Initialize = true;

                // start process
                bkpDBFull.SqlBackup(server);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
    }
}
