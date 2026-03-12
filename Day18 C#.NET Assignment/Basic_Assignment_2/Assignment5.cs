using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Assignment_2
{
    internal class Assignment5
    {
        static void Main(string[] args)
        {
            int n, num;
            int odd = 0, even = 0;

            Console.Write("Enter how many numbers: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Enter number: ");
                num = Convert.ToInt32(Console.ReadLine());

                if (num % 2 == 0)
                    even++;
                else
                    odd++;
            }

            Console.WriteLine("Total Even Numbers = " + even);
            Console.WriteLine("Total Odd Numbers = " + odd);
        }
    }
}
