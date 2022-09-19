/*
 * https://school.programmers.co.kr/learn/courses/30/lessons/43165
 */

using System.Collections.Generic;

namespace TargetNumber
{
    public class Solution
    {

        public int solution(int[] numbers, int target)
        {
            int answer = 0;
            Stack<BinaryTree> findTargetNumberTree = new Stack<BinaryTree>();

            BinaryTree root = new BinaryTree();
            root.order = -1;
            root.sum = 0;

            findTargetNumberTree.Push(root);

            while (findTargetNumberTree.Count > 0)
            {
                BinaryTree item = findTargetNumberTree.Pop();

                if(item.order + 1 < numbers.Length)
                {
                    BinaryTree left = new BinaryTree();
                    left.order = item.order + 1;
                    left.sum = item.sum + numbers[left.order];
                    findTargetNumberTree.Push(left);

                    BinaryTree right = new BinaryTree();
                    right.order = item.order + 1;
                    right.sum = item.sum - numbers[right.order];
                    findTargetNumberTree.Push(right);
                }

                else if(item.sum == target)
                {
                    answer++;
                }
            }

            return answer;
        }

        public class BinaryTree
        {
            public int order;
            public int sum;
        }
    }
}
