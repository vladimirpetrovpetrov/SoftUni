using System;

namespace Trekking_Mania
{
    class Program
    {
        static void Main(string[] args)
        {


            var groupCount = int.Parse(Console.ReadLine());
            var musala = 0.00;
            var monblan = 0.00;
            var kili = 0.00;
            var k2 = 0.00;
            var everest = 0.00;
            var sumPeople = 0;

            for (int i = 0; i < groupCount; i++)
            {
                var peopleCount = int.Parse(Console.ReadLine());
                sumPeople = sumPeople + peopleCount;
                if (peopleCount <= 5)
                {
                    musala += peopleCount;
                }
                else if (peopleCount > 5 && peopleCount <= 12)
                {
                    monblan += peopleCount;
                }
                else if (peopleCount > 12 && peopleCount <= 25)
                {
                    kili += peopleCount;
                }
                else if (peopleCount > 25 && peopleCount <= 40)
                {
                    k2 += peopleCount;
                }
                else if (peopleCount > 40)
                {
                    everest += peopleCount;
                }
            }

            musala = (musala / sumPeople) * 100;
            monblan = (monblan / sumPeople) * 100;
            kili = (kili / sumPeople) * 100;
            k2 = (k2 / sumPeople) * 100;
            everest = (everest / sumPeople) * 100;
            Console.WriteLine(String.Format("{0:0.00}", musala) + "%");
            Console.WriteLine(String.Format("{0:0.00}", monblan) + "%");
            Console.WriteLine(String.Format("{0:0.00}", kili) + "%");
            Console.WriteLine(String.Format("{0:0.00}", k2) + "%");
            Console.WriteLine(String.Format("{0:0.00}", everest) + "%");




        }
    }
}
