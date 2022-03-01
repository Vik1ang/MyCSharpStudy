using System.Collections;

namespace Vik1ang.Study.InDepth.ch1.csharp1;

/// <summary>
/// C# 1
/// 1. ArrayList没有提供与其内部有关的编译时信息. 不慎在GetSampleProducts创建的列表中那个添加一个字符串是完全有可能的,
/// 而编译器对此没有任何反应
/// 2. 代码中位属性提供了公共的取值办法, 这意味着如果添加对应的赋值方法, 那么赋值方法也必须是公共的
/// 3. 用于创建属性和变量的代码很复杂----封装一个字符串和一个十进制数应该是一个十分简单任务不应该那么复杂
/// </summary>
public class Product
{
    private string name;

    public string Name
    { get { return name; } }

    private decimal price;

    public decimal Price
    { get { return price; } }

    public Product(string name, decimal price)
    {
        this.name = name;
        this.price = price;
    }

    public static ArrayList GetSampleProducts()
    {
        ArrayList list = new ArrayList();
        list.Add(new Product("West Side Story", 9.9m));
        list.Add(new Product("Assassins", 14.9m));
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
/// 1. 只能定义一种排序顺序, 没有定制可言
/// 2. 如果只是按名称排序有点浪费力气
/// 3. Compare方法中的强制类型转换 比较消耗性能
/// 4. 强转可能会报错
/// </summary>
public class ProductNameComparer : ICompare
{
    public int Compare(object x, object y)
    {
        Product first = (Product)x;
        Product second = (Product)y;

        return first.Name.CompareTo(second.Name);
    }
}

internal class Program
{
    public static void MainFunc(string[] args)
    {
        ArrayList products = Product.GetSampleProducts();
        products.Sort(new ProductNameComparer());
        foreach (Product product in products)
        {
            Console.WriteLine(product);
        }
    }
}

public interface ICompare : IComparer
{
    public int Compare(object x, object y);
}
