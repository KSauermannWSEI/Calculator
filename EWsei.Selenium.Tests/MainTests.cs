using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EWsei.Selenium.Tests
{
    public abstract class MainTests
    {
        protected IWebDriver driver;

        [SetUp]
        public void RunBrowser()
        {
            driver = new ChromeDriver(@"C:\drivers");
            driver.Url = "https://e.wsei.edu.pl/";
            //driver = new FirefoxDriver();
        }
        [TearDown]
        public void Close()
        {
            driver.Close();
        }
    }
}
