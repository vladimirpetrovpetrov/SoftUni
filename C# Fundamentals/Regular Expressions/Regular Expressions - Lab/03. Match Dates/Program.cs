using System.Text.RegularExpressions;

var input = Console.ReadLine();
string pattern = @"(?<day>\d{2})(\.|-|\/)(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})";

Regex regex = new Regex(pattern);
MatchCollection matchCollection = regex.Matches(input);

foreach (Match match in matchCollection)
{
    Console.WriteLine($"Day: {match.Groups["day"]}, Month: {match.Groups["month"]}, Year: {match.Groups["year"]}");
}