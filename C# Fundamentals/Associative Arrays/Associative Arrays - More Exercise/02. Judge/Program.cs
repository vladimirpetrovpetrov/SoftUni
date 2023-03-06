using System.Text;
var dict = new Dictionary<string, Dictionary<string, int>>();
var list = new List<User>();
while (true)
{
    var input = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

    if (input[0] == "no more time")
    {
        break;
    }
    var username = input[0];
    var contest = input[1];
    var points = int.Parse(input[2]);
    var dictTwo = new Dictionary<string, int>();

    bool exist = list.Any(x => x.Name == username);
    if (!exist) 
    {
        User user = new User(username);
        list.Add(user);
        user.Contests.Add(contest, points);
    }
    else
    {
        User user = list.Find(x=> x.Name == username);  
        if(user.Contests.ContainsKey(contest) && user.Contests[contest] < points)
        {
            user.Contests[contest] = points;
        }else if (!user.Contests.ContainsKey(contest))
        {
            user.Contests.Add(contest, points);
        }
    }
    if (!dict.ContainsKey(contest))
    {
        dictTwo.Add(username, points);
        dict.Add(contest, dictTwo);
    }
    else
    {
        if (!dict[contest].ContainsKey(username))
        {
            dict[contest].Add(username, points);
        }
        else
        {
            if (dict[contest][username] < points)
            {
                dict[contest][username] = points;
            }
        }
    }
}

foreach (var (key, value) in dict)
{
    StringBuilder st = new StringBuilder();
    st.AppendLine($"{key}: {value.Keys.Count} participants");
    int position = 1;
    foreach (var (k, v) in value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
    {
        st.AppendLine($"{position++}. {k} <::> {v}");
    }
    Console.WriteLine(st.ToString().Trim('\n'));
    position = 1;
}

Console.WriteLine("Individual standings:");
var pos = 1;
foreach (var item in list)
{
    item.CalcPoints();
}
var dict2 = new Dictionary<string,int>();
foreach (var item in list)
{
    dict2.Add(item.Name, item.TotalPoints);
}
foreach (var item in dict2.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
{
    Console.WriteLine($"{pos++}. {item.Key} -> {item.Value}");
}
public class User
{
    public string Name { get; set; }
    public Dictionary<string, int> Contests { get; set; } = new Dictionary<string, int>();
    public int TotalPoints { get; set; }
    public User(string name)
    {
        this.Name = name;
    }
    public void CalcPoints()
    {
        this.TotalPoints = this.Contests.Values.Sum();
    }
}