var originalSchedule = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries).ToList();

while (true)
{

    string command = Console.ReadLine();
    if(command=="course start")
    {
        break;
    }
    var doIt = command.Split(":").ToList();
    if (doIt[0] == "Add")
    {
        if (!originalSchedule.Contains(doIt[1])) 
        {
            originalSchedule.Add(doIt[1]);
        }

    }
    else if (doIt[0] == "Insert")
    {
        if (!originalSchedule.Contains(doIt[1]))
        {
            originalSchedule.Insert(int.Parse(doIt[2]),doIt[1]);
        }
    }
    else if (doIt[0] == "Remove")
    {
        string testExercise = doIt[1] + "-Exercise";
        if (originalSchedule.Contains(doIt[1]) && originalSchedule.Contains(testExercise))
        {
            originalSchedule.Remove(doIt[1]);
            originalSchedule.Remove(testExercise);
        }else if(originalSchedule.Contains(doIt[1]) && !originalSchedule.Contains(testExercise))
        {
            originalSchedule.Remove(doIt[1]);
        }
    }
    else if (doIt[0] == "Swap")
    {
        string testExercise = doIt[1] + "-Exercise";
        string testExercise2 = doIt[2] + "-Exercise";
        if (originalSchedule.Contains(doIt[1]) && originalSchedule.Contains(doIt[2]) && !originalSchedule.Contains(testExercise) && !originalSchedule.Contains(testExercise2))
        {
            int indexOfFirst = originalSchedule.IndexOf(doIt[1]);
            int indexOfSecond = originalSchedule.IndexOf(doIt[2]);
            string temp = originalSchedule[indexOfFirst];
            originalSchedule[indexOfFirst] = originalSchedule[indexOfSecond];
            originalSchedule[indexOfSecond] = temp;

        }else if (originalSchedule.Contains(doIt[1]) && originalSchedule.Contains(doIt[2]) && !originalSchedule.Contains(testExercise) && originalSchedule.Contains(testExercise2))
        {
            int indexOfFirst = originalSchedule.IndexOf(doIt[1]);
            int indexOfSecond = originalSchedule.IndexOf(doIt[2]); 
            int indexOfSecondEx = originalSchedule.IndexOf(testExercise2); 
            string temp = originalSchedule[indexOfFirst]; 
            originalSchedule[indexOfFirst] = originalSchedule[indexOfSecond];
            originalSchedule.Insert(indexOfFirst + 1, testExercise2);
            int indexOfLast = originalSchedule.LastIndexOf(doIt[2]);
            originalSchedule[indexOfLast] = temp;
            originalSchedule.RemoveAt(indexOfLast+1);
        }
        else if (originalSchedule.Contains(doIt[1]) && originalSchedule.Contains(doIt[2]) && originalSchedule.Contains(testExercise) && !originalSchedule.Contains(testExercise2))
        {
            int indexOfFirst = originalSchedule.IndexOf(doIt[1]);
            int indexOfFirstEx = originalSchedule.IndexOf(testExercise);
            int indexOfSecond = originalSchedule.IndexOf(doIt[2]); 
            string temp = originalSchedule[indexOfSecond];
            originalSchedule[indexOfSecond] = originalSchedule[indexOfFirst];
            originalSchedule.Insert(indexOfSecond + 1, testExercise);
            originalSchedule[indexOfFirst] = temp;
            originalSchedule.RemoveAt(indexOfFirstEx);
        }
        else if (originalSchedule.Contains(doIt[1]) && originalSchedule.Contains(doIt[2]) && originalSchedule.Contains(testExercise) && originalSchedule.Contains(testExercise2))
        {
            string temp = doIt[1];
            string tempE = testExercise;
            int indexOfFirst = originalSchedule.IndexOf(doIt[1]);
            int indexOfFirstEx = originalSchedule.IndexOf(testExercise);
            int indexOfSecond = originalSchedule.IndexOf(doIt[2]);
            int indexOfSecondEx = originalSchedule.IndexOf(testExercise2);
            originalSchedule[indexOfFirst] = originalSchedule[indexOfSecond];
            originalSchedule[indexOfFirstEx] = originalSchedule[indexOfSecondEx];
            originalSchedule[indexOfSecond] = temp;
            originalSchedule[indexOfSecondEx] = tempE;
        }
    }
    else if (doIt[0] == "Exercise")
    {
        string testExercise = doIt[1] + "-Exercise";
        if (originalSchedule.Contains(doIt[1]) && !originalSchedule.Contains(testExercise))
        {
            int indexOf = originalSchedule.IndexOf(doIt[1]);
            originalSchedule.Insert(indexOf + 1, testExercise);
        }else if (!originalSchedule.Contains(doIt[1]) && !originalSchedule.Contains(testExercise))
        {
            originalSchedule.Add(doIt[1]);
            originalSchedule.Add(testExercise);
        }
    }
}
int a = 1;
foreach (var item in originalSchedule)
{
    Console.WriteLine($"{a++}.{item}");
}