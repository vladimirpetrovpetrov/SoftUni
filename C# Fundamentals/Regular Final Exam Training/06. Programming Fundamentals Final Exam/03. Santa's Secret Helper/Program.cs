using System.Text.RegularExpressions;
using System.Xml.Linq;

var children = new List<string>();
int key = int.Parse(Console.ReadLine());
while (true)
{
    var input = Console.ReadLine();
    if(input == "end")
    {
        break;
    }

    var decrypted = string.Empty;
    foreach (var item in input)
    {
        var x = (int)item - key;
        var charX = (char)x;
        decrypted += charX;
    }
    Regex regex = new Regex(@"\@(?<name>[A-Za-z]+)[^\@\-\!\:\>]*\!(?<isGood>G)\!");
    Match match= regex.Match(decrypted);
    if(match.Success)
    {
        children.Add(match.Groups["name"].Value);
    }
}
foreach (var item in children)
{
    Console.WriteLine(item);
}