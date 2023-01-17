using System;

namespace Ски_Почивка
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            	"room for one person" – 18.00 лв за нощувка
            	"apartment" – 25.00 лв за нощувка
            	"president apartment" – 35.00 лв за нощувка

            Според броят на дните, в които ще остане в хотела 
            (пример: 11 дни = 10 нощувки) и видът на помещението,
            което ще избере, той може да ползва различно намаление.

            вид помещение	по-малко от 10 дни	между 10 и 15 дни	повече от 15 дни
        room for one person	не ползва намаление	не ползва намаление	не ползва намаление
        apartment	        30% от крайната цена35% от крайната цена50% от крайната цена
        president apartment	10% от крайната цена15% от крайната цена20% от крайната цена

            //позитивна оценка = цена + (цена * 0.25)
            //негативна оценка = цена - (цена * 0.10)

            */

            var dniPrestoi = (int.Parse(Console.ReadLine()) - 1);
            var pomeshtenie = Console.ReadLine();
            var ocenka = Console.ReadLine();
            var cena = 0.00;

            switch (ocenka)
            {
                case "positive":
                    switch (pomeshtenie)
                    {

                        case "room for one person":

                            cena = dniPrestoi * 18;

                            break;

                        case "apartment":
                            if (dniPrestoi < 10)
                            {
                                cena = (dniPrestoi * 25) - (dniPrestoi * 25) * 0.30;
                            }
                            else if (dniPrestoi >= 10 && dniPrestoi <= 15)
                            {
                                cena = (dniPrestoi * 25) - (dniPrestoi * 25) * 0.35;
                            }
                            else
                            {
                                cena = (dniPrestoi * 25) - (dniPrestoi * 25) * 0.50;
                            }

                            break;

                        case "president apartment":
                            if (dniPrestoi < 10)
                            {
                                cena = (dniPrestoi * 35) - (dniPrestoi * 35) * 0.10;
                            }
                            else if (dniPrestoi >= 10 && dniPrestoi <= 15)
                            {
                                cena = (dniPrestoi * 35) - (dniPrestoi * 35) * 0.15;
                            }
                            else
                            {
                                cena = (dniPrestoi * 35) - (dniPrestoi * 35) * 0.20;
                            }
                            break;
                    }
                    cena = cena + (cena * 0.25);
                    Console.WriteLine(String.Format("{0:0.00}", cena));
                    break;

                case "negative":
                    switch (pomeshtenie)
                    {

                        case "room for one person":

                            cena = dniPrestoi * 18;

                            break;

                        case "apartment":
                            if (dniPrestoi < 10)
                            {
                                cena = (dniPrestoi * 25) - (dniPrestoi * 25) * 0.30;
                            }
                            else if (dniPrestoi >= 10 && dniPrestoi <= 15)
                            {
                                cena = (dniPrestoi * 25) - (dniPrestoi * 25) * 0.35;
                            }
                            else
                            {
                                cena = (dniPrestoi * 25) - (dniPrestoi * 25) * 0.50;
                            }

                            break;

                        case "president apartment":
                            if (dniPrestoi < 10)
                            {
                                cena = (dniPrestoi * 35) - (dniPrestoi * 35) * 0.10;
                            }
                            else if (dniPrestoi >= 10 && dniPrestoi <= 15)
                            {
                                cena = (dniPrestoi * 35) - (dniPrestoi * 35) * 0.15;
                            }
                            else
                            {
                                cena = (dniPrestoi * 35) - (dniPrestoi * 35) * 0.20;
                            }
                            break;
                    }
                    cena = cena - (cena * 0.10);
                    Console.WriteLine(String.Format("{0:0.00}", cena));
                    break;
            }








        }
    }
}
