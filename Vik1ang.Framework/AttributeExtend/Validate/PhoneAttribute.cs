using System.Text.RegularExpressions;

namespace Vik1ang.Framework.AttributeExtend.Validate
{
    public class PhoneAttribute : AbstractValidateAttribute
    {
        public override bool Validate(object value)
        {
            return value != null && Regex.IsMatch(value.ToString(), @"^[1]+[3,5]+\d{9}");
        }
    }
}