using MyDelegateEvent.Event;

namespace MyDelegateEvent;

public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("委托和事件");

            {
                Console.WriteLine("*********Delegate********");
                MyDelegate myDelegate = new MyDelegate();
                myDelegate.Show();
            }
            {
                Console.WriteLine("*********Delegate********");
                ListExtend.ListExtend test = new ListExtend.ListExtend();
                test.Show();
            }

            {
                Console.WriteLine("***********Event************");
                {
                    Cat cat = new Cat();
                    //cat.Miao();
                }
                {
                    Cat cat = new Cat();
                    cat.MiaoDelegateHandler += new Mouse().Run;
                    cat.MiaoDelegateHandler += new Baby().Cry;
                    cat.MiaoDelegateHandler += new Mother().Wispher;
                    cat.MiaoDelegateHandler += new Father().Roar;
                    cat.MiaoDelegateHandler += new Neighbor().Awake;
                    cat.MiaoDelegateHandler += new Stealer().Hide;
                    cat.MiaoNew();
                }

                {
                    Console.WriteLine("***********using event***********");
                    Cat cat = new Cat();
                    cat.MiaoDelegateHandlerEvent += new Mouse().Run;
                    cat.MiaoDelegateHandlerEvent += new Baby().Cry;
                    cat.MiaoDelegateHandlerEvent += new Mother().Wispher;
                    cat.MiaoDelegateHandlerEvent += new Father().Roar;
                    cat.MiaoDelegateHandlerEvent += new Neighbor().Awake;
                    cat.MiaoDelegateHandlerEvent += new Stealer().Hide;
                    cat.MiaoEvent();
                    Console.WriteLine("***********End*****************");
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
}