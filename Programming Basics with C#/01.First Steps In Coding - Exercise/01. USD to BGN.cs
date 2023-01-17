using System;
namespace USD_to_BGN
{
	internal class Program
	{
		static void Main(string[] args)
		{
			const double rate = 1.79549;
			double usd = double.Parse(Console.ReadLine());
			Console.WriteLine(usd * rate);
		}
	}
}