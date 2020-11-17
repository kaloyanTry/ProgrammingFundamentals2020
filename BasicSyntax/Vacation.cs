using System;
using System.Globalization;

namespace VacationGroup
{
    class Vacation
    {
        static void Main(string[] args)
        {
            int numOfPeople = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string day = Console.ReadLine();

            double totalPrice = 0;

            if (typeOfGroup == "Students")
            {
                switch (day)
                {
                    case "Friday":
                        totalPrice = numOfPeople * 8.45;
                        break;
                    case "Saturday":
                        totalPrice = numOfPeople * 9.80;
                        break;
                    case "Sunday":
                        totalPrice = numOfPeople * 10.46;
                        break;
                }

                if (numOfPeople >= 30)
                {
                    totalPrice *= 0.85;
                }
            }
            else if (typeOfGroup == "Business")
            {
                if (numOfPeople >= 100)
                {
                    numOfPeople -= 10;
                }
                switch (day)
                {
                    case "Friday":
                        totalPrice = numOfPeople * 10.90;
                        break;
                    case "Saturday":
                        totalPrice = numOfPeople * 15.60;
                        break;
                    case "Sunday":
                        totalPrice = numOfPeople * 16.00;
                        break;
                }
            }
            else if (typeOfGroup == "Regular")
            {
                switch (day)
                {
                    case "Friday":
                        totalPrice = numOfPeople * 15.00;
                        break;
                    case "Saturday":
                        totalPrice = numOfPeople * 20.00;
                        break;
                    case "Sunday":
                        totalPrice = numOfPeople * 22.50;
                        break;
                }
                if (numOfPeople >= 10 && numOfPeople <= 20)
                {
                    totalPrice *= 0.95;
                }
            }
            Console.WriteLine($"Total price: {totalPrice:F2}");
        }
    }
}
