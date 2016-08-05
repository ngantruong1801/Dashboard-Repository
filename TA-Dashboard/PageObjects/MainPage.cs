using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace TA_Dashboard.PageObjects
{
    public class MainPage:GeneralPage
    {
        public static readonly By _tabUser = By.XPath("//a[@href='#Welcome']");
        public static readonly By _tabAdminister = By.XPath("//a[@href='#Administer']");
        public static readonly By _tabLogout = By.XPath("//div[@id='header']//a[.='Logout']");

        public string GetWelcomeText()
        {
            return GetTextControl(_tabUser);
        }

    }
}
