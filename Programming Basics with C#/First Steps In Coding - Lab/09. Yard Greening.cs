using System;
namespace _01._Hello_SoftUni
{
	internal class Program
	{
		static void Main(string[] args)
		{

			var sqM = double.Parse(Console.ReadLine());
			//цена кв.м - 7.61
			//отстъпка - 18%

			Console.WriteLine("The final price is: {0} lv.", String.Format("{0:0.00}",
				((sqM * 7.61) * 0.82)));
			Console.WriteLine("The discount is: {0} lv.", String.Format("{0:0.00}", sqM * 7.61 * 0.18));


		}
	}
}