using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MasterMindLogik;

namespace WonTest
{
    [TestClass]
    public class UnitTestWon
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool test = Logik.Won(new[] { -1, -1, -1, -1 });
            Assert.IsTrue(test);
        }
    }
}
