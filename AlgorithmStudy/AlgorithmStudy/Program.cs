using System;

namespace AlgorithmStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            UglyNumber.Solution solution = new UglyNumber.Solution();
            var quizAnswer = solution.IsUgly(0);

            Console.WriteLine(quizAnswer);
        }
    }
}
