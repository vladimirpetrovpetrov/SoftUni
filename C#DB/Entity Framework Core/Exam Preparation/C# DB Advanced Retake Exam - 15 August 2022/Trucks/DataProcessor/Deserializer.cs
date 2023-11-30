namespace Trucks.DataProcessor
{
    using Data;
    using Newtonsoft.Json;
    using System.ComponentModel.DataAnnotations;
    using System.Text;
    using System.Xml.Serialization;
    using Trucks.Data.Models;
    using Trucks.Data.Models.Enums;
    using Trucks.DataProcessor.ImportDto;

    public class Deserializer
    {
        private const string ErrorMessage = "Invalid data!";

        private const string SuccessfullyImportedDespatcher
            = "Successfully imported despatcher - {0} with {1} trucks.";

        private const string SuccessfullyImportedClient
            = "Successfully imported client - {0} with {1} trucks.";

        public static string ImportDespatcher(TrucksContext context, string xmlString)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ImportDespatcherDto[]), new XmlRootAttribute("Despatchers"));

            ImportDespatcherDto[] despatcherDtos = (ImportDespatcherDto[])serializer.Deserialize(new StringReader(xmlString));

            var despatchers = new List<Despatcher>();
            StringBuilder sb = new();

            foreach (var despatcherDto in despatcherDtos)
            {
                if (!IsValid(despatcherDto))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                string position = despatcherDto.Position;
                bool isPositionInvalid = string.IsNullOrEmpty(position);

                if (isPositionInvalid)
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                var dToAdd = new Despatcher
                {
                    Name = despatcherDto.Name,
                    Position = despatcherDto.Position
                };



                foreach (var truckDto in despatcherDto.Trucks)
                {
                    if (!IsValid(truckDto))
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }

                    dToAdd.Trucks.Add(new Truck
                    {
                        RegistrationNumber = truckDto.RegistrationNumber,
                        VinNumber = truckDto.VinNumber,
                        TankCapacity = truckDto.TankCapacity,
                        CargoCapacity = truckDto.CargoCapacity,
                        CategoryType = (CategoryType)truckDto.CategoryType,
                        MakeType = (MakeType)truckDto.MakeType
                    });
                }

                despatchers.Add(dToAdd);
                sb.AppendLine(string.Format(SuccessfullyImportedDespatcher, dToAdd.Name, dToAdd.Trucks.Count));
            }

            context.AddRange(despatchers);
            context.SaveChanges();





            return sb.ToString().Trim();
        }
        public static string ImportClient(TrucksContext context, string jsonString)
        {
            var clientsDtos = JsonConvert.DeserializeObject<ImportClientDto[]>(jsonString);
            StringBuilder sb = new();
            List<Client> clients = new();
            var truckIds = context.Trucks.Select(x => x.Id).ToArray();

            foreach (var clientDto in clientsDtos)
            {
                if (!IsValid(clientDto) || clientDto.Type == "usual")
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                Client c = new Client
                {
                    Name = clientDto.Name,
                    Nationality = clientDto.Nationality,
                    Type = clientDto.Type
                };



                foreach (var truckId in clientDto.Trucks.Distinct())
                {
                    Truck t = context.Trucks.Find(truckId);
                    if (t == null)
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }

                    c.ClientsTrucks.Add(new ClientTruck()
                    {
                        Truck = t
                    });
                }
                clients.Add(c);
                sb.AppendLine(string.Format(SuccessfullyImportedClient,c.Name,c.ClientsTrucks.Count));

            }

            context.AddRange(clients);
            context.SaveChanges();




            return sb.ToString().Trim();
        }

        private static bool IsValid(object dto)
        {
            var validationContext = new ValidationContext(dto);
            var validationResult = new List<ValidationResult>();

            return Validator.TryValidateObject(dto, validationContext, validationResult, true);
        }
    }
}