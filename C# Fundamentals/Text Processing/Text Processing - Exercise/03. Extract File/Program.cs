using System.Text;
var input = Console.ReadLine();
var file = input.Split("\\", StringSplitOptions.RemoveEmptyEntries).Last().Split(".");
StringBuilder st = new StringBuilder();
st.AppendLine($"File name: {file.First()}");
st.AppendLine($"File extension: {file.Last()}");
Console.WriteLine(st.ToString().TrimEnd('\n'));

//Console.WriteLine(Path.GetFileNameWithoutExtension(input));
//Console.WriteLine(Path.GetExtension(input));