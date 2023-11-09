var dic = new Dictionary<int, string>();
dic.Add(1,"TARO");
dic.Add(2, "JIRO");
dic.Add(3, "TAMAKO");
int[] ids = { 1, 2 };
foreach (var item in ids)
{
    var name = dic[item];
    if (name.StartsWith("T"))
    {
        Console.WriteLine(name);
    }
}
