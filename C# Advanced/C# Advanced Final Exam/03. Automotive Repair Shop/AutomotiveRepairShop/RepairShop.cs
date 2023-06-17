using System.Runtime.CompilerServices;
using System.Text;

namespace AutomotiveRepairShop
{
    public class RepairShop
    {
        public RepairShop(int capacity)
        {
            Capacity = capacity;
            Vehicles = new List<Vehicle>();
        }

        public int Capacity { get; set; }
        public List<Vehicle> Vehicles { get; set; }

        public void AddVehicle(Vehicle vehicle)
        {
            if(this.Vehicles.Count < this.Capacity)
            {
                this.Vehicles.Add(vehicle);
            }
        }

        public bool RemoveVehicle(string vin)
        {
            foreach(Vehicle vehicle in this.Vehicles)
            {
                if(vehicle.VIN == vin)
                {
                    this.Vehicles.Remove(vehicle);
                    return true;
                }
            }
            return false;
        }

        public int GetCount()
        {
            return this.Vehicles.Count;
        }

        public Vehicle GetLowestMileage()
        {
            var minMileage = this.Vehicles.Min(x => x.Mileage);
            var result = this.Vehicles.Find(x => x.Mileage == minMileage);
            return result;
        }

        public string Report()
        {
            StringBuilder st = new StringBuilder();
            st.AppendLine("Vehicles in the preparatory:");
            st.AppendLine(String.Join(Environment.NewLine, Vehicles));
            return st.ToString().TrimEnd();
        }



    }
}
