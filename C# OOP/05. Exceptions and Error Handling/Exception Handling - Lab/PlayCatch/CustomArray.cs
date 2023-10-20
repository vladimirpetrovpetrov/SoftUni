using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayCatch;

public class CustomArray
{
    public int[] ints;
    public int errors;

    public CustomArray(int[] ints)
    {
        this.ints = ints;
        errors = 0;
    }
    public void Replace (int index, int value)
    {
        if(index < 0 || index >= ints.Length)
        {
            throw new IndexOutOfRangeException("The index does not exist!");
        }
        else
        {
            this.ints[index] = value;
        }
    }

    internal void Show(int index)
    {
        if (index < 0 || index >= ints.Length)
        {
            throw new IndexOutOfRangeException("The index does not exist!");
        }
        else
        {
            Console.WriteLine(ints[index]);
        }
    }
    internal void Print(int startIndex, int endIndex)
    {
        if (startIndex < 0 || startIndex >= ints.Length ||
            endIndex < 0 || endIndex >= ints.Length)
        {
            throw new IndexOutOfRangeException("The index does not exist!");
        }
        else
        {
            var cuttedArray = new int[(endIndex - startIndex) + 1];
            var counter = 0; 
            for (int i = startIndex; i <= endIndex; i++)
            {
                cuttedArray[counter++] = this.ints[i]; 
            }
            Console.WriteLine(String.Join(", ", cuttedArray));

        }
    }
}
