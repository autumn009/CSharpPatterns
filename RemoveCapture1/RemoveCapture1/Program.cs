var start = DateTime.Now;
long sum = 0;
for (long i = 0; i < 1000000000L; i++) sub(i);
Console.WriteLine(sum);
Console.WriteLine(DateTime.Now-start);

void sub(long i) => sum += i;
