using System.Configuration;

namespace Vik1ang.Framework
{
    public class StaticConstant
    {
        /// <summary>
        /// SqlServer 数据库连接
        /// </summary>
        public static string SqlServerConnString = ConfigurationManager.ConnectionStrings["Customers"].ConnectionString;
    }
}