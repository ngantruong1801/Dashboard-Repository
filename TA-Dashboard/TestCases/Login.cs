using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TA_Dashboard.Common;
using TA_Dashboard.PageObjects;


namespace TA_Dashboard.TestCases
{
    [TestClass]
    public class Login: BaseTest
    {
        LoginPage loginPage = new LoginPage();
        [TestMethod]
        public void DA_LOGIN_TC001_Verify_that_user_can_login_specific_repository_successfully_via_Dashboard_login_page_with_correct_credentials()
        {
            //1. Navigate to Dashboard login page
            NavigateTADashboard();
            loginPage.Login(TestData.defaulRepository, TestData.validUsername, TestData.validPassword);
            MainPage mainPage = new MainPage();
            string actualText = mainPage.GetWelcomeText();
            Console.WriteLine(actualText);
            CheckTextDisplays(TestData.validUsername, actualText);
        }

        [TestMethod]
        public void DA_LOGIN_TC002_Verify_that_user_fails_to_login_specific_repository_successfully_via_Dashboard_login_page_with_incorrect_credentials()
        {
            loginPage.Login(TestData.defaulRepository, TestData.invalidUsername, TestData.invalidPassword);
            string actualMessage = loginPage.GetTextPopup();
            CheckTextDisplays(TestData.errorLoginMessage, actualMessage);
        }
    }
}
