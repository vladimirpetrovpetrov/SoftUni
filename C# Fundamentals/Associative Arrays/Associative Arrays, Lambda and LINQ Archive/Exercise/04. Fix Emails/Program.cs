using System;
using System.Collections.Generic;

namespace _04._Fix_Emails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var emails = new Dictionary<string,string>();
            while (true)
            {
                var name = Console.ReadLine();
                if(name == "stop")
                {
                    break;
                }
                var email = Console.ReadLine();

                if (!emails.ContainsKey(name))
                {
                    emails.Add(name, email);
                }
                else
                {
                    emails[name] = email;
                }
            }

            foreach (var (key,value) in emails)
            {
                if(value.ToLower().EndsWith("us") || value.EndsWith("uk"))
                {
                    emails.Remove(key);
                }
            }
            foreach (var (key,value) in emails)
            {
                Console.WriteLine($"{key} -> {value}");
            }
        }
    }
}
