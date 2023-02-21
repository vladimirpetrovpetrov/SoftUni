public class Program
{
    static void Main()
    {
        int teamsCount = int.Parse(Console.ReadLine()!);
        var teams = new List<Team>();
        for (int i = 0; i < teamsCount; i++)
        {
            var input = Console.ReadLine()!.Split("-").ToList();
            teams.Add(new Team (new User(input[0]), input[1]) );
        }
        while (true)
        {
            var input = Console.ReadLine()!.Split().ToList();
            if (input[0] == "end of assignment")
            {
                break;
            }







        }
    }
}
public class Team
{
    public List<User> users { get; set; }
    public string Name { get; set; }
    public Team(User user, string name)
    {
        this.Name = name;
        users.Add(user);
    }
}
public class User
{
    public string UserName { get; set;}
    public User(string userName)
    {
        this.UserName = userName;
    }
}