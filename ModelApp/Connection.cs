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
        static IDbConnection con = null;
        static IDbCommand cmd = null;

        public static void Connect(string cstr, string server)
        {
            if (con != null && con.State == ConnectionState.Open) return;

            switch (server)
            {
                case "MsSql":
                    con = new SqlConnection(cstr);
                    cmd = new SqlCommand("", (SqlConnection) con);
                    con.Open();
                    break;
                case "MySql":
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
            return cmd.ExecuteNonQuery();
        }

        public static IDataReader Select(string req)
        {
            cmd.CommandText = req;
            return cmd.ExecuteReader();
        }

        public static Dictionary<string, string> GetTableFields(string table)
        {
            cmd.CommandText = $"SELECT COLUMN_NAME,COLUMN_TYPE FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA = '{con.Database}' AND TABLE_NAME = '{table}'; ";
            IDataReader reader = cmd.ExecuteReader();
            Dictionary<string, string> res = new Dictionary<string,string>();

            while (reader.Read())
            {
                res.Add(reader.GetString(0) , reader.GetString(1));
            }

            reader.Close();
            return res;
        }

        public static void Close()
        {
            if (con != null && con.State == ConnectionState.Open) con.Close();
        }
    }
}
