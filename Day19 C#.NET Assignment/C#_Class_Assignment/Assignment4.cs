using System;
using System.Collections.Generic;
using System.Text;

namespace C__Class_Assignment
{
    class Appointment
    {
        // Properties
        public int AppointmentId;
        public string PatientName;
        public string DoctorName;
        public DateTime AppointmentDate;

        // Default Constructor
        public Appointment()
        {
            DoctorName = "General Physician";
            AppointmentDate = DateTime.Today;
        }
    }

    class Assignment4
    {
        static void Main(string[] args)
        {
            // Creating object
            Appointment a1 = new Appointment();

            // Assigning remaining values
            a1.AppointmentId = 201;
            a1.PatientName = "Ravi Kumar";

            // Displaying details
            Console.WriteLine("Appointment Id: " + a1.AppointmentId);
            Console.WriteLine("Patient Name: " + a1.PatientName);
            Console.WriteLine("Doctor Name: " + a1.DoctorName);
            Console.WriteLine("Appointment Date: " + a1.AppointmentDate.ToShortDateString());

            Console.ReadLine();
        }
    }
}
