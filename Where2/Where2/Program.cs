string[] src = { "Alice", "Becky", "Cindy", "Adam" };

foreach(var item in src.Where(c=>c.StartsWith("A")))
{
    Console.WriteLine(item);
}
