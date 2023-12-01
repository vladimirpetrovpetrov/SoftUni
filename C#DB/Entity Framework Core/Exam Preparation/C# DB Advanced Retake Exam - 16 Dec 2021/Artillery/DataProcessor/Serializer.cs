
namespace Artillery.DataProcessor
{
    using Artillery.Data;
    using Artillery.DataProcessor.ExportDto;
    using Newtonsoft.Json;
    using System.Text;
    using System.Xml.Serialization;

    public class Serializer
    {
        public static string ExportShells(ArtilleryContext context, double shellWeight)
        {
            var shells = context.Shells
                .Where(s => s.ShellWeight > shellWeight)
                .ToArray()
                .Select(s => new
                {
                    ShellWeight = s.ShellWeight,
                    Caliber = s.Caliber,
                    Guns = s.Guns
                   .Where(x => ((int)x.GunType) == 3)
                    .Select(g => new
                    {
                        GunType = g.GunType.ToString(),
                        GunWeight = g.GunWeight,
                        BarrelLength = g.BarrelLength,
                        Range = g.Range > 3000 ? "Long-range" : "Regular range"
                    })
                    .OrderByDescending(g => g.GunWeight)
                    .ToArray()
                })
                .OrderBy(s => s.ShellWeight)
                .ToArray();

            var serializedInfo = JsonConvert.SerializeObject(shells, Formatting.Indented);
            return serializedInfo;
        }

        public static string ExportGuns(ArtilleryContext context, string manufacturer)
        {
            var guns = context.Guns
                .Where(g => g.Manufacturer.ManufacturerName == manufacturer)
                .Select(g => new ExportGunDto
                {
                    Manufacturer = g.Manufacturer.ManufacturerName,
                    GunType= g.GunType.ToString(),
                    GunWeight= g.GunWeight,
                    BarrelLength= g.BarrelLength,
                    Range = g.Range,
                    Countries = g.CountriesGuns
                        .Where(cg=>cg.Country.ArmySize > 4500000)
                        .Select(cg=> new ExportCountryDto
                        {
                            Country = cg.Country.CountryName,
                            ArmySize = cg.Country.ArmySize
                        })
                        .OrderBy(c=>c.ArmySize)
                        .ToArray()
                })
                .OrderBy(g=>g.BarrelLength)
                .ToArray();

            XmlSerializer serializer = new XmlSerializer(typeof(ExportGunDto[]),new XmlRootAttribute("Guns"));

            var xns = new XmlSerializerNamespaces();
            xns.Add(string.Empty, string.Empty);

            var sb = new StringBuilder();
            using(StringWriter sw = new StringWriter(sb))
            {
                serializer.Serialize(sw, guns, xns);
            }

            return sb.ToString().Trim();

                
        }
    }
}
