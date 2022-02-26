using System;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using Vik1ang.Framework;
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
        public static T Find<T>(int id) where T : BaseModel
        {
            Type type = typeof(T);
            string columnString = string.Join(",", type.GetProperties().Select(p => $"[{p.Name}]"));
            string sql = $"SELECT {columnString} FROM [{type.Name}] WHERE Id = {id}";
            T t = (T)Activator.CreateInstance(type);
            using (SqlConnection connection = new SqlConnection(StaticConstant.SqlServerConnString))
            {
                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();
                SqlDataReader sqlDataReader = command.ExecuteReader();
                if (sqlDataReader.Read()) // 表示有数据 开始读
                {
                    foreach (PropertyInfo propertyInfo in type.GetProperties())
                    {
                        propertyInfo.SetValue(t, sqlDataReader[propertyInfo.Name]);
                    }
                }
            }

            return t;
        }
    }
}