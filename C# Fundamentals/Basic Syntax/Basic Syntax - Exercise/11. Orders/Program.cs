var countOfOrders = int.Parse(Console.ReadLine());
double totalSum = 0;
while (countOfOrders > 0)
{

    var pricePerCapsule = double.Parse(Console.ReadLine());
    var days = int.Parse(Console.ReadLine());
    var capsuleCount = int.Parse(Console.ReadLine());

    Console.WriteLine($"The price for the coffee is: ${pricePerCapsule*days*capsuleCount:f2}");
    totalSum += (pricePerCapsule * days * capsuleCount);
    countOfOrders--;
}
Console.WriteLine($"Total: ${totalSum:f2}");

