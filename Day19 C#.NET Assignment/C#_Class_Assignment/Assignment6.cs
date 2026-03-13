using System;
using System.Collections.Generic;
using System.Text;

namespace C__Class_Assignment
{
    class Billing
    {
        // Fields
        public string PatientName;
        public double ConsultationFee;
        public double TestCharges;

        // Method to calculate total bill
        public double CalculateTotalBill()
        {
            double total = ConsultationFee + TestCharges;
            return total;
        }
    }

    class Assignment6
    {
        static void Main(string[] args)
        {
            // Creating object
            Billing bill = new Billing();

            // Assigning values
            bill.PatientName = "Ramesh";
            bill.ConsultationFee = 500;
            bill.TestCharges = 1000;

            // Calling method
            double totalBill = bill.CalculateTotalBill();

            // Displaying output
            Console.WriteLine("Patient Name: " + bill.PatientName);
            Console.WriteLine("Total Bill: " + totalBill);

            Console.ReadLine();
        }
    }
}
