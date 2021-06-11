using Microsoft.VisualStudio.TestTools.UnitTesting;

using Utility;

namespace ProjectEulerTests
{
    [TestClass]
    public class PatternsTests
    {
        Patterns patterns = new Patterns();

        [TestMethod]
        public void IsPalindrome_WhenGivenAPalindromicInt_ReturnsTrue()
        {
            // Arrange
            int testInt = 1001;
            bool expected = true;

            // Act
            bool actual = patterns.IsPalindrome(testInt);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsPalindrome_WhenGivenANonPalindromicInt_ReturnsFalse()
        {
            // Arrange
            int testInt = 1101;
            bool expected = false;

            // Act
            bool actual = patterns.IsPalindrome(testInt);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsPalindromeSplit_WhenGivenAPalindromicInt_ReturnsTrue()
        {
            // Arrange
            int testInt = 1001;
            bool expected = true;

            // Act
            bool actual = patterns.IsPalindromeSplit(testInt);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsPalindromeSplit_WhenGivenANonPalindromicInt_ReturnsFalse()
        {
            // Arrange
            int testInt = 1101;
            bool expected = false;

            // Act
            bool actual = patterns.IsPalindromeSplit(testInt);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PythagoreanTripletProduct_WhenGiven12_Returns60()
        {
            // Arrange
            int testInt = 12;
            int expected = 60;

            // Act
            int actual = patterns.PythagoreanTripletProduct(testInt);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PythagoreanTriplet_WhenGiven345_ReturnsTrue()
        {
            // Arrange
            int a = 3;
            int b = 4;
            int c = 5;
            bool expected = true;

            // Act
            bool actual = patterns.PythagoreanTriplet(a, b, c);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PythagoreanTriplet_WhenGiven346_ReturnsFalse()
        {
            // Arrange
            int a = 3;
            int b = 4;
            int c = 6;
            bool expected = false;

            // Act
            bool actual = patterns.PythagoreanTriplet(a, b, c);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
