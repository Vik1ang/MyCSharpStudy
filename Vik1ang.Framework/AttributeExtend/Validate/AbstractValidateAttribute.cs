using System;

namespace Vik1ang.Framework.AttributeExtend.Validate
{
    public abstract class AbstractValidateAttribute : Attribute
    {
        public abstract bool Validate(object value);
    }
}