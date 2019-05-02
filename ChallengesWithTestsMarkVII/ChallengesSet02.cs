﻿using System;
using System.Collections.Generic;
using System.Linq;
namespace ChallengesWithTestsMarkVII
{
    public class ChallengesSet02
    {
       
        public bool CharacterIsALetter(char c)
        {
            return Char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return vals.Length%2 == 0;
        }

        public bool IsNumberEven(int number)
        {
            return number%2 == 0;
        }

        public bool IsNumberOdd(int num)
        {
            return num%2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return 0;
            }
            else
            {
                return numbers.Min() + numbers.Max();
            }
        }/* 
            double minNumber =  double.MaxValue;
            double maxNumber = double.MinValue;

            foreach(double number in numbers)
            {
                if (number > maxNumber)
                {
                    maxNumber = number;
                }

                if (number < minNumber)
                {
                    minNumber = number;
                }
            }

            return minNumber + maxNumber;
        }*/

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return Math.Min(str1.Length, str2.Length);

            /*
            if (str1.Length < str2.Length)
            {
                return str1.Length;
            }
            else
            {
                return str2.Length;
            }*/
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            else
            {
                return numbers.Sum();
            }
            /*
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
            */
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            
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
            if (numbers == null)
            {
                return false;
            }
            else
            {
                return numbers.Sum()%2 != 0;
            }
            /*
            foreach (int number in numbers)
            {   
                sum += number;
            }
            
            return (sum % 2 != 0); */
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number < 0)
            {
                return 0;
            }
            else
            {
                return number / 2;
            }
        }
    }
}
