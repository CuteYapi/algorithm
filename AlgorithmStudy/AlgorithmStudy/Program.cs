using System;
using System.Collections.Generic;

namespace AlgorithmStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] survey = { "AN", "CF", "MJ", "RT", "NA" };
            int[] choices = { 5, 3, 2, 7, 5 };


        PersonalityTest.Solution solution = new PersonalityTest.Solution();

            Console.WriteLine(solution.solution(survey, choices));
        }
    }
}

