namespace MyGeneric.Extend;

public class CCTest
{
    public static void Show()
    {
        {
            Bird bird1 = new Bird();
            Bird bird2 = new Sparrow();
            Sparrow sparrow1 = new Sparrow();
        }

        {
            List<Bird> birdList1 = new List<Bird>();
            // List<Bird> birdList2 = new List<Sparrow>(); // 集合之间没有父子关系
            List<Bird> birdList3 = new List<Sparrow>().Select(c => (Bird)c).ToList();
        }

        {
            // 协变
            IEnumerable<Bird> birdList1 = new List<Bird>();
            IEnumerable<Bird> birdList2 = new List<Sparrow>();

            Func<Bird> func = new Func<Sparrow>(() => null);
        }
    }
}

public class Bird
{
    public int Id { get; set; }
}

public class Sparrow : Bird
{
    public string Name { get; set; }
}

public interface ICustomerListIn<in T>
{
    void Show(T t);
}

public class CustomerListIn<T> : ICustomerListIn<T>
{
    public void Show(T t)
    {
    }
}

public interface ICustomerListOut<out T>
{
    T Get();
}

public class CustomerListOut<T> : ICustomerListOut<T>
{
    public T Get()
    {
        return default!;
    }
}