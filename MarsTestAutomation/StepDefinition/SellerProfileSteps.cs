using MarsTestAutomation.Pages;
using MarsTestAutomation.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace MarsTestAutomation.StepDefinition
{
    [Binding]
    public class SellerProfileSteps : CommonDriver

    {
        private ProfilePage sellerProfileObj;

        [BeforeScenario]
        public void Initialization()
        {
            sellerProfileObj = new ProfilePage(driver);
        }

        [Given(@"I click on name expand icon")]
        public void GivenIClickOnNameExpandIcon()
        {
            sellerProfileObj.SelectSellerNameDropDown();
        }

      

        [When(@"I enter '(.*)' '(.*)' and click on Save button")]
        public void WhenIEnterAndClickOnSaveButton(string firstName, string lastName)
        {
            sellerProfileObj.EditSellerProfile(firstName, lastName);
        }


        [Then(@"Name should be saved successfully")]
        public void ThenNameShouldBeSavedSuccessfully()
        {
            string updatedSellerName = sellerProfileObj.GetSellerprofileName();
            Assert.AreEqual("nandini kusumpudi", updatedSellerName);
        }
    }
}