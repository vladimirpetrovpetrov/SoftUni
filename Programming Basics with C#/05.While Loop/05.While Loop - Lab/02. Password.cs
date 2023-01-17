using System;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            //while


            var name = Console.ReadLine();
            var password = Console.ReadLine();
            var password1 = Console.ReadLine();

            while (password1 != password)
            {
                password1 = Console.ReadLine();
            }
            Console.WriteLine("Welcome {0}!", name);



        }
    }
}
