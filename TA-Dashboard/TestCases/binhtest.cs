using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TA_Dashboard.Common;
using TA_Dashboard.PageObjects;
using OpenQA.Selenium;
using System.Threading;

namespace TA_Dashboard.TestCases
{
    [TestClass]
    public class binhtest:BaseTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            NavigateTADashboard();
            LoginPage loginPage = new LoginPage();
            loginPage.Login(TestData.defaulRepository, "administrator", "");
            MainPage mainPage = new MainPage();
            //mainPage.FindWebElement(By.XPath("//a[.='Dieu']")).Click();

            mainPage.MouseHover(MainPage._tabGlobalSetting);


            mainPage.ClickTab("Add Page");
            NewPage newpage = new NewPage();
            

            ////Thread.Sleep(1000);
            //mainPage.MouseHoverGlobalSetting();
            //Thread.Sleep(1000);
            //mainPage.ClickButtonChosePanels();
        }
    }
}
