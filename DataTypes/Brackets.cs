using System;

namespace BalancedBrackets
{
    class Brackets
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int countOpenBrackets = 0;
            int countClosedBrackets = 0;

            for (int i = 0; i < n; i++)
            {
                string inputLine = Console.ReadLine();

                char openBracket = '(';
                char closedBracket = ')';
               

                if (inputLine.Contains(openBracket))
                {
                    countOpenBrackets++;
                }

                if (inputLine.Contains(closedBracket))
                {
                    countClosedBrackets++;
                    if (countOpenBrackets - countClosedBrackets != 0)
                    {
                        break;
                    }
                }
            }
            
            if (countOpenBrackets == countClosedBrackets)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
