using System;
using System.Linq;

namespace CeaserCipher
{
    class EncrypetText
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string encrypetText = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                encrypetText += (char)(input[i] + 3);
            }

            Console.WriteLine(encrypetText.ToString());


            //second:
            //char[] outText = Console.ReadLine().Select(x => x + 3).Select(x => (char)x).ToArray();
            //Console.WriteLine(string.Join("", outText));
        }
    }
}
