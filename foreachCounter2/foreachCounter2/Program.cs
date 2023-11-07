int[] src = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
foreach (var item in src.Skip(3).Select((n,i)=>(n,i)).Where(c=>c.i % 2 == 0))
{
    Console.WriteLine(item.n);
}
