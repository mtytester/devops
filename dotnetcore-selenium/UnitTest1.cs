using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading;


namespace dotnetcore_selenium
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test1()
        {

         IWebDriver driver = new ChromeDriver();
         driver.Url = "http://localhost:80/";
            

         IWebElement ele = driver.FindElement(By.LinkText("About"));
         ele.Click();
         Thread.Sleep(20000);
         driver.Close();

        }

        [TestMethod]
        public void Test2() {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://localhost:80/";


            IWebElement ele = driver.FindElement(By.PartialLinkText("Add a Controller and View"));
            ele.Click();
            Thread.Sleep(20000);
            driver.Close();

        }

        [TestMethod]
        public void Test3() {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://localhost:80/";


            IWebElement ele = driver.FindElement(By.LinkText("Contact"));
            ele.Click();
            Thread.Sleep(20000);
            driver.Close();


        }

        [TestMethod]
        public void Test4()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://localhost:80/";


            IWebElement ele = driver.FindElement(By.LinkText("Run your app"));
            ele.Click();
            Thread.Sleep(20000);
            driver.Close();


        }

        [TestMethod]
        public void Test5()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://localhost:80/";


            IWebElement ele = driver.FindElement(By.LinkText("Use logging to log a message."));
            ele.Click();
            Thread.Sleep(20000);
            driver.Close();


        }

        [TestMethod]
        public void Test6()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://localhost:80/";


            IWebElement ele = driver.FindElement(By.LinkText("Security"));
            ele.Click();
            Thread.Sleep(20000);
            driver.Close();


        }
    }
}
