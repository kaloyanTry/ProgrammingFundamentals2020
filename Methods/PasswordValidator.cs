using System;

namespace PassValidator
{
    class PasswordValidator
    {
        static void Main(string[] args)
        {
            string inputPass = Console.ReadLine();
            ValidatePass(inputPass);
        }

        static void ValidatePass(string inputPass)
        {
            bool checkInvalid = false;
            if (inputPass.Length < 6 || inputPass.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                checkInvalid = true;
            }
            if (checkValidInput(inputPass) == false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
                checkInvalid = true;
            }
            if (countNumOfDigits(inputPass) < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
                checkInvalid = true;
            }
            if (checkInvalid == false)
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool checkValidInput(string inputPass)
        {
            for (int i = 0; i < inputPass.Length; i++)
            {
                char currentChar = inputPass[i];
                if (!((currentChar >= 48 && currentChar <= 57) 
                    || (currentChar >= 65 && currentChar <= 90)
                    || (currentChar >= 97 && currentChar <= 122)))
                {
                    return false;
                }
            }
            return true;
        }

        static int countNumOfDigits(string inputPass)
        {
            int digitsCount = 0;
            for (int i = 0; i < inputPass.Length; i++)
            {
                if (inputPass[i] >= 48 && inputPass[i] <= 57)
                {
                    digitsCount++;
                }
            }
            return digitsCount;
        }
    }
}
