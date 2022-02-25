using System;

namespace FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int magnolii = int.Parse(Console.ReadLine());
            int zumbuli = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int cactuses = int.Parse(Console.ReadLine());
            int PricePresent = int.Parse(Console.ReadLine());
            double rosesPrice = roses * 3.5;
            int zumbuliPrice = zumbuli * 4;
            double magnoliiPrice = magnolii * 3.25;
            int cactusesPrice = cactuses * 8;
           
            double sum = rosesPrice + zumbuliPrice + magnoliiPrice + cactusesPrice;
            double sumAfterTaxes = sum - sum * 0.05;

            if (sumAfterTaxes > PricePresent)
            {
                double moneyLeft = sumAfterTaxes - PricePresent;
                Console.WriteLine($"She is left with {Math.Floor(moneyLeft)} leva.");
            }
            else
            {
                double moneyToBorrow = PricePresent - sumAfterTaxes;
                Console.WriteLine($"She will have to borrow {Math.Ceiling(moneyToBorrow)} leva.");
            }
        }
    }
}
