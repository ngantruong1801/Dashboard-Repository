using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using System.Threading;
using TA_Dashboard.Common;
using OpenQA.Selenium.Support.UI;


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

        public void Login(string reponsitory, string username, string password)
        {
            //SelectItemByValue(_cboRepository, reponsitory);
            FindWebElement(_cboRepository).SendKeys(reponsitory);
            EnterValue(_txtUsername, username);
            EnterValue(_txtPassword, password);
            Click(_btnLogin);
            //
            Thread.Sleep(1000);
        }
    }
}
