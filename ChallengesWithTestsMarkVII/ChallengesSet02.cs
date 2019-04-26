using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMarkVII
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return (Char.IsLetter(c));
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return (vals.Length%2 == 0);
        }

        public bool IsNumberEven(int number)
        {
            return (number%2 == 0);
        }

        public bool IsNumberOdd(int num)
        {
            return (num%2 != 0);
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            double minNumber =  999;
            double maxNumber = -999;

            foreach(double number in numbers)
            {
                if (number > maxNumber)
                {
                    maxNumber = number;
                }
            }

            foreach (double number in numbers)
            {
                if (number < minNumber)
                {
                    minNumber = number;
                }
            }

            return minNumber + maxNumber;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length < str2.Length)
            {
                return str1.Length;
            }
            else
            {
                return str2.Length;
            }
        }

        public int Sum(int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
            
        }

        public int SumEvens(int[] numbers)
        {
            int sum = 0;

            foreach (int number in numbers)
            {
                if (number%2 == 0)
                {
                    sum += number;
                }
            }

            return sum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            int sum = 0;

            foreach (int number in numbers)
            {
                sum += number;
            }

            return (sum % 2 != 0);
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            int counter = 0;

            for (int i = 0; i < number; i++)
            {
                if (i%2 != 0)
                {
                    counter += 1;
                }
            }

            return counter;
        }
    }
}
