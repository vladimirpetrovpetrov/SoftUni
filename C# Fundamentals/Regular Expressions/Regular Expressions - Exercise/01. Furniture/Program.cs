using System.Text;
using System.Text.RegularExpressions;

var sum = 0d;
StringBuilder sb = new StringBuilder();
while (true)
{
    var input = Console.ReadLine();
    if (input == "Purchase")
    {
        break;
    }
    sb.AppendLine(input);
}
string pattern = @"[>]{2}(?<name>[A-Za-z]+)[<]{2}(?<price>\d+(\.\d+)*)!(?<quantity>\d+)";
Regex regex = new Regex(pattern);
MatchCollection matchCollection = regex.Matches(sb.ToString());
Console.WriteLine("Bought furniture:");
foreach (Match match in matchCollection)
{
    Console.WriteLine(match.Groups["name"]);
    sum += double.Parse(match.Groups["price"].Value) * double.Parse(match.Groups["quantity"].Value);
}
Console.WriteLine($"Total money spend: {sum}");