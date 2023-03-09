using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Parking_Validation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var licensePlateInfo = new Dictionary<string, string>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().ToList();
                if (input[0] == "register")
                {
                    var licenceNumber = input[2];
                    var username = input[1];

                    if (licensePlateInfo.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlateInfo[username]}");
                        continue;
                    }


                    if (input[2].Length != 8)
                    {
                        Console.WriteLine($"ERROR: invalid license plate {licenceNumber}");
                        continue;
                    }
                    var validLetters = input[2].Take(2).All(c => c >= 'A' && c <= 'Z');
                    var validLetters2 = input[2].Skip(6).Take(2).All(c => c >= 'A' && c <= 'Z');
                    var validL = validLetters && validLetters2;
                    if (!validL)
                    {
                        Console.WriteLine($"ERROR: invalid license plate {licenceNumber}");
                        continue;
                    }

                    var numbersInPlate = input[2].Skip(2).Take(4).All((n => n >= '0' && n <= '9'));
                    if (!numbersInPlate)
                    {
                        Console.WriteLine($"ERROR: invalid license plate {licenceNumber}");
                        continue;
                    }


                    if (licensePlateInfo.ContainsValue(licenceNumber))
                    {
                        Console.WriteLine($"ERROR: license plate {licenceNumber} is busy");
                        continue;
                    }
                    licensePlateInfo[username] = licenceNumber;
                    Console.WriteLine($"{username} registered {licenceNumber} successfully");


                }
                else if (input[0] == "unregister")
                {
                    var username = input[1];
                    if (!licensePlateInfo.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                        continue;
                    }
                    licensePlateInfo.Remove(username);
                    Console.WriteLine($"user {username} unregistered successfully");

                }
            }
            foreach (var item in licensePlateInfo)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
