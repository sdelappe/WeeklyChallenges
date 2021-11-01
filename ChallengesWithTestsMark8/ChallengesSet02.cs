using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            var num = vals.Count();
            if (num % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberEven(int number)
        {
            var num = number;

            if (num % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberOdd(int num)
        {
            var number = num;

            if (number % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return 0;
            }

            var numMax = numbers.Max();
            var numMin = numbers.Min();

            var answer = numMax + numMin;

            return answer;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            var length1 = str1.Length;
            var length2 = str2.Length;

            if (length1 < length2)
            {
                return length1;
            }
            else
            {
                return length2;
            }
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            else
            {
                var answer = numbers.Sum();

                return answer;
            }
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            else
            {
                var sum = 0;

                foreach (var num in numbers)
                {
                    if (num % 2 == 0)
                    {
                        sum += num;
                    }
                }

                return sum;
            }
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
                return false;

            var sum = numbers.Sum();

            if (sum % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number <= 0)
            {
                return 0;
            }

            long count = 0;

            for (long i = number-1; i > 0; i--)
            {
                if (i % 2 != 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
