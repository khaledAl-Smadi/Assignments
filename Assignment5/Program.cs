Dictionary<char, int> stringCounts = new Dictionary<char, int>()
{ };
Console.WriteLine("Enter a word:");
string Word = Console.ReadLine();
foreach (var item in Word)
{
    if (stringCounts.ContainsKey(item))
    {
        stringCounts[item]++;
    }
    else
    {
        stringCounts[item] = 1;
    }
}
foreach (var item in Word)
{
    if (stringCounts[item] == 1)
    {
        Console.WriteLine($"The first non repeating is ( {item} )");
        break;
    }
}