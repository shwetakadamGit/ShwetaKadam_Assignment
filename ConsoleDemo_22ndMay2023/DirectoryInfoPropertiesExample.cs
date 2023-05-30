//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleDemo_22ndMay2023
//{
//    internal class DirectoryInfoPropertiesExample
//    {
//        static void Main(string[] args)
//        {
//            DirectoryInfo fi = new DirectoryInfo(@"C:\\C_SharpTraining\\shwetaFile.txt");
//            Console.WriteLine("Directory name is {0}",fi.Name);
//            Console.WriteLine("Directory creation  time is {0}",fi.CreationTime.ToLongTimeString());
//            //Console.WriteLine("Directory last access time is {0}", fi.LastAccessTime.ToLongDateString());
//            Console.WriteLine("Directory Last Access Time is : {0}", fi.LastAccessTime.ToShortDateString());
//            Console.WriteLine("Directory exist is :", fi.Exists);
//            Console.WriteLine("Directory LastWriteTime is {0}",fi.LastWriteTime.ToLongTimeString());
//            Console.WriteLine("Directory root is {0}", fi.Root);
//        }
//    }
//}
