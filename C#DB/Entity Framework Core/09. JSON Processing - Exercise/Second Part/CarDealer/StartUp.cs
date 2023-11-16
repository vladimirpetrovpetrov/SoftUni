using AutoMapper;
using CarDealer.Data;
using CarDealer.Models;
using CarDealer.Models.DTO;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Globalization;

namespace CarDealer
{
    public class StartUp
    {
        public static void Main()
        {
            CarDealerContext context = new CarDealerContext();
            //var suppliersJson = File.ReadAllText("../../../Datasets/suppliers.json");
            //Console.WriteLine(ImportSuppliers(context,suppliersJson));
            //var partsJson = File.ReadAllText("../../../Datasets/parts.json");
            //Console.WriteLine(ImportParts(context, partsJson));
            //var carsJson = File.ReadAllText("../../../Datasets/cars.json");
            //Console.WriteLine(ImportCars(context, carsJson));
            //var customersJson = File.ReadAllText("../../../Datasets/customers.json");
            //Console.WriteLine(ImportCustomers(context, customersJson));
            //var salesJson = File.ReadAllText("../../../Datasets/sales.json");
            //Console.WriteLine(ImportSales(context, salesJson));
            //Console.WriteLine(GetOrderedCustomers(context));
            //Console.WriteLine(GetCarsFromMakeToyota(context));
            //Console.WriteLine(GetLocalSuppliers(context));
            //Console.WriteLine(GetCarsWithTheirListOfParts(context));
            //Console.WriteLine(GetTotalSalesByCustomer(context));
            Console.WriteLine(GetSalesWithAppliedDiscount(context));
        }
        public static string GetSalesWithAppliedDiscount(CarDealerContext context)
        {
            var sales = context.Sales
            .Take(10)
            .Select(s => new
            {
                car = new
                {
                    Make = s.Car.Make,
                    Model = s.Car.Model,
                    TraveledDistance = s.Car.TraveledDistance
                },
                customerName = s.Customer.Name,
                discount = s.Discount.ToString("f2"),
                price = s.Car.PartsCars.Sum(pc => pc.Part.Price).ToString("f2"),
                priceWithDiscount = ((s.Car.PartsCars.Sum(pc => pc.Part.Price) * (1 - s.Discount / 100))).ToString("f2")
            })
            .ToArray();
            //sale --> Car --> carparts --> part : price
            var serialized = JsonConvert.SerializeObject(sales, Formatting.Indented);
            return serialized;
        }
        public static string GetTotalSalesByCustomer(CarDealerContext context)
        {
            var customersWithSales = context.Customers
    .       Include(c => c.Sales)
                .ThenInclude(s=>s.Car)
                .ThenInclude(c=>c.PartsCars)
                .ThenInclude(pc=>pc.Part)
            .Where(c => c.Sales.Count > 0)
            .Select(c => new
            {
                fullName = c.Name,
                boughtCars = c.Sales.Count(),
                spentMoney = c.Sales
                    .SelectMany(s => s.Car.PartsCars)
                    .Sum(pc => pc.Part.Price)
            })
            .OrderByDescending(x => x.spentMoney)
                .ThenByDescending(x => x.boughtCars)
            .ToList();
            var serialized = JsonConvert.SerializeObject(customersWithSales,Formatting.Indented);

            return serialized;
        }
        public static string GetCarsWithTheirListOfParts(CarDealerContext context)
        {
            var cars = context.Cars
                .Select(c => new
                {
                    car = new
                    {
                        c.Make,
                        c.Model,
                        c.TraveledDistance,
                    },

                    parts = c.PartsCars.Select(p=>new
                    {
                        p.Part.Name,
                        Price = p.Part.Price.ToString("f2")
                    })
                })
                .ToList();

            string serialized = JsonConvert.SerializeObject(cars,Formatting.Indented);
            return serialized;
        }
        public static string GetLocalSuppliers(CarDealerContext context)
        {
            var supps = context.Suppliers
                .Where(c => c.IsImporter == false)
                .Select(c => new
                {
                    c.Id,
                    c.Name,
                    PartsCount = c.Parts.Count
                })
                .ToList();

            var serialized = JsonConvert.SerializeObject(supps,Formatting.Indented);
            return serialized;
        }
        public static string GetCarsFromMakeToyota(CarDealerContext context)
        {
            var cars = context.Cars
                .Where(c => c.Make == "Toyota")
                .OrderBy(c => c.Model)
                .ThenByDescending(c => c.TraveledDistance)
                .Select(c => new
                {
                    c.Id,
                    c.Make,
                    c.Model,
                    c.TraveledDistance,
                })
                .ToList();

            var serialized = JsonConvert.SerializeObject(cars,Formatting.Indented);
            return serialized;
        }
        public static string GetOrderedCustomers(CarDealerContext context)
        {
            var customers = context.Customers
                .OrderBy(c => c.BirthDate)
                .ThenBy(c => c.IsYoungDriver)
                .Select(c=>new
                {
                    c.Name,
                    BirthDate = c.BirthDate.ToString("dd/MM/yyyy",CultureInfo.InvariantCulture),
                    c.IsYoungDriver
                })
                .ToList();
            
            var toSerialize = JsonConvert.SerializeObject(customers,Formatting.Indented);



            return toSerialize;
        }
        public static string ImportSales(CarDealerContext context, string inputJson)
        {
            var sales = JsonConvert.DeserializeObject<Sale[]>(inputJson);

            context.Sales.AddRange(sales);
            context.SaveChanges();
            return $"Successfully imported {sales.Length}.";
        }
        public static string ImportCustomers(CarDealerContext context, string inputJson)
        {
            var customers = JsonConvert.DeserializeObject<Customer[]>(inputJson);

            context.Customers.AddRange(customers);
            context.SaveChanges();




            return $"Successfully imported {customers.Length}.";
        }
        public static string ImportCars(CarDealerContext context, string inputJson)
        {
            IMapper mapper = CreateMapper();

            ImportCarDto[] importCarDtos = JsonConvert.DeserializeObject<ImportCarDto[]>(inputJson);

            ICollection<Car> carsToAdd = new HashSet<Car>();

            foreach (var carDto in importCarDtos)
            {
                Car currentCar = mapper.Map<Car>(carDto);

                foreach (var id in carDto.PartsIds)
                {
                    if (context.Parts.Any(p => p.Id == id))
                    {
                        currentCar.PartsCars.Add(new PartCar
                        {
                            PartId = id,
                        });
                    }
                }

                carsToAdd.Add(currentCar);
            }

            context.Cars.AddRange(carsToAdd);
            context.SaveChanges();

            return $"Successfully imported {carsToAdd.Count}.";
        }
        public static string ImportParts(CarDealerContext context, string inputJson)
        {
            var parts = JsonConvert.DeserializeObject <Part[]>(inputJson);
            var suppliersIds = context.Suppliers.Select(x => x.Id).ToList();
            
            var partsToAdd = parts.Where(p => suppliersIds.Any(s => s == p.SupplierId)).ToArray();
            
            
            if(partsToAdd != null)
            {
                context.Parts.AddRange(partsToAdd);
                context.SaveChanges();
                return $"Successfully imported {partsToAdd.Length}.";
            }
            return $"Successfully imported 0.";

        }
        public static string ImportSuppliers(CarDealerContext context, string inputJson)
        {
            var supps = JsonConvert.DeserializeObject<Supplier[]>(inputJson);

            if(supps!= null)
            {
                context.Suppliers.AddRange(supps);
                context.SaveChanges();
                return $"Successfully imported {supps.Length}.";
            }
                return $"Successfully imported 0";
        }
        public static IMapper CreateMapper()
        {
            MapperConfiguration configuration = new MapperConfiguration(config =>
            {
                config.AddProfile<CarDealerProfile>();
            });

            IMapper mapper = configuration.CreateMapper();

            return mapper;
        }
    }
}