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
            return (sideLength1 + sideLength2 > sideLength3 && sideLength2 + sideLength3 > sideLength1 && sideLength1 + sideLength3 > sideLength2);
        }

        public bool IsStringANumber(string input)
        {
            return double.TryParse(input, out double unusedInteger);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int nullCounter = 0;

            foreach (var element in objs)
            {
                if (element == null)
                {
                    nullCounter += 1;
                }
            }
            return (nullCounter > objs.Length / 2);
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }

            double sumOfEvens   = 0;
            int countOfEvens = 0;

            foreach (int num in numbers)
            {
                if (num%2 == 0)
                {
                    sumOfEvens += num;
                    countOfEvens += 1;
                }
            }

            if (countOfEvens == 0)
            {
                return 0;
            }
            else
            {
                return sumOfEvens / countOfEvens;
            }
        }

        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            int factorial = 1;

            while (number > 0)
            {
                factorial *= number;
                number -= 1;
            }
            return factorial;
        }
    }
}
