using System;

namespace CenturesToMinutes
{
    class CenturesMinutes
    {
        static void Main(string[] args)
        {
            int centures = int.Parse(Console.ReadLine());

            int years = centures * 100;
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            int minutes = hours * 60;

            Console.WriteLine($"{centures} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");

        }
    }
}
