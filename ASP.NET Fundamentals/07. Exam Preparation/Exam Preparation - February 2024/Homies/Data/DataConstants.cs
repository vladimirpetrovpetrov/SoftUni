namespace Homies.Data;

public static class DataConstants
{
    public static class EventConstants
    {
        //Name
        public const int NameMinLength = 5;
        public const int NameMaxLength = 20;

        //Description
        public const int DescMinLength = 15;
        public const int DescMaxLength = 150;

        //Datetime required format
        public const string DateFormat = "yyyy-MM-dd H:mm";
        public const string DateFormatForEdit = "dd-MMM-yyyy HH:mm";
    }

    public static class TypeConstants
    {
        //Name
        public const int NameMinLength = 5;
        public const int NameMaxLength = 15;
    }
}
