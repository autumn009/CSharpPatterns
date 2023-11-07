int[] array = { 1, 2, 3 };
List<int> list = new();
list.AddRange(array);
sub(list);

void sub(List<int> list)
{
    foreach (int i in list) Console.WriteLine(i);
}
