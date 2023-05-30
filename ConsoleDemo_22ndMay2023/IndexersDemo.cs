//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleDemo_22ndMay2023
//{
//    internal class IndexersDemo
//    {
//        private string[] range = new string[5];
//        public string this[int index]
//        {
//            get
//            {
//                return range[index];
//            }
//            set
//            {
//                range[index] = value;
//            }
//        }
//    }
//    class IndexerDemo1 : IndexersDemo
//    {

//    }
//    class IndexerTest
//    {
//        static void Main(string[] args)
//        {
//            IndexerDemo1 id = new IndexerDemo1();
//            id[0] = "Shweta";
//            id[1] = "Shamal";
//            id[2] = "Roopali";
//            id[3] = "Darshan";
//            id[4] = "Yuvraj";
//            for (int i = 0; i < 5; i++)
//            {
//                Console.WriteLine(id[i]);
//            }
//        }
//    }
//}
