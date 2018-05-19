using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometricLibrary;

namespace UnitTest
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void TestConstructor_WrongNumberOfArgs_Zero()
        {
            Assert.ThrowsException<ArgumentException>(() => new Triangle());
        }

        [TestMethod]
        public void TestConstructor_WrongNumberOfArgs_Less()
        {
            Assert.ThrowsException<ArgumentException>(() => new Triangle(2, 4));
        }

        [TestMethod]
        public void TestConstructor_WrongNumberOfArgs_Greater()
        {
            Assert.ThrowsException<ArgumentException>(() => new Triangle(1, 2, 3, 4));
        }

        [TestMethod]
        public void GetArea_IsValid()
        {
            const Double smallCatheter = 3;
            const Double bigCatheter = 4;
            const Double area = 0.5 * smallCatheter * bigCatheter;
            Assert.AreEqual(area, new Triangle(smallCatheter, bigCatheter, 5).GetArea());
        }

        [TestMethod]
        public void IsRight_IsValid()
        {
            Assert.IsTrue(new Triangle(3, 4, 5).IsRight());
        }

        [TestMethod]
        public void IsRight_IsInvalid()
        {
            Assert.IsFalse(new Triangle(3, 4, 6).IsRight());
        }
    }
}
