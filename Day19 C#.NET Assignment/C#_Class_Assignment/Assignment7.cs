using System;
using System.Collections.Generic;
using System.Text;

namespace C__Class_Assignment
{
    class Nurse
    {
        // Properties
        public int NurseId { get; set; }
        public string NurseName { get; set; }
        public string Department { get; set; }
    }

    class Assignment7
    {
        static void Main(string[] args)
        {
            // Creating object
            Nurse n1 = new Nurse();

            // Assigning values
            n1.NurseId = 1;
            n1.NurseName = "Anita Sharma";
            n1.Department = "Emergency";

            // Displaying nurse information
            Console.WriteLine("Nurse Id: " + n1.NurseId);
            Console.WriteLine("Nurse Name: " + n1.NurseName);
            Console.WriteLine("Department: " + n1.Department);

            Console.ReadLine();
        }
    }
}
