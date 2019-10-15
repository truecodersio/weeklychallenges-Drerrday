using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            if (char.IsLetter(c))
            { return true; }
            return false;
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
            if(numbers == null)
            { return 0; }
            double min = 0;
            double max = 0;

            foreach (double num in numbers)
            {
                if (num > max)
                {
                    max = num;
                }
                if (num < min && num <= max)
                {
                    min = num;
                }
            }
            return max + min;
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
            if(numbers == null)
            { return 0; }
            int total = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                total += numbers[i];
            }
            return total;
        }
        
        public int SumEvens(int[] numbers)
        {
            int num = 0;
            if (numbers == null)
            { return 0; }
            if (numbers.Count() == 0)
            { return 0; }
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    num += numbers[i];
                }
            }
            return num;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            { return false; }
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
            long oddcount = 0;
            for (int i = 0; i < number; i++)
            {
                if (i % 2 != 0)
                {
                    oddcount++;
                }
            }
            return oddcount;
        }

        public static string CreatePhoneNumber(int[] numbers)
        {
            //string.Format(("{0:(###) ###-####}", sNumber);
            string sNumber = numbers.ToString();
            //string.Format(("{0:(###) ###-####}", numbers);
            string formatted =
               new StringBuilder(14)
               .Append('(')
               .Append(sNumber, 0, 3)
               .Append(") ")
               .Append(sNumber, 3, 3)
               .Append('-')
               .Append(sNumber, 6, 4)
               .ToString();
            return formatted;
        }
    }
}