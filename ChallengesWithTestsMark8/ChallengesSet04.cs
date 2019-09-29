using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int sum = 0;
            foreach(int num in numbers)
            {
                if(numbers[num] % 2 == 0)
                {
                    sum += numbers[num];
                }
                else if (numbers[num] % 2 == 1)
                {
                    sum -= numbers[num];
                }
            }
            return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int a = str1.Length;
            int b = str2.Length;
            int c = str3.Length;
            int d = str4.Length;
            int min = 0;
            int min2 = 0;

            if(a < b) //if a is min return a
            { min = a; }
            else if(b < a) // if b is min return b
            { min = b; }

            if (c < d) //if c is min return c
            { min2 = c; }

            else if (d < c)
            {min2 = d;}

            if (min < min2)
            { return min; }
            return min2;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            throw new NotImplementedException();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            throw new NotImplementedException();
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if(sideLength1 + sideLength2 + sideLength3 == 180)
            { return true; }
            return false;
        }

        public bool IsStringANumber(string input)
        {
            throw new NotImplementedException();
            //int.TryParse(input, out true) ;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            throw new NotImplementedException();
        }

        public double AverageEvens(int[] numbers)
        {
            double evens = 0;
            int ctr = 0;
            foreach(int num in numbers)
            {
                if(num % 2 == 0)
                {
                    evens += numbers[num];
                    ctr++;
                }
            }
            return evens / ctr;
        }

        public int Factorial(int number)
        {
            int Fact = 1;
            for(int i = 1; i < number; i++)
            {
                Fact += Fact * i;
            }
            return Fact;
        }
    }
}
