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
        [FindsBy(How = How.Id, Using = "page")]
        public IWebElement Login { get; set; }
    }
}
