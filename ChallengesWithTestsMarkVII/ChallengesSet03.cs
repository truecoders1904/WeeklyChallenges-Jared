using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMarkVII
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
<<<<<<< HEAD
            foreach (bool truthoodStatement in vals)
            {
                 if (!truthoodStatement)
                {
                    return true;
                }
            }

            return false;
=======
            throw new NotImplementedException();
>>>>>>> ca3df4e108d94bb802cbedf50327a31785fae67d
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
<<<<<<< HEAD
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
=======
            throw new NotImplementedException();
>>>>>>> ca3df4e108d94bb802cbedf50327a31785fae67d
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
<<<<<<< HEAD
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
=======
            throw new NotImplementedException();
>>>>>>> ca3df4e108d94bb802cbedf50327a31785fae67d
        }

        public char GetFirstLetterOfString(string val)
        {
<<<<<<< HEAD
            //char[] letters = val.ToCharArray();
            return val[0];
=======
            throw new NotImplementedException();
>>>>>>> ca3df4e108d94bb802cbedf50327a31785fae67d
        }

        public char GetLastLetterOfString(string val)
        {
<<<<<<< HEAD
            //char[] letters = val.ToCharArray();
            return val[val.Length-1]; ;
=======
            throw new NotImplementedException();
>>>>>>> ca3df4e108d94bb802cbedf50327a31785fae67d
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
<<<<<<< HEAD
            if (divisor == 0)
            {
                return 0;
            }
            else
            {
                return dividend/divisor;
            }
=======
            throw new NotImplementedException();
>>>>>>> ca3df4e108d94bb802cbedf50327a31785fae67d
        }

        public int LastMinusFirst(int[] nums)
        {
<<<<<<< HEAD
            return nums[nums.Length-1] - nums[0];
=======
            throw new NotImplementedException();
>>>>>>> ca3df4e108d94bb802cbedf50327a31785fae67d
        }

        public int[] GetOddsBelow100()
        {
<<<<<<< HEAD

            int maximum = 100;
            int[] oddsBelowMaximum = new int[maximum/2];
            int counter = 0;
            /*
            for (int i = 0; i < maximum; i++)
            {
                if (i%2 != 0)
                {
                    oddsBelow100[counter] = i;
                    counter += 1;
                }
            }
            */

            for (int i = 1; i < maximum; i += 2)
            {
                oddsBelowMaximum[counter] = i;
                counter += 1;
            }

            return oddsBelowMaximum;
        }

        public string[] ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }

            return words;
=======
            throw new NotImplementedException();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            throw new NotImplementedException();
>>>>>>> ca3df4e108d94bb802cbedf50327a31785fae67d
        }
    }
}
