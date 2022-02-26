using Vik1ang.Libraries.DAL;
using Vik1ang.Libraries.Model;

namespace Vik1ang.Libraries.Project;

internal class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Project");
            Company company = BaseDAL.Find<Company>(1);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}