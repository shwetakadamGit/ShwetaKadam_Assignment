//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleDemo_22ndMay2023
//{
//    class Employee
//    {
//        static void ThrowException(string name)
//        {
//            if(name== null) throw new ArgumentNullException();
//        }
//    }
//    internal class ExceptionDemo1
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Throw Example");
//            try
//            {
//                string empName = null;
//                ThrowException(empName);
//            }
//            catch (ArgumentNullException ex)
//            {
//                Console.WriteLine("Exception caught" ,objNull);

//            }
//        }
//    }
//}
