using OpenQA.Selenium;

namespace SeleniumAutomation.PageObjects
{
    public class BasePage
    {
        protected IWebDriver Driver;

        public BasePage(IWebDriver driver)
        {
            Driver = driver;
        }
    }
}