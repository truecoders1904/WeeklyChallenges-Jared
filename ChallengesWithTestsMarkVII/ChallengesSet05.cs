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
            if (numbers != null && numbers.Length > 0)
            {
                int[] sortedNumbers = new int[numbers.Length];
                Array.Copy(numbers, sortedNumbers, numbers.Length);
                Array.Sort(sortedNumbers);
                return Enumerable.SequenceEqual(numbers, sortedNumbers);
            }

            return false;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            int sum = 0;

            if (numbers != null && numbers.Length > 0)
            {
                for (int i = 1; i < numbers.Length; i++)
                {
                    sum += (numbers[i - 1] % 2 == 0) ? numbers[i] : 0;
                }
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
           
           List<double> fourthElements = new List<double>();

           if (elements != null && elements.Count > 0)
            {
                for (int i = 3; i < elements.Count; i += 4)
                {
                    fourthElements.Add(elements[i]);
                }
            }

            return fourthElements.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {


            if (nums == null || nums.Length == 0)
            {
                return false;
            }

            for (int i = 0; i < nums.Length; i++)
                {
                    for (int j = 0; j < nums.Length; j++)
                    {
                        if (j != i && nums[j] + nums[i] == targetNumber)
                        {
                            return true;
                        }
                    }
                }

            return false;
        }
    }
}
