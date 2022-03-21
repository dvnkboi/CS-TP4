﻿using ClaySharp;
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
        public int id = 0;
        private string sql = "";

        private Dictionary<string, T> ObjectToDictionary<T>(Object obj)
        {
            var json = JsonConvert.SerializeObject(obj);
            var dico = JsonConvert.DeserializeObject<Dictionary<string, T>>(json);
            return dico;
        }

        private dynamic DictionaryToObject(Dictionary<String, object> dico)
        {
            //does not work
            var obj = Activator.CreateInstance(this.GetType());

            foreach (var kv in dico)
            {
                var prop = this.GetType().GetProperty(kv.Key);
                if (prop == null) continue;

                object value = kv.Value;
                if (value is Dictionary<string, object>)
                {
                    value = DictionaryToObject((Dictionary<string, object>)value, prop.PropertyType);
                }

                prop.SetValue(obj, value, null);
            }
            return obj;
        }

        private static dynamic DictionaryToObject(Dictionary<String, object> dico, Type type)
        {
            //does not work 
            var obj = Activator.CreateInstance(type);

            foreach (var kv in dico)
            {
                var prop = type.GetProperty(kv.Key);
                if (prop == null) continue;

                object value = kv.Value;
                if (value is Dictionary<string, object>)
                {
                    value = DictionaryToObject((Dictionary<string, object>)value, prop.PropertyType);
                }

                prop.SetValue(obj, value, null);
            }
            return obj;
        }

        public int save()
        {
            Dictionary<string, string> dico = new Dictionary<string, string>();
            dico = ObjectToDictionary<string>(this);

            if (this.find() == null)
            {
                //insert
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
            }
            else
            {
                //update
                sql = $"update {this.GetType().Name} set ";
                foreach (KeyValuePair<string, string> field in dico)
                {
                    sql += $"{field.Key}='{field.Value}',";
                }
                sql = sql.Remove(sql.Length - 1);
                sql += $"where id='{id}'";
            }

            return Connection.IUD(sql);
        }

        public dynamic find()
        {
            Dictionary<string, object> dico = new Dictionary<string, object>();
            Dictionary<string, string> ch = new Dictionary<string, string>();
            sql = $"select * from {this.GetType().Name} where id='{id}'";

            //field information
            ch = Connection.GetTableFields(this.GetType().Name);
            Type type = null;
            string fieldName = "";

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
                    dico.Add(fieldName, Convert.ChangeType(reader.GetValue(i), type));
                }
            }

            reader.Close();
            return DictionaryToObject(dico, this.GetType());
        }

        public int delete()
        {
            sql = $"delete from {this.GetType().Name} where id='{id}'";
            return Connection.IUD(sql);
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

                    //add column to dictionary and change the column type from object to the indicated type 
                    dico.Add(fieldName, Convert.ChangeType(reader.GetValue(i), type));
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


            IDataReader reader = Connection.Select(sql);
            int fieldCount = reader.FieldCount;

            while (reader.Read())
            {
                for (int i = 0; i < fieldCount; i++)
                {
                    fieldName = ch.Keys.ElementAt(i);
                    type = SqlToType(ch.Values.ElementAt(i));
                    dico.Add(fieldName, Convert.ChangeType(reader.GetValue(i), type));
                }
                retList.Add(DictionaryToObject(dico,typeof(T)));
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

                    //add column to dictionary and change the column type from object to the indicated type 
                    dicoRes.Add(fieldName, Convert.ChangeType(reader.GetValue(i), type));
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

            string sql = $"select * from {typeof(T).Name} where ";

            foreach (KeyValuePair<string, object> field in dico)
            {
                sql += $"{field.Key} = '{field.Value.ToString()}' and";
            }
            sql = sql.Remove(sql.Length - 3);

            //table field information
            ch = Connection.GetTableFields(typeof(T).Name);
            Type type = null;
            string fieldName = "";

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

                    //add column to dictionary and change the column type from object to the indicated type 
                    dicoRes.Add(fieldName, Convert.ChangeType(reader.GetValue(i), type));
                }

                //add row to list
                retList.Add(DictionaryToObject(dicoRes, typeof(T)));
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
