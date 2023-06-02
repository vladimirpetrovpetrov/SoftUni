using System.Globalization;

namespace _04._Add_VAT
{
   
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, string> convertAndAddVAT = x =>
            {
                var toDouble = double.Parse(x);
                return (toDouble * 1.20).ToString("F2");
            };
            var prices = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(convertAndAddVAT)
                .ToArray();
            Console.WriteLine(String.Join(Environment.NewLine,prices));
        }
    }
}