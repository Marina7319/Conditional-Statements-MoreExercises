using System;

namespace _03.Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());//1020
            double Y = double.Parse(Console.ReadLine());//1.5
            int Z = int.Parse(Console.ReadLine());//425
            int workers = int.Parse(Console.ReadLine());//4
            double grapes = X * Y;//1020 * 1.5 = 1530
            double grapesKilosWine = grapes - grapes * 0.6;//1530-1530x0.6=612
            double wine = 0.4* grapes / 2.5;//1071/2.5=244.80
            if (Z > wine)
            {
                double wineLess = Math.Floor(Z - wine);
                Console.WriteLine($"It will be a tough winter! More {wineLess} liters wine needed.");
            } 
            if(Z <= wine)
            {
                double wineLeft = Math.Round(wine - Z);
                double wineWorker = Math.Round(wineLeft / workers);
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wine)} liters.");
                Console.WriteLine($"{wineLeft} liters left -> {wineWorker} liters per person.");
            }
        }
    }
}
