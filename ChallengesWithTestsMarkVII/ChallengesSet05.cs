using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMarkVII
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            while(true)
            {
                startNumber += 1;
                if (startNumber%n ==0)
                {
                    break;
                }
            }

            return startNumber;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (Business business in businesses)
            {
                if (business.TotalRevenue <= 0)
                {
                    business.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return false;
            }
            int[] sortedNumbers = new int[numbers.Length];
            Array.Copy(numbers, sortedNumbers, numbers.Length);
            Array.Sort(sortedNumbers);
            return Enumerable.SequenceEqual(numbers, sortedNumbers);
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }

            int sum = 0;

            for(int i = 1; i < numbers.Length; i++)
            {
                sum += (numbers[i-1] % 2 == 0) ? numbers[i] : 0;
            }
            
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0)
            {
                return "";
            }

            string sentence = "";

            foreach (string word in words)
            {
                sentence += (!string.IsNullOrWhiteSpace(word)) ? word.Trim() + " " : "";
            }

            return (sentence.Length > 0) ? sentence.TrimEnd() + "." : "";
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            throw new NotImplementedException();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            throw new NotImplementedException();
        }
    }
}
