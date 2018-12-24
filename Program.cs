using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler_Problem
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Problems.Problem_1 firstProblem = new Problems.Problem_1();

            Problems.Problem_2 secondProblem = new Problems.Problem_2();

            //int value = firstProblem.calculateSumOfMultiplesOf3And5(100);

            //Console.WriteLine("The sum of multiples of 3 & 5 less than 100 is: " + value);
            //Console.ReadKey();

            int intLimit = 4000000;
            Console.WriteLine("The sum of the even-numbered terms less than " + intLimit.ToString() + " is: " + secondProblem.calcuateSumEvenNumbersOfFibonacciNumbers(intLimit));
            Console.ReadKey();

        }
    }
}
