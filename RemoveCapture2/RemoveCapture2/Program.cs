var start = DateTime.Now;
Console.WriteLine(sub());
Console.WriteLine(DateTime.Now - start);

static long sub()
{
    long sum = 0;
    for (long i = 0; i < 1000000000L; i++) sum += i;
    return sum;
}
