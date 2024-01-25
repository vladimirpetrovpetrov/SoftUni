using System;
namespace Merge_Sort_Algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {2,3,1,8,1,5,7,11};
            MergeSort(numbers, 0,numbers.Length - 1);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i]+" ");
            }






        }
        private static void MergeSort(int[] a,int l,int r)
        {
            if (l < r)
            {
                int m = l + (r - l) / 2 + 1;
                MergeSort(a, l, m - 1);
                MergeSort(a, m,r);
                Merge(a, l, m, r);
            }




        }
        private static void Merge(int[] a, int l, int m, int r)
        {
            //three pointers;
            int i, j, k;
            int lal = m - l;
            int ral = r - m + 1;
            //defining two arrays po left part and right part
            int[] left = new int[lal];
            int[] right = new int[ral];
            for (i = 0; i < lal; i++)
            {
                left[i] = a[l + i];
            }
            for (i = 0; i < ral; i++)
            {
                right[i] = a[m + i];
            }
            i = 0;
            j = 0;
            k = 0;
            while (i < lal && j < ral)
            {
                if (left[i] <= right[j])
                {
                    a[k++] = left[i++];
                }
                else
                {
                    a[k++] = right[j++];
                }
            }
            if(i == lal)
            {
                //left array is done, and we copy from the right array
                for (int posistion = j; posistion < ral; posistion++)
                {
                    a[k++] = right[posistion];
                }
            }
            if (j == ral)
            {
                //right array is done, and we copy from the left array
                for (int posistion = i; posistion < lal; posistion++)
                {
                    a[k++] = left[posistion];
                }
            }



        }


    }
}
