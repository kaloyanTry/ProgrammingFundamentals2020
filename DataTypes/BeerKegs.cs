using System;

namespace BeerKegs
{
    class BeerKegs
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double volumeMax = 0;
            string kegMax = string.Empty;

            for (int i = 1; i <= n; i++)
            {
                string modelOfKeg = Console.ReadLine();
                
                double radiusKeg = double.Parse(Console.ReadLine());
                
                int heghtKeg = int.Parse(Console.ReadLine());
                
                double volumeOfKeg = Math.PI * radiusKeg * radiusKeg * heghtKeg;

                if (volumeOfKeg > volumeMax)
                {
                    volumeMax = volumeOfKeg;
                    kegMax = modelOfKeg;
                }
            }

            Console.WriteLine(kegMax);
        }
    }
}
