using System.Collections.Immutable;
using System.Linq;

int[] x = new int[] {3,1,2};

var y = x.OrderBy(x => x);
Console.WriteLine(String.Join(" ", y));
Console.WriteLine(y);