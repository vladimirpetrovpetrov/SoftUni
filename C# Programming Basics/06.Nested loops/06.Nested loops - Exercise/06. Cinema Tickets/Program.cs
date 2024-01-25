using System;

namespace _06._Cinema_Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            
            var typeOfTicket = " ";
            var standard = 0.0;
            var kid = 0.0;
            var student = 0.0;
            var count = 0.0;
            var allBoughtTickets = 0.0;
            var allStandardTickets = 0.0;
            var allStudentTickets = 0.0;
            var allKidTickets = 0.0;
            bool noMoreTickets = false;
            while (true)
            {
                string nameOfTheMovie = Console.ReadLine();
                if(nameOfTheMovie == "Finish")
                {
                    Console.WriteLine($"Total tickets: {allBoughtTickets}");
                    Console.WriteLine($"{(allStudentTickets / allBoughtTickets)*100:f2}% student tickets.");
                    Console.WriteLine($"{(allStandardTickets/allBoughtTickets)*100:f2}% standard tickets.");
                    Console.WriteLine($"{(allKidTickets / allBoughtTickets)*100:f2}% kids tickets.");
                    return;
                }
                var freeSeats = int.Parse(Console.ReadLine());
                var freeSeatsCopy = freeSeats;
                while (freeSeatsCopy > 0 && typeOfTicket != "End")
                {
                    typeOfTicket = Console.ReadLine();
                    if(typeOfTicket == "End")
                    {
                        Console.WriteLine($"{nameOfTheMovie} - {(count / freeSeats) * 100:f2}% full.");
                        noMoreTickets = true;
                        typeOfTicket = " ";
                        break;
                    }
                    if (typeOfTicket == "standard")
                    {
                        standard++;
                        count++;
                    }
                    else if (typeOfTicket == "student")
                    {
                        student++;
                        count++;
                    }
                    else if (typeOfTicket == "kid")
                    {
                        kid++;
                        count++;

                    }
                    freeSeatsCopy--;
                }
                if (!noMoreTickets)
                {
                    Console.WriteLine($"{nameOfTheMovie} - {(count / freeSeats) * 100:f2}% full.");
                    typeOfTicket = " ";
                }
                
                allBoughtTickets += count;
                allStandardTickets += standard;
                allStudentTickets += student;
                allKidTickets += kid;


                count = 0;
                kid = 0;
                student = 0;
                standard = 0;
                noMoreTickets = false;
            }









        }
    }
}
