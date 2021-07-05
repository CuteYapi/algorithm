using System;

namespace AlgorithmStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 4,9,5 };
            int[] arr2 = { 9,4,9,8,4 };

            IntersectionOfTwoArrays.Solution solution = new IntersectionOfTwoArrays.Solution();

            foreach (var item in solution.Intersection(arr1, arr2))
            {
                Console.WriteLine(item);
            }
        }
    }
}

