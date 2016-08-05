using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;


namespace TA_Dashboard.PageObjects
{
    public class LoginPage:GeneralPage
    {
        #region Locators
        static readonly By _cboRepository = By.Id("repository");
        static readonly By _txtUsername = By.Id("username");
        static readonly By _txtPassword = By.Id("password");
        static readonly By _btnLogin = By.ClassName("btn-login");
        #endregion

        public void Login(string responsitory, string username, string password)
        {
            SelectItemByValue(_cboRepository, responsitory);
            EnterValue(_txtUsername, username);
            EnterValue(_txtPassword, password);
            Click(_btnLogin);
        }
    }
}
