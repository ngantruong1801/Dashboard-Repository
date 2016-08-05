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
        static readonly By _tabUser = By.XPath("//a[@href='#Welcome']");
        static readonly By _tabAdminister = By.XPath("//a[@href='#Administer']");
        static readonly By _tabLogout = By.XPath("//div[@id='header']//a[.='Logout']");

    }
}
