Dictionary<string, Dictionary<string, List<string>>> continents = new();
int n = int.Parse(Console.ReadLine()!);

for (int i = 0; i < n; i++)
{
    var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    var continent = input[0];
    var country = input[1];
    var town = input[2];

    if (!continents.ContainsKey(continent))
    {
        //no continent,no country 
        var list = new List<string>();
        var dict = new Dictionary<string, List<string>>();
        continents[continent] = dict;
    }

    //continent , but not country
    if (!continents[continent].ContainsKey(country))
    {
        var list = new List<string>() {};
        continents[continent][country] = list;
    }

    continents[continent][country].Add(town);
}
foreach (var (k,v) in continents)
{
    Console.WriteLine($"{k}:");
    foreach (var (key,value) in v)
    {
        Console.WriteLine($"  {key} -> {String.Join(", ",value)}");
    }
}