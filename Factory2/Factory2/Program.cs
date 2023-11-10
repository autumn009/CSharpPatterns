sub(true);
sub(false);

void sub(bool IsMale)
{
    var c = Character.CreateCharacter(IsMale);
    c.Say();
}

abstract class Character
{
    internal string Name { get; set; } = "";
    internal abstract void Say();
    internal static Character CreateCharacter(bool IsMale)
    {
        Character? c;
        if (IsMale)
            c = new Male { Name = "オルテガの息子" };
        else
            c = new Female { Name = "オルテガの娘" };
        return c;
    }

    private class Male : Character
    {
        internal override void Say()
        {
            Console.WriteLine($"オレは{Name}だぜ!");
        }
    }

    private class Female : Character
    {
        internal override void Say()
        {
            Console.WriteLine($"私は{Name}よ!");
        }
    }
}
