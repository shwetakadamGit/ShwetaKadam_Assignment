using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemo_22ndMay2023
{
    internal class ThreadWithTask
    {
        static void Main(string[] args)
        {
            Work1();
            Work2();
        }
        public static async Task Work1()
        {
            await Task.Run(() => {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine("Work 1 is called " + i.ToString());
                    Task.Delay(100).Wait();
                }
            });
        }
        static void Work2()
        {
            for (int i = 1; i <= 10; i++)
            {

                Console.WriteLine("Work 2 is called " + i.ToString());
                Task.Delay(100).Wait();
            }
        }
    }
}
