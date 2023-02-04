public class Program
{
    static void Main()
    {
        while (true)
        {
            var num = Console.ReadLine();
            if(num == "END")
            {
                return;
            }
            char[] firstPartArray = FirstPart(num);
            char[] secondPartArray = SecondPart(num);
            Array.Reverse(secondPartArray);
            CompareArrays(firstPartArray, secondPartArray);
        }
    }
    static char[] FirstPart(string num)
    {
        string firstPart = string.Empty;
        for (int i = 0; i < num.Length / 2; i++)
        {
            firstPart += num[i];
        }
        return firstPart.ToCharArray();
    }
    static char[] SecondPart(string num)
    {
        string secondPart = string.Empty;
        for (int i = num.Length / 2; i < num.Length; i++)
        {
            secondPart += num[i];
        }
        return secondPart.ToCharArray();
    }
    static void CompareArrays(char[] a, char[] b)
    {
        bool areTheSame = true;
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] != b[i])
            {
                areTheSame = false;
                break;
            }
        }
        Console.WriteLine(areTheSame.ToString().ToLower());
    }
}