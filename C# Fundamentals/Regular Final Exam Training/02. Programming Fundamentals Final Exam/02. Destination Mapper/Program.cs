using System.Text.RegularExpressions;

var input = Console.ReadLine();
Regex regex = new Regex(@"(\=|\/)(?<name>[A-Z][A-Za-z]{2,})\1");
MatchCollection matches = regex.Matches(input);
var travelPoints = 0;
var destinations = new List<string>();
foreach (Match match in matches)
{
    travelPoints += match.Groups["name"].Length;
    destinations.Add(match.Groups["name"].Value);
}
Console.WriteLine($"Destinations: {String.Join(", ",destinations)}");
Console.WriteLine($"Travel Points: {travelPoints}");