using System.Text;

var cities = new Dictionary<string, List<long>>();
while (true)
{
    var input = Console.ReadLine().Split("||", StringSplitOptions.RemoveEmptyEntries);
    if (input[0] == "Sail")
    {
        break;
    }

    var city = input[0];
    var population = long.Parse(input[1]);
    var gold = long.Parse(input[2]);

    if (cities.ContainsKey(city))
    {
        cities[city][0] += population;
        cities[city][1] += gold;
    }
    else
    {
        var list = new List<long> { population, gold };
        cities[city] = list;
    }
}
while (true)
{
    var input = Console.ReadLine().Split("=>", StringSplitOptions.RemoveEmptyEntries);
    if (input[0] == "End")
    {
        break;
    }

    if (input[0] == "Plunder")
    {
        var city = input[1];
        var people = long.Parse(input[2]);
        var gold = long.Parse(input[3]);
        Console.WriteLine($"{city} plundered! {gold} gold stolen, {people} citizens killed.");
        cities[city][0] -= people;
        if (cities[city][0] <= 0)
        {
            Console.WriteLine($"{city} has been wiped off the map!");
            cities.Remove(city);
            continue;
        }
        cities[city][1] -= gold;
        if (cities[city][1] <= 0)
        {
            Console.WriteLine($"{city} has been wiped off the map!");
            cities.Remove(city);
            continue;
        }
    }
    else if (input[0] == "Prosper")
    {
        var town = input[1];
        var gold = long.Parse(input[2]);
        if (gold < 0)
        {
            Console.WriteLine("Gold added cannot be a negative number!");
            continue;
        }
        cities[town][1] += gold;
        Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {cities[town][1]} gold.");
    }
}
if (cities.Count > 0)
{
    StringBuilder st = new StringBuilder();
    st.AppendLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");
    foreach (var (key,value) in cities)
    {
        st.AppendLine($"{key} -> Population: {value[0]} citizens, Gold: {value[1]} kg");
    }
    Console.WriteLine(st.ToString().TrimEnd('\n'));
}
else
{
    Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
}
