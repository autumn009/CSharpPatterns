探偵[] 探偵達 =
{
    探偵ファクトリ.Create通常探偵(),
    探偵ファクトリ.Create優秀探偵(),
};
foreach (var d in 探偵達)
{
    Console.WriteLine($"{d.Name}です。");
    d.証拠を与える();
    d.現状を報告();
}

// フラット オブジェクト
// (振る舞いがカスタマイズされるが継承の対象
//  にならず、定義は階層化されない)
public class 探偵
{
    public string Name { get; set; } = "";
    public Action 証拠を与える = ()=> { };
    public Action 現状を報告 = () => { };
}

// フラット オブジェクト ファクトリ クラス
public static class 探偵ファクトリ
{
    // ファクトリ メソッド
    public static 探偵 Create優秀探偵()
    {
        bool 証拠あり = false;	// 優秀探偵は証拠がありさえすれば犯人が分かる
        探偵 優秀探偵 = new 探偵();
        優秀探偵.Name="優秀探偵";
        優秀探偵.証拠を与える = () => { 証拠あり = true; };
        優秀探偵.現状を報告 = () => Console.WriteLine(証拠あり ? "証明終了です" : "推理中です");
        return 優秀探偵;
    }

    // もう1つ別のファクトリ メソッド
    public static 探偵 Create通常探偵()
    {
        int 証拠数 = 0;	// 通常探偵は証拠の数を数えないと犯人が分からない
        探偵 通常探偵 = new 探偵();
        通常探偵.Name = "通常探偵";
        通常探偵.証拠を与える = () => 証拠数++;
        通常探偵.現状を報告 = () => Console.WriteLine(証拠数 >= 3 ? "犯人はおまえだ!" : "推理中です");
        return 通常探偵;
    }
}
