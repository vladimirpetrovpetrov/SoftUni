var players = new Dictionary<string, Dictionary<string, int>>();
while (true)
{
    var input = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
    if (input[0] == "Season end")
    {
        break;
    }

    if (input.Length == 1)
    {
        var fighters = input[0].Split(" vs ", StringSplitOptions.RemoveEmptyEntries);
        var playerOne = fighters[0];
        var playerTwo = fighters[1];
        //common position --> players,value(key)
        //check if they have common position
        if (!players.ContainsKey(playerOne) || !players.ContainsKey(playerTwo))
        {
            continue;
        }
        bool haveCommon = players[playerOne].Any(x => players[playerTwo].ContainsKey(x.Key));
        if (haveCommon)
        {
            var totalOne = players[playerOne].Values.Sum();
            var totalTwo = players[playerTwo].Values.Sum();
            if (totalOne > totalTwo)
            {
                players.Remove(playerTwo);
            }
            else if (totalTwo > totalOne)
            {
                players.Remove(playerOne);
            }
            else
            {
                continue;
            }
        }
        continue;
    }

    var player = input[0];
    var role = input[1];
    var skill = int.Parse(input[2]);
    if (!players.ContainsKey(player))
    {
        var tempDict = new Dictionary<string, int>();
        tempDict[role] = skill;
        players[player] = tempDict;
    }
    else
    {
        //key, key value
        //if value is higher
        //proveri tuk
        if (players[player].ContainsKey(role) && players[player][role] < skill)
        {
            players[player][role] = skill;

        }
        else if (!players[player].ContainsKey(role))
        {
            var tempDict = new Dictionary<string, int>();
            tempDict[role] = skill;
            players[player].Add(role, skill);
        }
    }
}
foreach (var (key, value) in players.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Key))
{
    Console.WriteLine($"{key}: {value.Values.Sum()} skill");
    foreach (var (k, v) in value.OrderByDescending(x => x.Value))
    {
        Console.WriteLine($"- {k} <::> {v}");
    }
}