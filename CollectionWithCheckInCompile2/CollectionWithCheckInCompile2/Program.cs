Console.WriteLine($"さくら組のメンバー数は{Teams.さくら組.Count}です。");
foreach (var prop in typeof(Teams).GetProperties(System.Reflection.BindingFlags.Static| System.Reflection.BindingFlags.NonPublic))
{
    var value = prop.GetValue(null) as Team;
    Console.WriteLine($"{prop.Name}は{value?.Description}でメンバー数は{value?.Count}です。");
}
static class Teams
{
    internal static Team さくら組 { get; set; } = new Team("年少クラス", 17);
    internal static Team ばら組 { get; set; } = new Team("年長クラス", 22);
}
record Team(string Description, int Count);
