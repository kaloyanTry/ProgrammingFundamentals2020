using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace StoreBox
{
    class StoreBoxes
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] inputArray = input.Split();

                boxes.Add(new Box(inputArray));

                input = Console.ReadLine();
            }

            foreach (var box in boxes.OrderByDescending(b => b.PriceForBox))
            {
                Console.WriteLine($"{box.BoxSerialNumber}");
                Console.WriteLine($"-- {box.BoxItem.ItemName} - ${box.BoxItem.ItemPrice:F2}: {box.BoxQuantity}");
                Console.WriteLine($"-- ${box.PriceForBox:F2}");
            }
        }
    }

    class Item
    {
        public string ItemName { get; set; }
        public decimal ItemPrice { get; set; }
        public Item(string itemName, decimal itemPrice)
        {
            this.ItemName = itemName;
            this.ItemPrice = itemPrice;
        }
    }
    class Box
    {
        public string BoxSerialNumber { get; set; }
        public Item BoxItem { get; set; }
        public int BoxQuantity { get; set; }
        public decimal PriceForBox { get; set; }

        public Box(string[] boxInfo)
        {
            this.BoxSerialNumber = boxInfo[0];
            this.BoxQuantity = int.Parse(boxInfo[2]);

            string boxItemName = boxInfo[1];
            decimal boxItemPrice = decimal.Parse(boxInfo[3]);

            this.BoxItem = new Item(boxItemName, boxItemPrice);
            this.PriceForBox = BoxQuantity * BoxItem.ItemPrice;
        }
    }
}
