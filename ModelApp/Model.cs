using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ModelApp
{
    public abstract class Model
    {
        public int id { get; set; }
        private string sql = "";

        private Dictionary<string, T> ObjectToDictionary<T>(Object obj)
        {
            var json = JsonConvert.SerializeObject(obj);
            var dico = JsonConvert.DeserializeObject<Dictionary<string, T>>(json);
            return dico;
        }

        private dynamic DictionaryToObject(Dictionary<String, object> dico)
        {
            if (dico.Keys.Count == 0) return null;

            Type type = this.GetType();
            var obj = Activator.CreateInstance(type);

            foreach (var kv in dico)
            {
                PropertyInfo info = type.GetProperty(kv.Key);
                info.SetValue(obj, Convert.ChangeType(kv.Value, info.PropertyType));
            }
            return Convert.ChangeType(obj,this.GetType());
        }

        private static dynamic DictionaryToObject<T>(Dictionary<String, object> dico)
        {
            if (dico.Keys.Count == 0) return null;

            var obj = Activator.CreateInstance(typeof(T));

            foreach (var kv in dico)
            {
                var prop = typeof(T).GetProperty(kv.Key);
                if (prop == null) continue;

                object value = kv.Value;
                if (value is Dictionary<string, object>)
                {
                    value = DictionaryToObject<T>((Dictionary<string, object>)value);
                }

                prop.SetValue(obj, Convert.ChangeType(value, prop.PropertyType) , null);
            }
            return obj;
        }

        public int save(string procedure = null)
        {
            Dictionary<string, string> dico = new Dictionary<string, string>();
            dico = ObjectToDictionary<string>(this);
            int ret = -1;

            Model ExistanceCheck = this.find();

            if (ExistanceCheck == null)
            {
                //insert
                try
                {
                    Connection.resetCmd();
                    sql = procedure!=null ? procedure : throw new Exception("no procedure passed");
                    foreach (KeyValuePair<string, string> field in dico)
                    {
                        Connection.AddParameter(field.Key,field.Value);
                    }
                    ret = Connection.IUD(sql);
                }
                catch (Exception)
                {
                    Connection.resetCmd();
                    sql = $"insert into {this.GetType().Name}(";

                    foreach (KeyValuePair<string, string> field in dico)
                    {
                        sql += $"{field.Key},";
                    }
                    sql = sql.Remove(sql.Length - 1);
                    sql += ") values(";

                    foreach (KeyValuePair<string, string> field in dico)
                    {
                        sql += $"'{field.Value}',";
                    }
                    sql = sql.Remove(sql.Length - 1);
                    sql += ")";
                    ret = Connection.IUD(sql);
                }
            }
            else
            {
                //update
                try
                {
                    Connection.resetCmd();
                    sql = procedure != null ? procedure : throw new Exception("no procedure passed");
                    foreach (KeyValuePair<string, string> field in dico)
                    {
                        Connection.AddParameter(field.Key, field.Value);
                    }
                    ret = Connection.IUD(sql);
                    
                }
                catch(Exception)
                {
                    Connection.resetCmd();
                    string tableAlias = this.GetType().Name.Substring(0, 1);
                    sql = $"update {this.GetType().Name} {tableAlias} set ";
                    dico.Remove("id");
                    foreach (KeyValuePair<string, string> field in dico)
                    {
                        sql += $"{tableAlias}.{field.Key}='{field.Value}',";
                    }
                    sql = sql.Remove(sql.Length - 1);
                    sql += $" where {tableAlias}.id='{id}'";
                    ret = Connection.IUD(sql);
                }
            }

            Connection.resetCmd();
            return ret;
        }

        public dynamic find()
        {
            Dictionary<string, object> dico = new Dictionary<string, object>();
            Dictionary<string, string> ch = new Dictionary<string, string>();
            sql = $"select * from {this.GetType().Name} where id={id}";

            //field information
            ch = Connection.GetTableFields(this.GetType().Name);
            Type type = null;
            string fieldName = "";
            int index = 0;

            //sql query execution
            IDataReader reader = Connection.Select(sql);
            int fieldCount = reader.FieldCount;

            //since id has to be unique (primary key) we dont have to check for unicity 
            while (reader.Read())
            {
                for (int i = 0; i < fieldCount; i++)
                {
                    fieldName = ch.Keys.ElementAt(i);
                    type = SqlToType(ch.Values.ElementAt(i));
                    index = reader.GetOrdinal(fieldName);
                    dico.Add(fieldName, Convert.ChangeType(reader.GetValue(index), type));
                }
            }

            reader.Close();
            return DictionaryToObject(dico);
        }

        public static dynamic find<T>(object id)
        {
            Dictionary<string, object> dico = new Dictionary<string, object>();
            Dictionary<string, string> ch = new Dictionary<string, string>();
            string sql = $"select * from {typeof(T).Name} where id={id}";

            //field information
            ch = Connection.GetTableFields(typeof(T).Name);
            Type type = null;
            string fieldName = "";
            int index = 0;

            //sql query execution
            IDataReader reader = Connection.Select(sql);
            int fieldCount = reader.FieldCount;

            //since id has to be unique (primary key) we dont have to check for unicity 
            while (reader.Read())
            {
                for (int i = 0; i < fieldCount; i++)
                {
                    fieldName = ch.Keys.ElementAt(i);
                    type = SqlToType(ch.Values.ElementAt(i));
                    index = reader.GetOrdinal(fieldName);
                    dico.Add(fieldName, Convert.ChangeType(reader.GetValue(index), type));
                }
            }

            reader.Close();
            return DictionaryToObject<T>(dico);
        }

        public int delete(string procedure = null)
        {
            int ret = 0;

            try
            {
                Connection.resetCmd();
                sql = procedure != null ? procedure : throw new Exception("no procedure passed");
                Connection.AddParameter("id", id);
                ret = Connection.IUD(sql);
            }
            catch(Exception)
            {
                Connection.resetCmd();
                sql = $"delete from {this.GetType().Name} where id='{id}'";
                ret = Connection.IUD(sql);
            }

            Connection.resetCmd();
            return ret;
        }

        public List<dynamic> All()
        {
            Dictionary<string, object> dico = new Dictionary<string, object>();
            Dictionary<string, string> ch = new Dictionary<string, string>();
            List<dynamic> retList = new List<dynamic>();

            sql = "select * from " + this.GetType().Name;

            //table field information
            ch = Connection.GetTableFields(this.GetType().Name);
            Type type = null;
            string fieldName = "";
            int index = 0;

            //get all fields and the field(column) count
            IDataReader reader = Connection.Select(sql);
            int fieldCount = reader.FieldCount;

            //read each row
            while (reader.Read())
            {
                //read each column
                for (int i = 0; i < fieldCount; i++)
                {
                    //get field name at col pos i
                    fieldName = ch.Keys.ElementAt(i);

                    //get type of field at col pos i, case insensitive
                    type = SqlToType(ch.Values.ElementAt(i));

                    //get index of field in reader
                    index = reader.GetOrdinal(fieldName);

                    //add column to dictionary and change the column type from object to the indicated type 
                    dico.Add(fieldName, Convert.ChangeType(reader.GetValue(index), type));
                }

                //add row to list
                retList.Add(Convert.ChangeType(DictionaryToObject(dico), this.GetType()));
                dico.Clear();
            }

            reader.Close();
            return retList;
        }

        public static List<dynamic> All<T>()
        {
            Dictionary<string, object> dico = new Dictionary<string, object>();
            Dictionary<string, string> ch = new Dictionary<string, string>();
            List<dynamic> retList = new List<dynamic>();

            string sql = "select * from " + typeof(T).Name;

            //field information
            ch = Connection.GetTableFields(typeof(T).Name);
            Type type = null;
            string fieldName = "";
            int index = 0;


            IDataReader reader = Connection.Select(sql);
            int fieldCount = reader.FieldCount;

            while (reader.Read())
            {
                for (int i = 0; i < fieldCount; i++)
                {
                    fieldName = ch.Keys.ElementAt(i);
                    type = SqlToType(ch.Values.ElementAt(i));
                    index = reader.GetOrdinal(fieldName);
                    dico.Add(fieldName, Convert.ChangeType(reader.GetValue(index), type));
                }
                retList.Add((T) DictionaryToObject<T>(dico));
                dico.Clear();
            }

            reader.Close();
            return retList;
        }

        public List<dynamic> select(Dictionary<string, object> dico)
        {
            Dictionary<string, object> dicoRes = new Dictionary<string, object>();
            Dictionary<string, string> ch = new Dictionary<string, string>();
            List<dynamic> retList = new List<dynamic>();

            sql = $"select * from {this.GetType().Name} where";

            foreach (KeyValuePair<string, object> field in dico)
            {
                sql += $" {field.Key} = '{field.Value.ToString()}' and";
            }
            sql = sql.Remove(sql.Length - 3);

            //table field information
            ch = Connection.GetTableFields(this.GetType().Name);
            Type type = null;
            string fieldName = "";
            int index = 0;

            //get all fields and the field(column) count
            IDataReader reader = Connection.Select(sql);
            int fieldCount = reader.FieldCount;

            //read each row
            while (reader.Read())
            {
                //read each column
                for (int i = 0; i < fieldCount; i++)
                {
                    //get field name at col pos i
                    fieldName = ch.Keys.ElementAt(i);

                    //get type of field at col pos i, case insensitive
                    type = SqlToType(ch.Values.ElementAt(i));

                    //get index of field in reader
                    index = reader.GetOrdinal(fieldName);

                    //add column to dictionary and change the column type from object to the indicated type 
                    dicoRes.Add(fieldName, Convert.ChangeType(reader.GetValue(index), type));
                }

                //add row to list
                retList.Add(Convert.ChangeType(DictionaryToObject(dicoRes), this.GetType()));
                dicoRes.Clear();
            }

            reader.Close();
            return retList;
        }

        public static List<dynamic> select<T>(Dictionary<string, object> dico)
        {
            Dictionary<string, object> dicoRes = new Dictionary<string, object>();
            Dictionary<string, string> ch = new Dictionary<string, string>();
            List<dynamic> retList = new List<dynamic>();

            string sql = $"select * from {typeof(T).Name} where";

            foreach (KeyValuePair<string, object> field in dico)
            {
                sql += $" {field.Key} = '{field.Value.ToString()}' and";
            }
            sql = sql.Remove(sql.Length - 3);

            //table field information
            ch = Connection.GetTableFields(typeof(T).Name);
            Type type = null;
            string fieldName = "";
            int index = 0;

            //get all fields and the field(column) count
            IDataReader reader = Connection.Select(sql);
            int fieldCount = reader.FieldCount;

            //read each row
            while (reader.Read())
            {
                //read each column
                for (int i = 0; i < fieldCount; i++)
                {
                    //get field name at col pos i
                    fieldName = ch.Keys.ElementAt(i);

                    //get type of field at col pos i, case insensitive
                    type = SqlToType(ch.Values.ElementAt(i));

                    //get index of field in reader
                    index = reader.GetOrdinal(fieldName);

                    //add column to dictionary and change the column type from object to the indicated type 
                    dicoRes.Add(fieldName, Convert.ChangeType(reader.GetValue(index), type));
                }

                //add row to list
                retList.Add((T) DictionaryToObject<T>(dicoRes));
                dicoRes.Clear();
            }

            reader.Close();
            return retList;
        }

        public static Type SqlToType(string sqlType)
        {
            sqlType = sqlType.Split("(")[0].ToLower();
            switch (sqlType)
            {
                case "bigint":
                case "real":
                    return typeof(long);
                case "numeric":
                    return typeof(decimal);
                case "bit":
                    return typeof(bool);

                case "smallint":
                    return typeof(short);

                case "decimal":
                case "smallmoney":
                case "money":
                    return typeof(decimal);

                case "int":
                    return typeof(int);

                case "tinyint":
                    return typeof(byte);

                case "float":
                    return typeof(float);

                case "date":
                case "datetime2":
                case "smalldatetime":
                case "datetime":
                case "time":
                    return typeof(DateTime);

                case "datetimeoffset":
                    return typeof(DateTimeOffset);

                case "char":
                case "varchar":
                case "text":
                case "nchar":
                case "nvarchar":
                case "ntext":
                    return typeof(string);


                case "binary":
                case "varbinary":
                case "image":
                    return typeof(byte[]);

                case "uniqueidentifier":
                    return typeof(Guid);

                default:
                    return typeof(string);

            }
        }
    }
}
