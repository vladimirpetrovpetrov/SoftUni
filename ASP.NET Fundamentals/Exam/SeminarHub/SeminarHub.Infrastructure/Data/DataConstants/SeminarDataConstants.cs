namespace SeminarHub.Infrastructure.Data.DataConstants;

public static class SeminarDataConstants
{
    /// <summary>
    /// Minimum length of the Seminar Topic
    /// </summary>
    public const int MinTopicLength = 3;

    /// <summary>
    /// Maximum length of the Seminar Topic
    /// </summary>
    public const int MaxTopicLength = 100;

    /// <summary>
    /// Minimum length of the Seminar Lecturer field
    /// </summary>
    public const int MinLecturerFieldLength = 5;
    /// <summary>
    /// Maximum length of the Seminar Lecturer field
    /// </summary>
    public const int MaxLecturerFieldLength = 60;

    /// <summary>
    /// Minimum length of the Seminar Details
    /// </summary>
    public const int MinDetailsLength = 10;
    /// <summary>
    /// Maximum length of the Seminar Details
    /// </summary>
    public const int MaxDetailsLength = 500;

    /// <summary>
    /// Minimum value of the Seminar Duration
    /// </summary>
    public const int DurationMinValue = 30;
    /// <summary>
    /// Maximum value of the Seminar Duration
    /// </summary>
    public const int DurationMaxValue = 180;

    /// <summary>
    /// The required DateTime Format
    /// </summary>
    public const string RequiredDateFormat = "dd/MM/yyyy HH:mm";


}
