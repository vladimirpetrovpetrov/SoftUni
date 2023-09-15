using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GenericArrayCreator
{
    public class ArrayCreator
    {
       
        public static T[] Create<T>(int length,T item)
        {
            T[] ar = new T[length];
            for (int i = 0; i < ar.Length; i++)
            {
                ar[i] = item;
            }
            
            return ar;
            
        }
    }
}
