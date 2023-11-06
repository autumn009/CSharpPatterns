int point = 10;
var dic = new Dictionary<string, int>();
dic["Taro"] = 10;

sub((t) => point = t, () => point);
Console.WriteLine(point);
sub((t)=> dic["Taro"]=t,()=> dic["Taro"]);
Console.WriteLine(dic["Taro"]);

void sub(Action<int> setter, Func<int> getter) => setter(getter() * 2);
