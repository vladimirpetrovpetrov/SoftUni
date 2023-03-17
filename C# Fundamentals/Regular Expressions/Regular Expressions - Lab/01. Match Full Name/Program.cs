using System.Text.RegularExpressions;

var input = Console.ReadLine();
string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
Regex regex = new Regex(pattern);
var matches = regex.Matches(input);
Console.WriteLine(String.Join(" ", matches));

//static
//var result = Regex.Matches(input, pattern);
//Console.WriteLine(String.Join(" ",result));