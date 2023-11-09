foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
{
    foreach (var item in assembly.GetTypes())
    {
        if (item.GetCustomAttributes(typeof(MyTargetAttribute), true).Length > 0)
        {
            dynamic? obj = Activator.CreateInstance(item);
            obj?.Sub();
        }
    }
}

class MyTargetAttribute : Attribute { }

[MyTarget]
class MyClass
{
    public void Sub()
    {
        Console.WriteLine("Sub called");
    }
}
