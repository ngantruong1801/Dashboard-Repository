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

        public void Login1(string reponsitory, string username, string password)
        {
            WaitForElementLoad(_cboRepository, 3);
            FindWebElement(_cboRepository).SendKeys(reponsitory);
            EnterUserName(username);
            EnterPassword(password);
            Click(_btnLogin);
        }

        public void EnterUserName(string username)
        {
            EnterValue1("username textbox", username);
        }

        public void EnterPassword(string password)
        {
            EnterValue1("password textbox", password);
        }


        public void EnterValue1(string control, string value)
        {
            FindWebElement1(control).Clear();
            FindWebElement1(control).SendKeys(value);
        }
        #endregion
    }
}
