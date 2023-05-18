HashSet<string> carsOnParking = new();
while (true)
{
    var input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
    if (input[0] == "END")
    {
        break;
    }

    if (input[0] == "IN")
    {
        carsOnParking.Add(input[1]);
    }else if (input[0] == "OUT")
    {
        if (carsOnParking.Contains(input[1]))
        {
            carsOnParking.Remove(input[1]);
        }
    }
}

if (carsOnParking.Count > 0)
{
    foreach (var item in carsOnParking)
    {
        Console.WriteLine(item);
    }
}
else
{
    Console.WriteLine("Parking Lot is Empty");
}