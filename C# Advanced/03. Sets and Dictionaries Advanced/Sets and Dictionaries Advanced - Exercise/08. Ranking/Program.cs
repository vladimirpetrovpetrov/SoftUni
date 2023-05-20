var contests = new Dictionary<string, string>();
while (true)
{
    var input = Console.ReadLine();
    if (input == "end of contests")
    {
        break;
    }
    var contest = input.Split(":", StringSplitOptions.RemoveEmptyEntries)[0];
    var password = input.Split(":", StringSplitOptions.RemoveEmptyEntries)[1];
    if (!contests.ContainsKey(contest))
    {
        contests[contest] = password;
    }
}
//Make it List<int> for total points the nested dict instead of just int
var usernames = new Dictionary<string, Dictionary<string, int>>();
while (true)
{
    var input = Console.ReadLine();
    if (input == "end of submissions")
    {
        break;
    }
    var contest = input.Split("=>", StringSplitOptions.RemoveEmptyEntries)[0];
    if (!contests.ContainsKey(contest))
    {
        continue;
    }
    var password = input.Split("=>", StringSplitOptions.RemoveEmptyEntries)[1];
    if (contests[contest] != password)
    {
        continue;
    }
    var username = input.Split("=>", StringSplitOptions.RemoveEmptyEntries)[2];
    var points = int.Parse(input.Split("=>", StringSplitOptions.RemoveEmptyEntries)[3]);
    if (!usernames.ContainsKey(username))
    {
        usernames.Add(username, new Dictionary<string, int>());
        usernames[username].Add(contest, points);
    }
    else if (usernames.ContainsKey(username))
    {
        if (!usernames[username].ContainsKey(contest))
        {
            usernames[username].Add(contest, points);
        }
        else
        {
            if (usernames[username][contest] < points)
            {
                usernames[username][contest] = points;
            }
        }
    }
}
var bestUser = string.Empty;
var mostPoints = 0;
foreach (var (k, v) in usernames)
{
    if (v.Values.Sum() > mostPoints)
    {
        mostPoints = v.Values.Sum();
        bestUser = k;
    }
}
Console.WriteLine($"Best candidate is {bestUser} with total {mostPoints} points.");
Console.WriteLine("Ranking:");
foreach (var (k, v) in usernames.OrderBy(x => x.Key))
{
    Console.WriteLine(k);
    foreach (var (key, value) in v.OrderByDescending(x => x.Value))
    {
        Console.WriteLine($"#  {key} -> {value}");
    }
}