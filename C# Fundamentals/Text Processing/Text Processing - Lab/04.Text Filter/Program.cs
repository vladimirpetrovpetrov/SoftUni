var bannedWords = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
var text = Console.ReadLine();
for (int i = 0; i < bannedWords.Length; i++)
{
    text = text.Replace(bannedWords[i], new string('*', bannedWords[i].Length));
}
Console.WriteLine(text);