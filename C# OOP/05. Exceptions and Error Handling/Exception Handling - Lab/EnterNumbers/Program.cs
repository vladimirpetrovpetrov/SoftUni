namespace EnterNumbers;

public class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int n = 0;
        while(numbers.Count < 10) 
        {
            try
            {
                if (numbers.Count > 0)
                {
                    numbers.Add(ReadNumber(numbers.Max(), 100));
                }
                else
                {
                    numbers.Add(ReadNumber(1, 100));
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Number!");
            }
            
        }
        Console.WriteLine(String.Join(", ",numbers));

    }

    private static int ReadNumber(int start, int end)
    {
            var n = int.Parse(Console.ReadLine());
            if(n <= start || n >= end)
            {
                throw new ArgumentException($"Your number is not in range {start} - 100!");
            }
        return n;
        


    }
}