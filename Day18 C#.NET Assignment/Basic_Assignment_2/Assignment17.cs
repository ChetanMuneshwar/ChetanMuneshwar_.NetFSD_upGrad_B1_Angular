using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Assignment_2
{
    internal class Assignment17
    {
        static void Main(string[] args)
        {
            Console.Write("Enter word: ");
            string word = Console.ReadLine();

            char[] arr = word.ToCharArray();
            Array.Reverse(arr);

            Console.WriteLine("Reverse = " + new string(arr));
        }
    }
}
