using System;

namespace VendingMashine
{
    class Vending
    {
        static void Main(string[] args)
        {
            string moneyInput = Console.ReadLine();
            double inputAmound = 0;

            while (moneyInput != "Start")
            {
                double currentCoint = double.Parse(moneyInput);
                bool isValidMoney = currentCoint == 0.1 || 
                                    currentCoint == 0.2 || 
                                    currentCoint == 0.5 || 
                                    currentCoint == 1 || 
                                    currentCoint == 2;
                
                if (isValidMoney)
                {
                    inputAmound += currentCoint;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {currentCoint}");
                }

                moneyInput = Console.ReadLine();
            }
            string product = Console.ReadLine();

            while (product != "End")
            {
                double productPrice = 0;

                switch (product)
                {
                    case "Nuts":
                        productPrice = 2.0;
                        break;
                    case "Water":
                        productPrice = 0.7;
                        break;
                    case "Crisps":
                        productPrice = 1.5;
                        break;
                    case "Soda":
                        productPrice = 0.8;
                        break;
                    case "Coke":
                        productPrice = 1.0;
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        product = Console.ReadLine();
                        continue;
                }

                if (productPrice <= inputAmound)
                {
                    inputAmound -= productPrice;
                    Console.WriteLine($"Purchased {product.ToLower()}");
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                product = Console.ReadLine();
            }
            Console.WriteLine($"Change: {inputAmound:F2}");
        }
    }
}
