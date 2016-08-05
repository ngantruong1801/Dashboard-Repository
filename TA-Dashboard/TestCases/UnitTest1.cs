using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TA_Dashboard.Common;
using TA_Dashboard.PageObjects;
using OpenQA.Selenium;
using System.Threading;

namespace TA_Dashboard.TestCases
{
    [TestClass]
    public class UnitTest1:BaseTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            NavigateTADashboard();
            LoginPage loginPage = new LoginPage();
            loginPage.Login(TestData.defaulRepository, "dieu.nguyen", "123");
            GeneralPage generalPage = new GeneralPage();
            generalPage.MouseHover(GeneralPage._tabGlobalSetting);
            generalPage.ClickTab("Add Page");
            NewPage newPage = new NewPage();
            Thread.Sleep(1000);
            newPage.AddPage("Dieu2", "Dieu1", "3", "", "public");
        }
    }
}
