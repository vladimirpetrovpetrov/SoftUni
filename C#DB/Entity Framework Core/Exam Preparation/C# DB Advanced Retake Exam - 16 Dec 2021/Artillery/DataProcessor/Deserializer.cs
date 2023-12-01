namespace Artillery.DataProcessor
{
    using Artillery.Data;
    using Artillery.Data.Models;
    using Artillery.Data.Models.Enums;
    using Artillery.DataProcessor.ImportDto;
    using Newtonsoft.Json;
    using System.ComponentModel.DataAnnotations;
    using System.Text;
    using System.Xml.Serialization;

    public class Deserializer
    {
        private const string ErrorMessage =
            "Invalid data.";
        private const string SuccessfulImportCountry =
            "Successfully import {0} with {1} army personnel.";
        private const string SuccessfulImportManufacturer =
            "Successfully import manufacturer {0} founded in {1}.";
        private const string SuccessfulImportShell =
            "Successfully import shell caliber #{0} weight {1} kg.";
        private const string SuccessfulImportGun =
            "Successfully import gun {0} with a total weight of {1} kg. and barrel length of {2} m.";

        public static string ImportCountries(ArtilleryContext context, string xmlString)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ImportCountryDto[]), new XmlRootAttribute("Countries"));

            ImportCountryDto[] cDtos = (ImportCountryDto[])serializer.Deserialize(new StringReader(xmlString));

            StringBuilder sb = new StringBuilder();

            List<Country> countries = new();

            foreach (var cDto in cDtos)
            {
                if (!IsValid(cDto))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                var cToAdd = new Country()
                {
                    CountryName = cDto.CountryName,
                    ArmySize = cDto.ArmySize
                };
                countries.Add(cToAdd);
                sb.AppendLine(string.Format(SuccessfulImportCountry, cToAdd.CountryName, cToAdd.ArmySize));
            }
            context.AddRange(countries);
            context.SaveChanges();
            return sb.ToString().Trim();
        }

        public static string ImportManufacturers(ArtilleryContext context, string xmlString)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ImportManufacturerDto[]), new XmlRootAttribute("Manufacturers"));

            ImportManufacturerDto[] mDtos = (ImportManufacturerDto[])serializer.Deserialize(new StringReader(xmlString));

            StringBuilder sb = new StringBuilder();

            List<Manufacturer> manufacturers = new();

            foreach (var mDto in mDtos)
            {
                if (!IsValid(mDto))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                if (manufacturers.Any(m => m.ManufacturerName == mDto.ManufacturerName))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                var mToAdd = new Manufacturer()
                {
                    ManufacturerName = mDto.ManufacturerName,
                    Founded = mDto.Founded
                };

                manufacturers.Add(mToAdd);

                var foundedParts = mToAdd.Founded.Split(", ");
                var cityCountry = new List<string>();
                for (int i = foundedParts.Length-1; i >= foundedParts.Length-2; i--)
                {
                    cityCountry.Add(foundedParts[i]);
                }
                cityCountry.Reverse();
                var cityCountryResult = string.Join(", ", cityCountry);



                sb.AppendLine(string.Format(SuccessfulImportManufacturer, mToAdd.ManufacturerName, cityCountryResult));
            }
            context.AddRange(manufacturers);
            context.SaveChanges();

            return sb.ToString().Trim();
        }

        public static string ImportShells(ArtilleryContext context, string xmlString)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ImportShellDto[]), new XmlRootAttribute("Shells"));

            ImportShellDto[] sDtos = (ImportShellDto[])serializer.Deserialize(new StringReader(xmlString));

            StringBuilder sb = new StringBuilder();

            List<Shell> shells = new();

            foreach (var sDto in sDtos)
            {
                if (!IsValid(sDto))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                var sToAdd = new Shell()
                {
                    ShellWeight= sDto.ShellWeight,
                    Caliber = sDto.Caliber
                };

                shells.Add(sToAdd);
                sb.AppendLine(string.Format(SuccessfulImportShell,sToAdd.Caliber,sToAdd.ShellWeight ));
            }
            context.AddRange(shells);
            context.SaveChanges();
            return sb.ToString().Trim();
        }

        //public static string ImportGuns(ArtilleryContext context, string jsonString)
        //{
        //    var gunTypes = new string[] { "Howitzer", "Mortar", "FieldGun", "AntiAircraftGun", "MountainGun", "AntiTankGun" };
        //    ImportGunDto[] gunsDtos = JsonConvert.DeserializeObject<ImportGunDto[]>(jsonString);

        //    var sb = new StringBuilder();

        //    List<Gun> guns = new();

        //    foreach (var gun in gunsDtos)
        //    {
        //        if (!IsValid(gun) || !gunTypes.Contains(gun.GunType))
        //        {
        //            sb.AppendLine(ErrorMessage);
        //            continue;
        //        }

        //        var gunToAdd = new Gun()
        //        {
        //            ManufacturerId = gun.ManufacturerId,
        //            GunWeight = gun.GunWeight,
        //            BarrelLength= gun.BarrelLength,
        //            NumberBuild = gun.NumberBuild,
        //            Range = gun.Range,
        //            GunType = (GunType)Enum.Parse(typeof(GunType), gun.GunType),
        //            ShellId = gun.ShellId
        //        };

        //        foreach (var countryDto in gun.Countries)
        //        {
        //            gunToAdd.CountriesGuns.Add(new CountryGun
        //            {
        //                CountryId = countryDto.Id,
        //                Gun = gunToAdd
        //            });
        //        }



        //        guns.Add(gunToAdd);
        //        sb.AppendLine(string.Format(SuccessfulImportGun, gun.GunType, gunToAdd.GunWeight, gunToAdd.BarrelLength));
        //    }

        //    context.Guns.AddRange(guns);
        //    context.SaveChanges();



        //    return sb.ToString().Trim();
        //}
        private static bool IsValid(object obj)
        {
            var validator = new ValidationContext(obj);
            var validationRes = new List<ValidationResult>();

            var result = Validator.TryValidateObject(obj, validator, validationRes, true);
            return result;
        }
    }
}