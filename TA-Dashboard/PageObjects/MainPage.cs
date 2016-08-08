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
        public static readonly By _tabRepository = By.XPath("//a[@href='#Repository']");
        public static readonly By _lblRepository = By.XPath("//a[@href='#Repository']/span");
        //public static readonly By _tabAdminister = By.XPath("//a[@href='#Administer']");
        //public static readonly By _tabGlobalSetting = By.XPath("//li[@class='mn-setting']/a");
        //public static readonly By _subTabAddPage = By.XPath("a[.='Add Page']");
        //public static readonly By _subTabCreateProfile = By.XPath("a[.='Create Profile']");
        //public static readonly By _subTabCreatePanel = By.XPath("a[.='Create Panel']");
        //public static readonly By _btnChoosePanels = By.Id("btnChoosepanel");
        //public static readonly By _tabOverview = By.XPath("a[.='Overview']");
        //public static readonly By _tabExecutionDashboard = By.XPath("a[.='Execution Dashboard']");
        //public static readonly By _tabLogout = By.XPath("//div[@id='header']//a[.='Logout']");

        //public string GetWelcomeText()
        //{
        //    return GetTextControl(_tabUser);
        //}

        public void ChooseRepository(string repository)
        {
            MouseHover(_tabRepository);
            ClickTab(repository);
        }

        public string GetWelcomeText()
        {
            return GetTextControl(_tabUser);
        }

        public string GetRepository()
        {
            return GetTextControl(_lblRepository);
        }
    }
}
