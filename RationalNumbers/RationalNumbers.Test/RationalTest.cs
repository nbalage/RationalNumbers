using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RationalNumbers;

namespace RationalNumbers.Test
{
    [TestClass]
    public class RationalTest
    {
        [TestMethod]
        public void GcdTest()
        {
            // Arrange
            var x = 12;
            var y = 6;

            // Act
            var gcd = Rational.Gcd(x, y);

            // Assert
            Assert.AreEqual(gcd, 6);
        }

        [TestMethod]
        public void RationalObjectsEqual()
        {
            // Arrange
            var rat1 = new Rational(8, 6);
            var rat2 = new Rational(4, 3);

            // Act
            var eq1 = rat1.Equals(rat2);
            var eq2 = rat2.Equals(rat1);

            // Assert
            Assert.IsTrue(eq1);
            Assert.IsTrue(eq2);
        }

        [TestMethod]
        public void RationalObjectNotEqual()
        {
            // Arrange
            var rat1 = new Rational(8, 6);
            var rat2 = new Rational(8, 7);

            // Act
            var eq1 = rat1.Equals(rat2);
            var eq2 = rat2.Equals(rat1);

            // Assert
            Assert.IsFalse(eq1);
            Assert.IsFalse(eq2);
        }

        [TestMethod]
        public void CompareToTest()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void AdditionOperatorTest()
        {
            // Arrange
            var rat1 = new Rational(8, 6);
            var rat2 = new Rational(7, 6);

            // Act
            var rat = rat1 + rat2;

            // Assert
            Assert.AreEqual(new Rational(15, 6), rat);
        }

        [TestMethod]
        public void SubtractionOperatorTest()
        {
            // Arrange
            var rat1 = new Rational(8, 6);
            var rat2 = new Rational(7, 6);

            // Act
            var rat = rat1 - rat2;

            // Assert
            Assert.AreEqual(new Rational(1, 6), rat);
        }

        [TestMethod]
        public void MultiplicationOperatorTest()
        {
            // Arrange
            var rat1 = new Rational(8, 6);
            var rat2 = new Rational(7, 6);

            // Act
            var rat = rat1 * rat2;

            // Assert
            Assert.AreEqual(new Rational(56, 36), rat);
        }

        [TestMethod]
        public void DivisionOperatorTest()
        {
            // Arrange
            var rat1 = new Rational(3, 4);
            var rat2 = new Rational(5, 7);

            // Act
            var rat = rat1 / rat2;

            // Assert
            Assert.AreEqual(new Rational(21, 20), rat);
        }
    }
}
