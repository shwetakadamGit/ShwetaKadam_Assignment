//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleDemo_22ndMay2023
//{
//    internal class NeortiesPharma
//    {
//        class Medicine
//        {
//            public string MedicineCode { get; set; }
//            public string MedicineName { get; set; }
//            public string ManufactureName { get; set; }
//            public decimal UnitPrice { get; set; }
//            public int QuantityOnHand { get; set; }
//            public DateTime ManufacturedDate { get; set; }
//            public DateTime ExpiryDate { get; set; }

//            public Medicine(string code, string name, string manufacture, decimal price, int quantity, DateTime manufacturedDate, DateTime expiryDate)
//            {
//                MedicineCode = code;
//                MedicineName = name;
//                ManufactureName = manufacture;
//                UnitPrice = price;
//                QuantityOnHand = quantity;
//                ManufacturedDate = manufacturedDate;
//                ExpiryDate = expiryDate;
//            }

//            public void Accept()
//            {
//                Console.Write("Enter Medicine Code: ");
//                MedicineCode = Console.ReadLine();

//                Console.Write("Enter Medicine Name: ");
//                MedicineName = Console.ReadLine();

//                Console.Write("Enter Manufacture Name: ");
//                ManufactureName = Console.ReadLine();

//                Console.Write("Enter Unit Price: ");
//                UnitPrice = Convert.ToDecimal(Console.ReadLine());

//                Console.Write("Enter Quantity On Hand: ");
//                QuantityOnHand = Convert.ToInt32(Console.ReadLine());

//                Console.Write("Enter Manufactured Date (yyyy-mm-dd): ");
//                ManufacturedDate = DateTime.Parse(Console.ReadLine());

//                Console.Write("Enter Expiry Date (yyyy-mm-dd): ");
//                ExpiryDate = DateTime.Parse(Console.ReadLine());
//            }

//            public void Print()
//            {
//                Console.WriteLine("Medicine Code: " + MedicineCode);
//                Console.WriteLine("Medicine Name: " + MedicineName);
//                Console.WriteLine("Manufacture Name: " + ManufactureName);
//                Console.WriteLine("Unit Price: " + UnitPrice);
//                Console.WriteLine("Quantity On Hand: " + QuantityOnHand);
//                Console.WriteLine("Manufactured Date: " + ManufacturedDate.ToString("yyyy-MM-dd"));
//                Console.WriteLine("Expiry Date: " + ExpiryDate.ToString("yyyy-MM-dd"));
//            }

//            public void PrintQuantityOnHand()
//            {
//                Console.WriteLine("Medicine Code: " + MedicineCode);
//                Console.WriteLine("Quantity On Hand: " + QuantityOnHand);
//            }

//            public void PrintDates()
//            {
//                Console.WriteLine("Medicine Code: " + MedicineCode);
//                Console.WriteLine("Medicine Name: " + MedicineName);
//                Console.WriteLine("Manufactured Date: " + ManufacturedDate.ToString("yyyy-MM-dd"));
//                Console.WriteLine("Expiry Date: " + ExpiryDate.ToString("yyyy-MM-dd"));
//            }
//        }

//        class Sales
//        {
//            public string MedicineCode { get; set; }
//            public int QuantitySold { get; set; }
//            public int PlannedSales { get; set; }
//            public int ActualSales { get; set; }
//            public string Region { get; set; }

//            public Sales(string code, int quantitySold, int plannedSales, int actualSales, string region)
//            {
//                MedicineCode = code;
//                QuantitySold = quantitySold;
//                PlannedSales = plannedSales;
//                ActualSales = actualSales;
//                Region = region;
//            }

//            public void Accept()
//            {
//                Console.Write("Enter Medicine Code: ");
//                MedicineCode = Console.ReadLine();

//                Console.Write("Enter Quantity Sold: ");
//                QuantitySold = Convert.ToInt32(Console.ReadLine());

//                Console.Write("Enter Planned Sales: ");
//                PlannedSales = Convert.ToInt32(Console.ReadLine());

//                Console.Write("Enter Actual Sales: ");
//                ActualSales = Convert.ToInt32(Console.ReadLine());

//                Console.Write("Enter Region: ");
//                Region = Console.ReadLine();
//            }
//        }

//        class Program
//        {
//            static void Main()
//            {
//                Medicine medicine = new Medicine("", "", "", 0, 0, DateTime.MinValue, DateTime.MinValue);
//                medicine.Accept();
//                medicine.Print();

//                Console.WriteLine();

//                medicine.PrintQuantityOnHand();

//                Console.WriteLine();

//                medicine.PrintDates();

//                Console.ReadLine();
//            }

//        }
//    }
//}
