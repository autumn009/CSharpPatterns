var start = DateTime.Now;
long sum = 0;
sub();
Console.WriteLine(sum);
Console.WriteLine(DateTime.Now - start);

void sub()
{
    for (long i = 0; i < 1000000000L; i++) sum += i;
}
