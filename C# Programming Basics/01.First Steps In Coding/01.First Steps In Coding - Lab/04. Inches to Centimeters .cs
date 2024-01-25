using System;
namespace _01._Hello_SoftUni
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var inch = double.Parse(Console.ReadLine());
			const double rate = 2.54;

			var result = inch * rate;
			Console.WriteLine(result);
		}
	}
}