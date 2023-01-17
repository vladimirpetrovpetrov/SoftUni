using System;

namespace Read_till_stop___while_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();
            while (word != "Stop")
            {
                Console.WriteLine(word);
                word = Console.ReadLine();
            }
        }
    }
}
