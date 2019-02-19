using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EWsei.Selenium.Tests
{
    public class LoginPage
    {
        private IWebDriver driver;
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = ".//a[text()='Logowanie']")]
        public IWebElement Login { get; set; }

        [FindsBy(How = How.ClassName, Using = "loginpanel")]
        public IWebElement LoginPanel { get; set; }
    }
}
