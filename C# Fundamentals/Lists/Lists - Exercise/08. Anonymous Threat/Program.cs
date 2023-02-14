var x = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

while (true)
{
    var command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
    if (command[0] == "3:1")
    {
        break;
    }
    if (command[0] == "merge")
    {
        int start = int.Parse(command[1]);
        int end = int.Parse(command[2]);
        int border = end - start - 1; 
        if (start >= 0 && end < x.Count) 
        {

            while (border >= 0)
            {
                x[start] += x[start + 1];
                x.RemoveAt(start + 1);
                border--;
            }
        }
        else if (start < 0 && end > x.Count - 1)
        {
            while (x.Count - 1 > 0)
            {
                x[0] += x[1];
                x.RemoveAt(1);
            }
        }
        else if (start < 0 && end <= x.Count - 1)
        {
            for (int i = 0; i < end; i++)
            {
                x[0] += x[1];
                x.RemoveAt(1);

            }
        }
        else if (start >= 0 && end > x.Count - 1)
        {
            while (x.Count - 1 > start)
            {
                x[start] += x[start + 1];
                x.RemoveAt(start + 1);
            }
        }
    }
    else if (command[0] == "divide")
    {
        int index = int.Parse(command[1]);
        int partitions = int.Parse(command[2]);

        int pieceLength = x[index].Length;
        List<string> pieces = new List<string>();
        int k = 0;
        if (partitions == 0) { continue; }
        if (pieceLength % partitions == 0)
        {
            for (int i = 0; i < partitions; i++)
            {
                string newElement = "";
                for (int j = 0; j < pieceLength / partitions; j++)
                {
                    newElement += x[index][k];
                    k++;
                }
                pieces.Add(newElement);
            }
        }
        else
        {
            string helper = "";
            for (int i = 0; i < partitions - 1; i++)
            {
                string newElement = "";
                for (int j = 0; j < pieceLength / partitions; j++)
                {
                    newElement += x[index][k];
                    k++;
                }
                helper += newElement;
                pieces.Add(newElement);
            }
            pieces.Add(x[index].Substring(helper.Length));

        }
        x.RemoveAt(index);
        x.InsertRange(index, pieces);
        pieces.Clear();
    }
}
Console.WriteLine(String.Join(" ", x));