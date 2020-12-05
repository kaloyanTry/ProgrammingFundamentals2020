using System;

namespace WordTour
{
    class Program
    {
        static void Main(string[] args)
        {
            string planTravel = Console.ReadLine();

            string input = Console.ReadLine();
            while (input != "Travel")
            {
                string[] inputData = input.Split(':');
                string command = inputData[0];

                if (command == "Add Stop")
                {
                    int index = int.Parse(inputData[1]);
                    string insertString = inputData[2];

                    if (index >= 0 && index < planTravel.Length)
                    {
                        planTravel = planTravel.Insert(index, insertString);
                    }
                    Console.WriteLine(planTravel);
                }
                else if (command == "Remove Stop")
                {
                    int startIndex = int.Parse(inputData[1]);
                    int endIndex = int.Parse(inputData[2]);
                    bool isValid = (startIndex >= 0 && startIndex < planTravel.Length)  && (endIndex > 0 && endIndex <= planTravel.Length - 1);
                    if (isValid)
                    {
                        planTravel = planTravel.Remove(startIndex, endIndex + 1 - startIndex);  
                    }
                    Console.WriteLine(planTravel);
                }
                else if (command == "Switch")
                {
                    string oldString = inputData[1];
                    string newString = inputData[2];

                    if (planTravel.Contains(oldString))
                    {
                        planTravel = planTravel.Replace(oldString, newString);
                        
                    }
                    Console.WriteLine(planTravel);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {planTravel}");
        }
    }
}
