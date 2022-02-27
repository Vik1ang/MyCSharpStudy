using System;
using System.Reflection;
using Vik1ang.Framework.AttributeExtend.Validate;
using Vik1ang.Framework.Model;

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

        public static bool Validate<T>(this T tModel) where T : BaseModel
        {
            Type type = tModel.GetType();
            foreach (PropertyInfo propertyInfo in type.GetProperties())
            {
                object[] customAttributes = propertyInfo.GetCustomAttributes(typeof(AbstractValidateAttribute), true);
                foreach (AbstractValidateAttribute attribute in customAttributes)
                {
                    if (!attribute.Validate(tModel))
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}