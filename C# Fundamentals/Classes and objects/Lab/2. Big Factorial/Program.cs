using System.Numerics;

public class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(Factoriel(n));

    }
    public static BigInteger Factoriel(int n)
    {
        if(n == 1)
        {
            return 1;
        }

        return n * Factoriel(n - 1);
    }
}