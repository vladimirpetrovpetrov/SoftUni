namespace TaskBoardApp.Data;

public static class DataConstants
{
    //General
    public const string LengthError = "{0} should be between {2} and {1}character long.";

    //Task Title
    public const int TaskTitleMaxLength = 70;
    public const int TaskTitleMinLength = 5;

    //Task Description
    public const int TaskDescMaxLength = 1000;
    public const int TaskDescMinLength = 10;

    //Board Name
    public const int BoardNameMaxLength = 30;
    public const int BoardNameMinLength = 3;


}
