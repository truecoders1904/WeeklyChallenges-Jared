using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMarkVII
{
    public class ChallengesSet07
    {
        public int CountOfBusinessesWithNegativeNetProfit(List<Business> businesses)
        {
            if (businesses == null)
            {
                return 0;
            }

            int count = 0;
            foreach (Business business in businesses)
            {
                if (business.TotalRevenue - business.TotalExpenses < 0)
                {
                    count += 1;
                }
            }

            return count;
        }

        public string GetCommaSeparatedListOfProfitableBusinesses(List<Business> businesses)
        {
            throw new NotImplementedException();
        }

        public string GetNameOfHighestParentCompany(Business business)
        {
            // If there is Company A, whose parent is Company B, whose parent is Company C, then given Company A return Company C
            throw new NotImplementedException();
        }

        public enum TicTacToeResult { X, O, Draw }
        public TicTacToeResult GetTicTacToeWinner(char[,] finalBoard)
        {
            throw new NotImplementedException();
        }

        public bool EachArrayInJaggedArrayContainsTargetNumber(int[][] numbers, int targetNumber)
        {
            if (numbers == null || numbers.Length == 0)
                return false;

            bool containsTargetNumber = true;
            
            foreach (int[] nums in numbers)
            {
                if (!nums.Contains(targetNumber))
                    containsTargetNumber = false;
            }

            return containsTargetNumber;
        }
    }
}
