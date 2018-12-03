using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;

namespace dotnetcore_selenium
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            //String path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "chromedriver.exe");
           // Debug.WriteLine(path);
                IWebDriver driver = new ChromeDriver(@"C:\Users\hector.cavazos\Downloads\");
                driver.Url = "http://localhost:58947/";
                Thread.Sleep(5000);
                driver.Close();

            

        }
    }
}
