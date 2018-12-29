using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Project_Euler_Problem.Tests
{
    [TestFixture]
    class Problem4Tests
    {
        Problems.Problem_4 problem4 = new Problems.Problem_4();

        [Ignore]
        public void testGetLargestPalindromeWith1DigitFactors()
        {
            Assert.AreEqual(9, problem4.determineLargestPalindromeNumberFromProduct(1));
        }

        [Test]
        public void testGetLargestPalindromeWith2DigitFactors()
        {
            Assert.AreEqual(9009, problem4.determineLargestPalindromeNumberFromProduct(2));
        }
    }
}
