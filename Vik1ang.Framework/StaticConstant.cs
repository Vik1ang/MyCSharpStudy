using System.Configuration;

namespace Vik1ang.Framework
{
    public class StaticConstant
    {
        /// <summary>
        /// SqlServer 数据库连接
        /// </summary>
        public static string SqlServerConnString = ConfigurationManager.ConnectionStrings["Customers"].ConnectionString;

        private static readonly string DALTypeDLL = ConfigurationManager.AppSettings["IDBHELPER"].ToString();
        public static string DALDLLName = DALTypeDLL.Split(',')[1];
        public static string DALTypeName = DALTypeDLL.Split(',')[0];
    }
}