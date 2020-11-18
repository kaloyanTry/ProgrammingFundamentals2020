using System;

namespace RefactorVolumeOfPyramid
{
    class RefactorPyramid
    {
        static void Main(string[] args)
        {
            Console.Write("Length: ");
            double lengthOfPyramid = double.Parse(Console.ReadLine());

            Console.Write("Width: ");
            double widthOfPyramid = double.Parse(Console.ReadLine());

            Console.Write("Height: ");
            double heigthOfPyramid = double.Parse(Console.ReadLine());

            double volumeOfPiramid = (lengthOfPyramid * widthOfPyramid * heigthOfPyramid) / 3;

            Console.Write($"Pyramid Volume: {volumeOfPiramid:f2}");
        }
    }
}
