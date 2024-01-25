using System;

namespace _03._Logistics
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //cargo <= 3 - minibus / 200 lv /ton
            //cargo >= 4 && cargo <= 11 - truck / 175 / ton
            //cargo >= 12 - train / 120 lv / ton

            int cargoCount = int.Parse(Console.ReadLine());
            double allCargoPrice = 0.0;
            int truckCargos = 0;
            int trainCargos = 0;
            int minibusCargos = 0;

            for (int i = 0; i < cargoCount; i++)
            {
                int cargoWeight = int.Parse(Console.ReadLine());

                if (cargoWeight <= 3)
                {
                    minibusCargos += cargoWeight;
                    allCargoPrice += cargoWeight * 200.00;
                }
                else if (cargoWeight >= 4 && cargoWeight <= 11)
                {
                    truckCargos += cargoWeight;
                    allCargoPrice += cargoWeight * 175.00;
                }
                else
                {
                    trainCargos += cargoWeight;
                    allCargoPrice += cargoWeight * 120.00;
                }
            }
            double fullWeightOfCargo = truckCargos + trainCargos + minibusCargos;
            double averageCargoPrice = allCargoPrice / fullWeightOfCargo;
            Console.WriteLine($"{averageCargoPrice:0.00}");
            Console.WriteLine($"{minibusCargos / fullWeightOfCargo * 100:0.00}%");
            Console.WriteLine($"{truckCargos / fullWeightOfCargo * 100:0.00}%");
            Console.WriteLine($"{trainCargos / fullWeightOfCargo * 100:0.00}%");
        }
    }
}
