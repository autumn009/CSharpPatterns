Person taro = new PersonTemplate() { Name = "タロー", IdNumber = 1 };
Console.WriteLine($"{taro.Name}={taro.IdNumber}");

class Person
{
    internal readonly string? Name;
    internal readonly int IdNumber;
    public Person(PersonTemplate t)
    {
        Name = t.Name;
        IdNumber = t.IdNumber;
    }
}

class PersonTemplate
{
    internal string? Name;
    internal int IdNumber;
    public static implicit operator Person(PersonTemplate t)
    {
        return new Person(t);
    }
}