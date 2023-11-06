var x = new X();
x.Sub();

class X
{
    internal void Sub()
    {
        Console.WriteLine(calc(1, 2));
        Console.WriteLine(calc(3, 4));
        int calc(int x, int y) => (int)Math.Sqrt(x * x + y * y);
    }
    internal void Sub2()
    {
        // このメソッドからcalcメソッドを呼び出すことはできない。
    }
}
