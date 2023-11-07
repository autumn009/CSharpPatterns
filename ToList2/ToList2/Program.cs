int[] array = { 1, 2, 3 };
sub(array.ToList());

void sub(List<int> list)
{
    foreach (int i in list) Console.WriteLine(i);
}
