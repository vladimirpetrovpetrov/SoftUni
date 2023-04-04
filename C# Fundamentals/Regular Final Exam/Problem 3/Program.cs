using System.Xml.Linq;

var users = new Dictionary<string, List<int>>();
while (true)
{
    var input = Console.ReadLine().Split(": ", StringSplitOptions.RemoveEmptyEntries);
    if (input[0] == "Log out")
    {
        break;
    }

    if (input[0] == "New follower")
    {
        var username = input[1];
        if (!users.ContainsKey(username))
        {
            var tempList = new List<int> { 0, 0 };
            users[username] = tempList;
        }
    }else if (input[0] == "Like")
    {
        var username = input[1];
        var likes = int.Parse(input[2]);
        if (!users.ContainsKey(username))
        {
            var tempList = new List<int> { likes, 0 };
            users[username] = tempList;
        }
        else
        {
            users[username][0] += likes;
        }
    }
    else if (input[0] == "Comment")
    {
        var username = input[1];
        if (!users.ContainsKey(username))
        {
            var tempList = new List<int> { 0, 1 };
            users[username] = tempList;
        }
        else
        {
            users[username][1] += 1;
        }
    }
    else if (input[0] == "Blocked")
    {
        var username = input[1];
        if (!users.ContainsKey(username))
        {
            Console.WriteLine($"{username} doesn't exist.");
            continue;
        }
        users.Remove(username);
    }
}
Console.WriteLine($"{users.Count} followers");
foreach (var (key,value) in users)
{
    Console.WriteLine($"{key}: {value.Sum()}");
}