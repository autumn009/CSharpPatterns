int[] array = { 123, 456, 789 };
Console.WriteLine(General.RandomSelect(array));
General.Dump(array);

static class General
{
    internal static T RandomSelect<T>(IEnumerable<T> source)
    {
        var index = Random.Shared.Next(source.Count());
        return source.ElementAt(index);
    }
    internal static void Dump<T>(IEnumerable<T> source)
    {
        Console.Write("{ ");
        foreach (var item in source.Select((n, i) => (n, i)))
        {
            if (item.i > 0) Console.Write(", ");
            Console.Write(item.n);
        }
        Console.WriteLine(" }");
    }
}
