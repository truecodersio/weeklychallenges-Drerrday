using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            for(int i = 0; i < vals.Length; i++)
            {
                if(vals[i] == true)
                {
                    vals[i] = vals[i];
                }
                else
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            int Sum = 0;
            foreach(int num in numbers)
            {
                if(num % 2 == 1)
                {
                    Sum += num;
                }
            }
            if(Sum % 2 == 1)
            {
                return true;
            }
            return false;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            int ctr = 0;
            string up = password.ToUpper();
            string low = password.ToLower();
            string num = "0123456789";

            foreach(char c in password)
            {
                if(up[c] == password[c])
                {
                    ctr++;
                }
                if(low[c] == password[c])
                {
                    ctr++;
                }
                if(num[c] == password[c])
                {
                    ctr++;
                }
            }

            if(ctr == 3)
            {
                return true;
            }
            return false;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            int[] odds = {
                1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, //13
                27, 29, 31, 33, 35, 37, 39, 41, 43, 45, 47, 49, //12
                51, 53, 55, 57, 59, 61, 63, 65, 67, 69, 71, 73, //12
                75, 77, 79, 81, 83, 85, 87, 89, 91, 93, 95, 97, 99}; //13
            return odds;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            words = Array.ConvertAll(words, d => d.ToUpper());
        }
    }
}
