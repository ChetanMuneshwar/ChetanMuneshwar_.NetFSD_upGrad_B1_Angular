using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Assignment_2
{
    internal class Assignment14
    {
        static void Main(string[] args)
        {
            int min = int.MaxValue;

            for (int i = 1; i <= 5; i++)
            {
                Console.Write("Enter number: ");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num < min)
                    min = num;
            }

            Console.WriteLine("Smallest Number = " + min);
        }
    }
}
