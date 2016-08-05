using Microsoft.VisualStudio.TestTools.UnitTesting;
using TA_Dashboard.Common;

namespace TA_Dashboard.TestCases
{
    [TestClass]
    public class BaseTest : CommonActions
    {
        [AssemblyInitialize]
        public static void AssemblyInitializeMeThod(TestContext testContext)
        {
            CommonActions.OpenBrowser("chrome");
        }

        [AssemblyCleanup]
        public static void AssemblyCleapUpMethod()
        {
           CommonActions.CloseBrowser();
        }
    }
}

