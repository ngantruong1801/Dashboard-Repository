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
        static readonly By _tabRepository = By.XPath("//a[@href='#Repository']");
        static readonly By _tabAdminister = By.XPath("//a[@href='#Administer']");
        static readonly By _tabGlobalSetting = By.ClassName("mn-setting");
        static readonly By _subTabAddPage = By.XPath("a[.='Add Page']");
        static readonly By _subTabCreateProfile = By.XPath("a[.='Create Profile']");
        static readonly By _subTabCreatePanel = By.XPath("a[.='Create Panel']");
        static readonly By _btnChoosePanel = By.Id("btnChoosepanel");
        static readonly By _tabOverview = By.XPath("a[.='Overview']");
        static readonly By _tabExecutionDashboard = By.XPath("a[.='Execution Dashboard']");
    }
}
