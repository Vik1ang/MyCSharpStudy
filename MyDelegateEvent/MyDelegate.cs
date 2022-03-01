namespace MyDelegateEvent;

public delegate void NoReturnNoParaOutClass();

public class MyDelegate
{
    public delegate void NoReturnNoPara();

    public delegate void NoReturnWithPara(int x, int y);

    public delegate void WithReturnNoPara();

    public delegate string WithReturnWithPara(out int x, ref int y);

    public delegate void GenericNoReturnNoPara<T>();

    public void Show()
    {
        Student student = new Student
        {
            Id = 96,
            Name = "Summer"
        };
    }
}