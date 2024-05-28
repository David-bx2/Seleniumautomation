using OpenQA.Selenium;

namespace SeleniumAutomation.PageObjects
{
    public class PastebinHomePage : BasePage
    {
        private IWebElement NewPasteTextArea => Driver.FindElement(By.Id("postform-text"));
        private IWebElement PasteExpirationDropdown => Driver.FindElement(By.Id("select2-postform-expiration-container"));
        private IWebElement PasteNameTitleInput => Driver.FindElement(By.Id("postform-name"));
        private IWebElement CreateNewPasteButton => Driver.FindElement(By.XPath("//button[text()='Create New Paste']"));

        public PastebinHomePage(IWebDriver driver) : base(driver) { }

        public void EnterNewPasteText(string text)
        {
            NewPasteTextArea.SendKeys(text);
        }

        public void SelectPasteExpiration(string expiration)
        {
            PasteExpirationDropdown.Click();
            var expirationOption = Driver.FindElement(By.XPath($"//li[text()='{expiration}']"));
            expirationOption.Click();
        }

        public void EnterPasteNameTitle(string name)
        {
            PasteNameTitleInput.SendKeys(name);
        }

        public void ClickCreateNewPaste()
        {
            CreateNewPasteButton.Click();
        }
    }
}
