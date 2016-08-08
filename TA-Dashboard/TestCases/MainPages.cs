using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TA_Dashboard.Common;
using TA_Dashboard.PageObjects;

namespace TA_Dashboard.TestCases
{
    [TestClass]
    public class MainPages:BaseTest
    {
        LoginPage loginPage = new LoginPage();
        [TestMethod]
        public void DA_MP_TC012_Verify_that_user_is_able_to_add_additional_pages_besides_Overview_page_successfully()
        {
            NavigateTADashboard();
            loginPage.Login(TestData.defaulRepository, TestData.validUsername, TestData.validPassword);

            MainPage mainPage = new MainPage();
            mainPage.OpenAddPageDialog();

            NewPage newPage=new NewPage();
            
            newPage.AddPage("test123","","","","");
            
        }
    }
}
