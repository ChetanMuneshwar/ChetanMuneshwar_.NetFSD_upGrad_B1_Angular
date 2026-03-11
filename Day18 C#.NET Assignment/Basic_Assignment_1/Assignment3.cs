using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Assignment_1
{
    internal class Assignment3
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, n4, n5, sum, avg;

            Console.Write("Enter first number: ");
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            n2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter third number: ");
            n3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter fourth number: ");
            n4 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter fifth number: ");
            n5 = Convert.ToDouble(Console.ReadLine());

            sum = n1 + n2 + n3 + n4 + n5;
            avg = sum / 5;
            Console.WriteLine();
            Console.WriteLine("Sum = " + sum);
            Console.WriteLine("Average = " + avg);
        }
    }
}
