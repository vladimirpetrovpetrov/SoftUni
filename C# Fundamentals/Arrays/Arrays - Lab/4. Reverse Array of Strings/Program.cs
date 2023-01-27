var strings = Console.ReadLine().Split().ToArray();

var reversedStrings = new string[strings.Length];
for (int i = 0;i < strings.Length; i++)
{
    reversedStrings[i] = strings[strings.Length-1-i];
}

Console.Write(String.Join(" ",reversedStrings));