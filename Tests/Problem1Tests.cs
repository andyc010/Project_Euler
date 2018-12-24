using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Project_Euler_Problem.Tests
{
    [TestFixture]
    class Problem1Tests
    {
        Project_Euler_Problem.Problems.Problem_1 firstProblem = new Project_Euler_Problem.Problems.Problem_1();

        [Test]
        public void testGetSumOfNumbersLessThan10()
        {
            Assert.AreEqual(23, firstProblem.calculateSumOfMultiplesOf3And5(10));
        }

        [Test]
        public void testGetSumOfNumbersLessThan50()
        {
            Assert.AreEqual(543, firstProblem.calculateSumOfMultiplesOf3And5(50));
        }

        [Test]
        public void testGetSumOfNumbersLessThan100()
        {
            Assert.AreEqual(2318, firstProblem.calculateSumOfMultiplesOf3And5(100));
        }

        [Test]
        public void testGetSumOfNumbersLessThan1000()
        {
            Assert.AreEqual(233168, firstProblem.calculateSumOfMultiplesOf3And5(1000));
        }
    }
}
