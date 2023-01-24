using System;
namespace Crack_a_password__recursive_backtracking_
    
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine(Crack(5));
        }

        public static string Crack(int length)
        {
            return Crackhlpr(length, "");
        }

        public static string Crackhlpr(int length, string password)
        {
            
            if (Login(password))
            {
                return password;
            }
            else if (length == 0)
            {
                return "";
            }
            for (char i = 'a'; i <= 'z'; i++)
            {
                string found = Crackhlpr(length - 1, password + i);
                if (found != "")
                {
                    return found;
                }
                found = Crackhlpr(length - 1, password + char.ToUpper(i));
                if (found != "")
                {
                    return found;
                }
            }
            return "";

        }
        public static  bool Login(string password)
        {
            if (password == "vikii")
            {
                return true;
            }
            else { return false; }
        }
    }

}
