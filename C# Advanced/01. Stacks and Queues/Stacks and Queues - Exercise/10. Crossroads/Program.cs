Queue<string> carsQueue = new Queue<string>();
var greenLightDuration = int.Parse(Console.ReadLine());
var freeWindowDuration = int.Parse(Console.ReadLine());
var carsPassed = 0;
while (true)
{
    var input = Console.ReadLine();
    var hasCrashed = false;
    if (input == "END")
    {
        break;
    }
    if (input == "green")
    {
        var currentTime = greenLightDuration;
        while (carsQueue.Count > 0 && currentTime > 0)
        {

            var passingCar = carsQueue.Peek();
            if (passingCar.Length <= currentTime)
            {
                currentTime -= carsQueue.Peek().Length;
                carsQueue.Dequeue();
                carsPassed++;
            }
            else if (passingCar.Length > currentTime)
            {
                if (passingCar.Length > currentTime + freeWindowDuration)
                {
                    Console.WriteLine("A crash happened!");
                    var crashedIndex = passingCar.Length - (currentTime + freeWindowDuration);
                    Console.WriteLine($"{passingCar} was hit at {passingCar[^crashedIndex]}.");
                    hasCrashed = true;
                    return;
                }
                else
                {
                    carsQueue.Dequeue();
                    carsPassed++;
                    break;
                }
            }
        }
    }
    else
    {
        carsQueue.Enqueue(input);
    }
    if (hasCrashed)
    {
        break;
    }
}
Console.WriteLine("Everyone is safe.");
Console.WriteLine($"{carsPassed} total cars passed the crossroads.");
