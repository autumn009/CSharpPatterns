Console.WriteLine(enumData().First());

IEnumerable<string> enumData()
{
    yield return "Eagle";
    yield return "Shark";
    yield return "Panther";
}
