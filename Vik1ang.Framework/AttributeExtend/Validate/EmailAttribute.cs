using System.Text.RegularExpressions;

namespace Vik1ang.Framework.AttributeExtend.Validate
{
    public class EmailAttribute : AbstractValidateAttribute
    {
        public override bool Validate(object value)
        {
            return value != null && Regex.IsMatch(value.ToString(), @"^\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$");
        }
    }
}