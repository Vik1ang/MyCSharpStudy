namespace MyDelegateEvent.Event;

public class Cat
{
    public void Miao()
    {
        Console.WriteLine("{0} Miao", this.GetType().Name);
        new Dog().Wang();
        new Mouse().Run();
        new Baby().Cry();
        new Mother().Wispher();
        new Father().Roar();
        new Neighbor().Awake();
        new Stealer().Hide();
    }

    public delegate void MiaoDelegate();

    public MiaoDelegate MiaoDelegateHandler;

    public void MiaoNew()
    {
        Console.WriteLine("{0} Miao", this.GetType().Name);
        if (MiaoDelegateHandler != null)
        {
            MiaoDelegateHandler();
        }
    }

    public event MiaoDelegate MiaoDelegateHandlerEvent;

    public void MiaoEvent()
    {
        Console.WriteLine("{0} Miao", this.GetType().Name);
        if (MiaoDelegateHandlerEvent != null)
        {
            MiaoDelegateHandlerEvent();
        }
    }
}