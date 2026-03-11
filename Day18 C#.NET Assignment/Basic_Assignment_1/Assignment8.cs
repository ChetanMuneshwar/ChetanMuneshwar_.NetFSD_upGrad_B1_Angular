    using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Assignment_1
{
    internal class Assignment8
    {
        static void Main()
        {
            string str;
            char ch;

            Console.Write("Enter a string: ");
            str = Console.ReadLine();

            ch = str[2];

            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' ||
                ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine("Third character is a Vowel");
            }
            else
            {
                Console.WriteLine("Third character is a Consonant");
            }
        }
     }
}
