using OpenQA.Selenium;
using TA_Dashboard.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Edge;
using System.Diagnostics;

namespace TA_Dashboard.PageObjects
{
    public class CommonActions
    {
        public static void CheckTextDisplays(string expectedText, string actualText)
        {
            Assert.AreEqual(expectedText, actualText);
        }

        public static void OpenBrowser(string browsername)
        {
            switch (browsername.ToUpper())
            {
                case "FIREFOX":
                    Constant.driver = new FirefoxDriver();
                    Constant.driver.Manage().Window.Maximize();
                    break;
                case "CHROME":
                    Constant.driver = new ChromeDriver();
                    Constant.driver.Manage().Window.Maximize();
                    break;
                case "IE":
                    Constant.driver = new InternetExplorerDriver();
                    Constant.driver.Manage().Window.Maximize();
                    break;
                case "EDGE":
                    Constant.driver = new EdgeDriver();
                    Constant.driver.Manage().Window.Maximize();
                    break;
                default:
                    Constant.driver = new FirefoxDriver();
                    Constant.driver.Manage().Window.Maximize();
                    break;
            }
        }

        public static void CloseBrowser()
        {
            Constant.driver.Manage().Cookies.DeleteAllCookies();
            Constant.driver.Quit();
            foreach (Process process in Process.GetProcessesByName("iexplore"))
            {
                process.Kill();
            }

        }
    }
}
