namespace Library.Data;

public static class DataConstants
{
    public static class BookConstants
    {
        //Book Title
        public const int MaxTitleLength = 50;
        public const int MinTitleLength = 10;

        //Book Author
        public const int MaxAuthorLength = 50;
        public const int MinAuthorLength = 5;

        //Book Desc
        public const int MaxDescLength = 5000;
        public const int MinDescLength = 5;

        //Book Rating
        public const double MaxRatingValue = 10.00d;
        public const double MinRatingValue = 0.00d;
    }

    public static class CategoryConstants
    {
        //Category Name
        public const int MaxNameLength = 50;
        public const int MinNameLength = 5;
    }
}
