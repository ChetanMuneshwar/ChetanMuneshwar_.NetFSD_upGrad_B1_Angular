using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Assignment_1
{
    internal class Assignment6
    {
       static void Main()
        {
            double length, width, side;
            double rectArea, squareArea;

            Console.Write("Enter length of rectangle: ");
            length = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter width of rectangle: ");
            width = Convert.ToDouble(Console.ReadLine());

            rectArea = length * width;

            Console.WriteLine("Area of Rectangle = " + rectArea);

            Console.Write("Enter side of square: ");
            side = Convert.ToDouble(Console.ReadLine());

            squareArea = side * side;

            Console.WriteLine("Area of Square = " + squareArea);
        }
    }
}
