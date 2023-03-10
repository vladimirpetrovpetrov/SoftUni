var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
if (input[0].Length == input[1].Length)
{
	var sum = 0;
	for (int i = 0; i < input[0].Length; i++)
	{
		sum += input[0][i] * input[1][i];
	}
	Console.WriteLine(sum);
}
else
{
	var sum = 0;
	var lesserLength = Math.Min(input[0].Length, input[1].Length);
	var higherLength = Math.Max(input[0].Length, input[1].Length);
	bool firstIsBigger = input[0].Length > input[1].Length;
	for (int i = 0; i < lesserLength; i++)
	{
		sum += input[0][i] * input[1][i];
	}
	if (firstIsBigger)
	{
		for (int i = lesserLength; i < higherLength; i++)
		{
			sum += input[0][i];
		}
	}
	else
	{
        for (int i = lesserLength; i < higherLength; i++)
        {
            sum += input[1][i];
        }
    }
	Console.WriteLine(sum);
}
