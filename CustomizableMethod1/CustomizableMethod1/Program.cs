var a1 = new StringReader("ABC");
char[] a2 = { 'A', 'B', 'C' };

findA1(a1);
findA2(a2);

void findA1(TextReader reader)
{
    for (; ; )
    {
        var s = reader.Read();
        if (s < 0) break;
        if (s == 'A') Console.WriteLine("Found 'A'");
    }
}
void findA2(char[] array)
{
    foreach (var ch in array)
    {
        if (ch == 'A') Console.WriteLine("Found 'A'");
    }
}
