Dictionary<string, int> students = new();
Dictionary<string, int> submissions = new();

while (true)
{
    var input = Console.ReadLine().Split("-", StringSplitOptions.RemoveEmptyEntries).ToList();
    if (input[0] == "exam finished")
    {
        break;
    }
    if (input[1] == "banned")
    {
        students.Remove(input[0]);
        continue;
    }
    var username = input[0];
    var lang = input[1];
    var points = int.Parse(input[2]);


    if (!students.ContainsKey(username))
    {
        students.Add(username, points);
    }
    else
    {
        if (students[username] < points)
        {
            students[username] = points;
        }
    }

    if(!submissions.ContainsKey(lang)) 
    {
        submissions.Add(lang, 1);
    }
    else
    {
        submissions[lang]++;
    }
}

Console.WriteLine("Results:");
foreach (var (k,v) in students.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
{
    Console.WriteLine($"{k} | {v}");
}
Console.WriteLine("Submissions:");
foreach (var (k, v) in submissions.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
{
    Console.WriteLine($"{k} - {v}");
}