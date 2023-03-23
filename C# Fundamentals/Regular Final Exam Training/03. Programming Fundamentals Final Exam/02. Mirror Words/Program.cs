using System.Text;
using System.Text.RegularExpressions;

var input = Console.ReadLine();
Regex regex = new Regex(@"(\#|\@)(?<word>[A-Za-z]{3,})\1\1(?<reversed>[A-Za-z]{3,})\1");
MatchCollection matches = regex.Matches(input);
var reversedWords = new List<string>();
foreach (Match match in matches)
{
    var word = match.Groups["word"].Value;
    var reversedWord = match.Groups["reversed"].Value;
    var temp = new string(reversedWord.Reverse().ToArray());
    if (word == temp)
    {
        reversedWords.Add($"{word} <=> {reversedWord}");
    }
}
if (matches.Count > 0) {
    StringBuilder st = new StringBuilder();
    st.AppendLine($"{matches.Count} word pairs found!");
    if(reversedWords.Count > 0)
    {
        st.AppendLine("The mirror words are:");
        st.AppendLine(string.Join(", ", reversedWords));
        Console.WriteLine(st.ToString().Trim('\n'));
    }
    else
    {
        Console.WriteLine(st.ToString().TrimEnd('\n'));
        Console.WriteLine("No mirror words!");
    }

}
else
{
    Console.WriteLine("No word pairs found!");
    Console.WriteLine("No mirror words!");
}