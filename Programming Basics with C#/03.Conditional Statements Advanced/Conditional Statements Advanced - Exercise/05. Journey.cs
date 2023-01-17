using System;

namespace Пътешествие
{
    class Program
    {
        static void Main(string[] args)
        {

            var budget = double.Parse(Console.ReadLine());
            var season = Console.ReadLine();

            //лято = къмпинг
            //зима = хотел
            var destination = "";
            var type = "";

            if (budget <= 100)
            {
                destination = "Bulgaria";
                switch (season)
                {
                    case "summer":
                        budget = budget * 0.30;
                        type = "Camp";
                        Console.WriteLine("Somewhere in " + destination);
                        Console.WriteLine(type + " - " + String.Format("{0:0.00}", budget));
                        break;

                    case "winter":
                        budget = budget * 0.70;
                        type = "Hotel";
                        Console.WriteLine("Somewhere in " + destination);
                        Console.WriteLine(type + " - " + String.Format("{0:0.00}", budget));
                        break;
                }

            }



            else if (budget > 100 && budget <= 1000)
            {
                destination = "Balkans";
                switch (season)
                {
                    case "summer":
                        budget = budget * 0.40;
                        type = "Camp";
                        Console.WriteLine("Somewhere in " + destination);
                        Console.WriteLine(type + " - " + String.Format("{0:0.00}", budget));
                        break;

                    case "winter":
                        budget = budget * 0.80;
                        type = "Hotel";
                        Console.WriteLine("Somewhere in " + destination);
                        Console.WriteLine(type + " - " + String.Format("{0:0.00}", budget));
                        break;
                }
            }
            else if (budget > 1000)
            {
                destination = "Europe";
                type = "Hotel";
                budget = budget * 0.90;

                Console.WriteLine("Somewhere in " + destination);
                Console.WriteLine(type + " - " + String.Format("{0:0.00}", budget));


            }






        }
    }
}
