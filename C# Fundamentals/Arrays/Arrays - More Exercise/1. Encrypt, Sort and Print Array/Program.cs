var n = int.Parse(Console.ReadLine());
List<int> list = new List<int>();
for(int i = 0;i < n; i++)
{


    var command = Console.ReadLine();
    int sum = 0;
    foreach (char item in command)
	{
		if(item =='a' || item == 'e' || item == 'i' || item == 'o' || item == 'u' || 

            item == 'A' || item == 'E' || item == 'I' || item == 'O' || item == 'U' )
		{
			sum += (int)item * command.Length;
		}
		else
		{
			sum += (int)item / command.Length;
		}
    }
	list.Add(sum);
	sum = 0;
}
int[] y = new int[list.Count];
foreach(int i in list.OrderBy(x => x))
{
	Console.WriteLine(i);
}