int n = int.Parse(Console.ReadLine());
var dict = new SortedDictionary<string, SortedDictionary<string, int>>();
for (int i = 0; i < n; i++)
{
    var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    var ip = input[0];
    var user = input[1];
    var duration = int.Parse(input[2]);

    bool userExist = dict.ContainsKey(user);

    if (!userExist)//ако юзъра не съществува 
    {
        var ipS = new SortedDictionary<string, int>();
        ipS.Add(ip, duration);
        dict.Add(user, ipS);
    }
    else//ако юзъра съществува
    {
        var ipExist = dict[user].ContainsKey(ip);


        if (!ipExist)//ако ip-to вече същесвува
        {
            dict[user].Add(ip, duration);
        }
        else
        {
            dict[user][ip] += duration;
        }
    }
}


foreach (var (key,value) in dict)
{
    Console.Write($"{key}: {value.Values.Sum()} ");
    Console.WriteLine("["+String.Join(", ",value.Keys)+"]");

}