//RemoveALl
var list = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList();
list.RemoveAll(x => x < 0);
if (list.Count == 0)
{
    Console.WriteLine("empty");
    return;
}
list.Reverse();
Console.WriteLine(String.Join(" ", list));




//Where

//var list = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).Where(x => x >= 0).ToList();
//if(list.Count == 0)
//{
//    Console.WriteLine("empty");
//    return;
//}
//list.Reverse();
//Console.WriteLine(String.Join(" ",list));