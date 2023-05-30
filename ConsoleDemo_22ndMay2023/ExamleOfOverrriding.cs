//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleDemo_22ndMay2023
//{
//    internal class ExamleOfOverrriding
//    {
//        public class Shape
//        {
//            public virtual void getArea()
//            {
//            }
//        }
//        public class Circle : Shape
//        {
//            double radius;

//            //Constructor
//            public Circle() { }
//            public override void getArea() { }
//        }
//        public class Cylinder : Shape
//        {
//            public double height;
//            //Constructor
//            public Cylinder() { }
//            public override void getArea() { }
//        }
//        public class Program
//        {
//            public static void Main()
//            {
//                Circle d = new Circle();
//                d.getArea();

//                Cylinder b = new Cylinder();
//                b.getArea();
//            }
//        }
//    }
//}
