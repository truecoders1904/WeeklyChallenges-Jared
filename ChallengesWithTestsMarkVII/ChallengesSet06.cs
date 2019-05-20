using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMarkVII
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {

            if (words == null)
            {
                return false;
            }

            foreach (string wrd in words)
            {
                if (ignoreCase && wrd != null && wrd.ToLower() == word.ToLower())
                {
                    return true;
                }
                else if (!ignoreCase && wrd != null && wrd == word)
                {
                    return true;
                }
            }

            return false;
        }

        public bool IsPrimeNumber(int num)
        {
            if (num < 2)
            {
                return false;
            }

            for (int i = 2; i < num; i++)
            {
                if (num%i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (str.Count(x => x == str[i]) == 1)
                {
                    return i;
                }
            }
            return -1;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if (elements == null || n <= 0)
            {
                return new double[0];
            }
           
            List<double> nthElements = new List<double>();

            for (int i = n - 1; i < elements.Count(); i+= n)
            {
                nthElements.Add(elements[i]);
            }

            return nthElements.ToArray();
        }
    }
}
