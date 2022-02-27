using System;
using System.Linq;
using Vik1ang.Framework.AttributeExtend;
using Vik1ang.Framework.Model;

namespace Vik1ang.Libraries.DAL
{
    public class TSqlHelper<T> where T : BaseModel
    {
        public static string FindSql = null;
        public static string FindAllSql = null;

        static TSqlHelper()
        {
            Type type = typeof(T);
            string columnString = string.Join(",", type.GetProperties().Select(p => $"[{p.GetColumnName()}]"));
            FindSql = $"SELECT {columnString} FROM [{type.Name}] WHERE Id=";
            FindAllSql = $"SELECT {columnString} FROM [{type.Name}]";
        }
    }
}