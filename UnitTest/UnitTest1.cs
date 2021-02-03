using System;
using HelloWorld;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()

        {
            Date TestDate = new Date();
            DateTime CompareDate = new DateTime(2008, 11, 1, 13, 45, 10);

            Assert.AreEqual(TestDate.GetTime(), CompareDate);
      
        }
    }
}
