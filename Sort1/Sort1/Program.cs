int[] array = { 1, 3, 2 };
var dup = array.ToArray();
Array.Sort(dup);
foreach (var item in dup)
{
    Console.WriteLine(item);
}
