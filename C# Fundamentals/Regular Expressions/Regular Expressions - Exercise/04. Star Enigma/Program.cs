using System.Text.RegularExpressions;

int n = int.Parse(Console.ReadLine());

var planets = new Dictionary<string, List<string>>();
planets.Add("A",new List<string>());
planets.Add("D",new List<string>());
for (int i = 0; i < n; i++)
{
    var input = Console.ReadLine();
    var counterPattern = @"[SsTtAaRr]";
    Regex regex = new Regex(counterPattern);
    var count = regex.Matches(input).Count;

    var decryptedMessage = string.Empty;
    decryptedMessage = string.Join("", input.Select(x => (char)(x - count)));
    var pattern = @"[^@\-!:>]*\@(?<planet>[A-Za-z]+)[^@\-!:>]*\:(?<population>\d+)[^@\-!:>]*\!(?<type>A|D)\![^@\-!:>]*\-\>(?<soldierCount>\d+)[^@\-!:>]*";
    Regex regexTwo = new Regex(pattern);
    Match match = regexTwo.Match(decryptedMessage);
    if (match.Success)
    {
        var name = match.Groups["planet"].Value;
        var population = long.Parse(match.Groups["population"].Value);
        var type = match.Groups["type"].Value;
        var soldierCount = long.Parse(match.Groups["soldierCount"].Value);
        if (!planets.ContainsKey(type))
        {
            var list = new List<string>();
            planets.Add(type, list);
            if (!list.Contains(name))
            {
                list.Add(name);
            }
        }
        else
        {
            planets[type].Add(name);
        }
    }
}
Console.WriteLine($"Attacked planets: {planets["A"].Count}");
foreach (var item in planets["A"].OrderBy(x=>x))
{
    Console.WriteLine($"-> {item}");
}
Console.WriteLine($"Destroyed planets: {planets["D"].Count}");
foreach (var item in planets["D"].OrderBy(x => x))
{
    Console.WriteLine($"-> {item}");
}