//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleDemo_22ndMay2023
//{
//    internal class ArrayListMenudrivenProgram
//    {
//        public static void Main(string[] args)
//        {
//            ArrayList patientList = new ArrayList();

//            string choice;
//            do
//            {
//                Console.Write("Enter patient name: ");
//                string name = Console.ReadLine();

//                patientList.Add(name);

//                Console.Write("Do you want to add more names? (Y/N): ");
//                choice = Console.ReadLine();
//            } while (choice.ToUpper() == "Y");

//            Console.WriteLine("List of patients:");

//            foreach (string patient in patientList)
//            {
//                Console.WriteLine(patient);
//            }

//            bool exit = false;
//            while (!exit)
//            {
//                Console.WriteLine();
//                Console.WriteLine("Menu:");
//                Console.WriteLine("1. Sort");
//                Console.WriteLine("2. Remove");
//                Console.WriteLine("3. Reverse");
//                Console.WriteLine("4. Search");
//                Console.WriteLine("5. Exit");
//                Console.Write("Enter your choice: ");
//                string menuChoice = Console.ReadLine();

//                switch (menuChoice)
//                {
//                    case "1":
//                        patientList.Sort();
//                        Console.WriteLine("List sorted successfully.");
//                        DisplayPatientList(patientList);
//                        break;
//                    case "2":
//                        Console.Write("Enter the name to remove: ");
//                        string removeName = Console.ReadLine();
//                        //string removed = patientList.Remove(removeName);
                        
//                        if (patientList.Remove(removeName))
//                        {
//                            Console.WriteLine("Name removed successfully.");
//                        }
//                        else
//                        {
//                            Console.WriteLine("Name not found in the list.");
//                        }
//                        DisplayPatientList(patientList);
//                        break;
//                    case "3":
//                        patientList.Reverse();
//                        Console.WriteLine("List reversed successfully.");
//                        DisplayPatientList(patientList);
//                        break;
//                    case "4":
//                        Console.Write("Enter the name to search: ");
//                        string searchName = Console.ReadLine();
//                        bool found = patientList.Contains(searchName);
//                        if (found)
//                        {
//                            Console.WriteLine("Name found in the list.");
//                        }
//                        else
//                        {
//                            Console.WriteLine("Name not found in the list.");
//                        }
//                        break;
//                    case "5":
//                        exit = true;
//                        break;
//                    default:
//                        Console.WriteLine("Invalid choice. Please try again.");
//                        break;
//                }
//            }
//        }
//        static void DisplayPatientList(ArrayList patientList)
//        {
//            Console.WriteLine("Updated List of patients:");
//            foreach (string patient in patientList)
//            {
//                Console.WriteLine(patient);
//            }
//        }
//    }
//}
