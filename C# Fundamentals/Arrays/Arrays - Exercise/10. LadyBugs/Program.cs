//input
int sizeOfTheField = int.Parse(Console.ReadLine()!);
if (sizeOfTheField == 0)
{
    return;
}
int[] field = new int[sizeOfTheField];
Array.Fill(field, 0); // filing the array with 0
//Console.WriteLine(String.Join(" ", field));
int[] indexesOfBugs = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
InitBugs(field, indexesOfBugs);//filling the array with bugs/1-s
//Console.WriteLine(String.Join(" ", field));



while (true)
{
    var movement = Console.ReadLine().Split().ToArray();
    if (movement[0] == "end")
    {
        Console.WriteLine(String.Join(" ", field));
        return;
    }
    int movingBug = int.Parse(movement[0]);
    int spaces = int.Parse(movement[2]);
    string direction = movement[1];
    if (movingBug < 0 || movingBug > field.Length - 1)
    {
        continue;
    }
    if (direction == "right")
    {
        MoveRight(field, movingBug, spaces);
        //Console.WriteLine(String.Join(" ", field));
    }
    else
    {
        MoveLeft(field, movingBug, spaces);
        // Console.WriteLine(String.Join(" ", field));
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
static void MoveRight(int[] field, int movingBugIndex, int spaces)
{
    if (field[movingBugIndex] == 0) // ako nqma bug na poleto
    {
        return;
    }
    if (movingBugIndex + spaces > field.Length - 1)
    {
        field[movingBugIndex] = 0;
        return;
    }
    field[movingBugIndex] = 0;

    while (movingBugIndex + spaces < field.Length && field[movingBugIndex + spaces] != 0)
    {
        spaces++;
        if (movingBugIndex + spaces >= field.Length)
        {
            return;
        }
    }

    field[movingBugIndex + spaces] = 1;
}
static void MoveLeft(int[] field, int movingBugIndex, int spaces)
{
    if (field[movingBugIndex] == 0)
    {
        return;
    }
    if (movingBugIndex - spaces < 0)
    {
        field[movingBugIndex] = 0;
        return;
    }
    field[movingBugIndex] = 0;
    while (movingBugIndex - spaces >= 0 && field[movingBugIndex - spaces] != 0)
    {

        spaces++;
        if (movingBugIndex - spaces < 0)
        {
            return;
        }
    }
    field[movingBugIndex - spaces] = 1;
}