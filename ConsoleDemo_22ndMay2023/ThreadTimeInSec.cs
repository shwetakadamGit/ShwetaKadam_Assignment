//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleDemo_22ndMay2023
//{
//    internal class ThreadTimeInSec
//    {
//        static void Main()
//        {
//            // Create a new thread and specify the method to execute
//            Thread thread = new Thread(Countdown);

//            // Start the thread
//            thread.Start();

//            // Main thread execution
//            for (int i = 1; i <= 10; i++)
//            {
//                Console.WriteLine("Main Thread: " + i);
//                Thread.Sleep(200); // Delay for 200 milliseconds
//            }

//            // Wait for the other thread to finish
//            thread.Join();

//            Console.WriteLine("Main thread execution complete.");
//        }

//        static void Countdown()
//        {
//            for (int i = 10; i >= 1; i--)
//            {
//                Console.WriteLine("Secondary Thread: " + i);
//                Thread.Sleep(500); // Delay for 500 milliseconds
//            }

//            Console.WriteLine("Secondary thread execution complete.");
//        }
//    }
//}
