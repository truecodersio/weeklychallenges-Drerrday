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
            var list = new List<int>();
            for(int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    list.Add(i);
                }
            }

            return list.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            words = Array.ConvertAll(words, d => d.ToUpper());
        }
    }
}
