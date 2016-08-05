using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TA_Dashboard.Common;
using TA_Dashboard.PageObjects;
using OpenQA.Selenium;

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
            MainPage mainPage = new MainPage();
            //mainPage.MouseHover(By.XPath("//a[.='Overview']"));
            mainPage.MouseHover(By.XPath("//li[@class='mn-setting']"));       
        }
    }
}
