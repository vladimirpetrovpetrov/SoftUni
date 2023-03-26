using System.Text.RegularExpressions;


var input = Console.ReadLine();
string patternForNums = @"\d";
Regex regexTwo = new Regex(patternForNums);
MatchCollection numMatches = regexTwo.Matches(input);
long threshold = 1; //check for num range 
foreach (Match item in numMatches)
{
    threshold *= int.Parse(item.Value);
}
string patterForEmoji = @"(\:\:|\*\*)(?<emoji>[A-Z][a-z]{2,})\1";
Regex regex = new Regex(patterForEmoji);
MatchCollection emojiMatches = regex.Matches(input);
var coolEmojis = new List<string>();

foreach (Match item in emojiMatches)
{
    var emojiCoolness = 0;
    foreach (var c in item.Groups["emoji"].Value)
	{
		emojiCoolness += (int)c;
	}
    if(emojiCoolness >= threshold)//check if it's > or >=
    {
        coolEmojis.Add(item.Value);
    }
}

Console.WriteLine($"Cool threshold: {threshold}");
Console.WriteLine($"{emojiMatches.Count} emojis found in the text. The cool ones are:");
foreach (var item in coolEmojis)
{
    Console.WriteLine(item);
}