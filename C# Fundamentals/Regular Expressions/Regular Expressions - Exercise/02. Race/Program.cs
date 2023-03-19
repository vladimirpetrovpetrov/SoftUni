using System.Collections.Immutable;
using System.Text;
using System.Text.RegularExpressions;

var participants = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
var racers = new Dictionary<string, long>();
while (true)
{
    var input = Console.ReadLine();
    if (input == "end of race")
    {
        break;
    }
    string namePattern = @"[A-Za-z]+";
    Regex regex = new Regex(namePattern);
    var resultName = regex.Matches(input);
    var name = string.Empty;
    foreach (Match item in resultName)
    {
        name += item;
    }
    string distancePattern = @"\d";
    int totalDistance = 0;
    regex = new Regex(distancePattern);
    var resultDistance = regex.Matches(input);
    foreach (Match item in resultDistance)
    {
        totalDistance += int.Parse(item.Value);
    }
    if (!racers.ContainsKey(name))
    {
        racers[name] = totalDistance;
    }
    else
    {
        racers[name] += totalDistance;
    }
}
foreach (var (key, value) in racers)
{
    if (!participants.Contains(key))
    {
        racers.Remove(key);
    }
}
var count = 1;
StringBuilder st = new StringBuilder();
foreach (var item in racers.OrderByDescending(x=>x.Value))
{

    switch (count)
    {
        case 1:
            st.AppendLine($"1st place: {item.Key}");
            break;
        case 2:
            st.AppendLine($"2nd place: {item.Key}");
            break;
        case 3:
            st.AppendLine($"3rd place: {item.Key}");
            break;
        default:
            break;
    }
    count++;
    if (count > 3)
    {
        break;
    }
}
Console.WriteLine(st.ToString().TrimEnd('\n'));
