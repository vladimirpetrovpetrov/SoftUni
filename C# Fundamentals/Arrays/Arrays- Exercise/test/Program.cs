int[] x = new int[] {3,1,2};
var reversedX = new int[3];
reversedX = x.Reverse().ToArray(); 
Console.WriteLine(String.Join(" ",reversedX)); //2,1,3




Array.Reverse(x); // тук го завърта и го сейфа
Console.WriteLine(String.Join(" ", x));