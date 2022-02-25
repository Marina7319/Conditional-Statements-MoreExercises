using System;

namespace Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());//90
            int days = int.Parse(Console.ReadLine());//7
            int employees = int.Parse(Console.ReadLine());//3
            double hoursAvailable = 8 - 8 * 0.1;
            double perEmployee = hoursAvailable * days;
            double timeForMore = employees * (2 * days);//3x2x7=42
            double totalHours = timeForMore + perEmployee;
               if (hours < totalHours)
                {
                double timeExtra =  totalHours - hours;
                  Console.WriteLine($"Yes!{Math.Round(timeExtra)} hours left.");
              } else
              {
                double timeExtra = hours - totalHours;
                Console.WriteLine($"Not enough time!{Math.Ceiling(timeExtra)} hours needed.");
              }
        }
    }
}
