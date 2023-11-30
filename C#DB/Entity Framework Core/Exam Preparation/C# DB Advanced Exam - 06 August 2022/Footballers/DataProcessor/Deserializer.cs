namespace Footballers.DataProcessor
{
    using Castle.Core.Internal;
    using Footballers.Data;
    using Footballers.Data.Models;
    using Footballers.Data.Models.Enums;
    using Footballers.DataProcessor.ImportDto;
    using Newtonsoft.Json;
    using System.ComponentModel.DataAnnotations;
    using System.Globalization;
    using System.Text;
    using System.Xml.Serialization;

    public class Deserializer
    {
        private const string ErrorMessage = "Invalid data!";

        private const string SuccessfullyImportedCoach
            = "Successfully imported coach - {0} with {1} footballers.";

        private const string SuccessfullyImportedTeam
            = "Successfully imported team - {0} with {1} footballers.";

        public static string ImportCoaches(FootballersContext context, string xmlString)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ImportCoachDto[]),new XmlRootAttribute("Coaches"));

            ImportCoachDto[] coachesDtos = (ImportCoachDto[])serializer.Deserialize(new StringReader(xmlString));

            StringBuilder sb = new StringBuilder();

            List<Coach> coaches = new List<Coach>();

            foreach (var coachDto in coachesDtos)
            {
                if (!IsValid(coachDto))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                if (coachDto.Nationality.IsNullOrEmpty())
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                var coachToAdd = new Coach
                {
                    Name = coachDto.Name,
                    Nationality = coachDto.Nationality
                };

                //now validating the footballers

                foreach (var footballerDto in coachDto.Footballers)
                {

                    if (!IsValid(footballerDto))
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }
                    DateTime parsedStartDate = default(DateTime);
                    DateTime parsedEndDate = default(DateTime);

                    if (DateTime.TryParseExact(footballerDto.ContractStartDate, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime startDate))
                    {
                        parsedStartDate = startDate;
                    }
                    else
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }

                    if (DateTime.TryParseExact(footballerDto.ContractEndDate, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime endDate))
                    {
                        parsedEndDate = endDate;
                    }
                    else
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }

                    if(parsedEndDate < parsedStartDate)
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }


                    coachToAdd.Footballers.Add(new Footballer
                    {
                        Name = footballerDto.Name,
                        ContractStartDate = parsedStartDate,
                        ContractEndDate = parsedEndDate,
                        BestSkillType = (BestSkillType)footballerDto.BestSkillType,
                        PositionType = (PositionType)footballerDto.PositionType
                    });
                }

                coaches.Add(coachToAdd);
                sb.AppendLine(string.Format(SuccessfullyImportedCoach, coachToAdd.Name, coachToAdd.Footballers.Count));
            }

            context.AddRange(coaches);
            context.SaveChanges();

            return sb.ToString().Trim();
        }

        public static string ImportTeams(FootballersContext context, string jsonString)
        {
            ImportTeamDto[] teamsDtos = JsonConvert.DeserializeObject<ImportTeamDto[]>(jsonString);

            var sb = new StringBuilder();

            List<Team> teams = new();

            foreach (var teamDto in teamsDtos)
            {
                //TODO: Check if it validates the nationality (if empty)!!!
                if(!IsValid(teamDto) || teamDto.Trophies == 0)
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                var teamToAdd = new Team
                {
                    Name = teamDto.Name,
                    Nationality = teamDto.Nationality,
                    Trophies = teamDto.Trophies
                };

                //now check the footballers
                foreach (var fIdDto in teamDto.Footballers.Distinct())
                {

                    Footballer f = context.Footballers.Find(fIdDto);
                    if(f == null)
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }

                    teamToAdd.TeamsFootballers.Add(new TeamFootballer
                    {
                        Footballer = f
                    });

                }
                teams.Add(teamToAdd);
                sb.AppendLine(string.Format(SuccessfullyImportedTeam, teamToAdd.Name, teamToAdd.TeamsFootballers.Count));
            }
            context.AddRange(teams);
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
