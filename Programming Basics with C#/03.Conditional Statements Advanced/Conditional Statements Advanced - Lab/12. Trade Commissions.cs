using System;

namespace Training
{
    class Program
    {
        static void Main(string[] args)
        {

            var city = Console.ReadLine();
            var obemProdajbi = double.Parse(Console.ReadLine());
            var komisionna = 0.0;

            switch (city)
            {
                case "Sofia":
                    if (obemProdajbi >= 0 && obemProdajbi <= 500)
                    {
                        komisionna = obemProdajbi * 0.05;
                        Console.WriteLine((String.Format("{0:0.00}", komisionna)));
                    }
                    else if (obemProdajbi > 500 && obemProdajbi <= 1000)
                    {
                        komisionna = obemProdajbi * 0.07;
                        Console.WriteLine((String.Format("{0:0.00}", komisionna)));
                    }
                    else if (obemProdajbi > 1000 && obemProdajbi <= 10000)
                    {
                        komisionna = obemProdajbi * 0.08;
                        Console.WriteLine((String.Format("{0:0.00}", komisionna)));
                    }
                    else if (obemProdajbi > 10000)
                    {
                        komisionna = obemProdajbi * 0.12;
                        Console.WriteLine((String.Format("{0:0.00}", komisionna)));
                    }
                    else { Console.WriteLine("error"); }
                    break;
                case "Plovdiv":
                    if (obemProdajbi >= 0 && obemProdajbi <= 500)
                    {
                        komisionna = obemProdajbi * 0.055;
                        Console.WriteLine((String.Format("{0:0.00}", komisionna)));
                    }
                    else if (obemProdajbi > 500 && obemProdajbi <= 1000)
                    {
                        komisionna = obemProdajbi * 0.08;
                        Console.WriteLine((String.Format("{0:0.00}", komisionna)));
                    }
                    else if (obemProdajbi > 1000 && obemProdajbi <= 10000)
                    {
                        komisionna = obemProdajbi * 0.12;
                        Console.WriteLine((String.Format("{0:0.00}", komisionna)));
                    }
                    else if (obemProdajbi > 10000)
                    {
                        komisionna = obemProdajbi * 0.145;
                        Console.WriteLine((String.Format("{0:0.00}", komisionna)));
                    }
                    else { Console.WriteLine("error"); }
                    break;
                case "Varna":
                    if (obemProdajbi >= 0 && obemProdajbi <= 500)
                    {
                        komisionna = obemProdajbi * 0.045;
                        Console.WriteLine((String.Format("{0:0.00}", komisionna)));
                    }
                    else if (obemProdajbi > 500 && obemProdajbi <= 1000)
                    {
                        komisionna = obemProdajbi * 0.075;
                        Console.WriteLine((String.Format("{0:0.00}", komisionna)));
                    }
                    else if (obemProdajbi > 1000 && obemProdajbi <= 10000)
                    {
                        komisionna = obemProdajbi * 0.10;
                        Console.WriteLine((String.Format("{0:0.00}", komisionna)));
                    }
                    else if (obemProdajbi > 10000)
                    {
                        komisionna = obemProdajbi * 0.13;
                        Console.WriteLine((String.Format("{0:0.00}", komisionna)));
                    }
                    else { Console.WriteLine("error"); }
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }



        }
    }
}
