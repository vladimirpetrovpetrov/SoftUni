namespace _04.Raw_Data
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var model = input[0];
                var engineSpeed = int.Parse(input[1]);
                var enginePower = int.Parse(input[2]);
                var cargoWeight = int.Parse(input[3]);
                var cargoType = input[4];
                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoWeight, cargoType);
                Car car = new Car(model, engine, cargo);
                cars.Add(car);
            }
            var typeAsked = Console.ReadLine();
            if (typeAsked == "fragile")
            {
                cars.Where(x => x.cargo.CargoType == typeAsked && x.cargo.CargoWeight < 1000).ToList().ForEach(x => Console.WriteLine(x));
            }
            else
            {
                cars.Where(x => x.cargo.CargoType == typeAsked && x.engine.EnginePower > 250).ToList().ForEach(x => Console.WriteLine(x));
            }
        }
    }
    public class Car
    {
        public Car(string model, Engine engine, Cargo cargo)
        {
            this.Model = model;
            this.engine = engine;
            this.cargo = cargo;
        }

        public string Model { get; set; }
        public Engine engine { get; set; }
        public Cargo cargo { get; set; }
        public override string ToString()
        {
            return this.Model;
        }
    }
    public class Cargo
    {
        public Cargo(int cargoWeight, string cargoType)
        {
            this.CargoWeight = cargoWeight;
            this.CargoType = cargoType;
        }

        public int CargoWeight { get; set; }
        public string CargoType { get; set; }

    }
    public class Engine
    {
        public Engine(int engineSpeed, int enginePower)
        {
            this.EngineSpeed = engineSpeed;
            this.EnginePower = enginePower;
        }

        public int EngineSpeed { get; set; }
        public int EnginePower { get; set; }
    }
}
