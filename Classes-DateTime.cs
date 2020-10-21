using System;
using System.Globalization;

namespace ConsoleObject
{
    class Trainig
    {
        static void Main(string[] args)
        {
            string inputDate = Console.ReadLine();

            string format = "d-M-yyyy";
            CultureInfo provider = CultureInfo.InvariantCulture;

            DateTime result;

            result = DateTime.ParseExact(inputDate, format, provider);
            Console.WriteLine(result.DayOfWeek);
        }
    }
}
