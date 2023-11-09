string[] src =
{
    "Waiting",
    "NORMAL",
    "Start",
    "SINGLE",
    "Hello!",
    "How are you?",
    "DOUBLE",
    "Let's go!",
    "NORMAL",
    "THE END"
};
Action<string> action = (s)=> { };

foreach (var line in src)
{
    if (line == "NORMAL") setNormal();
    else if (line == "SINGLE") setSingle();
    else if (line == "DOUBLE") setDouble();
    else action(line);
}

void setNormal() => action = (s) => Console.WriteLine(s);
void setSingle() => action = (s) => Console.WriteLine($"'{s}'");
void setDouble() => action = (s) => Console.WriteLine($"\"{s}\"");
