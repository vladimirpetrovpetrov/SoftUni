namespace _03.Speed_Racing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            //инициализираме колите
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var model = input[0];
                var fuelAmount = double.Parse(input[1]);
                var fuelConsumptionFor1km = double.Parse(input[2]);
                cars.Add(new Car(model,fuelAmount,fuelConsumptionFor1km));
            }
            


            //тук става карането
            while (true)
            {
                var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "End")
                {
                    break;
                }
                var model = input[1];
                var distance = int.Parse(input[2]);
                Car car = cars.First(x => x.Model == model);
                car.Drive(distance);
            }

            //тук принтираме
            foreach (var item in cars)
            {
                Console.WriteLine(item);
            }





        }
    }
    public class Car
    {
        public Car(string model, double fuelAmount, double fuelPerKm)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelPerKm = fuelPerKm;
            TraveledDistance = 0;
        }

        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelPerKm { get; set; }
        public double TraveledDistance { get; set; }

        public void Drive(int distance)
        {
            var neededFuel = distance * this.FuelPerKm;
            if(neededFuel <= this.FuelAmount)
            {
                this.FuelAmount -= neededFuel;
                this.TraveledDistance += distance;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
        public override string ToString()
        {
            return $"{this.Model} {this.FuelAmount:f2} {this.TraveledDistance}";
        }
    }
}
