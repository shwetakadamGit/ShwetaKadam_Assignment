//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleDemo_22ndMay2023
//{
//    internal class FileHandlingDemmo
//    {
//        public static void Main(string[] args)
//        {
//            FileStream f1 = new FileStream("C:\\C_SharpTraining\\shwetaFile.txt", FileMode.OpenOrCreate);
//            StreamWriter s1 = new StreamWriter(f1);
//            s1.WriteLine("Shweta has wwritten program for file handling.");
//            s1.Close();
//            f1.Close();
//            FileStream f2 = new FileStream("C:\\C_SharpTraining\\shwetaFile.txt", FileMode.OpenOrCreate);
//            StreamReader s2 = new StreamReader(f2);
//            string data = s2.ReadLine();
//            Console.WriteLine("The data in the file is as follows");
//            Console.WriteLine(data);
//            s2.Close();
//            f2.Close();
//        }
//    }
//}
