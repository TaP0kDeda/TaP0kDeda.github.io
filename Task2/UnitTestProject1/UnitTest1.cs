using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Task2;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int i = 2;
            int n = 10;
            string res = "1010"
            string act = Notation.CountNotation(i, n);
            Assert.AreEqual(res, act, 0.001, "Ожидаемое значение не получено");

        }
    }
}
