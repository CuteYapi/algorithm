/*
 * https://school.programmers.co.kr/learn/courses/30/lessons/82612
 */

namespace ShortMoney
{
    class Solution
    {
        public long solution(int price, int money, int count)
        {
            long _money = money; //문제에서 제시한 범위가 int의 범위를 초과함
            long _price = price;

            for (int i = 1; i <= count; i++)
            {
                _money = _money - (_price * i);
            }

            if(_money < 0)
            {
                return _money * -1;
            }

            else
            {
                return 0;
            }
        }
    }
}
