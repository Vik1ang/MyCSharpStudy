namespace Vik1ang.Study.InDepth.ch1.csharp3;

/// <summary>
/// C# 3
///
/// 1. 不再有任何代码(或者可见的变量)与属性关联, 而且硬编码的列表是以一种全然不同的方式构建的;
/// 由于没有name和price变量可供访问, 我们必须在类中处处使用属性, 增强了一致性
/// 2. 现在有一个私有的无参构造函数, 用于新的基于属性的初始化
/// </summary>
public class Product
{
    public string Name { get; private set; }
    public decimal Price { get; private set; }

    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    public Product()
    {
    }

    public static List<Product> GetSampleProducts()
    {
        return new List<Product>
        {
            (new Product("West Side Story", 9.99m)),
            (new Product("Assassins", 14.99m)),
            (new Product("Frogs", 13.99m)),
            (new Product("Sweeney Todd", 10.99m))
        };
    }

    public override string ToString()
    {
        return string.Format("{0}: {1}", Name, Price);
    }
}


/// <summary>
/// 1. 通过创建委托的方式更简单
/// 2. 通过Lambda表达式来更精简
/// </summary>
internal class Program
{
    public static void MainFunc(string[] args)
    {
        List<Product> products = Product.GetSampleProducts();
        products.Sort(delegate (Product x, Product y)
        {
            return x.Name.CompareTo(y.Name);
        });

        foreach (Product product in products)
        {
            Console.WriteLine(product);
        }

        products = Product.GetSampleProducts();

        products.Sort((x, y) => x.Name.CompareTo(y.Name));

        foreach (Product product in products)
        {
            Console.WriteLine(product);
        }

    }
}