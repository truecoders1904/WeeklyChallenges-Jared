using System;
using System.Collections.Generic;

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
            throw new NotImplementedException();
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            throw new NotImplementedException();
        }
    }
}
