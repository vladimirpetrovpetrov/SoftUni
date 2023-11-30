namespace Footballers.DataProcessor
{
    using Data;
    using Footballers.DataProcessor.ExportDto;
    using Newtonsoft.Json;
    using System.Globalization;
    using System.Text;
    using System.Xml.Serialization;

    public class Serializer
    {
        public static string ExportCoachesWithTheirFootballers(FootballersContext context)
        {
            var coaches = context.Coaches
                .Where(c=>c.Footballers.Any())
                .OrderByDescending(c=>c.Footballers.Count)
                .ThenBy(c=>c.Name)
                .ToArray()
                .Select(c=> new ExportCoachDto
                {
                    FootballersCount = c.Footballers.Count,
                    CoachName= c.Name,
                    Footballers = c.Footballers
                    .OrderBy(f=>f.Name)
                    .ToArray()
                    .Select(f=>new ExportFootballerDto
                    {
                        Name= f.Name,
                        Position = f.PositionType.ToString()
                    })
                    .ToArray()
                })
                .ToArray();

            XmlSerializer serializer = new XmlSerializer(typeof(ExportCoachDto[]),new XmlRootAttribute("Coaches"));

            var xns = new XmlSerializerNamespaces();
            xns.Add(string.Empty, string.Empty);

            StringBuilder st = new StringBuilder();

            using (StringWriter sw = new(st))
            {
                serializer.Serialize(sw, coaches, xns);
            }




            return st.ToString().Trim();
        }

        public static string ExportTeamsWithMostFootballers(FootballersContext context, DateTime date)
        {
            var teams = context.Teams
                .Where(t => t.TeamsFootballers.Any(tf => tf.Footballer.ContractStartDate >= date))
                .ToArray()
                .Select(t => new
                {
                    Name = t.Name,
                    Footballers = t.TeamsFootballers
                        .Where(tf => tf.Footballer.ContractStartDate >= date)
                        .ToArray()
                        .OrderByDescending(tf => tf.Footballer.ContractEndDate)
                        .ThenBy(tf => tf.Footballer.Name)
                        .Select(tf => new
                        {
                            FootballerName = tf.Footballer.Name,
                            ContractStartDate = tf.Footballer.ContractStartDate.ToString("d", CultureInfo.InvariantCulture),
                            ContractEndDate = tf.Footballer.ContractEndDate.ToString("d", CultureInfo.InvariantCulture),
                            BestSkillType = tf.Footballer.BestSkillType.ToString(),//TODO
                            PositionType = tf.Footballer.PositionType.ToString()//TODO
                        })
                        .ToArray()
                })
                .OrderByDescending(t => t.Footballers.Count())
                .ThenBy(t => t.Name)
                .Take(5)
                .ToArray();

            return JsonConvert.SerializeObject(teams, Formatting.Indented);
        }
    }
}
