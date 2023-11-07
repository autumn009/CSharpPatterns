foreach (var item in Enumerable.Range(0, int.MaxValue).Select(c => 2084 + c * 4).Where(c => c % 100 != 0 || c % 400 == 0).Take(10))
{
    Console.WriteLine(item);
}
