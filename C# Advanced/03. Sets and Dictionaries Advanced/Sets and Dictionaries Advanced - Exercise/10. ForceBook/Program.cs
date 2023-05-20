Dictionary<string, string> forceUsers = new Dictionary<string, string>();
Dictionary<string, List<string>> sides = new Dictionary<string, List<string>>();

while (true)
{
    string input = Console.ReadLine();
    if (input == "Lumpawaroo")
    {
        break;
    }

    if (input.Contains("|"))
    {
        string[] tokens = input.Split(" | ");
        string side = tokens[0];
        string forceUser = tokens[1];

        if (!forceUsers.ContainsKey(forceUser))
        {
            forceUsers.Add(forceUser, side);

            if (!sides.ContainsKey(side))
            {
                sides[side] = new List<string>();
            }

            sides[side].Add(forceUser);
        }
    }
    else if (input.Contains("->"))
    {
        string[] tokens = input.Split(" -> ");
        string forceUser = tokens[0];
        string side = tokens[1];

        if (forceUsers.ContainsKey(forceUser))
        {
            string oldSide = forceUsers[forceUser];

            if (oldSide != side)
            {
                sides[oldSide].Remove(forceUser);

                if (!sides.ContainsKey(side))
                {
                    sides[side] = new List<string>();
                }

                sides[side].Add(forceUser);
                forceUsers[forceUser] = side;

                Console.WriteLine($"{forceUser} joins the {side} side!");
            }
        }
        else
        {
            if (!sides.ContainsKey(side))
            {
                sides[side] = new List<string>();
            }

            sides[side].Add(forceUser);
            forceUsers.Add(forceUser, side);

            Console.WriteLine($"{forceUser} joins the {side} side!");
        }
    }
}

foreach (var side in sides.OrderByDescending(s => s.Value.Count).ThenBy(s => s.Key))
{
    if (side.Value.Count > 0)
    {
        Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");
        foreach (var forceUser in side.Value.OrderBy(u => u))
        {
            Console.WriteLine($"! {forceUser}");
        }
    }
}
