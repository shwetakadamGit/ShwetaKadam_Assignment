//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleDemo_22ndMay2023
//{
//    // Base class
//    class Animal
//    {
//        public string Name { get; set; }
//        public int Age { get; set; }

//        public void Eat()
//        {
//            Console.WriteLine($"{Name} is eating.");
//        }

//        public void Sleep()
//        {
//            Console.WriteLine($"{Name} is sleeping.");
//        }
//    }

//    // Derived class inheriting from the base class
//    class Dog : Animal
//    {
//        public void Bark()
//        {
//            Console.WriteLine($"{Name} is barking.");
//        }
//    }
//    internal class InheritanceDemo
//    {
//        public static void Main(string[] args)
//        {
//            // Creating an object of the derived class
//            Dog dog = new Dog();
//            dog.Name = "Buddy";
//            dog.Age = 3;

//            // Accessing properties and methods from the base class
//            dog.Eat();
//            dog.Sleep();

//            // Accessing method from the derived class
//            dog.Bark();

//            Console.ReadLine();
//        }
//    }
//}
