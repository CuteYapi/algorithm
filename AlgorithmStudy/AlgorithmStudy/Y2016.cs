/*
 * https://school.programmers.co.kr/learn/courses/30/lessons/12901
 */

namespace Y2016
{
    public class Solution
    {
        public string solution(int a, int b)
        {
            int[] monthDayCount = new int[] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30};
            int totalDay = 0;

            a = a - 1;

            if (a > 0)
            {
                for (int i = 0; i < a; i++)
                {
                    totalDay = totalDay + monthDayCount[i];
                }
            }

            totalDay = totalDay + b;

            switch (totalDay % 7)
            {
                case 0:
                    return "THU";
                case 1:
                    return "FRI";
                case 2:
                    return "SAT";
                case 3:
                    return "SUN";
                case 4:
                    return "MON";
                case 5:
                    return "TUE";
                case 6:
                    return "WED";
                default:
                    return "";
            }
        }
    }
}
