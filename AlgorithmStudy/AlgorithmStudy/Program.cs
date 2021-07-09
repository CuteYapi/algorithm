using System;

namespace AlgorithmStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 400000;

            CountPrimes.Solution solution = new CountPrimes.Solution();

            Console.WriteLine(solution.CountPrimes(n));
        }
    }
}

