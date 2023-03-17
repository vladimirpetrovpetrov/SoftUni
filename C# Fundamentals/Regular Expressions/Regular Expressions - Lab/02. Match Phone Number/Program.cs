using System.Text.RegularExpressions;

var input = Console.ReadLine();
var pattern = @"\+359(\s|-)[2]\1\d{3}\1\d{4}\b";
Regex regex = new Regex(pattern);
MatchCollection matchCollection = regex.Matches(input);
Console.WriteLine(String.Join(", ",matchCollection));