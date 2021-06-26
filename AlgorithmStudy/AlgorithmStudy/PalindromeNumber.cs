using System;

namespace PalindromeNumber
{
    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            char[] intToCharArray = (x.ToString()).ToCharArray();

            int arrayPointer = 0;

            while (arrayPointer < intToCharArray.Length - 1)
            {
                if (intToCharArray[arrayPointer] != intToCharArray[intToCharArray.Length - (arrayPointer + 1)])
                {
                    return false;
                }
                arrayPointer++;
            }

            return true;
        }
    }
}