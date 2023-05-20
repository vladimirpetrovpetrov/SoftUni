int n = int.Parse(Console.ReadLine());
HashSet<string> list = new HashSet<string>();

for (int i = 0; i < n; i++)
{
    var input = Console.ReadLine();
    list.Add(input);
}
Console.WriteLine(string.Join(Environment.NewLine,list));
