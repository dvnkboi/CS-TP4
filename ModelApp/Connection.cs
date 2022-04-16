using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Text;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;

namespace ModelApp
{
    public class Connection
    {
        public static IDbConnection con = null;
        public static IDbCommand cmd = null;
        public static string Server = null;
        public static string conString = null;
        public static Dictionary<string, Dictionary<string, string>> _schemaMap = new Dictionary<string, Dictionary<string, string>>();
        public static bool IsConnected
        {
            get
            {
                return con != null && con.State == ConnectionState.Open;
            }
        }

        public static bool DatabaseProvided(string conString, string Server = null)
        {
            switch (Server)
            {
                case "mssql":
                    return conString.ToLower().Contains("initial catalog");
                case "mysql":
                    return conString.ToLower().Contains("database");
                default:
                    throw new Exception("database server not supported... yikes kinda cringe");
            }
        }

        public static void Connect(string cstr, string server)
        {
            Server = server.Trim().ToLower();
            conString = cstr;
            if (con != null && IsConnected) return;

            switch (Server)
            {
                case "mssql":
                    con = new SqlConnection(cstr);
                    cmd = new SqlCommand("", (SqlConnection) con);
                    con.Open();
                    break;
                case "mysql":
                    con = new MySqlConnection(cstr);
                    cmd = new MySqlCommand("",(MySqlConnection) con);
                    con.Open();
                    break;
                default:
                    throw new Exception("database server not supported... yikes kinda cringe");
            }
        }

        public static int IUD(string req)
        {
            cmd.CommandText = req;
            int scalar = cmd.ExecuteNonQuery();
            return scalar;
        }

        public static void resetCmd()
        {
            cmd.CommandText = "";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Clear();
        }

        public static IDataReader Select(string req)
        {
            cmd.CommandText = req;
            return cmd.ExecuteReader();
        }

        public static Dictionary<string, string> GetTableFields(string table)
        {
            if (_schemaMap.ContainsKey(table)) return _schemaMap[table];

            switch (Server)
            {
                case "mssql":
                    cmd.CommandText = $"SELECT COLUMN_NAME, DATA_TYPE FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{table}'";
                    break;
                case "mysql":
                    cmd.CommandText = $"SELECT COLUMN_NAME,COLUMN_TYPE FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA = '{con.Database}' AND TABLE_NAME = '{table}'";
                    break;
                default:
                    throw new Exception("database server not supported... yikes kinda cringe");
            }
            
            IDataReader reader = cmd.ExecuteReader();
            Dictionary<string, string> res = new Dictionary<string,string>();

            while (reader.Read())
            {
                res.Add(reader.GetString(0) , reader.GetString(1));
            }

            reader.Close();
            _schemaMap.Add(table, res);
            return res;
        }

        public static void Close()
        {
            if (con != null && IsConnected) con.Close();
        }

        public static void Execute(string text)
        {
            switch (Server)
            {
                case "mssql":
                    Server server = new Server(new ServerConnection((Microsoft.Data.SqlClient.SqlConnection)con));
                    server.ConnectionContext.ExecuteNonQuery(text);
                    break;
                case "mysql":
                    MySqlScript script = new MySqlScript((MySqlConnection)con, text);
                    script.Execute();
                    break;
                default:
                    throw new Exception("database server not supported... yikes kinda cringe");
            }
        }

        public static void AddParameter(string key, Object value)
        {
            cmd.CommandType = CommandType.StoredProcedure;
            switch (Server)
            {
                case "mssql":
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@"+key, value));
                    break;
                case "mysql":
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new MySqlParameter(key, value));
                    break;
                default:
                    throw new Exception("database server not supported... yikes kinda cringe");
            }
        }

        public static void CreateDb(string conString,string server,string db)
        {
            Server = server.ToLower().Trim();
            switch (Server)
            {
                case "mssql":
                    Connect(concatDb(conString, server, "master"), "mssql");
                    IUD($"Create database {db}");
                    break;
                case "mysql":
                    Connect(concatDb(conString, server, "mysql"), "mysql");
                    IUD($"Create database {db}");
                    break;
                default:
                    throw new Exception("database server not supported... yikes kinda cringe");
            }
        }

        public static string concatDb(string conString, string server, string db)
        {
            Server = server.ToLower().Trim();
            string cstr = conString;
            switch (Server)
            {
                case "mssql":
                    cstr += $"Initial Catalog={db};";
                    return cstr;
                case "mysql":
                    cstr += $"Database={db};";
                    return cstr;
                default:
                    throw new Exception("database server not supported... yikes kinda cringe");
            }
        }

        public static string concatStr(string host, string server, string user = null, string pass = null , string db = null, string[] opt = null)
        {
            Server = server.ToLower().Trim();
            string cstr = "";
            switch (Server)
            {
                case "mssql":
                    cstr += $"Data Source={host};";
                    cstr += db != null && db.Trim() != "" ? $"Initial Catalog={db};" : "";
                    cstr += user != null && user.Trim() != "" ? $"User ID={user};" : "";
                    cstr += pass != null && pass.Trim() != "" ? $"Password={pass};" : "";
                    cstr += opt != null &&  opt.Length != 0 ? $"{String.Join(";",opt)};" : "";
                    return cstr;
                case "mysql":
                    cstr += $"Server={host};";
                    cstr += db != null && db.Trim() != "" ? $"Database={db};" : "";
                    cstr += user != null && user.Trim() != "" ? $"Uid={user};" : "";
                    cstr += pass != null && pass.Trim() != "" ? $"Pwd={pass};" : "";
                    cstr += opt != null && opt.Length != 0 ? $"{String.Join(";",opt)};" : "";
                    return cstr;
                default:
                    throw new Exception("database server not supported... yikes kinda cringe");
            }
        }
    }
}
