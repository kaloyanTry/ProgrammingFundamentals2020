using System;

namespace MultiplicationSign
{
    class MultySign
    {
        static void Main(string[] args)
        {
            int negativeCounter = 0;
            bool isZero = false;

            for (int i = 0; i < 3; i++)
            {
                double currentNum = double.Parse(Console.ReadLine());

                if (currentNum < 0)
                {
                    negativeCounter++;
                }
                if (currentNum == 0)
                {
                    isZero = true;
                }
            }

            if (isZero)
            {
                Console.WriteLine("zero");
            }
            else if (negativeCounter % 2 != 0)
            {
                Console.WriteLine("negative");
            }
            else
            {
                Console.WriteLine("positive");
            }
        }
    }
}
