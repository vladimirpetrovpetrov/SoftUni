namespace _06.Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> list = new List<Vehicle>();
            while (true)
            {
                var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "End")
                {
                    break;
                }
                list.Add(new Vehicle(input[0], input[1], input[2], int.Parse(input[3])));
            }
            var avrgCarHp = 0.0;
            var avrgTruckHp = 0.0;
            if (list.Where(x => x.Type == "car").ToList().Count > 0)
            {
                avrgCarHp = list.Where(x => x.Type == "car").ToList().Average(x => x.HorsePower);
            }
            if (list.Where(x => x.Type == "truck").ToList().Count > 0)
            {
                avrgTruckHp = list.Where(x => x.Type == "truck").ToList().Average(x => x.HorsePower);
            }
            while (true)
            {
                var input = Console.ReadLine();
                if(input=="Close the Catalogue")
                {
                    break;
                }
                foreach (var item in list)
                {
                    if(input == item.Model)
                    {
                        Console.WriteLine($"Type: {item.TypeForPrint}");
                        Console.WriteLine($"Model: {item.Model}");
                        Console.WriteLine($"Color: {item.Color}");
                        Console.WriteLine($"Horsepower: {item.HorsePower}");
                    }
                }
            }
            Console.WriteLine($"Cars have average horsepower of: {avrgCarHp:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {avrgTruckHp:f2}.");



        }
    }
    public class Vehicle
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }
        public string TypeForPrint { get; set; }
        public Vehicle(string type,string model,string color,int horsePower)
        {
            this.Type = type;
            this.Model = model;
            this.Color = color;
            this.HorsePower = horsePower;
            if(type == "car")
            {
                this.TypeForPrint = "Car";
            }
            else
            {
                this.TypeForPrint = "Truck";
            }
        }
    }
}