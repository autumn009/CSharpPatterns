var dic = new Dictionary<int, string>();
dic.Add(1, "TARO");
dic.Add(2, "JIRO");
dic.Add(3, "TAMAKO");
int[] ids = { 1, 2 };
foreach (var name in ids.Select(c => dic[c]).Where(c => c.StartsWith("T")))
{
    Console.WriteLine(name);
}
