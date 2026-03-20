using System;
using System.Collections.Generic;
using System.Text;

namespace file_Handeling_Assignment
{
    internal class EmployeeLogSystem
    {
        static string filePath = "employee_log.txt";

        static void Main()
        {
            int choice;

            do
            {
                Console.WriteLine("\n--- Employee Log System ---");
                Console.WriteLine("1. Add Login Entry");
                Console.WriteLine("2. Update Logout Time");
                Console.WriteLine("3. View Logs");
                Console.WriteLine("4. Exit");
                Console.Write("Enter choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddLogin();
                        break;
                    case 2:
                        UpdateLogout();
                        break;
                    case 3:
                        ViewLogs();
                        break;
                    case 4:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }

            } while (choice != 4);
        }

        // ✅ Add Login Entry
        static void AddLogin()
        {
            try
            {
                Console.Write("Enter Employee ID: ");
                string id = Console.ReadLine();

                Console.Write("Enter Name: ");
                string name = Console.ReadLine();

                string loginTime = DateTime.Now.ToString();
                string logoutTime = "NA";

                // Append mode
                using (StreamWriter sw = new StreamWriter(filePath, true))
                {
                    sw.WriteLine($"{id}|{name}|{loginTime}|{logoutTime}");
                }

                Console.WriteLine("Login entry added successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Add Login operation completed.");
            }
        }

        // ✅ Update Logout Time
        static void UpdateLogout()
        {
            try
            {
                Console.Write("Enter Employee ID to update logout: ");
                string searchId = Console.ReadLine();

                List<string> lines = new List<string>();

                if (File.Exists(filePath))
                {
                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        string line;

                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] data = line.Split('|');

                            if (data[0] == searchId && data[3] == "NA")
                            {
                                data[3] = DateTime.Now.ToString();
                                line = string.Join("|", data);
                            }

                            lines.Add(line);
                        }
                    }

                    // Rewrite file
                    File.WriteAllLines(filePath, lines);

                    Console.WriteLine("Logout time updated!");
                }
                else
                {
                    Console.WriteLine("Log file not found!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Update operation completed.");
            }
        }

        // ✅ View Logs
        static void ViewLogs()
        {
            try
            {
                if (File.Exists(filePath))
                {
                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        string content = sr.ReadToEnd();
                        Console.WriteLine("\n--- Employee Logs ---");
                        Console.WriteLine(content);
                    }
                }
                else
                {
                    Console.WriteLine("No logs found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
