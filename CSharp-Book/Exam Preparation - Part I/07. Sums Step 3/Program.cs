using System;

namespace _07._Sums_Step_3
{
    internal class Program
    {
        static void Main(string[] args)
        {



            var n = int.Parse(Console.ReadLine());
            var sum1 = 0;
            var sum2 = 0;
            var sum3 = 0;
            var count = 0;


            //Начин 1
            for (int i = 0; i < n; i++)
            {

                var num = int.Parse(Console.ReadLine());

                if (count == 0)
                {
                    sum1 += num;
                    
                }else if(count == 1)
                {
                    sum2 += num;
                   
                }
                else if(count == 2)
                {
                    sum3 += num;
                    
                }
                count++;
                if(count > 2)
                {
                    count = 0;
                }



            }

            Console.WriteLine($"sum1 = {sum1}");
            Console.WriteLine($"sum2 = {sum2}");
            Console.WriteLine($"sum3 = {sum3}");



            //Начин 2

            //for (int i = 0; i < n; i++)
            //{
            //    var num = int.Parse(Console.ReadLine());

            //    if (i %3 == 0) //0 % 3 ==0 , 1-во число , 3%3 == 0, 6%3==0,9%3==0
            //    {
            //        sum1 += num;
            //    }
            //    if(i %3 == 1)//1%3==1,4%3 ==1,7%3==1
            //    {
            //        sum2 += num;
            //    }
            //    if(i%3 == 2)//2%3 == 2 , 5%3 ==2 ,  7%3==2
            //    {
            //        sum3 += num;
            //    }



            //}
            //Console.WriteLine($"sum1 = {sum1}");
            //Console.WriteLine($"sum2 = {sum2}");
            //Console.WriteLine($"sum3 = {sum3}");



            //9 - 9 числа        
            //1    1                sum1 = 1to - 4to - 7to
            //2    3                sum2 = 2-roto - 5toto - 8to
            //3    5                sum3 = 3-toto - 6 toto - 9toto
            //4    2
            //5    4
            //6    6
            //7    34
            //8    2
            //9    3









        }
    }
}
