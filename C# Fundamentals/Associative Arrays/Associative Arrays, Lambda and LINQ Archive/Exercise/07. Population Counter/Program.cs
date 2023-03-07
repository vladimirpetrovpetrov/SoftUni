using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07._Population_Counter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Country> countries = new List<Country>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "report")
                {
                    break;
                }
                var city = input.Split("|",StringSplitOptions.RemoveEmptyEntries)[0];
                var country = input.Split("|",StringSplitOptions.RemoveEmptyEntries)[1];
                var cityPop = long.Parse(input.Split("|", StringSplitOptions.RemoveEmptyEntries)[2]);

                bool countryExist = countries.Any(x => x.Name == country);
                if (!countryExist)
                {
                    var cityAndPopDict = new Dictionary<string, long>();
                    cityAndPopDict.Add(city, cityPop);
                    Country currentCountry = new Country(country, cityAndPopDict);
                    countries.Add(currentCountry);
                    currentCountry.CalcTotalPop();
                }
                else
                {
                    var currentCountry = countries.Find(x=> x.Name == country);
                    if (!currentCountry.CityAndPop.ContainsKey(city))
                    {
                        currentCountry.CityAndPop.Add(city, cityPop);
                        currentCountry.CalcTotalPop();
                    }
                }
            }
            countries = countries.OrderByDescending(x=>x.TotalPop).ToList();
            foreach (var item in countries)
            {
                Console.WriteLine(item);
            }

        }
    }
    public class Country
    {
        public string Name { get; set; }
        public Dictionary<string, long> CityAndPop { get; set; } = new Dictionary<string, long>();
        public long TotalPop { get; set; }
        public Country(string name, Dictionary<string, long> city)
        {
            this.Name = name;
            this.CityAndPop = city;
        }
        public void CalcTotalPop()
        {
            this.TotalPop = this.CityAndPop.Values.Sum();
        }
        public override string ToString()
        {
           StringBuilder st = new StringBuilder();
           st.AppendLine($"{this.Name} (total population: {this.TotalPop})");
            foreach (var (key,value) in this.CityAndPop.OrderByDescending(x=>x.Value))
            {
                st.AppendLine($"=>{key}: {value}");
            }
            return st.ToString().TrimEnd('\n');

        }

    }
}