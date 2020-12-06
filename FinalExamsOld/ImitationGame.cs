using System;
using System.Text;

namespace ImitaitonGame
{
    class ImitationGame
    {
        static void Main(string[] args)
        {
            string encryptedMessage = Console.ReadLine();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Decode")
            {
                string[] inputData = input.Split('|');
                string command = inputData[0];

                if (command == "Move")
                {
                    int nLetters = int.Parse(inputData[1]);
                    string subString = encryptedMessage.Substring(0, nLetters);
                    encryptedMessage = encryptedMessage.Remove(0, nLetters);
                    encryptedMessage = encryptedMessage + subString;
                }
                else if (command == "Insert")
                {
                    int index = int.Parse(inputData[1]);
                    string insertValue = inputData[2];

                    encryptedMessage = encryptedMessage.Insert(index, insertValue);
                }
                else if (command == "ChangeAll")
                {
                    string oldString = inputData[1];
                    string newString = inputData[2];

                    encryptedMessage = encryptedMessage.Replace(oldString, newString);
                }
            }

            Console.WriteLine($"The decrypted message is: {encryptedMessage}");
        }
    }
}
