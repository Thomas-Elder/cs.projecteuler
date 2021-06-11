using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

using Utility;

namespace ProjectEulerTests
{
    [TestClass]
    public class MultiplesTests
    {
        Multiples multiples = new Multiples();

        [TestMethod]
        public void DivisibleBy_WhenGivenArrayOfDivisors_ReturnsTrue()
        {
            // Arrange
            bool expected = true;
            int n = 6;
            int [] a = { 2, 3 };

            // Act
            bool actual = multiples.DivisibleBy(n, a); 

            // Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void MultiplesBelowAndOf_WhereOneParameterPassed_ReturnsExpectedMultiples()
        {
            // Arrange
            int n = 10;
            int a = 3;
            List<int> expected = new List<int>();
            expected.Add(3);
            expected.Add(6);
            expected.Add(9);

            // Act
            List<int> actual = multiples.MultiplesBelowAndOf(n, a);

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MultiplesBelowAndOf_WhereTwoParamaterPassed_ReturnsExpectedMultiples()
        {
            // Arrange
            int n = 10;
            int a = 3;
            int b = 5;

            List<int> expected = new List<int>();
            expected.Add(3);
            expected.Add(5);
            expected.Add(6);
            expected.Add(9);

            // Act
            List<int> actual = multiples.MultiplesBelowAndOf(n, a, b);

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsPrime_WhenGivenAPrimeNumber_ReturnsTrue()
        {
            // Arrange
            int testPrime = 11;
            bool expected = true;

            // Act
            bool actual = multiples.IsPrime(testPrime);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsPrime_WhenGivenANonPrimeNumber_ReturnsFalse()
        {
            // Arrange
            int testPrime = 10;
            bool expected = false;

            // Act
            bool actual = multiples.IsPrime(testPrime);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsPrime_Prime_WhenGivenAPrimeNumber_ReturnsTrue()
        {
            // Arrange
            int testPrime = 11;
            bool expected = true;

            // Act
            bool actual = multiples.IsPrime_Prime(testPrime);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsPrime_Prime_WhenGivenANonPrimeNumber_ReturnsFalse()
        {
            // Arrange
            long testPrime = 25;
            bool expected = false;

            // Act
            bool actual = multiples.IsPrime_Prime(testPrime);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SumOfSquares_WhenGiven10_Returns385()
        {
            // Arrange
            long n = 10;
            long expected = 385;

            // Act
            long actual = multiples.SumOfSquares(n);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SquareOfSum_WhenGiven10_Returns3025()
        {
            // Arrange
            long n = 10;
            long expected = 3025; 

            // Act
            long actual = multiples.SquareOfSum(n);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
