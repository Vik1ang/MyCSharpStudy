﻿namespace MyGeneric;

public interface ISports
{
    void PingPong();
}

public interface IWork
{
    void Work();
}

public class People
{
    public int Id { get; set; }
    public string Name { get; set; }

    public void Hi()
    {
        Console.WriteLine("Hi");
    }
}

public class Chinese : People, ISports, IWork
{
    public void Tradition()
    {
        Console.WriteLine("仁义礼智信, 温良恭俭让");
    }

    public void SayHi()
    {
        Console.WriteLine("吃了吗");
    }

    public void PingPong()
    {
        Console.WriteLine("打乒乓球");
    }

    public void Work()
    {
        throw new NotImplementedException();
    }
}

public class Hubei : Chinese
{
    public string Changjiang { get; set; }

    public void Majiang()
    {
        Console.WriteLine("打麻将");
    }
}

public class Japanese : ISports
{
    public int Id { get; set; }
    public string Name { get; set; }
    public void PingPong()
    {
        Console.WriteLine("打乒乓球");
    }
}