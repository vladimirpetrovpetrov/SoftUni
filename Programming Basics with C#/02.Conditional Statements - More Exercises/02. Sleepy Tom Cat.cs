using System;

namespace Training
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pochivniDni = int.Parse(Console.ReadLine());

            var dniZaIgra = 365 - pochivniDni;
            var obshto = pochivniDni * 127 + dniZaIgra * 63;

            if (obshto > 30000)
            {
                var razlika = obshto - 30000;
                var chasove = razlika / 60;
                var minuti = razlika % 60;
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", chasove, minuti);
            }
            else
            {
                var razlika = 30000 - obshto;
                var chasove = razlika / 60;
                var minuti = razlika % 60;
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", chasove, minuti);
            }





        }
    }
}