namespace MyLinq;

public static class ExtendMethod
{
    /*public static List<Student> ElevenWhere(this List<Student> source, Func<Student, bool> func)
    {
        var list = new List<Student>();
        foreach (var item in source)
        {
            if (func(item))
            {
                list.Add(item);
            }
        }

        return list;
    }*/

    public static IEnumerable<T> ElevenWhere<T>(this IEnumerable<T> source, Func<T, bool> func)
    {
        var list = new List<Student>();
        foreach (var item in source)
        {
            if (func(item))
            {
                yield return item;
            }
        }
    }
}