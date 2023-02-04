public class Program
{
    static void Main()
    {
        var password = Console.ReadLine();
        bool a = CharLength(password);
        bool b = CheckLetterAndDigits(password);
        bool c = AtleastTwoDigit(password);
        ValidPassword(a, b, c);
    }
    static void ValidPassword(bool a,bool b,bool c)
    {
        if (a &&b &&c)
        {
            Console.WriteLine("Password is valid");
        }
    }
    static bool CharLength(string password)
    {
        int count = password.Length;
        if (count < 6 || count > 10)
        {
            Console.WriteLine("Password must be between 6 and 10 characters");
            return false;
        }
        return true;
    }
    static bool CheckLetterAndDigits(string password)
    {
        foreach (var item in password)
        {
            if (!char.IsLetter(item) && !char.IsDigit(item))
            {
                Console.WriteLine("Password must consist only of letters and digits");
                return false;
            }
        }
        return true;
    }
    static bool AtleastTwoDigit(string password)
    {
        int digits = 0;

        foreach (var item in password)
        {
            if (Char.IsDigit(item))
            {
                digits++;
            }
        }
        if (digits < 2)
        {
            Console.WriteLine("Password must have at least 2 digits");
            return false;
        }
        else 
        {
            return true; 
        }

    }
}












