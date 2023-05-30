//using System;

//// Abstract class
//abstract class Shape
//{
//    // Abstract method
//    public abstract void Draw();

//    // Non-abstract method
//    public void DisplayArea(double area)
//    {
//        Console.WriteLine($"The area of the shape is: {area}");
//    }
//}

//// Concrete class inheriting from the abstract class
//class Circle : Shape
//{
//    // Implementation of the abstract method
//    public override void Draw()
//    {
//        Console.WriteLine("Drawing a circle...");
//    }
//}

//// Concrete class inheriting from the abstract class
//class Rectangle : Shape
//{
//    // Implementation of the abstract method
//    public override void Draw()
//    {
//        Console.WriteLine("Drawing a rectangle...");
//    }
//}

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        // Creating objects of concrete classes
//        Shape circle = new Circle();
//        Shape rectangle = new Rectangle();

//        // Calling the abstract method through objects
//        circle.Draw();
//        rectangle.Draw();

//        // Calling the non-abstract method through objects
//        circle.DisplayArea(3.14 * 5 * 5);
//        rectangle.DisplayArea(5 * 10);

//        Console.ReadLine();
//    }
//}
