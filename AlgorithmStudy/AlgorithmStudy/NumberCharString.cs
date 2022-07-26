/*
 * https://school.programmers.co.kr/learn/courses/30/lessons/81301
 * 1005점
 * */



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberCharString
{
    public class Solution
    {
        public int solution(string s)
        {
            int answer = 0;
            string numberText = null;

            Dictionary<string, int> keyValues = new Dictionary<string, int>();
            keyValues.Add("zero", 0);
            keyValues.Add("one", 1);
            keyValues.Add("two", 2);
            keyValues.Add("three", 3);
            keyValues.Add("four", 4);
            keyValues.Add("five", 5);
            keyValues.Add("six", 6);
            keyValues.Add("seven", 7);
            keyValues.Add("eight", 8);
            keyValues.Add("nine", 9);

            char[] charArray = new char[s.ToCharArray().Length];
            charArray = s.ToCharArray();


            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] >= 48 && charArray[i] <= 57)
                {
                    answer = answer * 10 + charArray[i] - '0';
                }

                else
                {
                    numberText = numberText + charArray[i].ToString();

                    if (keyValues.ContainsKey(numberText))
                    {
                        answer = answer * 10 + keyValues[numberText];
                        numberText = null;
                    }
                }
            }

            return answer;
        }
    }
}
