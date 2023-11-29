namespace Boardgames.DataProcessor
{
    using Boardgames.Data;
    using Boardgames.DataProcessor.ExportDto;
    using Newtonsoft.Json;
    using System.Text;
    using System.Xml.Serialization;

    public class Serializer
    {
        public static string ExportCreatorsWithTheirBoardgames(BoardgamesContext context)
        {
            var creators = context.Creators
                .Where(c => c.Boardgames.Any())
                .Select(c => new ExportCreatorDto
                {
                    BoardGamesCount = c.Boardgames.Count(),
                    CreatorName = c.FirstName + " " + c.LastName,
                    Boardgames = c.Boardgames.Select(bg => new ExportBoardGame
                        {
                            BoardgameName = bg.Name,
                            BoardgameYearPublished = bg.YearPublished
                        })
                        .OrderBy(bg => bg.BoardgameName)
                        .ToArray()
                })
                .OrderByDescending(c=>c.BoardGamesCount)
                .ThenBy(c=>c.CreatorName)
                .ToArray();


            XmlSerializer serializer = new XmlSerializer(typeof(ExportCreatorDto[]),new XmlRootAttribute("Creators"));

            var xsn = new XmlSerializerNamespaces();
            xsn.Add(string.Empty, string.Empty);

            StringBuilder sb = new();

            using (StringWriter sw = new(sb))
            {
                serializer.Serialize(sw, creators,xsn);
            }




            return sb.ToString().Trim();
        }

        public static string ExportSellersWithMostBoardgames(BoardgamesContext context, int year, double rating)
        {
            var sellers = context.Sellers
                .Where(s => s.BoardgamesSellers.Any(b => b.Boardgame.YearPublished >= year) && s.BoardgamesSellers.Any(b => b.Boardgame.Rating <= rating))
                .Select(s => new
                {
                    s.Name,
                    s.Website,
                    Boardgames = s.BoardgamesSellers
                    .Where(sb => sb.Boardgame.YearPublished >= year && sb.Boardgame.Rating <= rating)
                    .Select(b => new
                    {
                        Name = b.Boardgame.Name,
                        Rating = b.Boardgame.Rating,
                        Mechanics = b.Boardgame.Mechanics,
                        Category = b.Boardgame.CategoryType.ToString()
                    })
                    .OrderByDescending(b => b.Rating)
                    .ThenBy(b=>b.Name)
                    .ToList()
                })
                .OrderByDescending(s=>s.Boardgames.Count)
                .ThenBy(s=>s.Name)
                .Take(5)
                .ToList();

            return JsonConvert.SerializeObject(sellers, Formatting.Indented);
        }
    }
}