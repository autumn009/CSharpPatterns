var taro = new Person() { Name = "タロー", IdNumber = 1 };
Console.WriteLine($"{taro.Name}={taro.IdNumber}");

class Person
{
    internal string? Name;
    internal int IdNumber;
}
