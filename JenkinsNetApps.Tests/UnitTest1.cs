using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JenkinsNetApps;

namespace JenkinsNetApps.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            JenkinsNetApps.HomePage.Calculator objcalc = new JenkinsNetApps.HomePage.Calculator();
            Assert.AreEqual(objcalc.Add(1, 3), 4);
        }
    }
}
