using System;

namespace Training
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = Console.ReadLine();
            if (x == "banana" || x == "apple" || x == "kiwi" || x == "cherry" ||
                x == "lemon" || x == "grapes")
            {
                Console.WriteLine("fruit");
            }
            else if (x == "tomato" || x == "cucumber" || x == "pepper" || x == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else { Console.WriteLine("unknown"); }
        }
    }
}
