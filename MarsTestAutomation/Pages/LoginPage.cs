using OpenQA.Selenium;
using System;
using MarsTestAutomation.Utilities;


namespace MarsTestAutomation.Pages
{
    public class LoginPage
    {
        private string userName = "nandini.kusumpudi49@gmail.com";
        private string password = "test@123";
        private IWebElement SignInButton;
        private IWebDriver driver;
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void LoginAction()  
        {
            DriverUtilis.NavigateUrl(driver, "http://localhost:5000/");
            driver.Manage().Window.Maximize();

            SignInButton = driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a"));
            SignInButton.Click();
            
            // indetify the username textbox enter valid username
            IWebElement emailAddressTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
            emailAddressTextbox.SendKeys(userName);

            // identify password textbox enter valid password
            IWebElement passwordTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
            passwordTextbox.SendKeys(password);

            // identify login button and click
            IWebElement loginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
            loginButton.Click();
            
           
        }
    }
}