using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Assignment_2
{
    internal class Assignment11
    {
        static void Main(string[] args)
        {
            int num;

            Console.Write("Enter number: ");
            num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine(num + " x " + i + " = " + num * i);
            }
        }
    }
}
