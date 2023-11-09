    Sample.OnlyOneValue = 123;
    Console.WriteLine(Sample.OnlyOneValue);

    static class Sample
    {
        internal static int OnlyOneValue { get; set; } = 0;
    }
