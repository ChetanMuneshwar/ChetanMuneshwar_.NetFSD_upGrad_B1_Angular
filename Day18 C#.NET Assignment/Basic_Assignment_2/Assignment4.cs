using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Assignment_2
{
    internal class Assignment4
    {
        static void Main(string[] args)
        {
            int num;

            Console.Write("Enter number: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
                Console.WriteLine("Even Number");
            else
                Console.WriteLine("Odd Number");
        }
    }
}
