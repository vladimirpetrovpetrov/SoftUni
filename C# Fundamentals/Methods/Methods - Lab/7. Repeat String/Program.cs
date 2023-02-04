var word = Console.ReadLine();
var repeat = int.Parse(Console.ReadLine());
Console.WriteLine(RepeatString(word,repeat));



static string RepeatString(string input , int repeatTimes)
{
    string result = string.Empty;
	for (int i = 0; i < repeatTimes; i++)
	{
		result += input;
	}
	return result;
}