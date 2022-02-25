using System;

namespace _06.Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int food = int.Parse(Console.ReadLine());
            double dogFood = double.Parse(Console.ReadLine()); //day
            double catFood = double.Parse(Console.ReadLine());//day
            double turtleFood = double.Parse(Console.ReadLine())/1000;//day

            //dog
            double dogFoodForDays = days * dogFood;
            //cat
            double catFoodForDays = days * catFood;
            //turtule
            double turtleFoodForDays = days * turtleFood;
            //sum food
            double foodTotal = dogFoodForDays + catFoodForDays + turtleFoodForDays;
            
            //отпечатване на резултата 
            if(food >= foodTotal)
            {
                double foodLeft = food - foodTotal;
                Console.WriteLine($"{Math.Floor(foodLeft)} kilos of food left.");
            } else
            {
                double foodLeft = foodTotal - food;
                Console.WriteLine($"{Math.Ceiling(foodLeft)} more kilos of food are needed.");
            }
        }
    }
}
