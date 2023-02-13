var whole = Console.ReadLine();
var x = whole.Split("|", StringSplitOptions.RemoveEmptyEntries).ToList();
var final = new List<string>();

for (int i = 0; i < x.Count; i++)
{
    List<string> list = new List<string>();
    list = x[x.Count - 1-i].Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
    
    for (int j = 0; j < list.Count; j++)
    {
        final.Add(list[j]);
    }
    ;
}
Console.WriteLine(String.Join(" ",final));