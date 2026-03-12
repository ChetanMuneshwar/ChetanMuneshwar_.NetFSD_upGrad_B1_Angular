using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Assignment_2
{
    internal class Assignment9
    {
        static void Main(string[] args)
        {
            int num;
            long fact = 1;

            Console.Write("Enter number: ");
            num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                fact = fact * i;
            }

            Console.WriteLine("Factorial = " + fact);
        }
    }
}
