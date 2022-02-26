using System.Reflection;

namespace MyAttribute;

public class Manager
{
    public static void Show(Student student)
    {
        Type type = typeof(Student);
        if (type.IsDefined(typeof(CustomAttribute), true))
        {
            CustomAttribute? attribute = (CustomAttribute)type.GetCustomAttribute(typeof(CustomAttribute), true)!;
            Console.WriteLine($"{attribute?.Description}_{attribute?.Remark}");
            attribute?.Show();
        }

        PropertyInfo? propertyInfo = type.GetProperty("Id");
        if (propertyInfo!.IsDefined(typeof(CustomAttribute), true))
        {
            CustomAttribute? attribute = (CustomAttribute)type.GetCustomAttribute(typeof(CustomAttribute))!;
            Console.WriteLine($"{attribute.Description}_{attribute.Remark}");
            attribute.Show();
        }

        MethodInfo? methodInfo = type.GetMethod("Answer");
        if (methodInfo!.IsDefined(typeof(CustomAttribute), true))
        {
            CustomAttribute? attribute = (CustomAttribute)type.GetCustomAttribute(typeof(CustomAttribute))!;
            Console.WriteLine($"{attribute.Description}_{attribute.Remark}");
            attribute.Show();
        }

        ParameterInfo? parameterInfo = methodInfo.GetParameters()[0];
        if (parameterInfo.IsDefined(typeof(CustomAttribute), true))
        {
            CustomAttribute? attribute = (CustomAttribute)type.GetCustomAttribute(typeof(CustomAttribute))!;
            Console.WriteLine($"{attribute.Description}_{attribute.Remark}");
            attribute.Show();
        }

        student.Study();
        string result = student.Answer("Eleven");
    }
}