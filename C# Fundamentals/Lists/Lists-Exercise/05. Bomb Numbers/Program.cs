var list = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
var bomb = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
int num = bomb[0];
int power = bomb[1];

while (list.Contains(num))
{
	int indexOfDetonation = list.IndexOf(num);
    int tempPower = power;
    while(tempPower>0)
	{
        indexOfDetonation = list.IndexOf(num);
        if (indexOfDetonation - 1 >= 0)
        {
            list.RemoveAt(indexOfDetonation - 1);
            tempPower--;
        }
        else 
        { 
            break;
        }
    }
    indexOfDetonation = list.IndexOf(num);
    tempPower = power;
    while(tempPower>0)
    {
        
        if(indexOfDetonation + 1 <= list.Count - 1)
		{
			list.RemoveAt(indexOfDetonation + 1);
			tempPower--;
			
		}
		else { break; }
    }
    indexOfDetonation = list.IndexOf(num);
	list.RemoveAt(indexOfDetonation);
}
Console.WriteLine(list.Sum());