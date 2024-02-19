namespace SeminarHub.Infrastructure.Data.ErrorMessages;

public static class ErrorMessages
{
    /// <summary>
    /// Error Message for Required fields
    /// </summary>
    public const string RequireErrorMessage = "The field {0} is required!";

    /// <summary>
    /// Error Message for fields with set lengths
    /// </summary>
    public const string LengthErrorMessage = "The field {0} must be between {2} and {1} characters long.";
}
