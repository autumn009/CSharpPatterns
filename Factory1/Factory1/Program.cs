sub(true);
sub(false);

void sub(bool IsMale)
{
    Character? c;
    if (IsMale)
        c = new Male { Name = "オルテガの息子" };
    else
        c = new Female { Name = "オルテガの娘" };
    c.Say();
}

abstract class Character
{
    internal string Name { get; set; } = "";
    internal abstract void Say();
}

class Male : Character
{
    internal override void Say()
    {
        Console.WriteLine($"オレは{Name}だぜ!");
    }
}

class Female : Character
{
    internal override void Say()
    {
        Console.WriteLine($"私は{Name}よ!");
    }
}


