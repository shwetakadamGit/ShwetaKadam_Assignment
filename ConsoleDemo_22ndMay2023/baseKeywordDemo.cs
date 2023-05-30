//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.InteropServices;
//using System.Security.Cryptography.X509Certificates;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleDemo_22ndMay2023
//{
//    internal class baseKeywordDemo
//    {
//        //base class
//        public class Shape
//        {
//            //Base Class Default Constructor
//            public Shape() { }

//            //Base Class Parameerized Constuctor
//            public Shape(float float1, float float2) { }

//        }
//        //Derived Class
//        public class Polygon : Shape
//        {
//            public Polygon() : base() { }
//            public Polygon(float float_base, float float_height) : base(float_base, float_height) { }

//        }
//        //Derived Class
//        public class Rectangle : Shape
//        {
//            public Rectangle() : base() { }

//            public Rectangle(float float_length, float float_width) : base(float_length, float_width) { }
//        }
//        class Program
//        {
//            static void Main(string[] args)
//            {
//                Polygon obj_Polygon = new Polygon();
//                Polygon obj_Polygon1 = new Polygon(3,7);

//                Rectangle obj_Rectangle = new Rectangle();
//                Rectangle obj_Rectangle1 = new Rectangle(4,3);

//                Console.ReadLine();
//            }
//        }
//    }
//}