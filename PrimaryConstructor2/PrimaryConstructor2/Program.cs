var obj = new Person("Taro");
Console.WriteLine(obj.Name);

class Person(string name)
{
    public string Name { get; init; } = name;
}
