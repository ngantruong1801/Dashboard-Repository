using System;
using System.Threading;
using TA_Dashboard.Common;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace TA_Dashboard.PageObjects
{
    public class GeneralPage
    {
        #region Locators
        public static readonly By _tabAdminister = By.XPath("//a[@href='#Administer']");
        public static readonly By _tabGlobalSetting = By.XPath("//li[@class='mn-setting']/a");
        public static readonly By _subTabAddPage = By.XPath("//div[@id='main-menu']//a[@class='add' and .='Add Page']");
        public static readonly By _subTabCreateProfile = By.XPath("//a[.='Create Profile']");
        public static readonly By _subTabCreatePanel = By.XPath("//a[.='Create Panel']");
        public static readonly By _subTabDelete = By.XPath(".//a[@class='delete' and .='Delete']");
        public static readonly By _btnChoosePanels = By.Id("btnChoosepanel");
        public static readonly By _tabOverview = By.XPath("//a[.='Overview']");
        public static readonly By _tabExecutionDashboard = By.XPath("//a[.='Execution Dashboard']");
        public static readonly By _tabLogout = By.XPath("//div[@id='header']//a[.='Logout']");
        #endregion

        #region Methods
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

        public void SelectValue(By locator, string value)
        {
            FindWebElement(locator).SendKeys(value);
        }

        public string GetTextControl(By locator)
        {
            WaitForElementLoad(locator, 3);
            return Constant.driver.FindElement(locator).Text;
        }

        public void ConfirmPopup()
        {
            Thread.Sleep(1000);
            Constant.driver.SwitchTo().Alert().Accept();
        }

        public string GetTextPopup()
        {
            Thread.Sleep(1000);
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

        public bool IsElementPresent(By locator)
        {
            try
            {
                return FindWebElement(locator).Displayed;
                
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public void Logout()
        {
            WaitForElementLoad(MainPage._tabUser, 3);
            MouseHover(MainPage._tabUser);
            Click(MainPage._tabLogout);
        }

        public void MouseHover(By locator)
        {
            Actions action = new Actions(Constant.driver);
            action.MoveToElement(FindWebElement(locator)).Perform();
            Thread.Sleep(1000);
        }

        public void WaitForElementLoad(By locator, int timeoutInSeconds)
        {
            if (timeoutInSeconds > 0)
            {
                WebDriverWait wait = new WebDriverWait(Constant.driver, TimeSpan.FromSeconds(timeoutInSeconds));
                wait.Until(ExpectedConditions.ElementIsVisible(locator));
            }
        }

        public void ClickTab(string tabName)
        {
            FindWebElement(By.XPath("//a[.='" + tabName + "']")).Click();
        }

        public void ClickButtonChosePanels()
        {
            FindWebElement(MainPage._btnChoosePanels).Click();
        }

        public void OpenAddPageDialog()
        {
            MouseHover(_tabGlobalSetting);
            Click(_subTabAddPage);
        }

        public void DeletePage(string pageName)
        {
            ClickTab(pageName);
            MouseHover(_tabGlobalSetting);
            Click(_subTabDelete);
            IAlert alert = Constant.driver.SwitchTo().Alert();
            alert.Accept();
        }

        #endregion
    }
}



