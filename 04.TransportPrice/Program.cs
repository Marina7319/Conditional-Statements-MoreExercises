using System;

namespace _04.TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string periodDay = Console.ReadLine();
            double taxiPrice = 0.0;
            double train = 0.0;
            double bus = 0.0;
            if (periodDay == "day")
            {
                taxiPrice = n * 0.79 + 0.7;
            }
            else if (n >= 100)
            {
                train = n * 0.06;
            }
             if (n >= 20)
            {
                bus = 0.09 * n;
            }
            if (periodDay == "night")
            {
                taxiPrice = n * 0.9 + 0.7;
            }
            if (n >= 20)
            {
                bus = n * 0.09;
            }
            else if (n >= 100)
            {
                train = n * 0.06;
            }
            if (train <= bus && train <= taxiPrice && train != 0)
            {
                Console.WriteLine($"{train:f2}");
            }
            else if (bus <= train && bus <= taxiPrice && bus != 0)
            {
                Console.WriteLine($"{train:f2}");
            }
            else
            {
                Console.WriteLine($"{taxiPrice:f2}");
            }
        }
    }
}

