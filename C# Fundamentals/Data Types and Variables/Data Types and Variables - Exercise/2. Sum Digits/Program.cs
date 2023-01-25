var n = int.Parse(Console.ReadLine());
Console.WriteLine(SumOFDigits(n));

int SumOFDigits(int number)
{
    int sum = 0;
	while (number>0)
	{
		sum += number % 10;
		number /= 10;
	}
	return sum;
}