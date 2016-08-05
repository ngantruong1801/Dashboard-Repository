using Microsoft.VisualStudio.TestTools.UnitTesting;
using TA_Dashboard.Common;
using TA_Dashboard.PageObjects;

namespace TA_Dashboard.TestCases
{
    [TestClass]
    public class BaseTest : CommonActions
    {
        public TestContext TestContext { get; set; }
        MainPage mainpage = new MainPage();

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
                case "":
                    break;

                default:
                    mainpage.Logout();
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

