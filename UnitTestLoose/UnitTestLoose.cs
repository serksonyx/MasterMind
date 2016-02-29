using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MasterMindLogik;

namespace UnitTestLoose
{
    [TestClass]
    public class UnitTestLoose
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool test = Logik.Won(new[] { 0, -1, -1, -1 });
            Assert.IsFalse(test);
        }
    }
}

