string[] src = { "Alice", "Becky", "Cindy", "Adam" };

foreach (var item in src)
{
    if (item.StartsWith("A"))
    {
        Console.WriteLine(item);
    }
}
