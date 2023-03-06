using System.Text;
List<Contest> contestsList = new List<Contest>();
List<Username> usernameList = new List<Username>();
while (true)
{
    var input = Console.ReadLine().Split(":", StringSplitOptions.RemoveEmptyEntries);

    if (input[0] == "end of contests")
    {
        break;
    }

    var contestName = input[0];
    var password = input[1];
    contestsList.Add(new Contest(contestName, password));
}

while (true)
{
    var input = Console.ReadLine().Split("=>", StringSplitOptions.RemoveEmptyEntries);
    if (input[0] == "end of submissions")
    {
        break;
    }
    var contestName = input[0];
    var password = input[1];
    var username = input[2];
    var points = int.Parse(input[3]);

    var searchTheContest = contestsList.Find(x => x.Name == contestName);
    if (searchTheContest != null)
    {
        if (searchTheContest.Password == password)
        {
            bool exist = false;
            foreach (var item in usernameList)
            {
                if (item.Name == username)
                {
                    if (!item.Contests.ContainsKey(contestName))
                    {
                        item.Contests.Add(contestName, points);
                        item.CalcPoints();
                        exist = true;
                        break;
                    }
                    else
                    {
                        item.updatePoints(contestName, points);
                        exist = true;
                        break;
                    }
                }
            }
            if (!exist)
            {
                Username user = new Username(username);
                usernameList.Add(user);
                if (!user.Contests.ContainsKey(contestName))
                {
                    user.Contests.Add(contestName, points);
                    user.CalcPoints();
                }
                else
                {
                    user.updatePoints(contestName, points);
                }
            }
        }
    }

}
usernameList = usernameList.OrderBy(x => x.Name).ToList();

var mostPoints = usernameList.Max(x => x.TotalPoints);
var bestStudentName = usernameList.Find(x => x.TotalPoints == mostPoints).Name;
Console.WriteLine($"Best candidate is {bestStudentName} with total {mostPoints} points.");
Console.WriteLine("Ranking:");
foreach (var item in usernameList)
{
    Console.WriteLine(item);
}
public class Contest
{
    public Contest(string name, string password)
    {
        Name = name;
        Password = password;
    }

    public string Name { get; set; }
    public string Password { get; set; }

}
public class Username
{
    public Username(string name)
    {
        Name = name;
    }
    public string Name { get; set; }
    public int TotalPoints { get; set; }
    public Dictionary<string, int> Contests { get; set; } = new Dictionary<string, int>();
    public void updatePoints(string contestName, int totalPoints)
    {

        if (this.Contests.ContainsKey(contestName) && this.Contests[contestName] < totalPoints)
        {
            this.Contests[contestName] = totalPoints;
        }
        this.TotalPoints = this.Contests.Values.Sum();
    }
    public void CalcPoints()
    {
        this.TotalPoints = this.Contests.Values.Sum();
    }
    public override string ToString()
    {
        StringBuilder st = new StringBuilder();
        st.AppendLine(this.Name);
        foreach (var item in this.Contests.OrderByDescending(x => x.Value))
        {
            st.AppendLine($"#  {item.Key} -> {item.Value}");
        }
        return st.ToString().TrimEnd('\n');
    }
}