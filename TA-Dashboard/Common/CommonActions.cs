using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TA_Dashboard.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TA_Dashboard.PageObjects
{
    public class CommonActions
    {
        public static void CheckTextDisplays(string expectedText, string actualText)
        {
            Assert.AreEqual(expectedText, actualText);
        }
    }
}
