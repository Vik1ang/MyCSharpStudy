namespace MyDelegateEvent;

public delegate void NoReturnNoParaOutClass();

public class MyDelegate
{
    //public delegate void NoReturnNoPara<T>(T t);

    public delegate void NoReturnNoPara();

    public delegate void NoReturnWithPara(int x, int y);

    public delegate int WithReturnNoPara();

    public delegate string WithReturnWithPara(out int x, ref int y);

    public delegate void GenericNoReturnNoPara<T>();

    public void Show()
    {
        Student student = new Student
        {
            Id = 96,
            Name = "Summer"
        };

        student.Study();

        {
            NoReturnNoPara method = new NoReturnNoPara(this.DoNothing);
            method.Invoke(); // 委托调用
            method();
        }

        {
            NoReturnNoPara method = new NoReturnNoPara(DoNothing);
            method += new NoReturnNoPara(DoNothing);
            method += new NoReturnNoPara(Student.StudyAdvanced);
            method += new NoReturnNoPara(new Student().Study);
            method();

            foreach (NoReturnNoPara item in method.GetInvocationList())
            {
                item();
            }
        }

        {
            WithReturnNoPara method = new WithReturnNoPara(GetValue);
            method += GetValue;
            Console.WriteLine(method());
        }
    }

    private void DoNothing()
    {
        Console.WriteLine("This is DoNothing");
    }

    private int GetValue()
    {
        return 3;
    }
}