using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using dotnetcore_sample.Controllers; 

namespace dotnetcore_tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void About()
        {
          // Arrange
          HomeController controller = new HomeController();

          // Act
          ViewResult result = controller.About() as ViewResult;

          // Assert
          Assert.AreEqual("Your application description page.", result.ViewData["Message"]);
        }

        [TestMethod]
        public void Contact()
        {
          // Arrange
          HomeController controller = new HomeController();

          // Act
          ViewResult result = controller.Contact() as ViewResult;

          // Assert
          Assert.AreEqual("Your contact page.", result.ViewData["Message"]);
        }

        [TestMethod]
        public void parallel1() {

            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(30));
            Assert.IsTrue(5>1);
        }
        [TestMethod]
        public void parallel2()
        {

            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(30));
            Assert.IsTrue(10<50);
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
        
        //From here tests last longer
        [TestMethod]
        public void parallel7()
        {

            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(40));
            Assert.IsTrue(5 > 1);
        }

        [TestMethod]
        public void parallel8()
        {

            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(40));
            Assert.IsTrue(5 > 1);
        }

        [TestMethod]
        public void parallel9()
        {

            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(40));
            Assert.IsTrue(5 > 1);
        }

        [TestMethod]
        public void parallel10()
        {

            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(40));
            Assert.IsTrue(5 > 1);
        }

        [TestMethod]
        public void parallel11()
        {

            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(40));
            Assert.IsTrue(5 > 1);
        }

        [TestMethod]
        public void parallel12()
        {

            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(40));
            Assert.IsTrue(5 > 1);
        }


    }
}
