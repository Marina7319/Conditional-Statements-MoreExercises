using System;

namespace _02.SleepyTomCat
{
    class Program
    {
        static void Main(string[] args)
        {
            int holidays = int.Parse(Console.ReadLine());
            int yearDays = 365;
            int workingDays = yearDays - holidays;
            int totalPlayingWithTom = holidays * 127 + workingDays * 63;
            int morePlay = Math.Abs(totalPlayingWithTom - 30000);
            int hours = morePlay / 60;
            int minutes = morePlay % 60;
            if (30000 < totalPlayingWithTom)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hours:f0} hours and {minutes} minutes more for play");
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hours:f0} hours and {minutes} minutes less for play");
            }
        }
    }
}
