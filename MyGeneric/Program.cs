namespace MyGeneric;

public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            int iValue = 123;
            string sValue = "456";
            DateTime dtValue = DateTime.Now;
            object oValue = "MrSorry";

            Console.WriteLine("***************Generic*****************");

            GenericMethod.Show<int>(iValue);
            GenericMethod.Show(3);

            Console.WriteLine("***************Constraint*****************");
            {
                People people = new People
                {
                    Id = 123,
                    Name = "走自己的路"
                };
                Chinese chinese = new Chinese
                {
                    Id = 234,
                    Name = "晴天"
                };
                Hubei hubei = new Hubei
                {
                    Id = 345,
                    Name = "流年"
                };
                Japanese japanese = new Japanese
                {
                    Id = 456,
                    Name = "随机"
                };
                Constraint.Show<People>(people);
                Constraint.Show<Chinese>(chinese);
                // Constraint.Show(Japanese);
                
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
}