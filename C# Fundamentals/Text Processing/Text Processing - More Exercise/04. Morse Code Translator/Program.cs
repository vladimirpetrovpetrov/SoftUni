using System.Text;
var words = Console.ReadLine().Split(" | ", StringSplitOptions.RemoveEmptyEntries);
Dictionary<string, char> morse = new Dictionary<string, char>()
            {
                { ".-",       'A'    } ,
                { "-...",     'B'    } ,
                { "-.-.",     'C'    } ,
                { "-..",      'D'    } ,
                { ".",        'E'    } ,
                { "..-.",     'F'    } ,
                { "--.",      'G'    } ,
                { "....",     'H'    } ,
                { "..",       'I'    } ,
                { ".---",     'J'    } ,
                { "-.-",      'K'    } ,
                { ".-..",     'L'    } ,
                { "--",       'M'    } ,
                { "-.",       'N'    } ,
                { "---",      'O'    } ,
                { ".--.",     'P'    } ,
                { "--.-",     'Q'    } ,
                { ".-.",      'R'    } ,
                { "...",      'S'    } ,
                { "-",        'T'    } ,
                { "..-",      'U'    } ,
                { "...-",     'V'    } ,
                { ".--",      'W'    } ,
                { "-..-",     'X'    } ,
                { "-.--",     'Y'    } ,
                { "--..",     'Z'    } ,
                { "-----",    '0'    } ,
                { ".----",    '1'    } ,
                { "..---",    '2'    } ,
                { "...--",    '3'    } ,
                { "....-",    '4'    } ,
                { ".....",    '5'    } ,
                { "-....",    '6'    } ,
                { "--...",    '7'    } ,
                { "---..",    '8'    } ,
                { "----.",    '9'    } ,
            };

StringBuilder output = new StringBuilder();
foreach (var item in words)
{
    var characters = item.Split(' ', StringSplitOptions.RemoveEmptyEntries);

    for (int i = 0; i < characters.Length; i++)
    {
        var toAppend = morse[characters[i]];
        output.Append(toAppend);
    }
    output.Append(" ");
}
output.ToString().TrimEnd(' ');
Console.WriteLine(output);
