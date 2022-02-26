namespace MyGeneric;

public class Generic
{
}

public class GenericClass<T>
//where T : People
{
}

public interface IGenericInterface<T>
{
    T GetT();
}

public delegate void SayHi<T>(T t);

public class CommonClass : GenericClass<int>
{
}

public class GenericClassChild<T> : GenericClass<T>
{
}

public class CommonClass2 : IGenericInterface<int>
{
    public int GetT()
    {
        throw new NotImplementedException();
    }
}