int n = int.Parse(Console.ReadLine());
var pieces = new Dictionary<string, List<string>>();
for (int i = 0; i < n; i++)
{
    var input = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);
    var piece = input[0];
    var composer = input[1];
    var key = input[2];
    pieces[piece] = new List<string>()
    {
        composer,key
    };
}
while (true)
{
    var input = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);
    if (input[0] == "Stop")
    {
        break;
    }
    if (input[0] == "Add")
    {
        var piece = input[1];
        var composer = input[2];
        var key = input[3];
        if (pieces.ContainsKey(piece))
        {
            Console.WriteLine($"{piece} is already in the collection!");
            continue;
        }
        pieces.Add(piece, new List<string>() { composer, key });
        Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
    }
    else if (input[0] == "Remove")
    {
        var piece = input[1];
        if (!pieces.ContainsKey(piece))
        {
            Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
            continue;
        }
        pieces.Remove(piece);
        Console.WriteLine($"Successfully removed {piece}!");
    }
    else if (input[0] == "ChangeKey")
    {
        var piece = input[1];
        var key = input[2];
        if (!pieces.ContainsKey(piece))
        {
            Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
            continue;
        }
        pieces[piece][1] = key;
        Console.WriteLine($"Changed the key of {piece} to {key}!");
    }
}
foreach (var (key, value) in pieces)
{
    Console.WriteLine($"{key} -> Composer: {value[0]}, Key: {value[1]}");
}