using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            PalindromeNumber.Solution solution = new PalindromeNumber.Solution();
            var quizAnswer = solution.IsPalindrome(10202);

            Console.WriteLine(quizAnswer);
        }
    }
}
