using System;

namespace Vik1ang.Framework.AttributeExtend
{
    public class ColumnAttribute : Attribute
    {
        private readonly string _Name = null;

        public ColumnAttribute(string name)
        {
            _Name = name;
        }

        public string GetColumnName()
        {
            return _Name;
        }
    }
}