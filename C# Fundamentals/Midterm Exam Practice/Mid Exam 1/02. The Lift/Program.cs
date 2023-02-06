using System;
using System.Linq;

namespace _2.TheLift
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalPeople = int.Parse(Console.ReadLine());
            int[] LiftNow = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool x = LiftNow.Any(x => x < 4);
            if (!x && totalPeople>0)
            {
                Console.WriteLine($"There isn't enough space! {totalPeople} people in a queue!");
            }else if(!x && totalPeople == 0)
            {
                Console.WriteLine(String.Join(" ", LiftNow));
            }

            int peopleonTheLyft = 0;
            bool noMorePeople = false;
            bool noMoreSpace = false;

            for (int i = 0; i < LiftNow.Length; i++) // proverqvame vsichki vagoni
            {
                while (LiftNow[i] < 4 && totalPeople >0)
                {
                   
                    LiftNow[i]++;
                    totalPeople--;
                }
                if (totalPeople == 0)
                {

                    noMorePeople = true;
                    break;
                }
            }
            if (LiftNow.Sum() == LiftNow.Length * 4)
            {
                noMoreSpace = true;
            }
            if (totalPeople ==0  && noMoreSpace)
            {
                Console.WriteLine(String.Join(" ",LiftNow));
            }else if (noMoreSpace && !noMorePeople) 
            {
                Console.WriteLine($"There isn't enough space! {totalPeople} people in a queue!");
                Console.WriteLine(String.Join(" ", LiftNow));
            }
            else if(!noMoreSpace && noMorePeople)
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(String.Join(" ", LiftNow));
            }
        }
    }
}