var dic = new Dictionary<string, Team>();
dic.Add("さくら組", new Team("年少クラス", 17));
dic.Add("ばら組", new Team("年長クラス", 22));
var members = dic["さくら組"].Count;
Console.WriteLine($"さくら組のメンバー数は{members}です。");
foreach (var key in dic.Keys)
{
    Console.WriteLine($"{key}は{dic[key].Description}でメンバー数は{dic[key].Count}です。");
}
record Team(string Description, int Count);
