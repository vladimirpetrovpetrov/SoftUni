Queue<string> playlist = new Queue<string>();
var songs = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
foreach (var item in songs)
{
    if (playlist.Contains(item))
    {
        continue; //check here
    }
    playlist.Enqueue(item);
}
while(playlist.Count != 0)
{
    var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
    if (input[0] == "Play")
    {
        playlist.Dequeue();
    }
    else if (input[0] == "Add")
    {
        input.RemoveAt(0);
        var songName = String.Join(" ", input);
        if (!playlist.Contains(songName))
        {
            playlist.Enqueue(songName);
        }
        else
        {
            Console.WriteLine($"{songName} is already contained!");
        }
    }
    else if (input[0] == "Show")
    {
        Console.WriteLine(String.Join(", ",playlist));
    }
}
Console.WriteLine("No more songs!");