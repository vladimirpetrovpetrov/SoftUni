namespace HouseRentingSystem.Infrastructure.Constants;

public static class DataConstants
{
    /// <summary>
    /// Data constants for the eneity Category
    /// </summary>
    public static class Category
    {
        /// <summary>
        /// Maximum length of the Category name
        /// </summary>
        public const int MaxNameLength = 50;
    }

    /// <summary>
    /// Data constants for the eneity House
    /// </summary>
    public static class House
    {
        /// <summary>
        /// Minimum length of the House title
        /// </summary>
        public const int MinTitleLength = 10;

        /// <summary>
        /// Maximum length of the House title
        /// </summary>
        public const int MaxTitleLength = 50;
        
        /// <summary>
        /// Minimum length of the House address
        /// </summary>
        public const int MinAddressLength = 30;

        /// <summary>
        /// Maximum length of the House address
        /// </summary>
        public const int MaxAddressLength = 150;

        /// <summary>
        /// Minimum length of the House description
        /// </summary>
        public const int MinDescLength = 50;

        /// <summary>
        /// Maximum length of the House description
        /// </summary>
        public const int MaxDescLength = 500;

        /// <summary>
        /// Minimum value of the House price per month
        /// </summary>
        public const string MinPricePerMonth = "0.00";

        /// <summary>
        /// Maximum value of the House price per month
        /// </summary>
        public const string MaxPricePerMonth = "2000.00";

    }

    /// <summary>
    /// Data constants for the eneity Agent
    /// </summary>
    public static class Agent
    {
        /// <summary>
        /// Minimum length of the Agent phone number
        /// </summary>
        public const int MinPhoneNumberLength = 7;

        /// <summary>
        /// Maximum length of the Agent phone number
        /// </summary>
        public const int MaxPhoneNumberLength = 15;
    }

    public class ApplicationUser
    {
        /// <summary>
        /// Minimum length of the User First Name
        /// </summary>
        public const int MinFirstNameLength = 1;
        /// <summary>
        /// Maximum length of the User First Name
        /// </summary>
        public const int MaxFirstNameLength = 12;

        /// <summary>
        /// Minimum length of the User Last Name
        /// </summary>
        public const int MinLastNameLength = 3;
        /// <summary>
        /// Maximum length of the User Last Name
        /// </summary>
        public const int MaxLastNameLength = 15;
    }
}
