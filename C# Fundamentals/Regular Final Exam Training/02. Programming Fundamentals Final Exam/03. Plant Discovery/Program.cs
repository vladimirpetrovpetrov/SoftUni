using System.Text;
using System.Xml.Linq;

int count = int.Parse(Console.ReadLine());
var plants = new Dictionary<string, List<string>>();
for (int i = 0; i < count; i++)
{
    var input = Console.ReadLine().Split("<->", StringSplitOptions.RemoveEmptyEntries);
    var name = input[0];
    var rarity = input[1];
    var list = new List<string>();
    list.Add(rarity);
    plants.Add(name, list);
}
;
while (true)
{
    var command = Console.ReadLine().Split(new char[] { ' ', ':', '-' }, StringSplitOptions.RemoveEmptyEntries);
    if (command[0] == "Exhibition")
    {
        break;
    }
    if (command[0] == "Rate")
    {
        var name = command[1];
        var rating = command[2];
        if(!plants.ContainsKey(name))
        {
            Console.WriteLine("error");
            continue;
        }
        plants[name].Add(rating);
    }else if (command[0] == "Update")
    {
        var name = command[1];
        var rarity = command[2];
        if (!plants.ContainsKey(name))
        {
            Console.WriteLine("error");
            continue;
        }
        plants[name][0] = rarity;
    }
    else if (command[0] == "Reset")
    {
        var name = command[1];
        if (!plants.ContainsKey(name))
        {
            Console.WriteLine("error");
            continue;
        }
        var rarity = plants[name][0];
        var tempList = new List<string> { rarity };
        plants[name] = tempList;
    }
}
StringBuilder st = new StringBuilder();
st.AppendLine("Plants for the exhibition:");
foreach (var (key,value) in plants)
{
    var averageRating = 0d;
    if (value.Count > 1)
    {
        averageRating = value.Skip(1).Select(int.Parse).Average();
    }
    st.AppendLine($"- {key}; Rarity: {value[0]}; Rating: {averageRating:f2}");
}
Console.WriteLine(st.ToString().TrimEnd('\n'));