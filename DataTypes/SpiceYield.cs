using System;

namespace SpiceFlow
{
    class SpiceYield
    {
        static void Main(string[] args)
        {
            int startYield = int.Parse(Console.ReadLine());
            int day = 0;
            int totalYield = 0;
            int crewConsumes = 26;
            if (startYield < 100)
            {
                Console.WriteLine(day);
                Console.WriteLine(totalYield);
            }
            else
            {
                while (startYield >= 100)
                {
                    totalYield += startYield;
                    totalYield -= crewConsumes;

                    if (totalYield < 26)
                    {
                        crewConsumes = totalYield;
                    }

                    startYield -= 10;
                    day++;
                }
                totalYield -= 26;
                Console.WriteLine(day);
                Console.WriteLine(totalYield);

            }
        }
    }
}
