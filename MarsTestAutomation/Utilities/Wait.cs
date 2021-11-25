using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace MarsTestAutomation.Utilities
{
    public class Wait
    {
        public static void WaitForElementToBeClickable(IWebDriver driver, string locatorType, string locatorValue,
            int seconds)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));
            switch (locatorType)
            {
                case "Xpath":
                    wait.Until(
                        SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(locatorValue)));
                    break;
                case "Id":
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id(locatorValue)));
                    break;
                case "CssSelector":
                    wait.Until(
                        SeleniumExtras.WaitHelpers.ExpectedConditions
                            .ElementToBeClickable(By.CssSelector(locatorValue)));
                    break;
            }
        }
    }
}