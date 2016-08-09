using OpenQA.Selenium;

namespace TA_Dashboard.PageObjects
{
    public class MainPage:GeneralPage
    {
        #region Locators
        public static readonly By _tabUser = By.XPath("//a[@href='#Welcome']");
        public static readonly By _tabRepository = By.XPath("//a[@href='#Repository']");
        public static readonly By _lblRepository = By.XPath("//a[@href='#Repository']/span");
        public static readonly By _popupLoginRepository = By.XPath("//h2[text()='Login Repository']");

        #endregion

        #region Methods
        public void ChooseRepository(string repository)
        {
            WaitForElementLoad(_tabRepository,3);
            MouseHover(_tabRepository);
            ClickTab(repository);
        }

        public string GetWelcomeText()
        {
            return GetTextControl(_tabUser);
        }

        public string GetRepository()
        {
            WaitForElementLoad(_lblRepository,3);
            return GetTextControl(_lblRepository);
        }

        public bool IsLoginRepositoryDisplay()
        {
            return IsElementPresent(_popupLoginRepository);
        }

        #endregion
    }
}
