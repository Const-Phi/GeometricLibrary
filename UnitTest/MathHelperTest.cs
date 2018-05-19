using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometricLibrary;

namespace UnitTest
{
    [TestClass]
    public class MathHelperTest
    {
        [TestMethod]
        public void IsNearValid()
        {
            Assert.IsTrue(MathHelper.IsNear(1, 1, 0.1));
        }

        [TestMethod]
        public void IsNearInvalid()
        {
            Assert.IsFalse(MathHelper.IsNear(1, 2, 0.1));
        }

        [TestMethod]
        public void IsPythagoreanTripleValid()
        {
            Assert.IsTrue(MathHelper.IsPythagoreanTriple(3, 4, 5));
        }

        [TestMethod]
        public void IsPythagoreanTripleInvalid()
        {
            Assert.IsFalse(MathHelper.IsPythagoreanTriple(3, 4, 6));
        }
    }
}
