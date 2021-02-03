using System;
using HelloWorld;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestApresMidi()
        {
            FakeDateApresMidi TestDate = new FakeDateApresMidi();
            Name TestName = new Name();

            Message MockMessage = new Message( TestName , TestDate);

            Assert.AreEqual(MockMessage.GetMessageByTime(), "Bon Aprés-midi " + Environment.UserName);
        }

        [TestMethod]
        public void TestWeekEnd()
        {
            FakeDateWeekEnd TestDate = new FakeDateWeekEnd();
            Name TestName = new Name();

            Message MockMessage = new Message(TestName, TestDate);

            Assert.AreEqual(MockMessage.GetMessageByTime(), "Bon Week-end " + Environment.UserName);
        }

        [TestMethod]
        public void TestFaux()
        {
            FakeDateApresMidi TestDate = new FakeDateApresMidi();
            Name TestName = new Name();

            Message MockMessage = new Message(TestName, TestDate);

            Assert.AreNotEqual(MockMessage.GetMessageByTime(), "Bonsoir " + Environment.UserName);
            //AreNotEqual /!/ Pour confirmer que c'est faux. Ici que cette heure ci est pas le soir. 
        }
    }
}
