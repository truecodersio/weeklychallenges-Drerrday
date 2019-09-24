using System;
using System.Collections.Generic;


namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            if(c == ' ')
            {
                return true;
            } else
            {
                return false;
            }
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 == 0)
            {
                return true;
            }
            {
                return false;
            }
        }

        public bool IsNumberEven(int number)
        {
            var even = (number % 2 == 0);
            return even;
        }

        public bool IsNumberOdd(int num)
        {
            var even = (num % 2 == 0);
            return !even;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            double min = 0;
            double max = 0;

            foreach (double num in numbers)
            {
                if(num > max)
                {
                    max = num;
                }
                if(num < min)
                {
                    min = num;
                }
            }
            return max - min;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length > str2.Length)
            {
                return str2.Length;
            }
            else
            {
                return str1.Length;
            }

        }

        public int Sum(int[] numbers)
        {
            int total = 0;
            var arrlength = numbers.Length;
            for (int i = 0; i < arrlength; i++)
            {
                total += numbers[i];
            }

            return total;
        }
        
        public int SumEvens(int[] numbers)
        {
            int total = 0;
            var arrlength = numbers.Length;
            for (int i = 0; i < arrlength; i++)
            {
                if(numbers[i] % 2 == 0)
                total += numbers[i];
            }

            return total;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            int sum = 0;
            int Amount = numbers.Count;
            for(int i = 0; i < Amount; i++)
            {
                sum += numbers[i];
            }
            return (sum % 2 != 0);
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            int oddCount = 0;
            for(int i = 0; i < number; i++)
            {
                if (number % 2 == 1)
                {
                    oddCount++;
                }
            }

            return oddCount;
        }
    }
}