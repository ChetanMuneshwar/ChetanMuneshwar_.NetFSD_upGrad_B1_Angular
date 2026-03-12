using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Assignment_1
{
    internal class Assignment7
    {
        static void Main()
        {
            double distance, speed, time;

            Console.Write("Enter distance: ");
            distance = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter speed: ");
            speed = Convert.ToDouble(Console.ReadLine());

            time = distance / speed;

            Console.WriteLine("Time taken = " + time);
        }
    }
}
