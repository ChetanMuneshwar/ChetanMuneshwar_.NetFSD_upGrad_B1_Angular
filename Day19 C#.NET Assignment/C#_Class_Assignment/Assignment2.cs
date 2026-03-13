using System;
using System.Collections.Generic;
using System.Text;

namespace C__Class_Assignment
{
    class Doctor
    {
        // Instance Variables
        public int DoctorId;
        public string DoctorName;
        public string Specialization;
        public double ConsultationFee;
    }

    class Assignment2
    {
        static void Main(string[] args)
        {
            // Creating first doctor object
            Doctor d1 = new Doctor();
            d1.DoctorId = 1;
            d1.DoctorName = "Dr. Amit Sharma";
            d1.Specialization = "Cardiologist";
            d1.ConsultationFee = 800;

            // Creating second doctor object
            Doctor d2 = new Doctor();
            d2.DoctorId = 2;
            d2.DoctorName = "Dr. Neha Patel";
            d2.Specialization = "Dermatologist";
            d2.ConsultationFee = 600;

            // Printing first doctor details
            Console.WriteLine("Doctor 1 Details:");
            Console.WriteLine("Doctor Id: " + d1.DoctorId);
            Console.WriteLine("Doctor Name: " + d1.DoctorName);
            Console.WriteLine("Specialization: " + d1.Specialization);
            Console.WriteLine("Consultation Fee: " + d1.ConsultationFee);

            Console.WriteLine();

            // Printing second doctor details
            Console.WriteLine("Doctor 2 Details:");
            Console.WriteLine("Doctor Id: " + d2.DoctorId);
            Console.WriteLine("Doctor Name: " + d2.DoctorName);
            Console.WriteLine("Specialization: " + d2.Specialization);
            Console.WriteLine("Consultation Fee: " + d2.ConsultationFee);

            Console.ReadLine();
        }
    }
}
