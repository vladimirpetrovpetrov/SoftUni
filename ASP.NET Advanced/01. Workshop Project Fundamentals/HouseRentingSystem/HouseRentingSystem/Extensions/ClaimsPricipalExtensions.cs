using System.Security.Claims;

namespace HouseRentingSystem.Extensions;

public static class ClaimsPricipalExtensions
{
    public static string Id(this ClaimsPrincipal user)
    {
        return user.FindFirstValue(ClaimTypes.NameIdentifier);
    }
}
