namespace MyAttribute;

internal class Program
{
    public static void Main(string[] args)
    {
        try
        {
            {
                Student student = new Student
                {
                    Id = 123,
                    Name = "time"
                };
                // student.Study();
                // string result = student.Answer("Eleven");
                Manager.Show(student);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }

        Console.ReadKey();
    }
}