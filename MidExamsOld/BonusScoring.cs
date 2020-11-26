using System;

namespace _1.BonusScoringSystem
{
    class BonusScoring
    {
        static void Main(string[] args)
        {
            int countOfStudents = int.Parse(Console.ReadLine());
            int countOfLectures = int.Parse(Console.ReadLine());
            int initialBonus = int.Parse(Console.ReadLine());

            double maxBonus = 0;
            int maxAttendences = 0;

            for (int i = 1; i <= countOfStudents; i++)
            {
                int attendances = int.Parse(Console.ReadLine());

                double totalBonus = (attendances / (double)countOfLectures) * (5 + initialBonus);

                if (totalBonus > maxBonus)
                {
                    maxBonus = totalBonus;
                    maxAttendences = attendances;
                }
            }

            Console.WriteLine($"Max Bonus: {Math.Round(maxBonus)}.");
            Console.WriteLine($"The student has attended {maxAttendences} lectures.");
        }
    }
}
