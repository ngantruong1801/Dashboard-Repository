using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace TA_Dashboard.PageObjects
{
    public class NewPage:GeneralPage
    {
        public static readonly By _txtpageName = By.Id("name");


        public void AddPage(string pageName, string parentPage, string number, string displayAfter, string status)
        {
            FindWebElement(_txtpageName).SendKeys(pageName);
        }
    }
}
