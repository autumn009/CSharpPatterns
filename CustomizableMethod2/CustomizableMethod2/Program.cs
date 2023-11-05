var a1 = new StringReader("ABC");
char[] a2 = { 'A', 'B', 'C' };
int p = 0;

findA(a1.Read);
findA(() =>
{
    if (p >= a2.Length) return -1;
    return a2[p++];
});

void findA(Func<int> getter)
{
    for (; ; )
    {
        var s = getter();
        if (s < 0) break;
        if (s == 'A') Console.WriteLine("Found 'A'");
    }
}
