namespace Boardgames.DataProcessor;

using Boardgames.Data;
using Boardgames.Data.Models;
using Boardgames.Data.Models.Enums;
using Boardgames.DataProcessor.ImportDto;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

public class Deserializer
{
    private const string ErrorMessage = "Invalid data!";

    private const string SuccessfullyImportedCreator
        = "Successfully imported creator – {0} {1} with {2} boardgames.";

    private const string SuccessfullyImportedSeller
        = "Successfully imported seller - {0} with {1} boardgames.";

    public static string ImportCreators(BoardgamesContext context, string xmlString)
    {
        XmlSerializer serializer= new XmlSerializer(typeof(ImportCreatorDto[]),new XmlRootAttribute("Creators"));

        ImportCreatorDto[] creatorsDtos = (ImportCreatorDto[])serializer.Deserialize(new StringReader(xmlString));

        
        List<Creator> creators = new List<Creator>();
        StringBuilder sb = new StringBuilder();

        foreach (var creatorDto in creatorsDtos)
        {
            if (!IsValid(creatorDto))
            {
                sb.AppendLine(ErrorMessage);
                continue;
            }

            var creatorToAdd = new Creator
            {
                FirstName = creatorDto.FirstName,
                LastName = creatorDto.LastName,
                Boardgames = new List<Boardgame>()
            };

            foreach (var bg in creatorDto.Boardgames)
            {
                if (!IsValid(bg))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                creatorToAdd.Boardgames.Add(new Boardgame
                {
                    Name = bg.Name,
                    Rating = bg.Rating,
                    YearPublished = bg.YearPublished,
                    CategoryType = (CategoryType)bg.CategoryType,
                    Mechanics = bg.Mechanics
                });

            }
            creators.Add(creatorToAdd);
            sb.AppendLine(string.Format(SuccessfullyImportedCreator,creatorToAdd.FirstName,creatorToAdd.LastName,creatorToAdd.Boardgames.Count));
        }

        context.Creators.AddRange(creators);
        context.SaveChanges();

        return sb.ToString().Trim();
    }

    public static string ImportSellers(BoardgamesContext context, string jsonString)
    {

        StringBuilder sb = new StringBuilder();
        var sellerDtos = JsonConvert.DeserializeObject<ImportSellerDto[]>(jsonString);
        List<Seller> sellers = new List<Seller>();

        var boardGamesIds = context.Boardgames
            .Select(bg => bg.Id)
            .ToArray();
        
        foreach (var sellerDto in sellerDtos)
        {
            if(!IsValid(sellerDto))
            {
                sb.AppendLine(ErrorMessage);
                continue;
            }

            var sellerToAdd = new Seller
            {
                Name = sellerDto.Name,
                Address= sellerDto.Address,
                Country= sellerDto.Country,
                Website= sellerDto.Website

            };

            foreach (var boardGamesId in sellerDto.Boardgames.Distinct())
            {
                if (!boardGamesIds.Contains(boardGamesId))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                    
                }

                BoardgameSeller bgs = new()
                {
                    Seller = sellerToAdd,
                    BoardgameId = boardGamesId
                };

                sellerToAdd.BoardgamesSellers.Add(bgs);
            }

            sellers.Add(sellerToAdd);
            sb.AppendLine(string.Format(SuccessfullyImportedSeller, sellerToAdd.Name, sellerToAdd.BoardgamesSellers.Count()));
        }
        context.AddRange(sellers);
        context.SaveChanges();

        return sb.ToString().Trim();
    }

    private static bool IsValid(object dto)
    {
        var validationContext = new ValidationContext(dto);
        var validationResult = new List<ValidationResult>();

        return Validator.TryValidateObject(dto, validationContext, validationResult, true);
    }
    static bool IsValidWebsite(string input)
    {
        string pattern = @"^www\.[a-zA-Z0-9-]+\.com$";
        return Regex.IsMatch(input, pattern);
    }
}
