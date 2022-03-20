namespace MyLinq;

public delegate void NoReturnNoParaOutClass();

public delegate void GenericDelegate();

public class LambdaShow
{
    public delegate void NoReturnNoPara();

    public delegate void NoReturnWithPara(int x, int y);

    public delegate int WithReturnNoPara();

    public delegate string WithReturnWithPara(out int x, out int y);

    public void Show()
    {
        {
            NoReturnNoPara method = () =>
            {
                Console.WriteLine("This is Do Nothing");
            };
        }
        {
            NoReturnWithPara method = (x, y) =>
            {
                Console.WriteLine($"{x}, {y}");
            };
        }
    }

    private void DoNothing()
    {
        Console.WriteLine("This is Do Nothing");
    }
}