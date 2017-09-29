using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Addtest()
        {
            Assert.AreEqual(3, Code.Class1.Add(1, 2));
        }

        [TestMethod]
        public void Subtracttest()
        {
            Assert.AreEqual(2, Code.Class1.Subtract(4, 2));
        }

    }
}
