namespace MyAttribute;

[Obsolete("请不要使用这个了, 请使用什么来代替", false)]
[Serializable]
// [CustomAttribute]
[Custom]
[Custom()]
[Custom(123), Custom(123, Description = "1234")]
public class Student
{
    [Custom]
    public int Id { get; set; }

    public string Name { get; set; }

    public void Study()
    {
        Console.WriteLine($"这里是{this.Name}");
    }

    [Custom]
    [return: Custom]
    public string Answer([Custom] string name)
    {
        return $"This is {name}";
    }
}