using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEuler;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEulerTests
{
    [TestClass]
    public class SolutionsTests
    {
        private Answers answers = new Answers(@"C:\Users\thomb\source\repos\ProjectEuler\ProjectEulerTests\Answers.txt");
        private Solutions solutions = new Solutions();

        [TestMethod]
        public void Problem1_WhenCalled_ReturnsCorrectAnswer()
        {
            // Arrange
            long expected = answers.answerDictionary[1];

            // Act
            long actual = solutions.Problem1();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Problem2_WhenCalled_ReturnsCorrectAnswer()
        {
            // Arrange
            long expected = answers.answerDictionary[2];

            // Act
            long actual = solutions.Problem2();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Problem3_WhenCalled_ReturnsCorrectAnswer()
        {
            // Arrange
            long expected = answers.answerDictionary[3];

            // Act
            long actual = solutions.Problem3();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Problem4_WhenCalled_ReturnsCorrectAnswer()
        {
            // Arrange
            long expected = answers.answerDictionary[4];

            // Act
            long actual = solutions.Problem4();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Problem5_WhenCalled_ReturnsCorrectAnswer()
        {
            // Arrange
            long expected = answers.answerDictionary[5];

            // Act
            long actual = solutions.Problem5();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Problem6_WhenCalled_ReturnsCorrectAnswer()
        {
            // Arrange
            long expected = answers.answerDictionary[6];

            // Act
            long actual = solutions.Problem6();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Problem7_WhenCalled_ReturnsCorrectAnswer()
        {
            // Arrange
            long expected = answers.answerDictionary[7];

            // Act
            long actual = solutions.Problem7();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Problem8_WhenCalled_ReturnsCorrectAnswer()
        {
            // Arrange
            long expected = answers.answerDictionary[8];

            // Act
            long actual = solutions.Problem8();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Problem9_WhenCalled_ReturnsCorrectAnswer()
        {
            // Arrange
            long expected = answers.answerDictionary[9];

            // Act
            long actual = solutions.Problem9();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Problem10_WhenCalled_ReturnsCorrectAnswer()
        {
            // Arrange
            long expected = answers.answerDictionary[10];

            // Act
            long actual = solutions.Problem10();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
