SortedDictionary<string, Dictionary<string, double>> foodShops = new();
while (true)
{
    var input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
    if (input[0] == "Revision")
    {
        break;
    }
    var shopName = input[0];
    var product = input[1];
    var productPrice = double.Parse(input[2]);

    if (!foodShops.ContainsKey(shopName))
    {
        var dict = new Dictionary<string, double>();
        foodShops[shopName] = dict;
    }
    if (!foodShops[shopName].ContainsKey(product))
    {
        foodShops[shopName].Add(product, productPrice);
    }
}
foreach (var (k,v) in foodShops)
{
    Console.WriteLine($"{k}->");
    foreach (var (key,value) in v)
    {
        Console.WriteLine($"Product: {key}, Price: {value}");
    }
}