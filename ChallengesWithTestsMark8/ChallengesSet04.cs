using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int sum = 0;
            foreach(int num in numbers)
            {
                if(num % 2 == 0)
                {
                    sum += num;
                }
                else if (num % 2 == 1)
                {
                    sum -= num;
                }
            }
            return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            /*
            int a = str1.Length; int b = str2.Length; int c = str3.Length; int d = str4.Length;
            int min = 0;
            int min2 = 0;

            if(a < b)
            { min = a; }
            else if(b < a)
            { min = b; }

            if (c < d)
            { min2 = c; }
            else if (d < c)
            { min2 = d; }

            if (min < min2)
            { return min; }
            return min2;
            */
            var list = new List<int> { str1.Length, str2.Length, str3.Length, str4.Length };
            list.Sort();
            return list[0];
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            /*
            int min = 0;
            int min2 = 0;

            if (number1 < number2)
            { min = number1; }

            else if (number2 < number1)
            { min = number2; }

            if (number3 < number4)
            { min2 = number3; }

            else if (number4 < number3)
            { min2 = number4; }

            if (min < min2)
            { return min; }
            return min2;
            */
            var list = new List<int>() { number1, number2, number3, number4 };
            list.Sort();

            return list[0];
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            /*
            if(sideLength1 + sideLength2 + sideLength3 == 180)
            { return true; }
            return false;
            */
            return (sideLength1 + sideLength2 > sideLength3 &&
                    sideLength1 + sideLength3 > sideLength2 &&
                    sideLength2 + sideLength3 > sideLength1);
        }

        public bool IsStringANumber(string input)
        {
            return double.TryParse(input, out _);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int ctr = 0;
            int ctr2 = 0;
            foreach(var obj in objs)
            {
                if(obj == null)
                {
                    ctr++;
                }
                else { ctr2++; }
            }
            if (ctr > ctr2)
            { return true; }
            return false;
        }

        public double AverageEvens(int[] numbers)
        {
            double evens = 0;
            int ctr = 0;

            if(numbers == null)
            { return 0; }

            foreach(int num in numbers)
            {
                if(num % 2 == 0)
                {
                    evens += num;
                    ctr++;
                }
            }
            if (ctr > 0)
            { return evens / ctr; }
            else
            { return 0; }
        }

        public int Factorial(int number)
        {
            var Fact = 1;

            if(number < 0)
            { throw new ArgumentOutOfRangeException(); }

            for(int i = number; i > 0; i--)
            { Fact *= i; }

            return Fact;
        }
    }
}
