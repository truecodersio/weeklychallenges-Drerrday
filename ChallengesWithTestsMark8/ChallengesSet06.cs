using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null)
            {
                return false;
            }
            foreach(string wordPassed in words)
            {
                if (wordPassed != null)
                {
                    if (ignoreCase == true)
                    {
                        if (wordPassed.ToLower() == word.ToLower())
                        {
                            return true;
                        }
                    }
                    if (ignoreCase == false)
                    {
                        if (wordPassed == word)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public bool IsPrimeNumber(int num)
        {
            if (num != Math.Abs(num))
            {
                return false;
            }
            if(num == 0 || num == 1)
            {
                return false;
            }
            else
            {
                for (int i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            throw new NotImplementedException();
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            /*
            int ctr = 0;
            int max = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                if (i == 0)
                {
                    if (numbers[i] == numbers[i + 1])
                    {
                        ctr++;
                    }
                }
                else if (numbers[i] == numbers[i - 1] && numbers[i] != 1)
                {
                    ctr++;
                }
            }
            return ctr;
            */
            throw new NotImplementedException();
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            var arr = new List<double>();

            if(elements == null || n <= 0)
            {
                return arr.ToArray();
            }
            for (int i = 0; i < elements.Count; i+=n)
            {
                if((i % n) == 0)
                {
                    arr.Add(elements[i]);
                }
                else if (i == 0 && i % n == 0)
                {
                    return arr.ToArray();
                }
            }
            return arr.ToArray();
        }
    }
}
