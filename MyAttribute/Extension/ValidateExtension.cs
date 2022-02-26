using System.Reflection;

namespace MyAttribute.Extension;

public static class ValidateExtension
{
    public static bool Validate(this object o)
    {
        Type type = o.GetType();
        foreach (PropertyInfo propertyInfo in type.GetProperties())
        {
            if (propertyInfo.IsDefined(typeof(LongAttribute), true))
            {
                LongAttribute attribute = (LongAttribute)type.GetCustomAttribute(typeof(LongAttribute), true)!;
                if (!attribute.Validate(propertyInfo.GetValue(o)))
                {
                    return false;
                }
            }
        }

        return true;
    }
}

public class LongAttribute : Attribute
{
    private long _Min = 0;
    private long _Max = 0;

    public LongAttribute(long _min, long _max)
    {
        _Min = _min;
        _Max = _max;
    }

    public bool Validate(object? value)
    {
        if (value != null && !string.IsNullOrWhiteSpace(value.ToString()))
        {
            if (long.TryParse(value.ToString(), out long IResult))
            {
                if (IResult > _Min && IResult < _Max)
                {
                    return true;
                }
            }
        }

        return false;
    }
}