using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TA_Dashboard.Common;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using System.Threading;


namespace TA_Dashboard.PageObjects
{
    public class GeneralPage
    {
        #region Locators
        public static readonly By _tabUser = By.XPath("//a[@href='#Welcome']");
        //public static readonly By _tabUser = By.XPath("//a[text()='administrator']");

        public static readonly By _tabRepository = By.XPath("//a[@href='#Repository']");
        public static readonly By _tabAdminister = By.XPath("//a[@href='#Administer']");
        public static readonly By _tabGlobalSetting = By.XPath("//li[@class='mn-setting']/a");
        public static readonly By _subTabAddPage = By.XPath("//div[@id='main-menu']//a[@class='add' and .='Add Page']");
        public static readonly By _subTabCreateProfile = By.XPath("//a[.='Create Profile']");
        public static readonly By _subTabCreatePanel = By.XPath("//a[.='Create Panel']");
        public static readonly By _subTabDelete = By.XPath(".//a[@class='delete' and .='Delete']");
        public static readonly By _btnChoosePanels = By.Id("btnChoosepanel");
        public static readonly By _tabOverview = By.XPath("//a[.='Overview']");
        public static readonly By _tabExecutionDashboard = By.XPath("//a[.='Execution Dashboard']");
        public static readonly By _tabLogout = By.XPath("//a[.='Logout']");
        #endregion

        public string GetWelcomeText()
        {
            
            return GetTextControl(_tabUser);
        }

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
            //WaitForElementLoad(locator, 2);
            return Constant.driver.FindElement(locator).Text;
        }
        public void ConfirmPopup()
        {
            Constant.driver.SwitchTo().Alert().Accept();
            Thread.Sleep(1000);
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
            MouseHover(MainPage._tabUser);
            Click(MainPage._tabLogout);
            Thread.Sleep(1000);
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
    }
}


