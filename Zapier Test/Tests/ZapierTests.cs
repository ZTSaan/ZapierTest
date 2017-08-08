using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zapier_Test.Pages;

namespace Zapier_Test.Tests
{
   
    [TestFixture]
    public class ZapierTests
    {
        public IWebDriver driver = new ChromeDriver();
        public ZapierHomePage zapierHomePage;
        string url = "https://zapier.com/";

        [SetUp]

        public void Initialize()
        {
            zapierHomePage = new ZapierHomePage(driver);
            PageFactory.InitElements(driver, zapierHomePage);

            driver.Navigate().GoToUrl(url);
        }

        [Test]

        public void ZapierLogoIsVisible()
        {

            bool logoIsPresent = zapierHomePage.ZapierLogo.Displayed;

            Assert.True(logoIsPresent);
        }

        [TearDown]

        public void TearDownTests()
        {
            driver.Quit();
        }
    }
}
