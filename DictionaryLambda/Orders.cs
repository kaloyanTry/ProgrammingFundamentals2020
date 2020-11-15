using System;
using System.Collections.Generic;

namespace Orders
{
    class Orders
    {
        static void Main(string[] args)
        {
            var products = new Dictionary<string, Product>();
            
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "buy")
                {
                    break;
                }

                string[] splitedInput = input.Split();
                string productName = splitedInput[0];
                double productPrice = double.Parse(splitedInput[1]);
                int productQuantity = int.Parse(splitedInput[2]);

                Product product = new Product(productName, productPrice, productQuantity);

                if (!products.ContainsKey(productName))
                {
                    products.Add(productName, product);
                }
                else
                {
                    products[productName].Price = productPrice;
                    products[productName].Quantity += productQuantity;
                }
            }

            foreach (var pair in products)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value.Price * pair.Value.Quantity:f2}");
            }
        }
    }
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
    }
}
