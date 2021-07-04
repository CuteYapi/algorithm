using System;

namespace AlgorithmStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNumber = { 1,2,3,4,3,2,1 };

            SingleNumber.Solution solution = new SingleNumber.Solution();
            
            Console.WriteLine(solution.SingleNumber(arrayNumber));
        }
    }
}

