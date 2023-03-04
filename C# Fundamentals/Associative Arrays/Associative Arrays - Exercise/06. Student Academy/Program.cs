int n = int.Parse(Console.ReadLine());
var dict = new Dictionary<string, List<double>>();
for (int i = 0; i < n; i++)
{
    var studentName = Console.ReadLine();
    var studentGrade = double.Parse(Console.ReadLine());

    if (!dict.ContainsKey(studentName))
    {
        dict.Add(studentName, new List<double>());
        dict[studentName].Add(studentGrade);    
    }
    else
    {
        dict[studentName].Add(studentGrade);
    }
}

foreach (var (key,value) in dict)
{
    if (!(dict[key].Average() >= 4.50))
    {
        dict.Remove(key);
    }
}

foreach (var (key,value) in dict)
{
    Console.WriteLine($"{key} -> {dict[key].Average():f2}");
}