using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEulerTests
{
    [TestClass]
    public class AnswersTests
    {

        [TestMethod]
        public void AnswersConstructor_WhenInstantiated_ShouldCreateDictionary()
        {
            // Arrange
            Answers answers;
            long expected = 233168;
            string filepath = @"C:\Users\thomb\source\repos\cs.projecteuler\ProjectEuler\ProjectEulerTests\Answers.txt";

            // Act
            answers = new Answers(filepath);
            long actual = answers.answerDictionary[1];

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
