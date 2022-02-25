using System;

namespace FuelTank_Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuel = Console.ReadLine();
            int fuelInTank = int.Parse(Console.ReadLine());
            string card = Console.ReadLine();
            double result = 0;
            switch (fuel)
            {
                case "Diesel":
                    if (card == "Yes")
                    {
                        result = fuelInTank * 2.21;                   
                    }
                    else  if (card == "No")
                    {
                        result = fuelInTank * 2.33;
                    }
                    break;
                case "Gasoline":
                    if (card == "Yes")
                    {
                        result = fuelInTank * 2.04;
                    }
                    else if (card == "No")
                    {
                        result = fuelInTank * 2.22;
                    }
                    break;
                case "Gas":
                    if (card == "Yes")
                    {
                        result = fuelInTank * 0.85;
                    }
                    else if(card == "No")
                    {
                        result = fuelInTank * 0.93;
                    }
                    break;
            }
            if(fuelInTank > 20 && fuelInTank <= 25)
            {
                double price = result - result * 0.08;
                Console.WriteLine($"{price:f2} lv.");
            } else if(fuelInTank > 25)
            {
                double price = result - result * 0.1;
                Console.WriteLine($"{price:f2} lv.");
            }
            else
            {
                Console.WriteLine($"{result:f2} lv.");
            }
        }
    }
}



