using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace dotnetcore_tests_second
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void parallel1()
        {

            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(30));
            Assert.IsTrue(5 > 1);
        }
        [TestMethod]
        public void parallel2()
        {

            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(30));
            Assert.IsTrue(10 < 50);
        }
        [TestMethod]
        public void parallel3()
        {

            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(30));
            Assert.IsTrue(5 > 1);
        }

        [TestMethod]
        public void parallel4()
        {

            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(30));
            Assert.IsTrue(5 > 1);
        }
        [TestMethod]
        public void parallel5()
        {

            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(30));
            Assert.IsTrue(5 > 1);
        }
        [TestMethod]
        public void parallel6()
        {

            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(30));
            Assert.IsTrue(5 > 1);
        }
        [TestMethod]
        public void parallel7()
        {

            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(30));
            Assert.IsTrue(5 > 1);
        }
    }
}
