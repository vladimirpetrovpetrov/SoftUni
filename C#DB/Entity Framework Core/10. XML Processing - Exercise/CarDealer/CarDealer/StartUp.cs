using AutoMapper;
using CarDealer.Data;
using CarDealer.DTOs.Export;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Xml.Serialization;

namespace CarDealer
{
    public class StartUp
    {
        public static void Main()
        {
            CarDealerContext context = new CarDealerContext();
            //9.
            //string inputSuppliersXml = File.ReadAllText("../../../Datasets/suppliers.xml");
            //Console.WriteLine(ImportSuppliers(context,inputSuppliersXml));
            //10
            //string partsXml = File.ReadAllText("../../../Datasets/parts.xml");
            //Console.WriteLine(ImportParts(context,partsXml));
            //11
            //string carsXml = File.ReadAllText("../../../Datasets/cars.xml");
            //Console.WriteLine(ImportCars(context,carsXml));
            //12
            //string customersXml = File.ReadAllText("../../../Datasets/customers.xml");
            //Console.WriteLine(ImportCustomers(context, customersXml));
            //13
            //string salesXml = File.ReadAllText("../../../Datasets/sales.xml");
            //Console.WriteLine(ImportSales(context, salesXml));
            //14
            //Console.WriteLine(GetCarsWithDistance(context));
            //15
            //Console.WriteLine(GetCarsFromMakeBmw(context));
            //16
            //Console.WriteLine(GetLocalSuppliers(context));
            //17
            //Console.WriteLine(GetCarsWithTheirListOfParts(context));
            //18
            //Console.WriteLine(GetTotalSalesByCustomer(context));
            //19
            //Console.WriteLine(GetSalesWithAppliedDiscount(context));
            Console.WriteLine(GetSalesWithAppliedDiscount(context));
        }
        private static Mapper GetMapper()
        {
            var cfg = new MapperConfiguration(c => c.AddProfile<CarDealerProfile>());
            return new Mapper(cfg);
        }
        //19
        public static string GetSalesWithAppliedDiscount(CarDealerContext context)
        {
            var sales = context.Sales
                .Include(s => s.Car)
                .ThenInclude(c => c.PartsCars)
                .ThenInclude(pc => pc.Part)
                .Include(s => s.Customer)
                .Select(a => new SalesWithDiscountDTO
                {
                    Car = new CarDtoExport
                    {
                        Make = a.Car.Make,
                        Model = a.Car.Model,
                        TraveledDistance = a.Car.TraveledDistance

                    },
                    Discount = a.Discount,
                    CustomerName = a.Customer.Name,
                    Price = a.Car.PartsCars.Sum(pc => pc.Part.Price),
                    PriceWithDiscount =
                        Math.Round((double)(a.Car.PartsCars
                            .Sum(p => p.Part.Price) * (1 - (a.Discount / 100))), 4)
                })
                .ToArray();

            XmlSerializer serializer = new XmlSerializer(typeof(SalesWithDiscountDTO[]), new XmlRootAttribute("sales"));

            var xns = new XmlSerializerNamespaces();
            xns.Add(string.Empty, string.Empty);

            var st = new StringBuilder();

            using (StringWriter sw = new StringWriter(st))
            {
                serializer.Serialize(sw, sales, xns);
            }

            return st.ToString().Trim();
        }


        //18
        //public static string GetTotalSalesByCustomer(CarDealerContext context)
        //{
        //    var salesByCustomer = context.Customers
        //        .Where(c => c.Sales.Count > 0)
        //        .Select(c => new SalesPerCustomerDTO
        //        {
        //            FullName = c.Name,
        //            BoughtCars = c.Sales.Count,
        //            SpentMoney = c.Sales.Sum(s =>
        //                s.Car.PartsCars.Sum(pc =>
        //                    Math.Round(c.IsYoungDriver ? pc.Part.Price * 0.95m : pc.Part.Price, 2)
        //                )
        //            )
        //        })
        //        .OrderByDescending(c=>c.SpentMoney)
        //        .ToArray();

        //    XmlSerializer serializer = new XmlSerializer(typeof(SalesPerCustomerDTO[]), new XmlRootAttribute("customers"));

        //    var xns = new XmlSerializerNamespaces();
        //    xns.Add(string.Empty, string.Empty);

        //    StringBuilder st = new();
        //    using (StringWriter sw = new StringWriter(st))
        //    {
        //        serializer.Serialize(sw, salesByCustomer, xns);
        //    }


        //    return st.ToString().Trim();
        //}

        //17
        //public static string GetCarsWithTheirListOfParts(CarDealerContext context)
        //{
        //    var cars = context.Cars
        //        .Include(c => c.PartsCars)
        //        .ThenInclude(pc => pc.Part)
        //        .OrderByDescending(c => c.TraveledDistance)
        //        .ThenBy(c => c.Model)
        //        .Take(5)
        //        .ToArray();


        //    List<CarsWithPartsDTO> resultCars = new List<CarsWithPartsDTO>();
        //    var mapper = GetMapper();
        //    foreach (var car in cars)
        //    {
        //        var resultCar = mapper.Map<CarsWithPartsDTO>(car);

        //        List<PartCarDTO> resultPartCars = new List<PartCarDTO>();

        //        foreach (var part in car.PartsCars.OrderByDescending(p=>p.Part.Price))
        //        {
        //            var resultPartCar = mapper.Map<PartCarDTO>(part);
        //            resultPartCars.Add(resultPartCar);
        //        }

        //        resultCar.PartsCars = resultPartCars.ToArray();
        //        resultCars.Add(resultCar);
        //    }

        //    XmlSerializer serializer = new XmlSerializer(typeof(List<CarsWithPartsDTO>), new XmlRootAttribute("cars"));

        //    var xns = new XmlSerializerNamespaces();
        //    xns.Add(string.Empty, string.Empty);

        //    var st = new StringBuilder();

        //    using (StringWriter sw = new StringWriter(st))
        //    {
        //        serializer.Serialize(sw, resultCars,xns);
        //    }
        //        return st.ToString().Trim();


        //}
        //16
        //public static string GetLocalSuppliers(CarDealerContext context)
        //{
        //    var suppliers = context.Suppliers
        //        .Include(s=>s.Parts)
        //        .Where(s => !s.IsImporter)
        //        .Select(s=>new LocalSuppliersDTO
        //        {
        //            Name = s.Name,
        //            Id= s.Id,
        //            PartsCount = s.Parts.Count,
        //        })
        //        .ToArray();

        //    XmlSerializer serializer = new XmlSerializer(typeof(LocalSuppliersDTO[]), new XmlRootAttribute("suppliers"));

        //    var xns = new XmlSerializerNamespaces();
        //    xns.Add(string.Empty, string.Empty);

        //    StringBuilder st = new StringBuilder();
        //    using (StringWriter sw = new StringWriter(st))
        //    {
        //        serializer.Serialize(sw, suppliers, xns);
        //    }
        //    return st.ToString().Trim();
        //}
        ////15
        //public static string GetCarsFromMakeBmw(CarDealerContext context)
        //{
        //    var cars = context.Cars
        //        .Where(c => c.Make == "BMW")
        //        .OrderBy(c => c.Model)
        //        .ThenByDescending(c => c.TraveledDistance)
        //        .ToArray();

        //    var mapper = GetMapper();
        //    CarBmw[] carDtos = mapper.Map<CarBmw[]>(cars);

        //    StringBuilder st = new StringBuilder();
        //    XmlSerializer serializer = new XmlSerializer(typeof(CarBmw[]),new XmlRootAttribute("cars"));
        //    var xns = new XmlSerializerNamespaces();
        //    xns.Add(string.Empty, string.Empty);

        //    using (StringWriter sw = new StringWriter(st))
        //    {
        //        serializer.Serialize(sw, carDtos,xns);
        //    }
        //    return st.ToString().Trim();

        //}
        ////14
        //public static string GetCarsWithDistance(CarDealerContext context)
        //{
        //    var cars = context.Cars
        //        .Where(c => c.TraveledDistance > 2000000)
        //        .OrderBy(c => c.Make)
        //        .ThenBy(c => c.Model)
        //        .Take(10)
        //        .ToArray();

        //    var mapper = GetMapper();

        //    CarsWithDistance[] resultCars = mapper.Map<CarsWithDistance[]>(cars);

        //    XmlSerializer xmlSerializer = new XmlSerializer(typeof(CarsWithDistance[]), new XmlRootAttribute("cars"));

        //    var xsn = new XmlSerializerNamespaces();//To clean default values for namaspace
        //    xsn.Add(string.Empty, string.Empty);//we initialize it like a empty object(the namespace)

        //    StringBuilder st = new StringBuilder();

        //    using (StringWriter sw = new StringWriter(st))
        //    {
        //        xmlSerializer.Serialize(sw, resultCars, xsn);
        //    }
        //        return st.ToString().Trim();
        //}
        ////13
        //public static string ImportSales(CarDealerContext context, string inputXml)
        //{
        //    XmlSerializer serializer = new XmlSerializer(typeof(SaleDto[]), new XmlRootAttribute("Sales"));

        //    SaleDto[] saleDtos = (SaleDto[])serializer.Deserialize(new StringReader(inputXml));

        //    var carIds = context.Cars
        //        .Select(c => c.Id)
        //        .ToList();

        //    var mapper = GetMapper();
        //    List<Sale> sales = new List<Sale>();
        //    foreach (var saleDto in saleDtos)
        //    {
        //        if (carIds.Contains(saleDto.CarId))
        //        {
        //            Sale sale = mapper.Map<Sale>(saleDto);
        //            sales.Add(sale);
        //        }
        //    }
        //    context.Sales.AddRange(sales);
        //    context.SaveChanges();
        //    return $"Successfully imported {sales.Count()}";
        //}
        ////12
        //public static string ImportCustomers(CarDealerContext context, string inputXml)
        //{
        //    XmlSerializer serializer = new XmlSerializer(typeof(CustomerDTO[]), new XmlRootAttribute("Customers"));

        //    var customerDtos = (CustomerDTO[])serializer.Deserialize(new StringReader(inputXml));

        //    var mapper = GetMapper();
        //    Customer[] customers = mapper.Map<Customer[]>(customerDtos);

        //    context.Customers.AddRange(customers);
        //    context.SaveChanges();

        //    return $"Successfully imported {customers.Length}";
        //}
        ////11
        //public static string ImportCars(CarDealerContext context, string inputXml)
        //{
        //    XmlSerializer serializer = new XmlSerializer(typeof(CarDTO[]), new XmlRootAttribute("Cars"));

        //    CarDTO[] carDtos = (CarDTO[])serializer.Deserialize(new StringReader(inputXml));

        //    var mapper = GetMapper();

        //    //create list of cars where we will save the cars 
        //    List<Car> cars = new List<Car>();
        //    //no loop through all of the carDtos
        //    foreach (var carDto in carDtos)
        //    {
        //        var car = mapper.Map<Car>(carDto);

        //        var carPartIds = carDto
        //            .PartsIds
        //            .Select(x => x.Id)
        //            .Distinct() //Select unique car part ids
        //            .ToList();


        //        //Create a List<CarPart>
        //        var carParts = new List<PartCar>();

        //        foreach (var id in carPartIds)
        //        {
        //            carParts.Add(new PartCar
        //            {
        //                Car = car,
        //                PartId = id
        //            });
        //        }
        //        car.PartsCars = carParts;
        //        cars.Add(car);
        //    }
        //    context.Cars.AddRange(cars);
        //    context.SaveChanges();
        //    return $"Successfully imported {cars.Count()}";
        //}
        ////10
        //public static string ImportParts(CarDealerContext context, string inputXml)
        //{
        //    //First - serializer
        //    XmlSerializer serializer = new XmlSerializer(typeof(PartDTO[]), new XmlRootAttribute("Parts"));

        //    //Second - Desirialize
        //    PartDTO[] partsDto = (PartDTO[])serializer.Deserialize(new StringReader(inputXml));

        //    //getting suppliers ids for validation
        //    var supplierIds = context.Suppliers
        //        .Select(x => x.Id)
        //        .ToList();

        //    //Third - mapping

        //    var mapper = GetMapper();
        //    Part[] parts = mapper.Map<Part[]>(partsDto.Where(p => supplierIds.Contains(p.SupplierId)));
        //    //Fourth - adding to DB 

        //    context.AddRange(parts);
        //    context.SaveChanges();

        //    return $"Successfully imported {parts.Length}";


        //}
        ////9
        //public static string ImportSuppliers(CarDealerContext context, string inputXml)
        //{
        //    // First new XmlSerializer
        //    XmlSerializer serializer = new XmlSerializer(typeof(SupplierDTO[]), new XmlRootAttribute("Suppliers"));

        //    // Second Deserializer
        //    SupplierDTO[] supplierDtos = (SupplierDTO[])serializer.Deserialize(new StringReader(inputXml));

        //    //Add Mapper config then
        //    //Third Mapping DTO to Model
        //    var mapper = GetMapper();
        //    Supplier[] suppliers = mapper.Map<Supplier[]>(supplierDtos);

        //    //Fourth Adding to context
        //    context.AddRange(suppliers);
        //    context.SaveChanges();

        //    return $"Successfully imported {suppliers.Length}";
        //}
    }
}