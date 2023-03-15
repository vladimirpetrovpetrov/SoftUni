var input = Console.ReadLine();
var startingIndex = 0;
var endingIndex = 0;
var symbol = string.Empty;

for (int i = 0; i < input.Length; i++)
{
    var lenght = 0;
    for (int j = i+1; j < input.Length; j++)
	{
		if (input[i] == input[j])
		{
			lenght++;
			symbol = input[i].ToString();
			startingIndex = i;
		}
		else
		{
			break;
		}
	}
    if (lenght > 0)
    {
        input = input.Remove(startingIndex, lenght);
    }
}
Console.WriteLine(input);