using System.Reflection;

namespace Vik1ang.Framework.AttributeExtend
{
    public static class AttributeHelper
    {
        public static string GetColumnName(this PropertyInfo propertyInfo)
        {
            if (propertyInfo.IsDefined(typeof(ColumnAttribute), true))
            {
                ColumnAttribute attribute =
                    (ColumnAttribute)propertyInfo.GetCustomAttribute(typeof(ColumnAttribute), true);
                return attribute.GetColumnName();
            }

            return propertyInfo.Name;
        }
    }
}