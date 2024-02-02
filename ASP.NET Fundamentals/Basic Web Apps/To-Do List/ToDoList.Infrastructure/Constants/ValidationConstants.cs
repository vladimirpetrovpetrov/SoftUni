namespace ToDoList.Infrastructure.Constants;

public static class ValidationConstants
{
    /// <summary>
    /// Error message for TaskViewModel Title Length
    /// </summary>
    public const string TitleLengthErrorMessage = "{0} must be between {2} and {1} symbols long!";

    /// <summary>
    /// Error message for TaskViewModel Description Length
    /// </summary>
    public const string DescLengthErrorMessage = "{0} must be between {2} and {1} symbols long!";

    /// <summary>
    /// Error message for required
    /// </summary>
    public const string RequiredErrorMessage = "{0} is required!";

}
