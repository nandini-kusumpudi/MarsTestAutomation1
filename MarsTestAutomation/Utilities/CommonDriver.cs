using MarsTestAutomation.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace MarsTestAutomation.Utilities
{
   
    public class CommonDriver
    {
        public static IWebDriver driver;

        public void LoginActions()
        {
            // open chrome browser
            driver = new ChromeDriver();

            // login page object initialization and definition
            //LoginPage loginPageObj = new LoginPage();
            //loginPageObj.LoginAction(driver);
        }
        
        [AfterScenario]
        public void CloseTestRun()
        {
            driver.Quit();
        }
    }
}