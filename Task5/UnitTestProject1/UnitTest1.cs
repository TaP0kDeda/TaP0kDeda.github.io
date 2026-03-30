using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Task5;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var slovar = new Slovar();
            slovar.AddWord("собака");
            slovar.AddWord("стол");

            var result = slovar.FindWordForms("ход");
            Assert.Empty(result);
        }
    }
}
