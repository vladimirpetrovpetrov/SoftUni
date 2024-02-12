namespace SoftUniBazar.Infrastructure.Constants;

/// <summary>
/// Validation constants for Advertisements
/// </summary>
public static class AdDataConstants
{
    /// <summary>
    /// Minimum Advertisement name length
    /// </summary>
    public const int NameMinLength = 5;

    /// <summary>
    /// Maximum Advertisement name length
    /// </summary>
    public const int NameMaxLength = 25;

    /// <summary>
    /// Minimum Advertisement description length
    /// </summary>
    public const int DescMinLength = 15;

    /// <summary>
    /// Maximum Advertisement description length
    /// </summary>
    public const int DescMaxLength = 250;

    /// <summary>
    /// The required date format for Advertisement creation date.
    /// </summary>
    public const string AdDateFormat = "yyyy-MM-dd H:mm";
    /// <summary>
    /// Minimal price value.
    /// </summary>
    public const int MinPriceValue = 0;
}
