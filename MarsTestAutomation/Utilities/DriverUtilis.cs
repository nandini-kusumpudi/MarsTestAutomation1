using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsTestAutomation.Utilities
{
    public class DriverUtilis
    {
        public static void NavigateUrl(IWebDriver driver, string url)
        {
            driver.Navigate().GoToUrl(url);
        }
    }
}
