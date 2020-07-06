using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace WeeklyChallenges
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            bool result;
           result =char.IsLetter(c);
            return result;

           
        }

        public bool CountOfElementsIsEven(string[] vals)
        {

            return true;

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
            throw new NotImplementedException();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            throw new NotImplementedException();
        }

        public int Sum(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public int SumEvens(int[] numbers)
        {
            var even = 0;
            foreach (var num in numbers)
            {
                if (num % 2 == 0)
                { even = +num; } 
            }

            return even;
           
            
        }

        public bool IsSumOdd(List<int> numbers)
        {
            throw new NotImplementedException();
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            throw new NotImplementedException();
        }
    }
}
