using System;

namespace JSolveSharp
{
    public class Program
    {
        public static unsafe void Main(string[] args)
        {
            var solver = new Solver();
            string inData = "4...3.......6..8..........1....5..9..8....6...7.2........1.27..5.3....4.9........";

            string result;
            int solutions;

            const int rounds = 1000;

            var sw = System.Diagnostics.Stopwatch.StartNew();
            {
                for (int i = 0; i < rounds; i++)
                {
                    solutions = solver.JSolve(inData, out result, 2);
                }
            }
            sw.Stop();

            var elapsed = sw.Elapsed.TotalMilliseconds / rounds;

            Console.WriteLine("Elapsed: " + elapsed);
        }
    }
}
