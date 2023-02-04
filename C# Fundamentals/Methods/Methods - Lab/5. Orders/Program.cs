var type = Console.ReadLine();
var quantity = int.Parse(Console.ReadLine());

const double coffeePrice = 1.50;
const double waterPrice = 1.00;
const double cokePrice = 1.40;
const double snacksPrice = 2.00;
Console.WriteLine(CalculatePrice(type, quantity));

static string CalculatePrice(string type, int quantity)
{
    var price = 0.0;
    if(type == "coffee")
    {
        price = quantity * coffeePrice;
        return $"{price:f2}";
    }else if (type == "water")
    {
        price = quantity * waterPrice;
        return $"{price:f2}";
    }
    else if (type == "coke")
    {
        price = quantity * cokePrice;
        return $"{price:f2}";
    }
    else if (type == "snacks")
    {
        price = quantity * snacksPrice;
        return $"{price:f2}";
    }
    return "";
}