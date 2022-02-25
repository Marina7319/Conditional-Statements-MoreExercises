using System;

namespace PipesInPool
{
    class Program
    {
        static void Main(string[] args)
        {
            //басейн с две тръби, които са пълни 
            //дебит тръба 1 = чете от конзолата
            //дебит тръба 2 = чете от конзолата
            //N часа 
            int V = int.Parse(Console.ReadLine());
            int P1 = int.Parse(Console.ReadLine());
            int P2 = int.Parse(Console.ReadLine());
            double time = double.Parse(Console.ReadLine());
            double Pipe1Water = P1 * time;
            double Pipe2Water = P2 * time;
            double PoolWater = Pipe1Water + Pipe2Water;

            //Колко ще в пълен басейна 
            if (V >= PoolWater)
            {
                double waterPercentFull = (PoolWater / V)*100;
                double waterPercentFullPipe1 = (Pipe1Water / PoolWater) * 100;
                double waterPercentFullPipe2 = (Pipe2Water / PoolWater) * 100;
                Console.WriteLine($"The pool is {waterPercentFull:f2}% full. Pipe 1: {waterPercentFullPipe1:f2}%. Pipe 2: {waterPercentFullPipe2:f2}%.");
            }
            else
            {
                double overflows = PoolWater - V;
                Console.WriteLine($"For {time:f2} hours the pool overflows with {overflows:f2} liters.");
            }
        }
    }
}
