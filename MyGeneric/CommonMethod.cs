namespace MyGeneric;

public class CommonMethod
{
    public static void ShowInt(int iParameter)
    {
        Console.WriteLine("This is {0}, parameter={1}, type={2}", typeof(CommonMethod).Name, iParameter.GetType().Name, iParameter);
    }
}