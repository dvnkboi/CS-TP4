using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Text;

namespace ModelApp
{
    abstract class Model
    {
        public int id = 0;
        private string sql = "";

        private Dictionary<string, T> ObjectToDictionary<T>(Object obj)
        {
            var json = JsonConvert.SerializeObject(obj);
            var dico = JsonConvert.DeserializeObject<Dictionary<string, T>>(json);
            return dico;
        }

        private static dynamic DictionaryToObject(Dictionary<String, object> dico)
        {
            if (dico.Count == 0) return null;

            dynamic ret = new ExpandoObject();
            foreach (var keyValue in dico)
            {
                ret[keyValue.Key] = keyValue.Value;
            }
            return ret;
        }

        public int save()
        {
            Dictionary<string, string> dico = new Dictionary<string, string>();
            dico = ObjectToDictionary<string>(this);

            if(this.find() == null)
            {
                //insert
                sql = $"insert into ${this.GetType().Name}(";

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
                sql = $"update ${this.GetType().Name} set";
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
            sql = "select * from " + this.GetType().Name + " where id=" + id;

            //field information
            ch = Connection.GetTableFields(this.GetType().Name);
            Type type = null;
            string fieldName = "";


            IDataReader reader = Connection.Select(sql);
            int fieldCount = reader.FieldCount;

            while (reader.Read())
            {
                for (int i = 0; i < fieldCount; i++)
                {
                    fieldName = ch.Keys.ElementAt(i);
                    type = Type.GetType(ch.Values.ElementAt(i), false, false);
                    dico.Add(fieldName, Convert.ChangeType(reader.GetValue(i), type));
                }
            }

            return DictionaryToObject(dico);
        }

        public int delete()
        {
            sql = "delete from " + this.GetType().Name + " where id=" + id;
            return Connection.IUD(sql);
        }

        public List<dynamic> All()
        {
            Dictionary<string, object> dico = new Dictionary<string, object>();
            Dictionary<string, string> ch = new Dictionary<string, string>();
            List<dynamic> retList = new List<dynamic>();

            sql = "select * from " + this.GetType().Name;

            //field information
            ch = Connection.GetTableFields(this.GetType().Name);
            Type type = null;
            string fieldName = "";


            IDataReader reader = Connection.Select(sql);
            int fieldCount = reader.FieldCount;

            while (reader.Read())
            {
                for (int i = 0; i < fieldCount; i++)
                {
                    fieldName = ch.Keys.ElementAt(i);
                    type = Type.GetType(ch.Values.ElementAt(i), false, false);
                    dico.Add(fieldName, Convert.ChangeType(reader.GetValue(i), type));
                }
                retList.Add( Convert.ChangeType(DictionaryToObject(dico),this.GetType()));
                dico.Clear();
            }

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
                    type = Type.GetType(ch.Values.ElementAt(i), false, false);
                    dico.Add(fieldName, Convert.ChangeType(reader.GetValue(i), type));
                }
                retList.Add(Convert.ChangeType(DictionaryToObject(dico), typeof(T)));
                dico.Clear();
            }

            return retList;
        }


    }
}
