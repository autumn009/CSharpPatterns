var obj = new Immutable("Taro");
//obj.Name = "Jiro"; // 不変だから書けない
Console.WriteLine(obj.Name);

class Immutable
{
    public string Name { get; init; }
    public Immutable(string name) => Name = name;
}
