var startingSongs = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
Queue<string> songs = new(startingSongs);
while (true)
{
    var command = Console.ReadLine();
    if (command == "Play")
    {
        if (songs.Count > 0)
        {
            songs.Dequeue();
        }
    }
    else if (command == "Show")
    {
        if (songs.Count > 0)
        {
            Console.WriteLine(String.Join(", ", songs));
        }
    }
    else
    {
        
        command = command.Remove(0, 4);
        if (songs.Contains(command))
        {
            Console.WriteLine($"{command} is already contained!");
        }
        else
        {
            songs.Enqueue(command);
        }
    }
    if(songs.Count == 0)
    {
        Console.WriteLine("No more songs!");
        break;
    }
}