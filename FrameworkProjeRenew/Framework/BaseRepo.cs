using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using Dapper;

namespace Framework
{
    public class BaseRepo<T> : BaseRepository<T> where T : class
    {
        string tableName = typeof(T).Name;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ConnectionString);
        public void Create(T entity, bool idRemove)
        {
            //insert into Unvan(UnvanAd) values (@UnvanAd)
            var props = GetProperties();
            if (idRemove == true)
            {
                props.RemoveAt(0);
            }
            string cols = GetInsertColumns(props);
            string vals = GetVal(props);
            string sql = "insert into " + tableName + cols + vals;
            con.Execute(sql, entity);
        }

        private string GetVal(List<PropertyInfo> props)
        {
            string val = "values (";
            foreach (var item in props)
            {
                val += "@" + item.Name + ",";
            }
            val = val.Remove(val.Length - 1, 1);
            val += ")";
            return val;
        }

        private string GetInsertColumns(List<PropertyInfo> props)
        {
            string col = "(";
            foreach (var item in props)
            {
                col += item.Name + ",";
            }
            col = col.Remove(col.Length - 1, 1);
            col += ")";
            return col;
        }

        public void Delete(dynamic id)
        {
            var props = GetProperties();
            string key = props[0].Name;
            string qry = "delete from " + tableName + " where " + key + " = " + $"'{id}'";
            con.ExecuteScalar<int>(qry);
        }

        public T Find(dynamic id)
        {
            var props = GetProperties();
            string key = props[0].Name;
            string sql = "select * from " + tableName + " where " + key + " = " + $"'{id}'";
            var unvan = con.Query<T>(sql).First();
            return unvan;
        }

        public List<PropertyInfo> GetProperties()
        {
            var props = typeof(T).GetProperties().ToList();
            return props;
        }

        public List<T> List()
        {
            string sql = "select * from " + tableName;
            return con.Query<T>(sql).ToList();
        }

        public List<T> List(string tableName)
        {
            string qry = "select * from " + tableName;
            return con.Query<T>(qry).ToList();
        }

        public void Update(T entity, dynamic id, bool idRemove)
        {
            var props = GetProperties();
            string key = props[0].Name;
            if(idRemove == true)
            {
                props.RemoveAt(0);
            }
            string val = GetUpdateColumns(props);
            string sql = "update " + tableName + " " + val + " where " + key + " = " + $"'{id}'";
            con.Execute(sql, entity);
        }

        private string GetUpdateColumns(List<PropertyInfo> props)
        {
            string val = "set ";
            foreach (var item in props)
            {
                val += item.Name + " = " + "@" + item.Name + ",";
            }
            val = val.Remove(val.Length - 1, 1);
            return val;
        }
    }
}
