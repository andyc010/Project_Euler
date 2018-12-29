using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler_Problem.Problems
{
    class Problem_4
    {
        /* 
         * A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
         * 
         * Find the largest palindrome made from the product of two 3-digit numbers.
         */

        // set beginning value to start, as we don't need numbers with # of digits less than the specified number...
        // for example, for 2 digit numbers, we don't need numbers 0 (or 1?) - 9
        public long setStartValue(long digits)
        {
            long returnValue = 1;

            for (long i = 1; i <= digits - 1; i++)
            {
                returnValue *= 10;
            }

            return returnValue;
        }

        // set ending value, maximum number is 10^x - 1 where x == number of digits in a factor
        // so for a 2-digit number 10^2 == 100 - 1 == 99
        public long setEndValue(long digits)
        {
            long returnValue = 1;

            for (long i = 1; i <= digits; i++)
            {
                returnValue *= 10;
            }
            returnValue -= 1;

            return returnValue;
        }

        // create an array of integers from the provided number (the product)
        public long[] createArray(long product)
        {
            List<long> digitList = new List<long>();

            while (product > 0)
            {
                digitList.Add(product % 10);
                product /= 10;
            }

            return digitList.ToArray();
        }

        // determine if a particular number is a palindrome
        public bool isPalindrome(long number)
        {
            bool returnValue = false;

            // break the number into its individual digits
            long[] digitsArray = createArray(number);

            for (long i = 0; i < digitsArray.Length - 1; i++)
            {
                if (digitsArray[i] == digitsArray[digitsArray.Length - i - 1])
                {
                    returnValue = true;
                }
                else
                {
                    returnValue = false;
                    break;
                }
            }

            return returnValue;
        }

        // the intNumber parameter refers to how many digits both factors need to have, so for example, intNumber == 3 could have
        // factors of 345 & 346
        public long determineLargestPalindromeNumberFromProduct(long intNumberOfDigits)
        {
            long intLargestPalindrome = 0;   // variable containing the largest palindrome number

            long intStartValue = 0;
            intStartValue = setStartValue(intNumberOfDigits);

            
            long intEndValue = 0;
            intEndValue = setEndValue(intNumberOfDigits);

            for (long firstFactor = intStartValue; firstFactor <= intEndValue; firstFactor++)
            {
                for (long secondFactor = intStartValue; secondFactor <= intEndValue; secondFactor++)
                {
                    if (isPalindrome(firstFactor * secondFactor) && intLargestPalindrome < firstFactor * secondFactor)
                    {
                        //Console.WriteLine(firstFactor + " " + secondFactor);
                        intLargestPalindrome = firstFactor * secondFactor;                
                    }
                }                
            }

            return intLargestPalindrome;
        }
    }
}
