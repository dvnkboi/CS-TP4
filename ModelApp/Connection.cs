using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ModelApp
{
    public class Connection
    {
        public static IDbConnection con = null;
        public static IDbCommand cmd = null;
        public static string Server = null;
        public static Dictionary<string, Dictionary<string, string>> _schemaMap = new Dictionary<string, Dictionary<string, string>>();

        public static void Connect(string cstr, string server)
        {
            Server = server.Trim().ToLower();
            if (con != null && con.State == ConnectionState.Open) return;

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
            if (con != null && con.State == ConnectionState.Open) con.Close();
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
    }
}
