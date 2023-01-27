//var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
//int sum = 0;

//for (int i = 0;i < arr.Length; i++)
//{
//    if (arr[i] % 2 == 0)
//    {
//        sum+= arr[i];
//    }
//}
//Console.WriteLine(sum);


Console.WriteLine(Console.ReadLine().Split().Select(int.Parse).Where(x => x % 2 == 0).Sum());



//Console.WriteLine(String.Join(" ",Console.ReadLine()
//                                  .Split()
//                                  .Where(x => Char.IsUpper(x[0]))));
                                  

