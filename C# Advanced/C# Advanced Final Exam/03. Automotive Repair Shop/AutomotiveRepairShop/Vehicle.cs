using static System.Net.Mime.MediaTypeNames;

namespace AutomotiveRepairShop
{
    public class Vehicle
    {
        public Vehicle(string vIN, int mileage, string damage)
        {
            this.VIN = vIN;
            this.Mileage = mileage;
            this.Damage = damage;
        }

        public string VIN { get; set; }
        public int Mileage { get; set; }
        public string Damage { get; set; }


        public override string ToString()
        {
            return $"Damage: {Damage}, Vehicle: {VIN} ({Mileage} km)";
        }
    }
}
