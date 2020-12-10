using System;
using System.Text;

namespace MultiplyBigNumber
{
    class BigNum
    {
        static void Main(string[] args)
        {
            string n1 = Console.ReadLine();
            int n2 = int.Parse(Console.ReadLine());

            if (n2 == 0)
            {
                Console.WriteLine(0);
                return;
            }
            while (n1[0] == '0')
            {
                n1 = n1.Substring(1);
            }

            StringBuilder sb = new StringBuilder();
            int reminder = 0;

            for (int i = n1.Length - 1; i >= 0; i--)
            {
                int result = int.Parse(n1[i].ToString()) * n2 + reminder;
                reminder = 0;

                if (result > 0)
                {
                    reminder = result / 10;
                    result = result % 10;
                }
                sb.Append(result);
            }

            if (reminder != 0)
            {
                sb.Append(reminder);
            }

            StringBuilder finalResult = new StringBuilder();
            for (int i = sb.Length - 1; i >= 0; i--)
            {
                finalResult.Append(sb[i]);
            }

            Console.WriteLine(finalResult);
        }
    }
}
