﻿using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            throw new NotImplementedException();
            /*
            foreach(string wordPassed in words)
            {
                if(wordPassed == word)
                {
                    return true;
                }
            }
            */
        }

        public bool IsPrimeNumber(int num)
        {
            throw new NotImplementedException();
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            throw new NotImplementedException();
            /*
            string[] ourUniqs = "";
            string uniqs = "!@#$%^&*()-+<>?,./";
            foreach(char u in str)
            {
                for (int i = 0; i < uniqs.Length; i++)
                {
                    if (str.Contains(uniqs[u]))
                    {
                        ourUniqs = str.Contains(uniqs[u]);
                    }
                }
            }
            */
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            throw new NotImplementedException();
        }
    }
}
