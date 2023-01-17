using System;

namespace Training
{
    internal class Program
    {
        static void Main(string[] args)
        {


            var age = double.Parse(Console.ReadLine());
            var sex = Console.ReadLine();

            if (sex == "m" && age < 16)
            {
                Console.WriteLine("Master");
            }
            else if (sex == "m" && age >= 16)
            {
                Console.WriteLine("Mr.");
            }
            else if (sex == "f" && age < 16)
            {
                Console.WriteLine("Miss");
            }
            else if (sex == "f" && age >= 16)
            {
                Console.WriteLine("Ms.");
            }



        }
    }
}
