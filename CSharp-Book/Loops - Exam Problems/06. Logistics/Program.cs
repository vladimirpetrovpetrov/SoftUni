using System;

namespace Logistics
{
    class Program
    {
        static void Main(string[] args)
        {


            var cargoCount = int.Parse(Console.ReadLine());
            var minibus = 0.00;
            var minibusAllCargo = 0.00;
            var truck = 0.00;
            var truckAllCargo = 0.00;
            var train = 0.00;
            var trainAllCargo = 0.00;
            var p1 = 0.00;
            var p2 = 0.00;
            var p3 = 0.00;
            var finalPrice = 0.00;
            var weigthAllCargo = 0.00;
            for (int i = 0; i < cargoCount; i++)
            {

                var cargoWeigth = int.Parse(Console.ReadLine());

                if (cargoWeigth <= 3)
                {
                    minibus += cargoWeigth;
                    //minibusAllCargo = minibusAllCargo + minibus;
                }
                else if (cargoWeigth > 3 && cargoWeigth <= 11)
                {
                    truck += cargoWeigth;
                    //truckAllCargo = truckAllCargo + truck;
                }
                else
                {
                    train += cargoWeigth;
                    //trainAllCargo += train;
                }
            }
            weigthAllCargo = minibus + truck + train;
            p1 = (minibus / weigthAllCargo) * 100;
            p2 = (truck / weigthAllCargo) * 100;
            p3 = (train / weigthAllCargo) * 100;
            finalPrice = (minibus * 200 + truck * 175 + train * 120) / weigthAllCargo;
            Console.WriteLine(String.Format("{0:0.00}", finalPrice));
            Console.WriteLine("{0}%", String.Format("{0:0.00}", p1));
            Console.WriteLine("{0}%", String.Format("{0:0.00}", p2));
            Console.WriteLine("{0}%", String.Format("{0:0.00}", p3));




        }
    }
}
