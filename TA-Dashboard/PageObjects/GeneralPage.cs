using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TA_Dashboard.Common;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace TA_Dashboard.PageObjects
{
    public class GeneralPage
    {
        public IWebElement FindWebElement(By locator)
        {
            return Constant.driver.FindElement(locator);
        }
        public void Click(By locator)
        {
            FindWebElement(locator).Click();
        }
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
        public void SelectItemByValue(By locator, string value)
        {
            SelectElement selectcontrol = new SelectElement(FindWebElement(locator));
            selectcontrol.SelectByText(value);
        }

        public void SelectItemByIndex(By locator, int index)
        {
            SelectElement selectcontrol = new SelectElement(FindWebElement(locator));
            selectcontrol.SelectByIndex(index);
        }

        public static bool IsElementPresent(By locator)
        {
            try
            {
                Constant.driver.FindElement(locator);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public void Logout()
        {
            if (IsElementPresent(MainPage._tabUser) == true)
            {
                MouseHover(MainPage._tabUser);
                Click(MainPage._tabLogout);
            }
        }
        public void MouseHover(By locator)
        {
            Actions action = new Actions(Constant.driver);
            action.MoveToElement(FindWebElement(locator)).Perform();
        }
        public void ClickTab(string tabName)
        {
            FindWebElement(By.XPath("//a[.='"+tabName+"']")).Click();
        }
        public void ClickButtonChosePanels()
        {
            FindWebElement(MainPage._btnChoosePanels).Click();
        }
    }
}



