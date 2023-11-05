int processType;
switch(DateTime.Now.Second)
    {
    case 0:
        Console.WriteLine("前処理1");
        processType = 1;
        break;
    case 1:
        Console.WriteLine("前処理2");
        processType = 2;
        break;
    default:
        Console.WriteLine("前処理3");
        processType = 3;
        break;
}
Console.WriteLine("本処理");
switch (processType)
{
    case 1:
        Console.WriteLine("後処理1");
        break;
    case 2:
        Console.WriteLine("後処理2");
        break;
    case 3:
        Console.WriteLine("後処理3");
        break;
}
