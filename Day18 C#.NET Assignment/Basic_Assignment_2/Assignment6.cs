using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Assignment_2
{
    class Assignment6
    {
        static void Main(string[] args)
        {
            double f, c;

            Console.Write("Enter temperature in Fahrenheit: ");
            f = Convert.ToDouble(Console.ReadLine());

            c = (f - 32) * 5 / 9;

            Console.WriteLine("Temperature in Celsius = " + c);
        }
    }
}
