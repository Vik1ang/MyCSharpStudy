namespace Vik1ang.Study.InDepth.ch1.csharp4;

/// <summary>
/// C# 4
///
/// 1. 尽管拥有私有赋值方法的类型不能被公共地改变, 但如果他也不能被私有地改变, 将会显得更加清晰;
/// C#4允许我们在调用构造函数指定实参的名称, 提供了3的清晰度还移除了易变性
/// </summary>
public class Product
{
    private readonly string name;

    public string Name
    {
        get { return name; }
    }

    private readonly decimal price;

    public decimal Price
    {
        get { return price; }
    }

    public Product(string name, decimal price)
    {
        this.name = name;
        this.price = price;
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
        return string.Format("{0}: {1}", name, price);
    }
}