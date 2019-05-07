using System;

namespace ChallengesWithTestsMarkVII
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
             {
                return 0;
             }
            int sum = 0;
            foreach (int num in numbers)
            {
                if (num%2 == 0)
                {
                    sum += num;
                }
                else
                {
                    sum -= num;
                }
            }
                return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            return GetSmallestNumber(str1.Length, str2.Length, str3.Length, str4.Length);
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            return Math.Min(Math.Min(number1, number2), Math.Min(number3, number4));
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            throw new NotImplementedException();
        }

        public bool IsStringANumber(string input)
        {
            throw new NotImplementedException();
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            throw new NotImplementedException();
        }

        public double AverageEvens(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public int Factorial(int number)
        {
            throw new NotImplementedException();
        }
    }
}
