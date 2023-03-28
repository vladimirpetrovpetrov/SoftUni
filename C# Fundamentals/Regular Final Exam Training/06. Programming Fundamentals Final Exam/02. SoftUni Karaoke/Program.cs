var people = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries).ToList();
var songs = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
var dict = new Dictionary<string, HashSet<string>>();

while (true)
{
    var input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
    if (input[0] == "dawn") 
    {
        break;
    }
    var name = input[0];
    var song = input[1];
    var award = input[2];
    if(!people.Contains(name) || !songs.Contains(song))
    {
        continue;
    }
    if (dict.ContainsKey(name))
    {
        dict[name].Add(award);
    }
    else
    {
        var temp = new HashSet<string> { award };
        dict[name] = temp;
    }
}
if (dict.Count > 0)
{
    foreach (var (key, value) in dict.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
    {
        Console.WriteLine($"{key}: {value.Count} awards");
        foreach (var item in value.OrderBy(x => x))
        {
            Console.WriteLine($"--{item}");
        }
    }
}
else
{
    Console.WriteLine("No awards");
}