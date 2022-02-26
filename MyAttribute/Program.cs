using MyAttribute.Extension;

namespace MyAttribute;

internal class Program
{
    public static void Main(string[] args)
    {
        try
        {
            /* {
                 Student student = new Student
                 {
                     Id = 123,
                     Name = "time"
                 };
                 // student.Study();
                 // string result = student.Answer("Eleven");
                 Manager.Show(student);
             }*/

            {
                Console.WriteLine(UserState.Normal.GetRemark());
                Console.WriteLine(UserState.Frozen.GetRemark());
                Console.WriteLine(UserState.Deleted.GetRemark());
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}