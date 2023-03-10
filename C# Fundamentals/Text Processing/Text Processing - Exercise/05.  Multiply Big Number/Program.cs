using System.Text;

var theBigNumber = Console.ReadLine().ToCharArray();
var readyToWork = theBigNumber.Select(x => x.ToString()).ToArray().Select(int.Parse).ToArray();    
int n = int.Parse(Console.ReadLine());
StringBuilder st = new StringBuilder();
var leftOver = 0;
for (int i = readyToWork.Length-1; i >= 0; i--)
{
    
    var sum = readyToWork[i] *n +  leftOver;
    var numberToAdd = sum % 10;
    leftOver = sum / 10;
    if (i == 0)
    {
        var reversedLastSum = sum.ToString().Reverse().ToArray();
        var finalSum = new string(reversedLastSum);
        st.Append(finalSum);
        break;
    }
    st.Append(numberToAdd);

}
var result = st.ToString().Reverse();
Console.WriteLine(String.Join("",result));
//9395388955727932769851328408
//3695388955727932769851328408