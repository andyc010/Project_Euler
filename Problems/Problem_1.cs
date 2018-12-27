using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler_Problem.Problems
{
    class Problem_1
    {
        /*
            If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.

            Find the sum of all the multiples of 3 or 5 below 1000.
        */

        // the limit parameter is what the sum must be under
        public int calculateSumOfMultiplesOf3And5(int limit)
        {
            int sum = 0;

            for (int i = 1; i < limit; i++)
            {
                // if the remainder after dividing a particular number is 0, include that number into the sum
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }
    }
}
