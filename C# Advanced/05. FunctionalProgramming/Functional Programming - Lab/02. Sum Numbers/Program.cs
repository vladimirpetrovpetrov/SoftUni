namespace _02._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(", ", Console.ReadLine().Split(", ").Select(int.Parse).Where(x => x % 2 == 0).OrderBy(x => x)));
        }
        static int CountNumbers(int[] array)
        {
            return array.Length;
        }
        static int SumNumbers(int[] array)
        {
            return array.Sum();
        }
    }
}