using System.Globalization;

namespace _04._Add_VAT
{
   
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(Environment.NewLine , Console.ReadLine().Split(", ").Select(priceString =>
            {
                return (double.Parse(priceString) + double.Parse(priceString) * 0.2).ToString("F2");
            })));


        }
    }

}