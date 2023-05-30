//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net.Http.Headers;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleDemo_22ndMay2023
//{
//    internal class JaggedArrayDemo
//    {
//        static void Main(string[] args)
//        {
//            //a jagged array of 4 array of integers.
//            int[][] jaggedArr = new int[4][] { new int[] { 0, 0 },new int[] { 1, 2 },
//            new int[]{2,4}, new int[]{4,8}};

//            int i, j;
//            for(i = 0;i< jaggedArr.Length; i++)
//                for (j = 0; j < jaggedArr[i].Length; j++)
//                {
//                    Console.WriteLine("jaggedArr[{0}][{1}] =  [{2}]", i, j, jaggedArr[i][j]);
//                }
//        }
//    }
//}
