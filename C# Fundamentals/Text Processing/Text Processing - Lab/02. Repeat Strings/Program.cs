using System.Text;
var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
StringBuilder st = new StringBuilder();

for (int i = 0; i < input.Count; i++)
{
	for (int j = 0; j < input[i].Length; j++)
	{
		st.Append(input[i]);
	}
}
Console.WriteLine(st);