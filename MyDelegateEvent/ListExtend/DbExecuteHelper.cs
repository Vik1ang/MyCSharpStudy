namespace MyDelegateEvent.ListExtend;

public class DbExecuteHelper
{
    public static void SafeInvoke(Action act)
    {
        try
        {
            act.Invoke();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
}