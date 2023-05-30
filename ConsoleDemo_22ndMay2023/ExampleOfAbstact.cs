//using System;

//// Abstract base class
//abstract class Clothing
//{
//    // Abstract methods
//    public abstract void Sales();
//    public abstract void Materials();
//    public abstract void CommonWear();
//}

//// Derived class - TrendSetting
//class TrendSetting : Clothing
//{
//    public override void Sales()
//    {
//        Console.WriteLine("TrendSetting sales by region: USA, Europe, Asia");
//    }

//    public override void Materials()
//    {
//        Console.WriteLine("TrendSetting materials: Silk, Lyocell");
//    }

//    public override void CommonWear()
//    {
//        Console.WriteLine("TrendSetting common wear: Dresses, Tops");
//    }
//}

//// Derived class - ClimateControl
//class ClimateControl : Clothing
//{
//    public override void Sales()
//    {
//        Console.WriteLine("ClimateControl sales by region: Europe, Asia, Australia");
//    }

//    public override void Materials()
//    {
//        Console.WriteLine("ClimateControl materials: Wool, Hemp");
//    }

//    public override void CommonWear()
//    {
//        Console.WriteLine("ClimateControl common wear: Jackets, Trousers");
//    }
//}

//// Derived class - Sports
//class Sports : Clothing
//{
//    public override void Sales()
//    {
//        Console.WriteLine("Sports sales by region: USA, Asia, Australia");
//    }

//    public override void Materials()
//    {
//        Console.WriteLine("Sports materials: Ramie, Silk");
//    }

//    public override void CommonWear()
//    {
//        Console.WriteLine("Sports common wear: Shirts, Shorts");
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        // Creating objects of derived classes
//        TrendSetting trendSetting = new TrendSetting();
//        ClimateControl climateControl = new ClimateControl();
//        Sports sports = new Sports();

//        // Displaying information using the abstract methods
//        Console.WriteLine("TrendSetting:");
//        trendSetting.Sales();
//        trendSetting.Materials();
//        trendSetting.CommonWear();
//        Console.WriteLine();

//        Console.WriteLine("ClimateControl:");
//        climateControl.Sales();
//        climateControl.Materials();
//        climateControl.CommonWear();
//        Console.WriteLine();

//        Console.WriteLine("Sports:");
//        sports.Sales();
//        sports.Materials();
//        sports.CommonWear();
//        Console.WriteLine();

//        Console.ReadLine();
//    }
//}
