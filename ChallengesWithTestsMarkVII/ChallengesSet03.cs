﻿using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMarkVII
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach (bool truthoodStatement in vals)
            {
                 if (!truthoodStatement)
                {
                    return true;
                }
            }

            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }

            int sum = 0;

            foreach (int number in numbers)
            {
                if (number % 2 != 0)
                {
                    sum += number;
                }
            }

            return (sum % 2 != 0);
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool containsUpper = false;
            bool containsLower = false;
            bool containsNumber = false;

            foreach (char c in password)
            {
                if (Char.IsUpper(c))
                {
                    containsUpper = true;
                }
                else if (Char.IsLower(c))
                {
                    containsLower = true;
                }
                else if (Char.IsNumber(c))
                {
                    containsNumber = true;
                }
            }

            return (containsUpper && containsLower && containsNumber);
        }

        public char GetFirstLetterOfString(string val)
        {
            char[] letters = val.ToCharArray();
            return letters[0];
        }

        public char GetLastLetterOfString(string val)
        {
            char[] letters = val.ToCharArray();
            return letters[letters.Length-1]; ;
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            else
            {
                return dividend/divisor;
            }
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length-1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            throw new NotImplementedException();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            throw new NotImplementedException();
        }
    }
}
