/*
 * https://school.programmers.co.kr/learn/courses/30/lessons/12909
 */

using System.Collections.Generic;

namespace bracket
{
    public class Solution
    {
        public bool solution(string s)
        {
            Stack<char> bracketStack = new Stack<char>();

            foreach (var c in s)
            {
                if(c == '(')
                {
                    bracketStack.Push(c);
                }

                else 
                {
                    if(bracketStack.Count == 0)
                    {
                        return false;
                    }

                    bracketStack.Pop();
                }
            }

            if(bracketStack.Count == 0)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
