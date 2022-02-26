using System.Reflection;

namespace MyAttribute.Extension;

public static class RemarkExtension
{
    public static string GetRemark(this Enum value)
    {
        Type type = value.GetType();
        FieldInfo? field = type.GetField(value.ToString());
        if (field!.IsDefined(typeof(RemarkAttribute), true))
        {
            RemarkAttribute attribute = (RemarkAttribute)field.GetCustomAttribute(typeof(RemarkAttribute), true)!;
            return attribute.GetRemark();
        }

        return value.ToString();
    }
}

public enum UserState
{
    [Remark("正常")]
    Normal = 0,

    [Remark("正常")]
    Frozen = 1,

    // [Remark("正常")]
    Deleted = 2
}

public class RemarkAttribute : Attribute
{
    private string _Remark;

    public RemarkAttribute(string remark)
    {
        _Remark = remark;
    }

    public string GetRemark()
    {
        return _Remark;
    }
}