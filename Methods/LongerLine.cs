using System;

namespace LongerLine
{
    class LongerLine
    {
        static void Main(string[] args)
        {
            double firstX1 = double.Parse(Console.ReadLine());
            double firstY1 = double.Parse(Console.ReadLine());
            double firstX2 = double.Parse(Console.ReadLine());
            double firstY2 = double.Parse(Console.ReadLine());
            double secondX1 = double.Parse(Console.ReadLine());
            double secondY1 = double.Parse(Console.ReadLine());
            double secondX2 = double.Parse(Console.ReadLine());
            double secondY2 = double.Parse(Console.ReadLine());

            CalculateDistance(firstX1, firstY1, firstX2, firstY2, secondX1, secondY1, secondX2,  secondY2);
        }

        private static void CalculateDistance(double firstX1, double firstY1, double firstX2, double firstY2, double secondX1, double secondY1, double secondX2, double secondY2)
        {
            double firstPoint1 = Math.Sqrt(Math.Pow(firstX1, 2) + Math.Pow(firstY1, 2));

            double firstPoint2 = Math.Sqrt(Math.Pow(firstX2, 2) + Math.Pow(firstY2, 2));

            double firstLine = firstPoint1 + firstPoint2;

            double secondPoint1 = Math.Sqrt(Math.Pow(secondX1, 2) + Math.Pow(secondY1, 2));

            double secondPoint2 = Math.Sqrt(Math.Pow(secondX2, 2) + Math.Pow(secondY2, 2));

            double secondLine = secondPoint1 + secondPoint2;

            if (firstLine >= secondLine)
            {
                if (firstPoint1 <= firstPoint2)
                {
                    Console.WriteLine($"({firstX1}, {firstY1})({firstX2}, {firstY2})");
                }
                else
                {
                    Console.WriteLine($"({firstX2}, {firstY2})({firstX1}, {firstY1})");
                }
            }
            else
            {
                if (secondPoint1 <= secondPoint2)
                {
                    Console.WriteLine($"({secondX1}, {secondY1})({secondX2}, {secondY2})");
                }
                else
                {
                    Console.WriteLine($"({secondX2}, {secondY2})({secondX1}, {secondY1})");
                }
            }
        }
    }
}
