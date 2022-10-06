using System;
using System.Collections.Generic;

namespace AlgorithmStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] value1 = {"banana", "apple", "rice", "pork", "pot"};
            int[] value2 = { 3, 2, 2, 2, 1 } ;
            string[] value3 = { "apple", "banana", "rice", "apple", 
                "pork", "banana", "pork", "rice", "pot", "banana", "apple", "banana","chicken", "apple" };

            BargainSale.Solution solution = new BargainSale.Solution();

            Console.WriteLine(solution.solution(value1, value2, value3));
        }
    }
}

