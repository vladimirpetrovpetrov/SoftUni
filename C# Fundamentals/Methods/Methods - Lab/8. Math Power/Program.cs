var x = double.Parse(Console.ReadLine());
var y = double.Parse(Console.ReadLine());

Console.WriteLine(MathPower(x,y));



static double MathPower(double x, double y)
{
	double result = 1;
	for (int i = 0; i < y; i++)
	{
		result *= x;
	}
	return result;
}