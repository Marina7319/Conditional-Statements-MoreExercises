using System;

namespace FuelTank
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuel = Console.ReadLine();
            int fuelInTank = int.Parse(Console.ReadLine());
            switch (fuel)
            {
                case "Diesel":
                    if (fuelInTank >= 25)
                    {
                        Console.WriteLine($"You have enough diesel.");
                    }
                    else if (fuelInTank < 25)
                    {
                        Console.WriteLine($"Fill your tank with diesel!");
                    }
                    break;
                case "Gasoline":
                    if (fuelInTank >= 25)
                    {
                        Console.WriteLine($"You have enough gasoline.");
                    }
                    else if (fuelInTank < 25)
                    {
                        Console.WriteLine($"Fill your tank with gasoline!");
                    }
                    break;
                case "Gas":
                    if (fuelInTank >= 25)
                    {
                        Console.WriteLine($"You have enough gas.");
                    }
                    else if (fuelInTank < 25)
                    {
                        Console.WriteLine($"Fill your tank with gas!");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid fuel!");
                    break;
            }
        }
    }
}

