using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Assignment_2
{
    internal class Assignment13
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.Write("Enter first number: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter third number: ");
            c = Convert.ToInt32(Console.ReadLine());

            int max = a;

            if (b > max) max = b;
            if (c > max) max = c;

            Console.WriteLine("Largest Number = " + max);
        }
    }
}
