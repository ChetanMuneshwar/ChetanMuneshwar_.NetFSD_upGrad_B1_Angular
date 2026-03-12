using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Assignment_2
{
    internal class Assignment19
    {
        static void Main(string[] args)
        {
            Console.Write("Enter word: ");
            string word = Console.ReadLine();
            string rev = "";

            for (int i = word.Length - 1; i >= 0; i--)
            {
                rev += word[i];
            }

            if (word.Equals(rev))
                Console.WriteLine("Palindrome");
            else
                Console.WriteLine("Not Palindrome");
        }
    }
}
