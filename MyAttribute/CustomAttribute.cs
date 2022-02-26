namespace MyAttribute;

[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class CustomAttribute : Attribute
{
    public CustomAttribute()
    { }

    public CustomAttribute(int id)
    {
    }

    public string Description { get; set; }

    public string? Remark = null;

    public void Show()
    {
        Console.WriteLine($"This is {nameof(CustomAttribute)}");
    }
}