using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TA_Dashboard.Common;


namespace TA_Dashboard.PageObjects
{
    public class CommonActions
    {
        public void Click(By control)
        {
            Constant.driver.FindElement(control).Click();
        }
        public void Type(By control, string value)
        {
            Constant.driver.FindElement(control).Clear();
            Constant.driver.FindElement(control).SendKeys(value);
        }
        public string GetTextOfControl(By control)
        {
            return Constant.driver.FindElement(control).Text;
        }
        public void ConfirmPopup()
        {
            Constant.driver.SwitchTo().Alert().Accept();
        }
        public string GetTextOfPopup()
        {
            return Constant.driver.SwitchTo().Alert().Text;
        }
    }
}
