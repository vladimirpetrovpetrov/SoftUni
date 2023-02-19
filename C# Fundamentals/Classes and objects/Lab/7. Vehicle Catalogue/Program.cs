using System.Security.Cryptography.X509Certificates;

public class Program
{
    static void Main()
    {
        var cars = new List<Car>();
        var trucks = new List<Truck>();
        Catalog catalog = new Catalog(cars, trucks);
        while (true)
        {
            string input = Console.ReadLine()!;
            if (input == "end") { break; }
            var newInput = input.Split("/", StringSplitOptions.RemoveEmptyEntries).ToList();
            if (newInput[0] == "Car")
            {
                cars.Add(new Car(newInput[1], newInput[2], int.Parse(newInput[3])));
            }
            else if (newInput[0] == "Truck")
            {
                trucks.Add(new Truck(newInput[1], newInput[2], int.Parse(newInput[3])));
            }
        }
        catalog.Cars = catalog.Cars.OrderBy(x=>x.Brand).ToList();
        catalog.Trucks = catalog.Trucks.OrderBy(x=>x.Brand).ToList();

        if (catalog.Cars.Count > 0)
        {
            Console.WriteLine("Cars:");
            for (int i = 0; i < catalog.Cars.Count; i++)
            {
                Console.WriteLine($"{catalog.Cars[i].Brand}: {catalog.Cars[i].Model} - {catalog.Cars[i].Hp}hp");
            }
        }
        if (catalog.Trucks.Count > 0)
        {
            Console.WriteLine("Trucks:");
            for (int i = 0; i < catalog.Trucks.Count; i++)
            {
                Console.WriteLine($"{catalog.Trucks[i].Brand}: {catalog.Trucks[i].Model} - {catalog.Trucks[i].Weight}kg");
            }
        }
    }
}
public class Car
{
    public string Brand { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
    public int Hp { get; set; } = 0;
    public Car(string Brand, string Model, int Hp)
    {
        this.Brand = Brand;
        this.Model = Model;
        this.Hp = Hp;
    }
}
public class Truck
{
    public string Brand { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
    public double Weight { get; set; }
    public Truck(string Brand, string Model, double Weight)
    {
        this.Brand = Brand;
        this.Model = Model;
        this.Weight = Weight;
    }


}
public class Catalog
{
    public List<Car> Cars { get; set; }
    public List<Truck> Trucks { get; set; }
    public Catalog(List<Car> cars, List<Truck> trucks)
    {
        this.Cars = cars;
        this.Trucks = trucks;
    }

}