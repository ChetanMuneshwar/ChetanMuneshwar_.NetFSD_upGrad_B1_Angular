using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Assignment_2
{
    internal class Assignment7
    {
        static void Main(string[] args)
        {
            int product, quantity;
            double price = 0;

            Console.Write("Enter product number (1-3): ");
            product = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter quantity: ");
            quantity = Convert.ToInt32(Console.ReadLine());

            switch (product)
            {
                case 1: price = 22.5; break;
                case 2: price = 44.5; break;
                case 3: price = 9.98; break;
                default: Console.WriteLine("Invalid product"); break;
            }

            Console.WriteLine("Total Price = " + price * quantity);
        }
    }
}
