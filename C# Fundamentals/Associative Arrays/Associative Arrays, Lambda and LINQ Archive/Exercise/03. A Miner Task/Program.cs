using System;
using System.Collections.Generic;

namespace _03._A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string,int>();
            while (true)
            {
                var resourse = Console.ReadLine();
                if(resourse == "stop")
                {
                    break;
                }
                var quantity = int.Parse(Console.ReadLine());
                if (!dict.ContainsKey(resourse))
                {
                    dict[resourse] = quantity;
                }
                else
                {
                    dict[resourse] += quantity;
                }
            }
            foreach (var (key,value) in dict)
            {
                Console.WriteLine($"{key} -> {value}");
            }
        }
        
	

	
    }
}
