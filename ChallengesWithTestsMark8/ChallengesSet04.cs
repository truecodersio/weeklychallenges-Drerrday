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

            if(a < b)
            {min = a;}
            else if(b < a)
            {min = b;}

            if (c < d)
            {min2 = c;}
            else if (d < c)
            {min2 = d;}

            if (min < min2)
            {return min;}
            return min2;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
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
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if(sideLength1 + sideLength2 + sideLength3 == 180)
            { return true; }
            return false;
        }

        public bool IsStringANumber(string input)
        {
            bool success;

            success = int.TryParse(input, out _);
            return success;
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
