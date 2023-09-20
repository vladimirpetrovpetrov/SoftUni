using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listyiterator;

public class ListyIterator<T>
{
    private List<T> list;
    private int index = 0;

    public ListyIterator(List<T> list)
    {
        this.list = list;
    }

    public bool Move()
    {
        if(index < list.Count - 1)
        {
            index++;
            return true;
        }
        else
        {
            return false;
        }
    }
    public bool HasNext()
    {
        if(index < list.Count - 1)
        {
            return true;
        }
        else 
        { 
            return false;
        }
    }

    public void Print()
    {
        if(list.Count == 0) 
        {
            throw new InvalidOperationException("Invalid Operation!");
        }
        Console.WriteLine(list[index]);
    }
}
