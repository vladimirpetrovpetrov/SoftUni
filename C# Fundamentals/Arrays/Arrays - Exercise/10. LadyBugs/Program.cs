using System.Reflection.Metadata.Ecma335;

var arrLength = int.Parse(Console.ReadLine());

int[] arr = new int[arrLength];
InitArr(arr, arrLength); //init the array only with 0
//Console.WriteLine(String.Join(" ", arr));
var bugsIndexes = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
InitBugs(arr, bugsIndexes); //init the bugs in the array (with 1)
//Console.WriteLine(String.Join(" ", arr));


while (true)
{
    var command = Console.ReadLine();
    if(command == "end")
    {
        Console.WriteLine(String.Join(" ", arr));
        return;
    }
    string[] moves = command.Split().ToArray();
    
    int movingBug = int.Parse(moves[0]); //коя се движи
    int spaces = int.Parse(moves[2]); // колко полета ще се движи
    string direction = moves[1]; // на дясно или ляво

    MoveBugs(arr, movingBug, spaces, direction);
    //Console.WriteLine(String.Join(" ", arr));
}







static void InitArr(int[] arr, int length)
{
    for (int i = 0; i < length; i++)
    {
        arr[i] = 0;
    }
}

static void InitBugs(int[] arr, int[] bugIndexes)
{
    foreach (var item in bugIndexes)
    {
        if (item < 0 || item > arr.Length - 1)
        {
            continue;
        }
        else
        {
            arr[item] = 1;
        }
    }
}
static void MoveBugs(int[] arr, int movingBug, int spaces, string direction)
{
    if (arr[movingBug] != 1) { return; }
    arr[movingBug] = 0;
    if (direction == "right")
    {
        if (movingBug + spaces >= arr.Length)
        {
            return;
        }
        while (arr[movingBug + spaces] != 0 && movingBug + spaces < arr.Length - 1)
        {
            spaces++;
        }
        if (movingBug + spaces < arr.Length)
        {
            arr[movingBug + spaces] = 1;
        }
    }
    else
    {
        if (movingBug - spaces < 0)
        {
            return;
        } //директно върни ако индекса е по-малък от 0 
        while (arr[movingBug - spaces] != 0 && movingBug - spaces >= 0)
        {
                spaces++;
        }
        if (movingBug - spaces >= 0)
        {
            arr[movingBug - spaces] = 1;
        }
    }
}