var arr1 = Console.ReadLine().Split().ToArray();
var arr2 = Console.ReadLine().Split().ToArray();





for (int i = 0; i < arr2.Length; i++)
{
    if (arr1.Contains(arr2[i]))
    {
        Console.Write(arr2[i]+" ");
    }
}




