using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumAutomation.PageObjects;
using System;

namespace SeleniumAutomation.Tests
{
    [TestFixture]
    public class PastebinTests
    {
        private IWebDriver _driver;

        [SetUp]
        public void SetUp()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [Test]
        public void CreateNewPasteTest()
        {
            _driver.Navigate().GoToUrl("https://pastebin.com");

            var pastebinHomePage = new PastebinHomePage(_driver);
            pastebinHomePage.EnterNewPasteText("Hello from WebDriver");
            pastebinHomePage.SelectPasteExpiration("10 Minutes");
            pastebinHomePage.EnterPasteNameTitle("helloweb");
            pastebinHomePage.ClickCreateNewPaste();

            // Agregar validaciones según sea necesario
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
            _driver.Dispose();
        }
    }
}


