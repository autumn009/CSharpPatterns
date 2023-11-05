Action postProcess = ()=> { };
if (DateTime.Now.Day == 1)
{
    Console.WriteLine("毎月1日のみ前処理を行う");
    postProcess = () => Console.WriteLine("毎月1日のみ後処理を行う");
}
Console.WriteLine("本処理");
postProcess();
