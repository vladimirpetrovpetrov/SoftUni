int n = int.Parse(Console.ReadLine());
Dictionary<string, Dictionary<string, int>> wardrobe = new();
for (int i = 0; i < n; i++)
{
    var input = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
    var color = input[0];
    var clothes = input[1].Split(",", StringSplitOptions.RemoveEmptyEntries);
    foreach (var item in clothes)
    {
        //няма шкаф няма дреха
        if (!wardrobe.ContainsKey(color))
        {
            wardrobe.Add(color, new Dictionary<string, int>());
        }
        //има шкаф няма дреха
        if (!wardrobe[color].ContainsKey(item))
        {
            wardrobe[color].Add(item, 0);
        }
        wardrobe[color][item]++;
    }
}
var searchedInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
var searchedColor = searchedInput[0];
var searchedCloth = searchedInput[1];

foreach (var (k,v) in wardrobe)
{
    Console.WriteLine($"{k} clothes:");
    foreach (var (key,value) in v)
    {
        if (k == searchedColor && key == searchedCloth)
        {
            Console.WriteLine($"* {key} - {value} (found!)");
            continue;
        }
        Console.WriteLine($"* {key} - {value}");
    }
}