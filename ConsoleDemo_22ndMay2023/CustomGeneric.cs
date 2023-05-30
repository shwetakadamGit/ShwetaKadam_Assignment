//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleDemo_22ndMay2023
//{
//    class CustomGenericClass<T1, T2>
//    {
//        private T1 data1;
//        private T2 data2;

//        public CustomGenericClass(T1 value1, T2 value2)
//        {
//            data1 = value1;
//            data2 = value2;
//        }

//        public void DisplayData()
//        {
//            Console.WriteLine("Data1: " + data1);
//            Console.WriteLine("Data2: " + data2);
//        }
//    }
//    internal class CustomGeneric
//    {
//        static void Main()
//        {
//            CustomGenericClass<double, string> customClass = new CustomGenericClass<double, string>(90.56, "Hello, World!");

//            customClass.DisplayData();
//        }
//    }
//}
