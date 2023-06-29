using Object;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
    public class DAL
    {
        public OracleConnection ConnectToOracle()
        {
            //Connection String 
            string connectionString = "User Id=dbadmin; password=dbadmin;" +
            "Data Source=localhost:1521/orcl; Pooling=false;";


            //Create Connection
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = connectionString;
            conn.Open();
            return conn;
        }

        public List<User> GetListUsersFromDatabase()
        {
            var users = new List<User>();
            OracleConnection conn = ConnectToOracle();
            OracleCommand oc = new OracleCommand();
            oc.Connection = conn;
            // oc.CommandText = "SELECT username FROM all_users";   // lấy tất cả user kể cả user do hệ thống tạo
            oc.CommandText = "SELECT USERNAME, ACCOUNT_STATUS, CREATED, EXPIRY_DATE, LAST_LOGIN " +
              "FROM DBA_USERS WHERE DEFAULT_TABLESPACE = 'USERS'";  // chỉ lấy common user (user không phải do hệ thống tạo)
            var reader = oc.ExecuteReader();

            while (reader.Read())
            {
                var user = new User();
                user.Username = reader.GetString(0);
                user.Status = reader.GetString(1);
                user.CreatedDate = reader.IsDBNull(2) ? (DateTime?)null : reader.GetDateTime(2);
                user.ExpiryDate = reader.IsDBNull(3) ? (DateTime?)null : reader.GetDateTime(3);
                user.LastLogin = reader.IsDBNull(4) ? (DateTime?)null : reader.GetDateTime(4);
                users.Add(user);
            }
            conn.Close();
            return users;
        }

        public List<Role> GetListRolesFromDatabase()
        {
            var roles = new List<Role>();
            OracleConnection conn = ConnectToOracle();
            OracleCommand oc = new OracleCommand();
            oc.Connection = conn;
            //oc.CommandText = "SELECT GRANTED_ROLE AS ROLE FROM USER_ROLE_PRIVS WHERE GRANTED_ROLE != 'RESOURCE'"; // chỉ lấy role do dbadmin tạo
            oc.CommandText = "SELECT role FROM dba_roles";    // lấy tất cả role kể cả role do hệ thống tạo
            var reader = oc.ExecuteReader();
            while (reader.Read())
            {
                roles.Add(new Role(reader.GetString(0)));
            }
            conn.Close();
            return roles;
        }

        public List<string> GetListRolesFromUserFromDatabase(string username)
        {
            var roles = new List<string>();
            OracleConnection conn = ConnectToOracle();
            OracleCommand oc = new OracleCommand();
            oc.Connection = conn;
            oc.CommandText = $"select granted_role from dba_role_privs where grantee = '{username}'";
            var reader = oc.ExecuteReader();
            while (reader.Read())
            {
                roles.Add(reader.GetString(0));
            }
            conn.Close();
            Console.WriteLine(roles);
            return roles;
        }

        public List<string> GetListUsersFromRoleFromDatabase(string role)
        {
            var users = new List<string>();
            OracleConnection conn = ConnectToOracle();
            OracleCommand orc = new OracleCommand();
            orc.Connection = conn;
            orc.CommandText = $"select grantee from dba_role_privs where granted_role = '{role}'";
            var reader = orc.ExecuteReader();
            while (reader.Read())
            {
                users.Add(reader.GetString(0));
            }
            conn.Close();
            return users;
        }

        public List<Priv> GetListPrivsFromDatabase(String objectGrantee, String typePriv, String typeObjectGrantee)
        {
            var privs = new List<Priv>();
            OracleConnection conn = ConnectToOracle();

            try
            {
                OracleCommand oc = new OracleCommand();
                oc.Connection = conn;
                oc.CommandText = "SELECT * FROM " + typePriv + " WHERE " + typeObjectGrantee + " = '" + objectGrantee + "'";
                OracleDataReader reader = oc.ExecuteReader();

                Console.WriteLine("oc.CommandText: " + oc.CommandText);

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string objectName = "";
                        string privName = reader["PRIVILEGE"].ToString();
                        string privType = typePriv;
                        string tableName = "";
                        string owner = "";

                        if (String.Compare(typeObjectGrantee, "GRANTEE", true) == 0)
                        {
                            objectName = reader["GRANTEE"].ToString();
                            if (String.Compare(typePriv, "DBA_TAB_PRIVS", true) == 0)
                            {
                                tableName = reader["TABLE_NAME"].ToString();
                                owner = reader["OWNER"].ToString();
                            }
                        }
                        else if (String.Compare(typeObjectGrantee, "ROLE", true) == 0)
                        {
                            objectName = reader["ROLE"].ToString();
                            if (String.Compare(typePriv, "ROLE_TAB_PRIVS", true) == 0)
                            {
                                tableName = reader["TABLE_NAME"].ToString();
                                owner = reader["OWNER"].ToString();
                            }
                        }

                        privs.Add(new Priv(objectName, privName, privType, tableName, owner));
                    }
                }
                else
                {
                    Console.WriteLine("Không có dữ liệu trả về");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                conn.Close();
            }

            return privs;
        }

        public bool createUserInDatabase(String username, String pwd)
        {
            bool status = false;
            username = username.ToUpper();

            // Tạo kết nối trực tiếp tới Oracle
            OracleConnection conn = ConnectToOracle();

            try
            {
                // Tạo một đối tượng Command
                OracleCommand oc = new OracleCommand();
                // Liên hợp Command với Connection
                oc.Connection = conn;
                string sql = "ALTER SESSION SET \"_ORACLE_SCRIPT\" = true"; // sửa lỗi invalid common user or role name
                oc.CommandText = sql;
                oc.ExecuteNonQuery();

                if (((username[0] >= 'a') && (username[0] <= 'z')) || ((username[0] >= 'A') && (username[0] <= 'Z')))
                {
                    sql = "CREATE USER " + username + " IDENTIFIED BY " + pwd;
                }
                else
                {
                    sql = "CREATE USER \"" + username + "\" IDENTIFIED BY " + pwd;
                }
                oc.CommandText = sql;

                oc.ExecuteNonQuery();

                status = true;

            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                conn.Close();
            }

            return status;
        }

        public bool updateUserInDatabase(String username, String pwd)
        {
            bool status = false;
            username = username.ToUpper();

            // Tạo kết nối trực tiếp tới Oracle
            OracleConnection conn = ConnectToOracle();

            try
            {
                // Tạo một đối tượng Command
                OracleCommand oc = new OracleCommand();
                // Liên hợp Command với Connection
                oc.Connection = conn;

                string sql = "ALTER SESSION SET \"_ORACLE_SCRIPT\" = true"; // sửa lỗi invalid common user or role name
                oc.CommandText = sql;
                oc.ExecuteNonQuery();

                if (((username[0] >= 'a') && (username[0] <= 'z')) || ((username[0] >= 'A') && (username[0] <= 'Z')))
                {
                    sql = "ALTER USER " + username + " IDENTIFIED BY " + pwd;
                }
                else
                {
                    sql = "ALTER USER \"" + username + "\" IDENTIFIED BY " + pwd;
                }

                oc.CommandText = sql;
                oc.ExecuteNonQuery();

                status = true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                conn.Close();
            }

            return status;
        }

        public bool deleteUserInDatabase(String username)
        {
            bool status = false;
            username = username.ToUpper();

            // Tạo kết nối trực tiếp tới Oracle
            OracleConnection conn = ConnectToOracle();

            try
            {
                // Tạo một đối tượng Command
                OracleCommand oc = new OracleCommand();
                // Liên hợp Command với Connection
                oc.Connection = conn;
                string sql = "ALTER SESSION SET \"_ORACLE_SCRIPT\" = true"; // sửa lỗi invalid common user or role name
                oc.CommandText = sql;
                oc.ExecuteNonQuery();

                if (((username[0] >= 'a') && (username[0] <= 'z')) || ((username[0] >= 'A') && (username[0] <= 'Z')))
                {
                    sql = "DROP USER " + username + " CASCADE";
                }
                else
                {
                    sql = "DROP USER \"" + username + "\" CASCADE";
                }

                oc.CommandText = sql;

                oc.ExecuteNonQuery();

                status = true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                conn.Close();
            }

            return status;
        }

        public bool createRoleInDatabase(String rolename, String pwd)
        {
            bool status = false;
            rolename = rolename.ToUpper();

            // Tạo kết nối trực tiếp tới Oracle
            OracleConnection conn = ConnectToOracle();

            try
            {

                OracleCommand oc = new OracleCommand();
                oc.Connection = conn;

                string sql = "ALTER SESSION SET \"_ORACLE_SCRIPT\" = true"; // sửa lỗi invalid common user or role name
                oc.CommandText = sql;
                oc.ExecuteNonQuery();

                if (((rolename[0] >= 'a') && (rolename[0] <= 'z')) || ((rolename[0] >= 'A') && (rolename[0] <= 'Z')))
                {
                    sql = "CREATE ROLE " + rolename;
                }
                else
                {
                    sql = "CREATE ROLE \"" + rolename + "\"";
                }

                if (pwd.Length > 0)
                {
                    sql += " IDENTIFIED BY " + pwd;
                }

                oc.CommandText = sql;
                oc.ExecuteNonQuery();

                status = true;

            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                conn.Close();
            }

            return status;
        }

        public bool updateRoleInDatabase(String rolename, String pwd)   // đổi mật khẩu role
        {
            bool status = false;
            rolename = rolename.ToUpper();

            // Tạo kết nối trực tiếp tới Oracle
            OracleConnection conn = ConnectToOracle();

            try
            {
                // Tạo một đối tượng Command
                OracleCommand oc = new OracleCommand();
                // Liên hợp Command với Connection
                oc.Connection = conn;
                string sql = "ALTER SESSION SET \"_ORACLE_SCRIPT\" = true"; // sửa lỗi invalid common user or role name
                oc.CommandText = sql;
                oc.ExecuteNonQuery();

                if (((rolename[0] >= 'a') && (rolename[0] <= 'z')) || ((rolename[0] >= 'A') && (rolename[0] <= 'Z')))
                {
                    sql = "ALTER ROLE " + rolename + " IDENTIFIED BY " + pwd;
                }
                else
                {
                    sql = "ALTER ROLE \"" + rolename + "\"" + " IDENTIFIED BY " + pwd;
                }

                oc.CommandText = sql;

                oc.ExecuteNonQuery();

                status = true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                conn.Close();
            }

            return status;
        }

        public bool deleteRoleInDatabase(String rolename)
        {
            bool status = false;
            rolename = rolename.ToUpper();

            // Tạo kết nối trực tiếp tới Oracle
            OracleConnection conn = ConnectToOracle();

            try
            {
                // Tạo một đối tượng Command
                OracleCommand oc = new OracleCommand();
                // Liên hợp Command với Connection
                oc.Connection = conn;

                string sql = "ALTER SESSION SET \"_ORACLE_SCRIPT\" = true"; // sửa lỗi invalid common user or role name
                oc.CommandText = sql;
                oc.ExecuteNonQuery();

                if (((rolename[0] >= 'a') && (rolename[0] <= 'z')) || ((rolename[0] >= 'A') && (rolename[0] <= 'Z')))
                {
                    sql = "DROP ROLE " + rolename;
                }
                else
                {
                    sql = "DROP ROLE \"" + rolename + "\"";
                }

                oc.CommandText = sql;

                // Thực thi thủ tục.
                oc.ExecuteNonQuery();

                status = true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                conn.Close();
            }

            return status;
        }

        public bool revokePrivUserInDatabase(String user, String priv)
        {
            bool status = false;

            // Tạo kết nối trực tiếp tới Oracle
            OracleConnection conn = ConnectToOracle();

            try
            {
                // Tạo một đối tượng Command
                OracleCommand oc = new OracleCommand();
                // Liên hợp Command với Connection
                oc.Connection = conn;
                string sql = "ALTER SESSION SET \"_ORACLE_SCRIPT\" = true"; // sửa lỗi invalid common user or role name
                oc.CommandText = sql;
                oc.ExecuteNonQuery();

                if (((user[0] >= 'a') && (user[0] <= 'z')) || ((user[0] >= 'A') && (user[0] <= 'Z')))
                {
                    sql = "REVOKE " + priv + " FROM " + user + " container=CURRENT ";
                }
                else
                {
                    sql = "REVOKE " + priv + " FROM '" + user + "' container=CURRENT ";
                }

                oc.CommandText = sql;

                oc.ExecuteNonQuery();

                status = true;

            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                conn.Close();
            }

            return status;
        }

        public bool revokePrivRoleInDatabase(String role, String priv)
        {
            bool status = false;

            // Tạo kết nối trực tiếp tới Oracle
            OracleConnection conn = ConnectToOracle();

            try
            {
                // Tạo một đối tượng Command
                OracleCommand oc = new OracleCommand();
                // Liên hợp Command với Connection
                oc.Connection = conn;
                string sql = "ALTER SESSION SET \"_ORACLE_SCRIPT\" = true"; // sửa lỗi invalid common user or role name

                oc.CommandText = sql;
                oc.ExecuteNonQuery();

                if (((role[0] >= 'a') && (role[0] <= 'z')) || ((role[0] >= 'A') && (role[0] <= 'Z')))
                {
                    sql = "REVOKE " + priv + " FROM " + role + " container=CURRENT ";
                }
                else
                {
                    sql = "REVOKE " + priv + " FROM '" + role + "' container=CURRENT ";
                }

                oc.CommandText = sql;

                // Thực thi thủ tục.
                oc.ExecuteNonQuery();

                status = true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                conn.Close();
            }

            return status;
        }


        // lấy danh sách quyền hệ thống (system privileges) của user hoặc role
        public List<Privilege> GetPrivilegesByUserNameOrRoleName(string name)
        {
            var privileges = new List<Privilege>();
            OracleConnection conn = ConnectToOracle();
            OracleCommand oc = new OracleCommand();
            oc.Connection = conn;
            oc.CommandText = "SELECT GRANTEE, PRIVILEGE, ADMIN_OPTION FROM DBA_SYS_PRIVS WHERE GRANTEE = '" + name + "'";
            using (DbDataReader reader = oc.ExecuteReader())
            {

                while (reader.Read())
                {
                    // Chỉ số (index) của cột GRANTEE trong câu lệnh SQL.
                    int UsernaneIndex = reader.GetOrdinal("GRANTEE"); // 0
                    string Username = reader.GetString(UsernaneIndex);

                    // Chỉ số của cột PRIVILEGE là 1.
                    int privilegeIndex = reader.GetOrdinal("PRIVILEGE");// 1
                    string privilege = reader.GetString(privilegeIndex);


                    int admin_optionIndex = reader.GetOrdinal("ADMIN_OPTION");
                    string admin_option = reader.GetString(admin_optionIndex);

                    privileges.Add(new Privilege(Username, privilege, admin_option));
                }
            }
            conn.Close();
            return privileges;
        }

        public void GrantUserToRole(string query)
        {
            OracleConnection conn = ConnectToOracle();
            OracleCommand oc = new OracleCommand();
            oc.Connection = conn;
            oc.CommandText = query;
            oc.ExecuteNonQuery();
        }

        public void RevokeUserFromRole(string query)
        {
            OracleConnection conn = ConnectToOracle();
            OracleCommand oc = new OracleCommand();
            oc.Connection = conn;
            oc.CommandText = query;
            oc.ExecuteNonQuery();
        }

        public List<Role> GetListPrivilegeSYSDAL()
        {
            var pri = new List<Role>();
            OracleConnection conn = ConnectToOracle();
            OracleCommand oc = new OracleCommand();
            oc.Connection = conn;
            oc.CommandText = "SELECT distinct(privilege) FROM dba_sys_privs";
            var reader = oc.ExecuteReader();
            while (reader.Read())
            {
                pri.Add(new Role(reader.GetString(0)));
            }
            conn.Close();
            return pri;
        }

        public void grantPriToRoleDAL(string query)
        {
            OracleConnection conn = ConnectToOracle();
            OracleCommand oc = new OracleCommand();
            oc.Connection = conn;
            oc.CommandText = query;
            oc.ExecuteNonQuery();
        }

        public List<ObjectDB> getListObjectDB()
        {
            var objectDB = new List<ObjectDB>();
            OracleConnection conn = ConnectToOracle();
            OracleCommand oc = new OracleCommand();
            oc.Connection = conn;
            oc.CommandText = "SELECT OBJECT_NAME, OBJECT_TYPE FROM USER_OBJECTS WHERE OBJECT_TYPE != 'SEQUENCE'";
            var reader = oc.ExecuteReader();
            while (reader.Read())
            {
                objectDB.Add(new ObjectDB(reader.GetString(0), reader.GetString(1)));
            }
            conn.Close();
            return objectDB;
        }

        //public List<Privilege> GetPrivilegesOfUser(string username)
        //{

        //}
    }
}

