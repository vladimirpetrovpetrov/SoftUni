Console.WriteLine(CountVowels(Console.ReadLine().ToLower()));

static int CountVowels(string input)
{
	int count = 0;
	foreach (char item in input)
	{
		if(item == 'a' || item == 'e' || item == 'o' || item == 'u' || item == 'i')
		{
			count++;
		}
	}
	return count;
}