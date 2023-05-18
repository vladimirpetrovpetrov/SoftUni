HashSet<string> vipInvitations = new();
HashSet<string> regularInvitations = new();
var input = string.Empty;
while (true)
{
    input = Console.ReadLine();
    if (input == "PARTY" || input == "END")
    {
        break;
    }
    if (Char.IsDigit(input[0]))
    {
        vipInvitations.Add(input);
    }
    else
    {
        regularInvitations.Add(input);
    }
}
if (input == "PARTY")
{
    while (true)
    {
        input = Console.ReadLine();
        if (input == "END")
        {
            break;
        }
        if (vipInvitations.Contains(input))
        {
            vipInvitations.Remove(input);
        }
        else if (regularInvitations.Contains(input))
        {
            regularInvitations.Remove(input);
        }
    }
}

var peopleThatDidntCome = vipInvitations.Count + regularInvitations.Count;
Console.WriteLine(peopleThatDidntCome);
if (vipInvitations.Count > 0)
{
    Console.WriteLine(String.Join(Environment.NewLine, vipInvitations));
}
if (regularInvitations.Count > 0)
{
    Console.WriteLine(String.Join(Environment.NewLine, regularInvitations));
}