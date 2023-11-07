int count = 0;
for (int i = 2084; ; i += 4)
{
    if (i % 100 == 0 && i % 400 != 0) continue;
    Console.WriteLine(i);
    count++;
    if (count >= 10) break;
}
