using System;
using System.Collections.Generic;
using System.Text;

namespace C__Class_Assignment
{
    class MedicalTest
    {
        // Fields
        public int TestId;
        public string TestName;
        public double TestCost;

        // Parameterized Constructor
        public MedicalTest(int id, string name, double cost)
        {
            TestId = id;
            TestName = name;
            TestCost = cost;
        }

        // Method to display test details
        public void Display()
        {
            Console.WriteLine("Test Id: " + TestId);
            Console.WriteLine("Test Name: " + TestName);
            Console.WriteLine("Test Cost: " + TestCost);
            Console.WriteLine();
        }
    }

    class Assignment5
    {
        static void Main(string[] args)
        {
            // Creating objects using parameterized constructor
            MedicalTest test1 = new MedicalTest(1, "Blood Test", 500);
            MedicalTest test2 = new MedicalTest(2, "X-Ray", 1200);

            // Displaying details
            test1.Display();
            test2.Display();

            Console.ReadLine();
        }
    }
}
