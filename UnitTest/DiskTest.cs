using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometricLibrary;

namespace UnitTest
{
    [TestClass]
    public class DiskTest
    {
        [TestMethod]
        public void TestConstructor_WrongRadius()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Disk(-1));
        }

        [TestMethod]
        public void TestConstructor_DefaultRadius()
        {
            Assert.AreEqual(0, new Disk().Radius);
        }

        [TestMethod]
        public void TestConstructor_ValidRadius()
        {
            const Double radius = 1.0;
            Assert.AreEqual(radius, new Disk(radius).Radius);
        }

        [TestMethod]
        public void TestGetArea_ValidArea()
        {
            const Double radius = 1.0;
            const Double area = Math.PI * radius * radius;
            Assert.AreEqual(area, new Disk(radius).GetArea());
        }
    }
}
