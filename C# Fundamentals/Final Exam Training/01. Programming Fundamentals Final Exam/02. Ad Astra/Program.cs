using System.Text.RegularExpressions;

var input = Console.ReadLine();
var totalCal = 0;
Regex regex = new Regex(@"(?<sep>\#|\|)(?<name>[A-za-z ]+)\k<sep>(?<expDate>\d{2}\/\d{2}\/\d{2})\k<sep>(?<calories>\d{1,5})\k<sep>");
MatchCollection matches = regex.Matches(input);
totalCal = matches.Select(item => int.Parse(item.Groups["calories"].Value)).Sum();
Console.WriteLine($"You have food to last you for: {totalCal/2000} days!");
foreach (Match match in matches)
{
    Console.WriteLine($"Item: {match.Groups["name"]}, Best before: {match.Groups["expDate"]}, Nutrition: {match.Groups["calories"]}");
}