using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TA_Dashboard.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TA_Dashboard.PageObjects
{
    public class CommonActions
    {
        public IWebElement FindWebElement(By locator)
        {
            return Constant.driver.FindElement(locator);
        }
        //public void Click(By locator)
        //{
        //    FindWebElement(locator).Click();
        //}
        public void EnterValue(By locator, string value)
        {
            FindWebElement(locator).Clear();
            FindWebElement(locator).SendKeys(value);
        }
        public string GetTextControl(By locator)
        {
            return Constant.driver.FindElement(locator).Text;
        }
        public void ConfirmPopup()
        {
            Constant.driver.SwitchTo().Alert().Accept();
        }
        public string GetTextPopup()
        {
            return Constant.driver.SwitchTo().Alert().Text;
        }
        public static void CheckTextDisplays(string expectedText, string actualText)
        {
            Assert.AreEqual(expectedText, actualText);
        }
    }
}
