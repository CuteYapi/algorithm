/*
 * https://school.programmers.co.kr/learn/courses/30/lessons/118666
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalityTest
{
    public class Solution
    {
        Dictionary<Char, int> personality = new Dictionary<Char, int>();

        public string solution(string[] survey, int[] choices)
        {
            personality.Add('R', 0);
            personality.Add('T', 0);
            personality.Add('C', 0);
            personality.Add('F', 0);
            personality.Add('J', 0);
            personality.Add('M', 0);
            personality.Add('A', 0);
            personality.Add('N', 0);

            for (int i = 0; i < choices.Length; i++)
            {
                if (choices[i] < 4)
                {
                    personality[survey[i][0]] += (4 - choices[i]);
                }

                else if (choices[i] > 4)
                {
                    personality[survey[i][1]] += (choices[i] - 4);
                }
            }

            string answer = null;

            if (personality['R'] >= personality['T']) { answer += 'R'; }
            else                                      { answer += 'T'; }

            if (personality['C'] >= personality['F']) { answer += 'C'; }
            else                                      { answer += 'F'; }

            if (personality['J'] >= personality['M']) { answer += 'J'; }
            else                                      { answer += 'M'; }

            if (personality['A'] >= personality['N']) { answer += 'A'; }
            else                                      { answer += 'N'; }

            return answer;
        }
    }
}
