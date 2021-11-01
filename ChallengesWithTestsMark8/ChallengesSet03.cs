using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            return vals.Contains(false);
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            var oddSum = 0;

            if (numbers == null)
            {
                return false;
            }

            foreach (var num in numbers)
            {
                if (num % 2 != 0)
                {
                    oddSum += num;
                }
            }

            if (oddSum % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            var hasUpper = false;
            var hasLower = false;
            var hasNumber = false;

            if (password.Any(char.IsUpper))
            {
                hasUpper = true;
            }

            if (password.Any(char.IsLower))
            {
                hasLower = true;
            }

            if (password.Any(char.IsDigit))
            {
                hasNumber = true;
            }

            if (hasUpper && hasLower && hasNumber)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            var end = val.Length - 1;

            return val[end];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (dividend == 0 || divisor == 0)
            {
                return 0;
            }

            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            var end = nums.Length - 1;

            return nums[end] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            int x = 1;

            int[] odds = new int[50];
            for (int i = 0; i < odds.Length; i++)
            {
                odds[i] = x;
                x += 2;
            }

            return odds;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
