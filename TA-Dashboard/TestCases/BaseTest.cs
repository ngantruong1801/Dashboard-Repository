using Microsoft.VisualStudio.TestTools.UnitTesting;
using TA_Dashboard.Common;
using TA_Dashboard.PageObjects;

namespace TA_Dashboard.TestCases
{
    [TestClass]
    public class BaseTest : CommonActions
    {
        [AssemblyInitialize]
        public static void AssemblyInitializeMeThod(TestContext testContext)
        {
            CommonActions.OpenBrowser("firefox");
        }


        [AssemblyCleanup]
        public static void AssemblyCleapUpMethod()
        {
           CommonActions.CloseBrowser();
        }
    }
}

