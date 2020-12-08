using System;
using System.Linq;

namespace ExtractFiles
{
    class ExtractFiles
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('\\');

            string[] file = input[input.Length - 1].Split('.');

            Console.WriteLine($"File name: {file[0]}");
            Console.WriteLine($"File extension: {file[1]}");

            //string inputLast = input.Last();
            //string[] fileNameExtansion = inputLast.Split('.');
            //string fileName = fileNameExtansion[0];
            ////string fileExtension = fileNameExtansion[1];
            //Console.WriteLine($"File name: {fileName}");
            //Console.WriteLine($"File extension: {fileExtension}");

        }
    }
}
