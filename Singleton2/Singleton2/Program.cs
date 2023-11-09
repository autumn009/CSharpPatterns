Sample.OnlySample.OnlyOneValue = 123;
Console.WriteLine(Sample.OnlySample.OnlyOneValue);

class Sample
{
    internal int OnlyOneValue { get; set; } = 0;
    internal static Sample OnlySample = new Sample();
    private Sample() { }
}
