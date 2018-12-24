using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Project_Euler_Problem.Tests
{
    [TestFixture]
    class Problem2Tests
    {
        [Test]
        public void testGetSumOfEvenValueTermsOfFibonacciNumbersWithValuesLessThanOrEqualTo2()
        {
            Project_Euler_Problem.Problems.Problem_2 secondProblem = new Problems.Problem_2();

            Assert.AreEqual(2, secondProblem.calcuateSumEvenNumbersOfFibonacciNumbers(2));
        }

        [Test]
        public void testGetEvenValuedTermsSumOfFibonacciNumbersWithValuesLessThanOrEqualTo5()
        {
            Project_Euler_Problem.Problems.Problem_2 secondProblem = new Problems.Problem_2();

            Assert.AreEqual(2, secondProblem.calcuateSumEvenNumbersOfFibonacciNumbers(5));
        }

        [Test]
        public void testGetEvenValuedTermsSumOfFibonacciNumbersWithValuesLessThanOrEqualTo10()
        {
            Project_Euler_Problem.Problems.Problem_2 secondProblem = new Problems.Problem_2();

            Assert.AreEqual(10, secondProblem.calcuateSumEvenNumbersOfFibonacciNumbers(10));
        }

        [Test]
        public void testGetEvenValuedTermsSumOfFibonacciNumbersWithValuesLessThanOrEqualTo100()
        {
            Project_Euler_Problem.Problems.Problem_2 secondProblem = new Problems.Problem_2();

            Assert.AreEqual(44, secondProblem.calcuateSumEvenNumbersOfFibonacciNumbers(100));
        }
    }
}
