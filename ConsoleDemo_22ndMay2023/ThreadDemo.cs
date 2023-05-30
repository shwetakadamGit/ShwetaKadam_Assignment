//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleDemo_22ndMay2023
//{
//    internal class ThreadDemo
//    {
//        static void Main(string[] args)
//        {
//            Thread oThreadone = new Thread(TJoin);
//          //Thread oThreadtwo = new Thread(Work2);

//            oThreadone.Start();
//            oThreadone.Join();
//            Console.WriteLine("Work completed...");
//            //oThreadtwo.Start();

//        }
//        //static void Work1()
//        //{
//        //    for(int i =0; i < 10; i++)
//        //    {
//        //        Console.WriteLine("Work 1 is called "+i.ToString());
//        //    }
//        //}
//        //static void Work2()
//        //{
//        //    for (int i = 0; i < 10; i++)
//        //    {
//        //        Console.WriteLine("Work 2 is called " + i.ToString());
//        //    }
//        //}
//        static void TJoin()
//        {
//            for (int i = 0; i < 10; i++)
//            {
//                Console.WriteLine("Work in progress..." + i.ToString());
//            }
//        }
//    }
//}
