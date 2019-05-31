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
                if (business.TotalRevenue < business.TotalExpenses)
                {
                    count += 1;
                }
            }
            return count;
        }

        public string GetCommaSeparatedListOfProfitableBusinesses(List<Business> businesses)
        {
            if (businesses == null)
            {
                return "";
            }

            string namesOfProfitableBusinesses = "";

            foreach (Business business in businesses)
            {
                if (business.TotalRevenue > business.TotalExpenses)
                {
                    namesOfProfitableBusinesses += $"{business.Name},";
                }
            }

            return namesOfProfitableBusinesses.TrimEnd(',');
        }

        public string GetNameOfHighestParentCompany(Business business)
        {
            string nameOfParentCompany = business.Name;

            while(business.ParentCompany != null)
            {
                nameOfParentCompany = business.ParentCompany.Name;
                business = business.ParentCompany;
            }
            return nameOfParentCompany;
        }

        public enum TicTacToeResult { X, O, Draw }
        public TicTacToeResult GetTicTacToeWinner(char[,] board)
        {
            if (checkWinner(board[0,0],board[1,1],board[2,2]) || checkWinner(board[0, 2], board[1, 1], board[2, 0]))
            {
                return returnWinner(board[1, 1]);
            }
            
            for (int i = 0; i < board.GetLength(0); i++)
            {
                if (checkWinner(board[i,0],board[i,1],board[i,2]))
                {
                    return returnWinner(board[i, 0]);
                }
                else if (checkWinner(board[0,i],board[1,i],board[2,i]))
                {
                    return returnWinner(board[0,i]);
                }
            }
            return TicTacToeResult.Draw;
        }
        private bool checkWinner(char a, char b, char c)
        {
            return (a == b && b == c);
        }

        private TicTacToeResult returnWinner(char c)
        {
            if (c == 'X')
            {
                return TicTacToeResult.X;
            }
            else
            {
                return TicTacToeResult.O;
            }
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
