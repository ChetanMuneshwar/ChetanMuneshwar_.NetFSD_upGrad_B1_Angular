using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Assignment_1
{
    internal class Assignment4
    {
        static void Main(string[] args)
        {
            int num;

            Console.Write("Enter a Number : ");
            num = Convert.ToInt32(Console.ReadLine());

            if ((num / 2) * 2 == num) 
            Console.WriteLine(num + " is even");
            else 
            Console.WriteLine(num + " is odd");
        }
    }
}
