using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06._User_Logs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IP> iPs = new List<IP>();
            List<User> users = new List<User>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "end")
                {
                    break;//dict < username,Class( Dict<IP,Колко пъти)>
                }
                var ipAddress = input.Split(" ", StringSplitOptions.RemoveEmptyEntries)[0][3..];
                var message = input.Split(" ", StringSplitOptions.RemoveEmptyEntries)[1][8..];
                var user = input.Split(" ", StringSplitOptions.RemoveEmptyEntries)[2][5..];

                bool userExist = users.Any(x => x.Username == user);// check if username exist
                bool ipAddressExist = iPs.Any(x => x.IpTimes.ContainsKey(ipAddress)); // чеква дали IP-то съществува въобще, не само за юзъра , а въобще дали някой е изпращал досега от това IP

                //ако съществува IP-то , то да проверим дали съществува за конкретния USER и да проверим дали това въобще е нужно от условието

                if (!userExist)
                {
                    IP ip = new IP(); //инициализираме ново ИП
                    ip.IpTimes.Add(ipAddress, 1); // създаваме ново ИП с адреса му и че е изпратено 1 съобщение от него за момента
                    User newUser = new User(user, ip); //създаваме и нов юзър
                    users.Add(newUser);
                }
                else //ако юзъра съществува
                {
                    var currentUser = users.Find(x => x.Username == user);
                    var ipExistForCurrentUser = currentUser.Ip.IpTimes.ContainsKey(ipAddress); //показва дали юзъра е пращал съобщения от това ИП.

                    if (!ipExistForCurrentUser) //ако не му съществува ИП-то
                    {
                        currentUser.Ip.IpTimes[ipAddress] = 1;
                    }
                    else
                    {
                        currentUser.Ip.IpTimes[ipAddress]++;
                    }
                }
            }

            users = users.OrderBy(x => x.Username).ToList();
            foreach (var item in users)
            {
                Console.WriteLine($"{item}\n {item.Ip}");
            }







        }
    }
    public class IP
    {
        public Dictionary<string, int> IpTimes { get; set; } //IP address - times
        public IP()
        {
            this.IpTimes = new Dictionary<string, int>();
        }
        public override string ToString()
        {
            StringBuilder st = new StringBuilder();

            foreach (var (key, value) in IpTimes)
            {
                var lastKey = IpTimes.Last().Key;
                if (!(lastKey == key))
                {
                    st.Append($"{key} => {value}, ");
                }
                else
                {
                    st.Append($"{key} => {value}.");
                }
            }
            return st.ToString().TrimEnd('\n');

        }
    }
    public class User
    {
        public string Username { get; set; }
        public IP Ip { get; set; }
        public User(string username, IP ip)
        {
            this.Username = username;
            this.Ip = ip;
        }
        public override string ToString()
        {
            return $"{this.Username}:";
        }
    }
}
