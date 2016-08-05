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
            CommonActions.OpenBrowser("IE");
        }

        [TestCleanup]
        public void TestCleanup()
        {

            switch (TestContext.TestName)
            {
                case "DA_LOGIN_TC002_Verify_that_user_fails_to_login_specific_repository_successfully_via_Dashboard_login_page_with_incorrect_credentials":
                case "DA_LOGIN_TC003_Verify_that_user_fails_with_correct_username_and_incorrect_password":
                    loginPage.ConfirmPopup();
                    Thread.Sleep(1000);
                    break;

                default:
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

