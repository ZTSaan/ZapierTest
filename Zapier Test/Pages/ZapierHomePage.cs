using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zapier_Test.Pages
{
    public class ZapierHomePage
    {
        public IWebDriver Driver { get; private set; }

        [FindsBy(How = How.ClassName, Using = "header__logo")]
        public IWebElement ZapierLogo;

        public ZapierHomePage(IWebDriver _driver)
        {
            Driver = _driver;
        }
    }
}
