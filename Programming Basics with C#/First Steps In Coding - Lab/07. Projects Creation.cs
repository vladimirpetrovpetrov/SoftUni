using System;
namespace _01._Hello_SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var archName = Console.ReadLine();
            var projectCount = int.Parse(Console.ReadLine());
            Console.WriteLine("The architect {0} " +
                "will need {1}" +
                " hours to complete {2} project/s.", archName, projectCount * 3, projectCount);

        }
    }
}