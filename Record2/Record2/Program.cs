var obj = new Immutable("Taro");
//obj.Name = "Jiro"; // 不変だから書けない
Console.WriteLine(obj.Name);

record Immutable(string Name);
