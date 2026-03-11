using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Assignment_1
{
    internal class Assignment1
    {
        static void Main(string[] args)
        {
            double num1, num2, quotient;

            Console.WriteLine("Enter a num1 : ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter a num2 : ");
            num2 = Convert.ToDouble(Console.ReadLine());

            quotient = num1 / num2;
            Console.WriteLine("quotient : "+quotient);
        }
    }
}
