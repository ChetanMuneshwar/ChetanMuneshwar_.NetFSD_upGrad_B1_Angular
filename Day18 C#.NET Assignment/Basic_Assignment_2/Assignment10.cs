using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Assignment_2
{
    internal class Assignment10
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1, c;

            while (a <= 40)
            {
                Console.WriteLine(a);
                c = a + b;
                a = b;
                b = c;
            }
        }
    }
}
