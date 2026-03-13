using System;
using System.Collections.Generic;
using System.Text;

namespace C__Class_Assignment
{
    class PatientRecord
    {
        // Static Variable
        public static string HospitalName;

        // Properties
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public int Age { get; set; }
        public string Disease { get; set; }

        // Parameterized Constructor
        public PatientRecord(int id, string name, int age, string disease)
        {
            PatientId = id;
            PatientName = name;
            Age = age;
            Disease = disease;
        }

        // Method to display patient record
        public void DisplayPatientRecord()
        {
            Console.WriteLine("Hospital: " + HospitalName);
            Console.WriteLine("Patient Id: " + PatientId);
            Console.WriteLine("Name: " + PatientName);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Disease: " + Disease);
            Console.WriteLine();
        }
    }

    class Assignment8
    {
        static void Main(string[] args)
        {
            // Set static hospital name
            PatientRecord.HospitalName = "Apollo Hospital";

            // Create patient objects
            PatientRecord p1 = new PatientRecord(101, "Ravi", 40, "Fever");
            PatientRecord p2 = new PatientRecord(102, "Sneha", 35, "Diabetes");
            PatientRecord p3 = new PatientRecord(103, "Amit", 50, "Blood Pressure");

            // Display patient records
            p1.DisplayPatientRecord();
            p2.DisplayPatientRecord();
            p3.DisplayPatientRecord();

            Console.ReadLine();
        }
    }
}
