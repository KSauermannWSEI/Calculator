using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using SeleniumExtras.PageObjects;
using System;

namespace EWsei.Selenium.Tests
{
    [TestFixture]
    public class EWseiTests : MainTests
    {

        [Test]
        public void GoToLoginPage()
        {
            //LoginPage loginPage = new LoginPage(driver);
            //var x = loginPage.Login;
            var login = driver.FindElement(By.XPath(".//a[text()='Logowanie']"));
            login.Click();
            var loginpanel = driver.FindElement(By.ClassName("loginpanel"));            
            Assert.IsTrue(loginpanel.Displayed);
        }
        [Test]
        public void GoToLoginPage2()
        {
            LoginPage loginPage = new LoginPage(driver);           
            loginPage.Login.Click();            
            Assert.IsTrue(loginPage.LoginPanel.Displayed);
        }
        [Test]
        public void LoginWrongPassword()
        {           
            var login = driver.FindElement(By.XPath(".//a[text()='Logowanie']"));
            login.Click();
            var username = driver.FindElement(By.Id("username"));
            username.SendKeys("username");
            var password = driver.FindElement(By.Id("password"));
            password.SendKeys("password");
            var loginbtn = driver.FindElement(By.Id("loginbtn"));
            loginbtn.SendKeys("loginbtn");
            loginbtn.Submit();
            var error = driver.FindElement(By.ClassName("error"));
            //var error = driver.FindElement(By.CssSelector(".error"));
            StringAssert.StartsWith("Niewłaściwa", error.Text);
        }

    }
}
