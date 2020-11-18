using System;

namespace TypeExercise
{
    class Exercise
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int litersInTank = 0;

            for (int i = 0; i < n; i++)
            {
                int liters = int.Parse(Console.ReadLine());

                if (litersInTank + liters > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }
                litersInTank += liters;
            }
            Console.WriteLine(litersInTank);
        }
    }
}
