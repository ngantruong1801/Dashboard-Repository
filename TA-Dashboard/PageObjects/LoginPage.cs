using OpenQA.Selenium;

namespace TA_Dashboard.PageObjects
{
    public class LoginPage:GeneralPage
    {
        #region Locators
        public static readonly By _cboRepository = By.Id("repository");
        static readonly By _txtUsername = By.Id("username");
        static readonly By _txtPassword = By.Id("password");
        static readonly By _btnLogin = By.ClassName("btn-login");
        #endregion

        #region Methods
        public void Login(string reponsitory, string username, string password)
        {
            WaitForElementLoad(_cboRepository, 3);
            FindWebElement(_cboRepository).SendKeys(reponsitory);
            EnterValue(_txtUsername, username);
            EnterValue(_txtPassword, password);
            Click(_btnLogin);          
        }

        #endregion
    }
}
