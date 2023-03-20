var n = int.Parse(Console.ReadLine());
var pianoPieces = new Dictionary<string, Dictionary<string, string>>();
for (int i = 0; i < n; i++)
{
    var input = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);
    var piece = input[0];
    var composer = input[1];
    var key = input[2];

    if (!pianoPieces.ContainsKey(composer)) //IF composer doesnt exist
    {
        var song = new Dictionary<string, string>();
        song[piece] = key;
        pianoPieces[composer] = song;
    }
    else //IF composer exist
    {
        if(!pianoPieces[composer].ContainsKey(piece)) ////IF composer exist,but piece doesnt exist
        {
            var song = new Dictionary<string, string>();
            song[piece] = key;
            pianoPieces[composer].Add(piece, key);
        }
    }
} 
while (true)
{
    var input = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);
    if (input[0] == "Stop")
    {
        break;
    }

    if (input[0] == "Remove")
    {
        var pieceToRemove = input[1];
        bool exist = false;
        foreach (var (key,value) in pianoPieces)
        {
            if (value.ContainsKey(pieceToRemove))//If the collection have this piece
            {
                exist = true;
                value.Remove(pieceToRemove);
                Console.WriteLine($"Successfully removed {pieceToRemove}!");
                break; 
            }
        }
        if (!exist)//If the collection dont have this piece
        {
            Console.WriteLine($"Invalid operation! {pieceToRemove} does not exist in the collection.");
        }
    }
    else if (input[0] == "Add")
    {
        var pieceToAdd = input[1];
        var composerToAdd = input[2];
        var keyToAdd = input[3];
        if(!pianoPieces.ContainsKey(composerToAdd)) //If the composer doesnt exist
        {
            var song = new Dictionary<string, string>();
            song[pieceToAdd] = keyToAdd;
            pianoPieces[composerToAdd] = song;
            Console.WriteLine($"{pieceToAdd} by {composerToAdd} in {keyToAdd} added to the collection!");
        }
        else //If the composer exist
        {
            //Composer exists , but not the piece
            if (!pianoPieces[composerToAdd].ContainsKey(pieceToAdd))
            {
                var song = new Dictionary<string, string>();
                song[pieceToAdd] = keyToAdd;
                pianoPieces[composerToAdd].Add(pieceToAdd, keyToAdd);
                Console.WriteLine($"{pieceToAdd} by {composerToAdd} in {keyToAdd} added to the collection!");
            }
            else //If composer and piece , both exist.
            {
                Console.WriteLine($"{pieceToAdd} is already in the collection!");
            }
        }
    }
    else if (input[0] == "ChangeKey")
    {
        var pieceToChange = input[1];
        var newKey = input[2];
        var exist = false;
        foreach (var (key, value) in pianoPieces)
        {
            if(value.ContainsKey(pieceToChange)) //If the collection have this piece
            {
                exist = true;
                value[pieceToChange] = newKey;
                Console.WriteLine($"Changed the key of {pieceToChange} to {newKey}!");
                break;
            }
        }
        if (!exist) //If the collection dont have this piece
        {
            Console.WriteLine($"Invalid operation! {pieceToChange} does not exist in the collection.");
        }
    }
}
pianoPieces = pianoPieces.Where(x => x.Value.Count != 0).ToDictionary(x => x.Key,x => x.Value); //Remove the composers with 0 songs from the dictionary

foreach (var (key,value) in pianoPieces)
{
    foreach (var (k,v) in value)
    {
        Console.WriteLine($"{k} -> Composer: {key}, Key: {value[k]}");
    }
}