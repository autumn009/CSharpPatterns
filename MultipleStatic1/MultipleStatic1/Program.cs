Sample<int>.Value = 1;
Sample<long>.Value = 2;
Console.WriteLine(Sample<int>.Value);
Console.WriteLine(Sample<long>.Value);

static class Sample<T>
{
    internal static int Value { get; set; }
}
```