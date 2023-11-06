var x = new X();
x.Sub();

class X
{
    private int calc(int x, int y) => (int)Math.Sqrt(x * x + y * y);
    internal void Sub()
    {
        Console.WriteLine(calc(1, 2));
        Console.WriteLine(calc(3, 4));
    }
    internal void Sub2()
    {
        // このメソッドからcalcメソッドを呼び出すことができてしまうが適切ではない。
    }
}