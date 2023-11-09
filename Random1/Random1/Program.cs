Console.WriteLine("予測不能の乱数");
for (int i = 0; i < 5; i++) sub(new Random());
Console.WriteLine("再現性のある乱数");
const int seed = 123456;
for (int i = 0; i < 5; i++) sub(new Random(seed));

void sub(Random random)
{
    for (int i = 0; i < 10; i++)
    Console.Write($"{random.Next(10)} ");
    Console.WriteLine();
}
