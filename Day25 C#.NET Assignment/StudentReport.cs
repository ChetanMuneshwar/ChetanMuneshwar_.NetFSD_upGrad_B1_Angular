using System;
using System.Collections.Generic;
using System.Text;

namespace file_Handeling_Assignment
{
    internal class StudentReport
    {
        static void Main()
        {
            int choice;

            do
            {
                Console.WriteLine("\n--- Student Report Card System ---");
                Console.WriteLine("1. Generate Report");
                Console.WriteLine("2. View Report");
                Console.WriteLine("3. Exit");
                Console.Write("Enter choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        GenerateReport();
                        break;
                    case 2:
                        ViewReport();
                        break;
                    case 3:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }

            } while (choice != 3);
        }

        // ✅ Generate Report
        static void GenerateReport()
        {
            try
            {
                Console.Write("Enter Student Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter Roll Number: ");
                string roll = Console.ReadLine();

                // Input validation for marks
                int m1 = GetValidMarks("Enter Marks for Subject 1: ");
                int m2 = GetValidMarks("Enter Marks for Subject 2: ");
                int m3 = GetValidMarks("Enter Marks for Subject 3: ");

                int total = m1 + m2 + m3;
                double average = total / 3.0;
                string grade = CalculateGrade(average);

                string content =
    $@"Student Name: {name}
Roll Number: {roll}
Marks: {m1}, {m2}, {m3}
Total: {total}
Average: {average:F2}
Grade: {grade}";

                string fileName = roll + ".txt";

                // Write file
                File.WriteAllText(fileName, content);

                Console.WriteLine("Report generated successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        // ✅ View Report
        static void ViewReport()
        {
            try
            {
                Console.Write("Enter Roll Number: ");
                string roll = Console.ReadLine();

                string fileName = roll + ".txt";

                if (File.Exists(fileName))
                {
                    string content = File.ReadAllText(fileName);
                    Console.WriteLine("\n--- Student Report ---");
                    Console.WriteLine(content);
                }
                else
                {
                    Console.WriteLine("Report not found!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        // ✅ Marks Validation
        static int GetValidMarks(string message)
        {
            int marks;

            while (true)
            {
                Console.Write(message);

                if (int.TryParse(Console.ReadLine(), out marks) && marks >= 0 && marks <= 100)
                    return marks;
                else
                    Console.WriteLine("Invalid input! Enter marks between 0 and 100.");
            }
        }

        // ✅ Grade Calculation
        static string CalculateGrade(double avg)
        {
            if (avg >= 75) return "A";
            else if (avg >= 60) return "B";
            else if (avg >= 50) return "C";
            else return "Fail";
        }
    }
}
