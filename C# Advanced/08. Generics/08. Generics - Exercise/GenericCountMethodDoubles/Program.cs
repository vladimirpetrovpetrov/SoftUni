namespace GenericCountMethodDoubles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Box<double> box = new Box<double>();
            for (int i = 0; i < n; i++)
            {
                box.AddElement(double.Parse(Console.ReadLine()));
            }
            var input = double.Parse(Console.ReadLine());
            Console.WriteLine(box.CountGreater(input));
        }
    }
}