using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace TA_Dashboard.PageObjects
{
    public class NewPage : GeneralPage
    {
        #region Locators
        static readonly By _txtPageName = By.Id("name");
        static readonly By _cboParentPage = By.Id("parent");
        static readonly By _cboNumberOfColumns = By.Id("columnnumber");
        static readonly By _cboDisplayAfter = By.Id("afterpage");
        static readonly By _chkPublic = By.Id("ispublic");
        static readonly By _btnOK = By.Id("OK");
        static readonly By _btn_Cancel = By.Id("Cancel");
        #endregion

        #region Methods
        public void AddPage(string pageName, string parentPage, string numberOfColumns, string displayAfter, string status)
        {
            WaitForElementLoad(_txtPageName, 3);
            EnterValue(_txtPageName, pageName);
            SelectValue(_cboParentPage, parentPage);
            SelectValue(_cboNumberOfColumns, numberOfColumns);
            SelectValue(_cboDisplayAfter, displayAfter);
            if (status == "public")
            {
                FindWebElement(_chkPublic).Click();
            }
            FindWebElement(_btnOK).Click();
            Thread.Sleep(2000);
        }
        #endregion

    }
}
