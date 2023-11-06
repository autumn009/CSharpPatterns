int point = 10;
var dic = new Dictionary<string, int>();
dic["Taro"] = 10;

sub(ref point);
Console.WriteLine(point);
//sub(ref dic["Taro"]);
//Console.WriteLine(dic["Taro"]);

void sub(ref int p) => p *= 2;
