using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TA_Dashboard.Common;
using TA_Dashboard.PageObjects;


namespace TA_Dashboard.TestCases
{
    [TestClass]
    public class LoginPage: BaseTest
    {
        PageObjects.LoginPage loginPage = new PageObjects.LoginPage();
        [TestMethod]
        public void DA_LOGIN_TC001_Verify_that_user_can_login_specific_repository_successfully_via_Dashboard_login_page_with_correct_credentials()
        {
            NavigateTADashboard();
            loginPage.Login(TestData.defaulRepository, TestData.validUsername, TestData.validPassword);
            PageObjects.MainPage mainPage = new PageObjects.MainPage();        
            string actualText = mainPage.GetWelcomeText();
            CheckTextDisplays(TestData.validUsername, actualText);
        }

        [TestMethod]
        public void DA_LOGIN_TC002_Verify_that_user_fails_to_login_specific_repository_successfully_via_Dashboard_login_page_with_incorrect_credentials()
        {
            NavigateTADashboard();
            loginPage.Login(TestData.defaulRepository, TestData.invalidUsername, TestData.invalidPassword);
            string actualMessage = loginPage.GetTextPopup();
            CheckTextDisplays(TestData.errorLoginMessage, actualMessage);
        }

        [TestMethod]
        public void DA_LOGIN_TC003_Verify_that_user_fails_with_correct_username_and_incorrect_password()
        {
            NavigateTADashboard();
            loginPage.Login(TestData.defaulRepository, TestData.validUsername, TestData.invalidPassword);
            string actualMessage = loginPage.GetTextPopup();
            CheckTextDisplays(TestData.errorLoginMessage, actualMessage);
        }

        [TestMethod]
        public void DA_LOGIN_TC004_Verify_that_user_is_able_to_log_in_different_repositories_successfully_after_logging_out_current_repository()
        {
            NavigateTADashboard();
            loginPage.Login(TestData.defaulRepository, TestData.validUsername, TestData.validPassword);
            PageObjects.MainPage mainPage = new PageObjects.MainPage();
            mainPage.Logout();
            loginPage.Login(TestData.testRepository, TestData.validUsername, TestData.validPassword);
            string actualText = mainPage.GetWelcomeText();
            CheckTextDisplays(TestData.validUsername, actualText);
        }

        [TestMethod]
        public void DA_LOGIN_TC005_Verify_that_there_is_no_Login_dialog_when_switching_between_2_repositories_with_the_same_account()
        {
            NavigateTADashboard();
            loginPage.Login(TestData.defaulRepository, TestData.validUsername, TestData.validPassword);
            PageObjects.MainPage mainPage = new PageObjects.MainPage();
            mainPage.ChooseRepository(TestData.testRepository);
            Assert.IsFalse(mainPage.IsLoginRepositoryDisplay());
            string actualRepository = mainPage.GetRepository();
            CheckTextDisplays(actualRepository, TestData.testRepository);
        }

        [TestMethod]
        public void DA_LOGIN_TC006_Verify_that_Password_input_is_case_sensitive()
        {
            NavigateTADashboard();
            loginPage.Login(TestData.defaulRepository, TestData.testUsername, TestData.testUppercasePassword);
            PageObjects.MainPage mainPage = new PageObjects.MainPage();
            string actualText = mainPage.GetWelcomeText();
            CheckTextDisplays(TestData.testUsername, actualText);
            mainPage.Logout();
            loginPage.Login(TestData.defaulRepository, TestData.testUsername, TestData.testLowercasePassword);
            string actualMessage = loginPage.GetTextPopup();
            CheckTextDisplays(TestData.errorLoginMessage, actualMessage);
        }

        [TestMethod]
        public void DA_LOGIN_TC007_Verify_that_Username_is_not_case_sensitive()
        {
            NavigateTADashboard();
            loginPage.Login(TestData.defaulRepository, TestData.uppercaseUsername, TestData.lowercasePassword);
            PageObjects.MainPage mainPage = new PageObjects.MainPage();
            string actualText1 = mainPage.GetWelcomeText();
            CheckTextDisplays(TestData.uppercaseUsername, actualText1);
            mainPage.Logout();
            loginPage.Login(TestData.defaulRepository, TestData.lowercaseUsername, TestData.lowercasePassword);
            string actualText2 = mainPage.GetWelcomeText();
            CheckTextDisplays(TestData.uppercaseUsername, actualText2);
        }

        [TestMethod]
        public void DA_LOGIN_TC008_Verify_that_password_with_special_characters_is_working_correctly()
        {
            NavigateTADashboard();
            loginPage.Login(TestData.defaulRepository, TestData.specialUsername, TestData.specialCharactersPassword);
            PageObjects.MainPage mainPage = new PageObjects.MainPage();
            string actualText = mainPage.GetWelcomeText();
            CheckTextDisplays(TestData.specialUsername, actualText);
        }

        [TestMethod]
        public void DA_LOGIN_TC009_Verify_that_username_with_special_characters_is_working_correctly()
        {
            NavigateTADashboard();
            loginPage.Login(TestData.defaulRepository, TestData.specialCharactersUsername, TestData.specialPassword);
            PageObjects.MainPage mainPage = new PageObjects.MainPage();
            string actualText = mainPage.GetWelcomeText();
            CheckTextDisplays(TestData.specialCharactersUsername, actualText);
        }

        [TestMethod]
        public void DA_LOGIN_TC010_Verify_that_the_page_works_correctly_for_the_case_when_no_input_entered_to_Password_and_Username_field()
        {
            NavigateTADashboard();
            loginPage.Login(TestData.defaulRepository, TestData.blankUsername, TestData.blankPassword);
            string actualMessage = loginPage.GetTextPopup();
            CheckTextDisplays(TestData.errorBlankUsernameLoginMessage, actualMessage);
        }     
    }
}
