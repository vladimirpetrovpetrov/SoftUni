using System.Text;
using System.Text.RegularExpressions;

var n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    var input = Console.ReadLine();

    Regex regex = new Regex(@"\|(?<name>[A-Z]{4,})\|\:\#(?<title>[A-Za-z]+ [A-Za-z]+)\#");
    Match match= regex.Match(input);
    if (!match.Success)
    {
        Console.WriteLine("Access denied!");
        continue;
    }
    StringBuilder st = new StringBuilder();
    st.AppendLine($"{match.Groups["name"].Value}, The {match.Groups["title"].Value}");
    st.AppendLine($">> Strength: {match.Groups["name"].Value.Length}");
    st.AppendLine($">> Armor: {match.Groups["title"].Value.Length}");
    Console.WriteLine(st.ToString().Trim('\n'));
}