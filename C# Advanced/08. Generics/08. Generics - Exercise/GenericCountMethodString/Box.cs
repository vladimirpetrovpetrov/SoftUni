using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCountMethodString;

public class Box<T> : IComparable
{
    private List<T> values;

    public Box()
    {
        this.values = new List<T>();
    }

    public void AddValue(T value)
    {
        this.values.Add(value);
    }

    public void Swap(int indexOne,int indexTwo)
    {
        T temp = this.values[indexOne];
        this.values[indexOne] = this.values[indexTwo];
        this.values[indexTwo] = temp;
    }

    public int CountGreater(T element)
    {
        int count = 0;
        foreach (T value in this.values)
        {
            if(value > element)
            {
                count++;
            }
        }
    }

    public override string ToString()
    {
        StringBuilder st = new StringBuilder();
        foreach (var item in values)
        {
            st.AppendLine($"{item.GetType()}: {item}");
        }
        return st.ToString().Trim();
    }
}
