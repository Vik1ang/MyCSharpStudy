namespace MyGeneric;

public class Constraint
{
    public static void Show<T>(T tParameter)
        where T : People
    {
        Console.WriteLine($"{tParameter.Id}_{tParameter.Name}");
        tParameter.Hi();
    }

    public static T Get<T>(T t)
    // where T : ISports // 接口约束
    // where T : class // 引用类型约束
    // where T : struct // 值类型约束
    where T : new() // 无参构造器约束
    {
        // t.PingPong();
        // T tNew = default(T);
        // return tNew;
        // return t;
        T tNew = new T();
        return tNew;
    }
}