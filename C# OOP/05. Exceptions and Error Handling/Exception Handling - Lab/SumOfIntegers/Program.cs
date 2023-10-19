using System.Xml.Linq;

namespace SumOfIntegers
{
    public class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(" ");
            var sum = 0;
            foreach (var item in input)
            {
                int num = 0;
                try
                {
                    num = int.Parse(item);
                }
                catch (FormatException)
                {
                    Console.WriteLine($"The element '{item}' is in wrong format!");
                }
                catch(OverflowException)
                {
                    Console.WriteLine($"The element '{item}' is out of range!");
                }
                sum += num;

                Console.WriteLine($"Element '{item}' processed - current sum: {sum}");
            }
            Console.WriteLine($"The total sum of all integers is: {sum}");
        }
    }
}