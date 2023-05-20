using System.Linq;

Dictionary<string,List<string>> vloggers = new Dictionary<string,List<string>>();
while (true)
{
    var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
    if (input[0] == "Statistics")
    {
        break;
    }
    //VloggerName
    var vloggername = input[0];

    if (input[1] == "joined")
    {
        //Joining V-Logger
        if (!vloggers.ContainsKey(vloggername))
        {
            vloggers.Add(vloggername, new List<string>() { "0", "0" });
        }
    }
    else
    {
        //Start following someone
        var vloggernameToFollow = input[2];
        //Cant follow someone who is not in V-Log and cant follow yourself
        if(!vloggers.ContainsKey(vloggernameToFollow)|| !vloggers.ContainsKey(vloggername) || vloggernameToFollow == vloggername || vloggers[vloggernameToFollow].Contains(vloggername))
        {
            continue;
        }
        //Followers = 0
        var followers = int.Parse(vloggers[vloggernameToFollow][0]);
        followers++;
        vloggers[vloggernameToFollow][0] = followers.ToString();
        //Following = 1
        var following = int.Parse(vloggers[vloggername][1]);
        following++;
        vloggers[vloggername][1] = following.ToString();
        vloggers[vloggernameToFollow].Add(vloggername);
    }
}
Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");
var count = 0;
foreach (var (k,v) in vloggers.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Value[1]))
{
        Console.WriteLine($"{++count}. {k} : {v[0]} followers, {v[1]} following");
        if(count == 1)
    {
        var followersList = vloggers[k].Skip(2).ToList();
        foreach (var item in followersList.OrderBy(x=>x))
        {
            Console.WriteLine($"*  {item}");
        }
    }
    
}
