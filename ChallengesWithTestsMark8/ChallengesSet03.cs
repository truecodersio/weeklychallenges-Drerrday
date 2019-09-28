using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach(bool val in vals)
            {
                if(val == false)
                { 
                    return true;
                }
            }
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            int sumofOdds = 0;
            foreach(int num in numbers)
            {
                if(num % 2 == 1)
                {
                    sumofOdds += num;
                }
                else
                {
                    sumofOdds += 0;
                }

                if (sumofOdds % 2 == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            throw new NotImplementedException();
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
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums.Length - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            int[] odds = {
                1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25,
                27, 29, 31, 33, 35, 37, 39, 41, 43, 45, 47, 49,
                51, 53, 55, 57, 59, 61, 63, 65, 67, 69, 71, 73,
                75, 77, 79, 81, 83, 85, 87, 89, 91, 93, 95, 97, 99};
            return odds;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            throw new NotImplementedException();
        }
    }
}
