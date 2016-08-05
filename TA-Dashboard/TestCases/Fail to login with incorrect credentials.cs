using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TA_Dashboard.PageObjects;
using TA_Dashboard.Common;

namespace TA_Dashboard.TestCases
{
    [TestClass]
    public class Fail_to_login_with_incorrect_credential : BaseTest
    {
        [TestMethod]
        public void DA_LOGIN_TC002_Verify_that_user_fails_to_login_specific_repository_successfully_via_Dashboard_login_page_with_incorrect_credentials()
        {
            NavigateTADashboard();
            LoginPage loginPage = new LoginPage();
            loginPage.Login(TestData.defaulRepository, TestData.invalidUsername, TestData.invalidPassword);
            string actualMessage = loginPage.GetTextPopup();
            CheckTextDisplays(TestData.errorLoginMessage, actualMessage);
        }
    }
}
