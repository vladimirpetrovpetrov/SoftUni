using System;

namespace Хотелска_стая
{
    class Program
    {
        static void Main(string[] args)
        {

            var month = Console.ReadLine();
            var nights = int.Parse(Console.ReadLine());
            var ap_price = 0.00;
            var s_price = 0.00;

            switch (month)
            {
                case "May":
                case "October":
                    ap_price = 65;
                    s_price = 50;
                    if (nights > 7 && nights <= 14)
                    {
                        s_price = s_price - (s_price * 0.05);
                    }
                    else if (nights > 14)
                    {
                        s_price = s_price - (s_price * 0.30);
                        ap_price = ap_price - (ap_price * 0.10);
                    }
                    Console.WriteLine("Apartment: " + String.Format("{0:0.00}", (nights * ap_price)) + " lv.");
                    Console.WriteLine("Studio: " + String.Format("{0:0.00}", (nights * s_price)) + " lv.");

                    break;

                case "June":
                case "September":
                    ap_price = 68.70;
                    s_price = 75.20;
                    if (nights > 14)
                    {
                        s_price = s_price - (s_price * 0.20);
                        ap_price = ap_price - (ap_price * 0.10);

                    }
                    Console.WriteLine("Apartment: " + String.Format("{0:0.00}", (nights * ap_price)) + " lv.");
                    Console.WriteLine("Studio: " + String.Format("{0:0.00}", (nights * s_price)) + " lv.");

                    break;

                case "July":
                case "August":
                    ap_price = 77;
                    s_price = 76;
                    if (nights > 14)
                    {
                        ap_price = ap_price - (ap_price * 0.10);
                    }
                    Console.WriteLine("Apartment: " + String.Format("{0:0.00}", (nights * ap_price)) + " lv.");
                    Console.WriteLine("Studio: " + String.Format("{0:0.00}", (nights * s_price)) + " lv.");
                    break;


            }



        }
    }
}
