using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Assignment_2
{
    internal class Assignment3
    {
        static void Main(string[] args)
        {
            int num1 = Convert.ToInt32(args[0]);
            int num2 = Convert.ToInt32(args[1]);

            for (int i = num1 + 1; i < num2; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
