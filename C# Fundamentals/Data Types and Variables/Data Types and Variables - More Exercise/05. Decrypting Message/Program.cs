var key = int.Parse(Console.ReadLine());
var lines = int.Parse(Console.ReadLine());
string finalR = string.Empty;
for(int i = 0; i < lines; i++)
{
    var line = char.Parse(Console.ReadLine());
    int result = line + key;
    finalR += (char)result;
}
Console.WriteLine(finalR);