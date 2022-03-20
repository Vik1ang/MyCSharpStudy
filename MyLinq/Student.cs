namespace MyLinq;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int ClassId { get; set; }
    public int Age { get; set; }

    public void Study()
    {
        Console.WriteLine("学习");
    }

    public static void StudyAdvanced()
    {
        Console.WriteLine("高级学习");
    }

    public static void Show()
    {
        Console.WriteLine("123");
    }
}