public class Program
{
    static void Main()
    {
        var numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
        var s = Console.ReadLine();
        string stringNew = "";
        int sum = 0;
        for (int i = 0; i < numbers.Count; i++)
        {
            sum = SumDigits(numbers, i);
            if (sum > s.Length)
            {
                sum %= s.Length;
                stringNew += s[sum];
                s = s.Remove(sum, 1);
            }
            else
            {
                stringNew += s[sum];
                s = s.Remove(sum, 1);
            }
        }
        Console.WriteLine(stringNew);
    }

    private static int SumDigits(List<int> list, int i)
    {
        int sum = 0;
        while (list[i] > 0)
        {
            sum += list[i] % 10;
            list[i] /= 10;
        }
        return sum;
    }
}