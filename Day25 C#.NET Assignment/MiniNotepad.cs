using System;
using System.Collections.Generic;
using System.Text;

namespace file_Handeling_Assignment
{
    internal class MiniNotepad
    {
        static void Main()
        {
            int choice;
            string fileName;

            do
            {
                Console.WriteLine("\n--- Mini Notepad ---");
                Console.WriteLine("1. Create New File");
                Console.WriteLine("2. Write to File");
                Console.WriteLine("3. Read File");
                Console.WriteLine("4. Append Text");
                Console.WriteLine("5. Delete File");
                Console.WriteLine("6. Exit");
                Console.Write("Enter choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter file name (without extension): ");
                fileName = Console.ReadLine() + ".txt";

                switch (choice)
                {
                    case 1:
                        CreateFile(fileName);
                        break;
                    case 2:
                        WriteFile(fileName);
                        break;
                    case 3:
                        ReadFile(fileName);
                        break;
                    case 4:
                        AppendFile(fileName);
                        break;
                    case 5:
                        DeleteFile(fileName);
                        break;
                    case 6:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }

            } while (choice != 6);
        }

        // ✅ Create File
        static void CreateFile(string fileName)
        {
            try
            {
                using (FileStream fs = new FileStream(fileName, FileMode.Create))
                {
                    Console.WriteLine("File created successfully!");
                }
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Access denied!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        // ✅ Write to File (Overwrite)
        static void WriteFile(string fileName)
        {
            try
            {
                using (FileStream fs = new FileStream(fileName, FileMode.Create))
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    Console.WriteLine("Enter text (type 'END' to stop):");

                    while (true)
                    {
                        string line = Console.ReadLine();
                        if (line.ToUpper() == "END")
                            break;

                        sw.WriteLine(line);
                    }
                }

                Console.WriteLine("Data written successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        // ✅ Read File
        static void ReadFile(string fileName)
        {
            try
            {
                if (!File.Exists(fileName))
                {
                    Console.WriteLine("File not found!");
                    return;
                }

                using (FileStream fs = new FileStream(fileName, FileMode.Open))
                using (StreamReader sr = new StreamReader(fs))
                {
                    Console.WriteLine("\n--- File Content ---");
                    Console.WriteLine(sr.ReadToEnd());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        // ✅ Append Text
        static void AppendFile(string fileName)
        {
            try
            {
                using (FileStream fs = new FileStream(fileName, FileMode.Append))
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    Console.WriteLine("Enter text to append (type 'END' to stop):");

                    while (true)
                    {
                        string line = Console.ReadLine();
                        if (line.ToUpper() == "END")
                            break;

                        sw.WriteLine(line);
                    }
                }

                Console.WriteLine("Data appended successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        // ✅ Delete File
        static void DeleteFile(string fileName)
        {
            try
            {
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                    Console.WriteLine("File deleted successfully!");
                }
                else
                {
                    Console.WriteLine("File not found!");
                }
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Access denied!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
