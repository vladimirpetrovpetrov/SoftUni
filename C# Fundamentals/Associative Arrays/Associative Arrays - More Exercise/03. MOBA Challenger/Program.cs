internal class Program
{
    private static void Main(string[] args)
    {
        List<Player> players = new List<Player>();
        while (true)
        {
            var input = Console.ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            if (input[0] == "Season" && input[1] == "end")
            {
                break;
            }
            if (input.Count == 5)
            {
                input.RemoveAll(x => x == "->");
                var player = input[0];
                var position = input[1];
                var skill = int.Parse(input[2]);

                bool playerExist = players.Any(x => x.Name == player); //дали играча вече съществува
                if (!playerExist)
                {
                    //ако играча НЕ съществува - го вкарваме(позиция и скил също няма как да съществуват при този случай)
                    Player p = new Player(player);
                    players.Add(p);
                    p.Positions.Add(position, skill);
                    p.CalcPoints();
                }
                else
                {
                    //Ако играча СЪЩЕСТВУВА
                    bool positionExist = players.Find(x => x.Name == player).Positions.ContainsKey(position);//дали позицията на играча съществува(тя може да съществува само, ако той съществува.
                    if (!positionExist)
                    {
                        //ако играча съществува, но позицията не съществува
                        players.Find(x => x.Name == player)!.Positions.Add(position, skill);
                        players.Find(x => x.Name == player)!.CalcPoints();
                    }
                    else
                    {
                        //ако играча съществува и позицията СЪЩЕСТВУВА
                        if (players.Find(x => x.Name == player)!.Positions[position] < skill)
                        {
                            //ако позицията съществува и новия скил е по-висок
                            players.Find(x => x.Name == player)!.Positions[position] = skill;
                            players.Find(x => x.Name == player)!.CalcPoints();
                        }
                        //ако позицията съществува но новия скил е по-нисък
                        //ако позицията съществува и скила е еднакъв 
                        //и в двата случая не трябва да добавяме нищо.
                    }
                }
            }
            else
            {
                input.RemoveAll(x => x == "vs");
                var firstPlayer = input[0];
                var secondPlayer = input[1];

                //тук става боя

                bool firstPlayerExist = players.Any(x => x.Name == firstPlayer);
                bool secondPlayerExist = players.Any(x => x.Name == secondPlayer);

                if (firstPlayerExist && secondPlayerExist)
                {
                    //ако и двата играча СЪЩЕСТВУВАТ

                    var firstObject = players.Find(x => x.Name == firstPlayer);
                    var secondObject = players.Find(x => x.Name == secondPlayer);
                    bool samePos = CheckForCommonPositions(firstObject, secondObject);
                    if (samePos)//ако имат обща позиция
                    {
                        //ако имат обща позиция и различен брой точки
                        if (firstObject.Points > secondObject.Points)
                        {
                            var loser = players.Find(x => x.Name == secondObject.Name);
                            players.Remove(loser);
                        }
                        else if (firstObject.Points < secondObject.Points)
                        {
                            var loser = players.Find(x => x.Name == firstObject.Name);
                            players.Remove(loser);
                        }
                        //ако имат обща позиция и еднакъв брой точки
                    }
                }
            }
        }

        //should print the players, ordered by total skill in descending order, then ordered by player
        //name in ascending order. Foreach player print their position and skill, ordered descending
        //by skill, then ordered by position name in ascending order.

        players = players.OrderByDescending(x => x.Points).ThenBy(x => x.Name).ToList(); //ordered by total skill in descending order, then ordered by player
                                                                                         //name in ascending order.

        foreach (var item in players)
        {
            Console.WriteLine($"{item.Name}: {item.Points} skill");
            foreach (var (key, value) in item.Positions.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"- {key} <::> {value}");
            }
        }
    }
    public static bool CheckForCommonPositions(Player firstObject, Player secondObject)
    {
        bool result = false;
        foreach (var p1 in firstObject.Positions)
        {
            foreach (var p2 in secondObject.Positions)
            {
                if (p1.Key == p2.Key)
                {
                    result = true;
                    break;
                }
            }
            if (result)
            {
                break;
            }
        }
        return result;
    }
}

public class Player
{
    public string Name { get; set; }
    public int Points { get; set; }
    public Dictionary<string, int> Positions { get; set; }
    public Player(string name)
    {
        Name = name;
        Positions = new Dictionary<string, int>();
        Points = 0;
    }
    public void CalcPoints()
    {
        this.Points = this.Positions.Values.Sum();
    }

}