namespace Threeuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            CustomThreeuple<string, string,string> tuple = new($"{input[0]} {input[1]}", input[2], input[3]);

            Console.WriteLine(tuple);

            input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            bool drunk;
            if (input[2] == "drunk")
            {
                drunk = true;
            }
            else
            {
                drunk = false;
            }

            CustomThreeuple<string, int, bool> tuple2 = new(input[0], int.Parse(input[1]),drunk);
            Console.WriteLine(tuple2);

            input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            CustomThreeuple<string, double,string> tuple3 = new(input[0], double.Parse(input[1]), input[2]);
            Console.WriteLine(tuple3);
        }
    }
}