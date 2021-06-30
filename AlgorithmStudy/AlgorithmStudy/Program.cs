using System;

namespace AlgorithmStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayExample = { 7,1,5,3,6,4 };

            BestTimeToBuyAndSellStock.Solution solution = new BestTimeToBuyAndSellStock.Solution();
            var quizAnswer = solution.MaxProfit(arrayExample);

            Console.WriteLine(quizAnswer);
        }
    }
}
