using System;

namespace Training
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var km = int.Parse(Console.ReadLine());
            var dayNight = Console.ReadLine();

            switch (dayNight)
            {
                case "day":

                    var taxiDay = km * 0.79 + 0.70;
                    var busDay = km * 0.09;
                    var trainDay = km * 0.06;
                    if (km < 20)
                    {
                        Console.WriteLine(String.Format("{0:0.00}", taxiDay));
                    }
                    else if (km >= 20 && km < 100)
                    {
                        if (busDay <= taxiDay)
                        {
                            Console.WriteLine(String.Format("{0:0.00}", busDay));
                        }
                        else { Console.WriteLine(String.Format("{0:0.00}", taxiDay)); }
                    }
                    else
                    {
                        if (busDay <= trainDay)
                        {
                            Console.WriteLine(String.Format("{0:0.00}", busDay));
                        }
                        else
                        {
                            Console.WriteLine(String.Format("{0:0.00}", trainDay));
                        }
                    }


                    break;
                case "night":
                    var taxiNight = km * 0.90 + 0.70;
                    var busNight = km * 0.09;
                    var trainNight = km * 0.06;
                    if (km < 20)
                    {
                        Console.WriteLine(String.Format("{0:0.00}", taxiNight));
                    }
                    else if (km >= 20 && km < 100)
                    {
                        if (busNight <= taxiNight)
                        {
                            Console.WriteLine(String.Format("{0:0.00}", busNight));
                        }
                        else { Console.WriteLine(String.Format("{0:0.00}", taxiNight)); }
                    }
                    else
                    {
                        if (busNight <= trainNight)
                        {
                            Console.WriteLine(String.Format("{0:0.00}", busNight));
                        }
                        else
                        {
                            Console.WriteLine(String.Format("{0:0.00}", trainNight));
                        }
                    }
                    break;
                default:
                    break;
            }



        }
    }
}
