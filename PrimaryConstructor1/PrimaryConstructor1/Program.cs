var obj = new Person("Taro");
Console.WriteLine(obj.Name);

class Person
{
    public string Name { get; init; }
    public Person(string name) => Name = name;
}
