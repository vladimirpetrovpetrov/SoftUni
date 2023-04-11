int n = int.Parse(Console.ReadLine());
Queue<string> cars = new Queue<string>();
int carsPassed = 0;
while (true)
{
    var input = Console.ReadLine();
    if(input == "end")
    {
        break;
    }

    if(input == "green")
    {
        for (int i = 0; i < n; i++)
        {
            if (cars.Count == 0)
            {
                continue;
            }
            Console.WriteLine($"{cars.Dequeue()} passed!");
            carsPassed++;
            
        }
    }
    else
    {
        cars.Enqueue(input!);
    }
}
Console.WriteLine($"{carsPassed} cars passed the crossroads.");