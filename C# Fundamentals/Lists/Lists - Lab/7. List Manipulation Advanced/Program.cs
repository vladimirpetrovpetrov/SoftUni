var list = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
var finalResult = new List<int>();
foreach (var item in list)
{
    finalResult.Add(item);
}
int changes = 0;
while (true)
{
    var line = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    if (line[0] == "end")
    {
        break;
    }
    if (line[0] == "Add")
    {
        int num = int.Parse(line[1]);
        finalResult.Add(num);
        changes++;
    }
    else if (line[0] == "Remove")
    {
        int num = int.Parse(line[1]);
        finalResult.Remove(num);
        changes++;
    }
    else if (line[0] == "RemoveAt")
    {
        int num = int.Parse(line[1]);
        finalResult.RemoveAt(num);
        changes++;
    }
    else if (line[0] == "Insert")
    {
        int index = int.Parse(line[2]);
        int num = int.Parse(line[1]);
        finalResult.Insert(index, num);
        changes++;
    }
    else if (line[0] == "Contains")
    {
        int num = int.Parse(line[1]);
        string result = finalResult.Contains(num) ? "Yes" : "No such number";
        Console.WriteLine(result);
    }
    else if (line[0] == "PrintEven")
    {
        List<int> evenNums = finalResult.Where(x => x % 2 == 0).ToList();
        Console.WriteLine(String.Join(" ", evenNums));
    }
    else if (line[0] == "PrintOdd")
    {
        List<int> oddNums = finalResult.Where(x => x % 2 != 0).ToList();
        Console.WriteLine(String.Join(" ", oddNums));
    }
    else if (line[0] == "GetSum")
    {
        Console.WriteLine(finalResult.Sum());
    }
    else if (line[0] == "Filter")
    {
        int num = int.Parse(line[2]);
        var condition = line[1];
        List<int> filteredList = new List<int>();
        if (condition == ">")
        {
            filteredList = finalResult.Where(x => x > num).ToList();
        }
        else if (condition == "<")
        {
            filteredList = finalResult.Where(x => x < num).ToList();
        }
        else if (condition == ">=")
        {
            filteredList = finalResult.Where(x => x >= num).ToList();
        }
        else if (condition == "<=")
        {
            filteredList = finalResult.Where(x => x <= num).ToList();
        }
        Console.WriteLine(String.Join(" ", filteredList));
    }
}
if (changes > 0)
{
    Console.WriteLine(String.Join(" ", finalResult));
}