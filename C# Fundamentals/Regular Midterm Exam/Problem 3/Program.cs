public class Program {
    static void Main()
    {
        var priceRating = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToList();
        var entryPoint = int.Parse(Console.ReadLine());
        var typeOfItems = Console.ReadLine();


        if (typeOfItems == "expensive")
        {
            var leftSum = priceRating.Take(entryPoint).Where(x => x >= priceRating[entryPoint]).Sum();
            var rightSum = priceRating.Skip(entryPoint + 1).Where(x => x >= priceRating[entryPoint]).Sum();
            PrintBestSide(leftSum, rightSum);

        }
        else if (typeOfItems == "cheap")
        {
            var leftSum = priceRating.Take(entryPoint).Where(x => x < priceRating[entryPoint]).Sum();
            var rightSum = priceRating.Skip(entryPoint + 1).Where(x => x < priceRating[entryPoint]).Sum();
            PrintBestSide(leftSum, rightSum);
        }
    }

    private static void PrintBestSide(int leftSum, int rightSum)
    {
        if (leftSum >= rightSum)
        {
            Console.WriteLine($"Left - {leftSum}");
        }
        else
        {
            Console.WriteLine($"Right - {rightSum}");
        }
    }

}