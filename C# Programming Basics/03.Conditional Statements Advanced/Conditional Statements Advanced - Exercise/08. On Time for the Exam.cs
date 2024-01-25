using System;

namespace Навреме_на_изпит
{
    class Program
    {
        static void Main(string[] args)
        {
            var chasIzpit = int.Parse(Console.ReadLine());
            var minutaIzpit = int.Parse(Console.ReadLine());
            var pristiganeChas = int.Parse(Console.ReadLine());
            var PristiganeMinuta = int.Parse(Console.ReadLine());


            var izpitZapochvaMin = chasIzpit * 60 + minutaIzpit; //960
            var daliETukMin = pristiganeChas * 60 + PristiganeMinuta; //900
            var konkretnoPod = 0;
            var konkretnoNad = 0;

            if (daliETukMin > izpitZapochvaMin) // това е за LATE
            {

                konkretnoPod = daliETukMin - izpitZapochvaMin; //90

                if (konkretnoPod < 60)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine(konkretnoPod + " minutes after the start");
                }
                else if (konkretnoPod >= 60) //true
                {
                    var resultHour = konkretnoPod / 60; // 1
                    var resultMin = konkretnoPod % 60; // 30
                    if (resultMin < 10)
                    {
                        Console.WriteLine("Late");
                        Console.WriteLine(resultHour + ":0" + resultMin + " hours after the start");
                    }
                    else
                    {
                        Console.WriteLine("Late");
                        Console.WriteLine(resultHour + ":" + resultMin + " hours after the start");
                    }
                }
            }
            else if (izpitZapochvaMin - daliETukMin >= 0 && izpitZapochvaMin - daliETukMin <= 30)
            {
                konkretnoPod = izpitZapochvaMin - daliETukMin;
                Console.WriteLine("On time");
                Console.WriteLine(konkretnoPod + " minutes before the start"); // може да има проблем с нулата
            }




            else if (izpitZapochvaMin - daliETukMin > 30)
            {
                konkretnoPod = izpitZapochvaMin - daliETukMin; //90

                if (konkretnoPod < 60)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine(konkretnoPod + " minutes before the start");
                }
                else if (konkretnoPod >= 60) //true
                {
                    var resultHour = konkretnoPod / 60; // 1
                    var resultMin = konkretnoPod % 60; // 30
                    if (resultMin < 10)
                    {
                        Console.WriteLine("Early");
                        Console.WriteLine(resultHour + ":0" + resultMin + " hours before the start");
                    }
                    else
                    {
                        Console.WriteLine("Early");
                        Console.WriteLine(resultHour + ":" + resultMin + " hours before the start");
                    }
                }
            }



        }
    }
}
