using System.Text;

var key = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
while (true)
{
    var input = Console.ReadLine();
    StringBuilder extractedMessage = new StringBuilder();
    if (input == "find")
    {
        break;
    }
    var indexForKey = 0;
    for (int i = 0; i < input.Length; i++)
    {
        extractedMessage.Append((char)(input[i] - key[indexForKey]));
        indexForKey++;
        if(indexForKey > key.Length - 1)
        {
            indexForKey = 0;
        }
    }
    //find the type of treasure 
    string message = extractedMessage.ToString();
    var startingIndex = message.IndexOf('&') + 1;
    var endingIndex = message.LastIndexOf('&');
    var typeOfTreasure = message.Substring(startingIndex, endingIndex - startingIndex);

    startingIndex = message.IndexOf('<') + 1;
    endingIndex = message.LastIndexOf('>');
    var coordinates = message.Substring(startingIndex,endingIndex- startingIndex);

    Console.WriteLine($"Found {typeOfTreasure} at {coordinates}");
}