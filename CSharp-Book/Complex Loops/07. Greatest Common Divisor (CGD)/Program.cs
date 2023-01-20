using System;

namespace Числата_от_1_до_2_на_н_та_с_for_цикъл
{
    class Program
    {
        static void Main(string[] args)
        {

            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());

            while (!(b == 0))
            {
                var oldB = b; //16 //8
                b = a % b; //8 //0
                a = oldB; //16 //8
            }
            Console.WriteLine(a);




        }
    }
}
