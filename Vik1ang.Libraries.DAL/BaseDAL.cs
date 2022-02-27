using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using Vik1ang.Framework;
using Vik1ang.Framework.AttributeExtend;
using Vik1ang.Libraries.Model;

namespace Vik1ang.Libraries.DAL
{
    public class BaseDAL
    {
        /// <summary>
        /// 约束是为了正确的调用, 才能 int Id
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="id"></param>
        public T Find<T>(int id) where T : BaseModel
        {
            Type type = typeof(T);
            string columnString = string.Join(",", type.GetProperties().Select(p => $"[{p.GetColumnName()}]"));
            string sql = $"SELECT {columnString} FROM [{type.Name}] WHERE Id = {id}";
            T t = (T)Activator.CreateInstance(type);
            using (SqlConnection connection = new SqlConnection(StaticConstant.SqlServerConnString))
            {
                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();
                SqlDataReader sqlDataReader = command.ExecuteReader();
                List<T> list = ReaderToList<T>(sqlDataReader);
                t = list.FirstOrDefault();
            }

            return t;
        }

        public List<T> FindAll<T>() where T : BaseModel
        {
            Type type = typeof(T);
            string columnString = string.Join(",", type.GetProperties().Select(p => $"[{p.GetColumnName()}]"));
            string sql = $"SELECT {columnString} FROM [{type.Name}]";
            T t = (T)Activator.CreateInstance(type);
            List<T> list = new List<T>();
            using (SqlConnection connection = new SqlConnection(StaticConstant.SqlServerConnString))
            {
                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();
                SqlDataReader sqlDataReader = command.ExecuteReader();
                list = ReaderToList<T>(sqlDataReader);
            }

            return list;
        }

        public void Update<T>(T t) where T : BaseModel
        {
            Type type = typeof(T);
            string columnString = string.Join(",",
                type.GetProperties().Select(p => $"[{p.GetColumnName()}]=@{p.GetColumnName()}"));
            SqlParameter[] sqlParameters = type.GetProperties().Where(p => !p.Name.Equals("Id")).Select(p => new SqlParameter($"@{p.GetColumnName()}", p.GetValue(t) ?? DBNull.Value)).ToArray();
            string sql = $"UPDATE {type.Name} SET {columnString} WHERE Id={t.Id}";
            using (SqlConnection connection = new SqlConnection(StaticConstant.SqlServerConnString))
            {
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddRange(sqlParameters);
                connection.Open();
                int result = command.ExecuteNonQuery();
                if (result == 0)
                {
                    throw new Exception("数据不存在");
                }
            }
        }

        public void Insert<T>(T t) where T : BaseModel
        {
            throw new NotImplementedException();
        }

        public void Delete<T>(int id) where T : BaseModel
        {
            throw new NotImplementedException();
        }

        #region PrivateMethod

        private List<T> ReaderToList<T>(SqlDataReader sqlDataReader)
        {
            Type type = typeof(T);
            List<T> list = new List<T>();
            T t = (T)Activator.CreateInstance(type);
            while (sqlDataReader.Read())
            {
                foreach (PropertyInfo propertyInfo in type.GetProperties())
                {
                    propertyInfo.SetValue(t, sqlDataReader[propertyInfo.GetColumnName()] is DBNull ? null : sqlDataReader[propertyInfo.Name]);
                }
                list.Add(t);
            }

            return list;
        }

        #endregion PrivateMethod
    }
}