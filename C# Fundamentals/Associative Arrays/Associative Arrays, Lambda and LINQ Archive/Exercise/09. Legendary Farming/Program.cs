var keyMaterials = new Dictionary<string, int> 
{
    {"shards",0 },
    {"fragments",0 },
    {"motes",0 },
};
var junk = new Dictionary<string, int>();
var keys = new List<string> { "shards", "fragments", "motes" };
bool obtained = false;
Weapons weapon = new Weapons();
while (!obtained)
{
    var input = Console.ReadLine().ToLower().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    var counter = 0;
    for (int i = 0; i < input.Length / 2; i++)
    {
        if (obtained)
        {
            break;
        }
        if (keys.Contains(input[counter+1]))
        {
            if (!keyMaterials.ContainsKey(input[counter + 1]))
            {
                keyMaterials.Add(input[counter + 1], int.Parse(input[counter]));
                if (keyMaterials.ContainsKey("shards") && keyMaterials["shards"] >= 250)
                {
                    obtained = true;
                    weapon = (Weapons)0;
                    keyMaterials["shards"] -= 250;
                    continue;
                }
                else if (keyMaterials.ContainsKey("fragments") && keyMaterials["fragments"] >= 250)
                {
                    obtained = true;
                    weapon = (Weapons)1;
                    keyMaterials["fragments"] -= 250;
                    continue;
                }
                else if (keyMaterials.ContainsKey("motes") && keyMaterials["motes"] >= 250)
                {
                    obtained = true;
                    weapon = (Weapons)2;
                    keyMaterials["motes"] -= 250;
                    continue;
                }
            }
            else
            {
                keyMaterials[input[counter + 1]] += int.Parse(input[counter]);
               
                    if (keyMaterials.ContainsKey("shards") && keyMaterials["shards"] >= 250)
                    {
                        obtained = true;
                        weapon = (Weapons)0;
                        keyMaterials["shards"] -= 250;
                        continue;
                    }
                    else if (keyMaterials.ContainsKey("fragments") && keyMaterials["fragments"] >= 250)
                    {
                        obtained = true;
                        weapon = (Weapons)1;
                        keyMaterials["fragments"] -= 250;
                        continue;
                    }
                    else if (keyMaterials.ContainsKey("motes") && keyMaterials["motes"] >= 250)
                    {
                        obtained = true;
                        weapon = (Weapons)2;
                        keyMaterials["motes"] -= 250;
                        continue;
                    }
                
            }
        }
        else
        {
            //тук за джънк
            if (!junk.ContainsKey(input[counter+1])) 
            {
                junk[input[counter + 1]] = int.Parse(input[counter]);
            }
            else
            {
                junk[input[counter + 1]] += int.Parse(input[counter]);
            }
        }
        counter += 2;

    }
}
Console.WriteLine($"{weapon} obtained!");
foreach (var item in keyMaterials.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
{
    Console.WriteLine($"{item.Key}: {item.Value}");
}
foreach (var item in junk.OrderBy(x => x.Key))
{
    Console.WriteLine($"{item.Key}: {item.Value}");
}





public enum Weapons
{
    Shadowmourne,
    Valanyr,
    Dragonwrath
}
