using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;


namespace TA_Dashboard.PageObjects
{
    public class Login:General
    {
        #region Locators
        static readonly By _cboRepository = By.Id("repository");
        static readonly By _txtUsername = By.Id("username");
        static readonly By _txtPassword = By.Id("password");
        static readonly By _btnPassword = By.ClassName("btn-login");
        #endregion
    }
}
