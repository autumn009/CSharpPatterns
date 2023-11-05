Action postProcess = () => { };
switch (DateTime.Now.Second)
{
    case 0:
        Console.WriteLine("前処理1");
        break;
    case 1:
        Console.WriteLine("前処理2");
        postProcess = () => Console.WriteLine("後処理2");
        break;
    default:
        Console.WriteLine("前処理3");
        break;
}
Console.WriteLine("本処理");
postProcess();
