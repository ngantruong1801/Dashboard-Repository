using Microsoft.VisualStudio.TestTools.UnitTesting;
using TA_Dashboard.Common;
using TA_Dashboard.PageObjects;
using System.Threading;

namespace TA_Dashboard.TestCases
{
    [TestClass]
    public class BaseTest : CommonActions
    {
        public TestContext TestContext { get; set; }
        MainPage mainPage = new MainPage();
        LoginPage loginPage = new LoginPage();

        [AssemblyInitialize]
        public static void AssemblyInitializeMeThod(TestContext testContext)
        {
            CommonActions.OpenBrowser("firefox");
        }

        [TestCleanup]
        public void TestCleanup()
        {

            switch (TestContext.TestName)
            {
                case "DA_LOGIN_TC002_Verify_that_user_fails_to_login_specific_repository_successfully_via_Dashboard_login_page_with_incorrect_credentials":
                case "DA_LOGIN_TC003_Verify_that_user_fails_with_correct_username_and_incorrect_password":
                case "DA_LOGIN_TC006_Verify_that_Password_input_is_case_sensitive":
                case "DA_LOGIN_TC010_Verify_that_the_page_works_correctly_for_the_case_when_no_input_entered_to_Password_and_Username_field":
                    Thread.Sleep(1000);
                    loginPage.ConfirmPopup();
                    break;
                case "DA_MP_TC012_Verify_that_user_is_able_to_add_additional_pages_besides_Overview_page_successfully":
                    mainPage.DeletePage(TestData.addPageName);
                    mainPage.Logout();
                    break;
                default:
                    Thread.Sleep(1000);
                    mainPage.Logout();
                    break;
            }
        }

        [AssemblyCleanup]
        public static void AssemblyCleapUpMethod()
        {
            CommonActions.CloseBrowser();
        }
    }
}

