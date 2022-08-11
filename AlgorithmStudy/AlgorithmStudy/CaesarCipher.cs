/*
 * https://school.programmers.co.kr/learn/courses/30/lessons/12926
 */
using System.Collections.Generic;

namespace CaesarCipher
{
    public class Solution
    {
        public string solution(string s, int n)
        {
            List<char> answerChar = new List<char>();

            foreach (char c in s)
            {
                if(c == ' ')
                {
                    answerChar.Add(c);
                }

                else if (65 <= c && c <= 90)
                {
                    if (c + n > 90)
                    {
                        answerChar.Add((char)(c + n - 26));
                    }

                    else
                    {
                        answerChar.Add((char)(c + n));
                    }
                }

                else if (97 <= c && c <= 122)
                {
                    if (c + n > 122)
                    {
                        answerChar.Add((char)(c + n - 26));
                    }

                    else
                    {
                        answerChar.Add((char)(c + n));
                    }
                }
            }

            string answerString = "";
            foreach (var item in answerChar)
            {
                answerString = answerString + item;
            }
            return answerString;
        }
    }
}
