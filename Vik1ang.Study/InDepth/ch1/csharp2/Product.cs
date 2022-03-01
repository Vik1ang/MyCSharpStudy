namespace Vik1ang.Study.InDepth.ch1.csharp2;

/// <summary>
/// C# 2
///
/// 1. 属性拥有了私有的赋值方法(在构造函数中使用了这两个赋值方法)
/// 2. List<Product>是告知编译器列表中只能包含Product, 试图将一个不同的类型添加到列表中, 会造成编译时错误,
/// 并且当你从列表中获取结果时, 也不需要转换结果的类型
/// </summary>
public class Product
{
    private string name;

    public string Name
    {
        get { return name; }
        private set { name = value; }
    }

    private decimal price;

    public decimal Price
    {
        get { return price; }
        private set { price = value; }
    }

    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    public static List<Product> GetSampleProducts()
    {
        List<Product> list = new List<Product>();
        list.Add(new Product("West Side Story", 9.99m));
        list.Add(new Product("Assassins", 14.99m));
        list.Add(new Product("Frogs", 13.99m));
        list.Add(new Product("Sweeney Todd", 10.99m));
        return list;
    }

    public override string ToString()
    {
        return string.Format("{0}: {1}", name, price);
    }
}

/// <summary>
/// 1. C# 2 引入泛型能解决1中强制转换的问题
/// </summary>
public class ProductNameComparer : IComparer<Product>
{
    public int Compare(Product? x, Product? y)
    {
        return x.Name.CompareTo(y.Name);
    }
}

internal class Program
{
    public static void MainFunc(string[] args)
    {
        List<Product> products = Product.GetSampleProducts();
        products.Sort(new ProductNameComparer());
        foreach (Product product in products)
        {
            Console.WriteLine(product);
        }
    }
}