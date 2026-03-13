using System;
using System.Collections.Generic;
using System.Text;

namespace C__Class_Assignment
{
    class Hospital
    {
        // Static Variables (shared by all objects)
        public static string HospitalName;
        public static string HospitalAddress;

        // Instance Variable
        public string PatientName;
    }

    class Assignment3
    {
        static void Main(string[] args)
        {
            // Assign static values
            Hospital.HospitalName = "City Care Hospital";
            Hospital.HospitalAddress = "Pune, Maharashtra";

            // Creating patient objects
            Hospital p1 = new Hospital();
            p1.PatientName = "Ravi Kumar";

            Hospital p2 = new Hospital();
            p2.PatientName = "Sneha Reddy";

            Hospital p3 = new Hospital();
            p3.PatientName = "Amit Sharma";

            // Display details
            Console.WriteLine("Hospital Name: " + Hospital.HospitalName);
            Console.WriteLine("Hospital Address: " + Hospital.HospitalAddress);
            Console.WriteLine();

            Console.WriteLine("Patient 1 Name: " + p1.PatientName);
            Console.WriteLine("Patient 2 Name: " + p2.PatientName);
            Console.WriteLine("Patient 3 Name: " + p3.PatientName);

            Console.ReadLine();
        }
    }
}
