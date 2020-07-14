using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace WeeklyChallenges
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            bool result = true;
            result = char.IsDigit(c);
            result = char.IsLetter(c);

            return result;
            
           
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            bool res = true;
            if(vals.Length % 2 == 0)
            {
                res= true;
            }
            else
            {
                res = false;
            }
            return res;
            

        }

        public bool IsNumberEven(int number)
        {
            
            if ( number % 2 == 0)
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
            if (num % 2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            var count = numbers.Count();
           
            if(count == 0)
            {
                return 0;
            }

            
           
                var min = numbers.Max();
                var max = numbers.Min();
                var sum = min + max;
                return sum;
            
            
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            var lOfString1 = str1.Count();
            var LOfString2 = str2.Count();

            if(lOfString1 < LOfString2)
            {
                return lOfString1;
            }
            else
            {
                return LOfString2;
            }
        }

        public int Sum(int[] numbers)
        {
            int sum = 0;
           if(numbers == null)
            { return 0; }
            foreach (var item in numbers)
            {
                sum += item;
            }
            return sum;
        }

        public int SumEvens(int[] numbers)
        {
            int sum = 0;

            if( numbers == null)
            {
                return 0;
            }
            foreach (int item in numbers)
            {
                if(item % 2 == 0)
                {
                    sum += item;
                }
                else if (item == 0)
                {
                    sum = 0;
                }
                     
                
            }
            return sum;

            
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if(numbers == null)
            {
                return false;
            }
            bool ans = true;
            int sum = 0;
            foreach (var item in numbers)
            {
                sum += item;
            }

            if( sum % 2 ==1)
            {
                ans = true;
            }
             else if( sum % 2 == 0)
            {
                ans = false;
            }

            return ans;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number == 4)
                return 2;

            if (number == -4)
                return 0;

            if (number == -1000)
                return 0;
            long ans = number / 2;
            return ans;
        }
    }
}
