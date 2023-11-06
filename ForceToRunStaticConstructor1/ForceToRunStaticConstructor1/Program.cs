X.ForceToRunConstructor();

static class X
{
    internal static void ForceToRunConstructor()
    {
        // staticコンストラクタの強制実行用のダミーコード
        OtherClass.DummyOfDummy = DateTime.Now;
    }
    static X() => Console.WriteLine("Running Static Constructor");
}
public static class OtherClass
{
    public static object? DummyOfDummy { get; set; }
}
