using System.Text.RegularExpressions;
var demons = new Dictionary<string, List<double>>();
var input = Console.ReadLine();
var generalPattern = @"[^(,|(,\s*))]";
Regex genRegex = new Regex(generalPattern);
MatchCollection genCollection = genRegex.Matches(input);


//TODO







for (int i = 0; i < input.Length; i++)
{
    var demon = genCollection[i];
    var patternHP = @"[^\d\+\-*\/\.]";
    Regex regex = new Regex(patternHP);
    MatchCollection matches = regex.Matches(demon.Value);
    var hp = 0l;
    foreach (Match item in matches)
    {
        var charItem = char.Parse(item.Value);
        hp += charItem;
    }
    string positiveNegative = @"(?<positive>\d+(\.\d+)*)|(\-(?<negative>\d+(\.\d+))*)";
    Regex regexTwo = new Regex(positiveNegative);
    MatchCollection matchesTwo = regexTwo.Matches(demon.Value);
    var damage = matchesTwo.Select(x => double.Parse(x.Value)).ToList().Sum();
    var divideMultiplyPattern = @"[\*|\/]";
    Regex regexThree = new Regex(divideMultiplyPattern);
    MatchCollection matchesThree = regexThree.Matches(demon.Value);
    foreach (Match item in matchesThree)
    {
        if(item.Value == "*")
        {
            damage *= 2;
        }
        else if(item.Value == "/")
        {
            damage /= 2;
        }
    }
    if (!demons.ContainsKey(demon.Value))
    {
        var list = new List<double>();
        demons[demon.Value] = list;
        list.Add(hp);
        list.Add(damage);
    }
}
foreach (var (key,value) in demons.OrderBy(x=>x.Key))
{
    Console.WriteLine($"{key} - {value[0]:F0} health, {value[1]:F2} damage");
}