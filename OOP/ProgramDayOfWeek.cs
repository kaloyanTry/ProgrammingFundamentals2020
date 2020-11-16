using System;
using System.Globalization;

namespace DayOfWeek
{
    class ProgramDayOfWeek
    {
        static void Main(string[] args)
        {
            string dataInput = Console.ReadLine();

            DateTime dayOfWeek = DateTime.ParseExact(dataInput, "d-MM-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(dayOfWeek.DayOfWeek);
        }
    }
}
