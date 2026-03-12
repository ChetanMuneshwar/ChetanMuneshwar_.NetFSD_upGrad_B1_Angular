using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Assignment_1
{
    internal class Assignment2
    {
       static void Main(string[] args)
        {
            double km, meters;

            Console.Write("Enter Distance in km : ");
            km = Convert.ToDouble(Console.ReadLine());

            meters = km * 1000;
            Console.WriteLine(km + "km is converted into "+meters+"Meters");
        }
    }
}
