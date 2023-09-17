namespace CustomNumberEnumerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NumbersEnumerable nums = new NumbersEnumerable();
            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }
        }
    }
}