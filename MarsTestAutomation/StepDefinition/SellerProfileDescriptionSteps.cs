using MarsTestAutomation.Pages;
using MarsTestAutomation.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace MarsTestAutomation.StepDefinition
{
    [Binding]
    public class SpDescriptionSteps : CommonDriver
    {
        private ProfilePage descriptionObj;

        [BeforeScenario]
        public void Initialization()
        {
            descriptionObj = new ProfilePage(driver);
        }

        [Given(@"I logged into Trade Skills portal successfully")]
        public void GivenILoggedIntoTradeSkillsPortalSuccessfully()
        {

            LoginPage loginObj = new LoginPage(driver);
            loginObj.LoginAction();
        }

        [Given(@"I click on pen icon")]
        public void GivenIClickOnPenIcon()
        {
            descriptionObj.ClickOnDescriptionPenIcon();
        }

        [When(@"I Add '(.*)' and click Save button")]
        public void WhenIAddAndClickSaveButton(string description)
        {
            descriptionObj.AddDescription(description);
        }

        [Then(@"'(.*)' should be saved successfully")]
        public void ThenShouldBeSavedSuccessfully(string description)
        {
            string newDescription = descriptionObj.GetDescription();
            Assert.AreEqual(description, newDescription);
        }

        [When(@"I click Save button without data")]
        public void WhenIClickSaveButtonWithoutData()
        {
            descriptionObj.AddDescription("");
        }

        [Then(@"A popup should be shown with '(.*)'")]
        public void ThenAPopupShouldBeShownWith(string message)
        {
            string popUpMessage = descriptionObj.GetPopUpMessage();
            Assert.AreEqual(popUpMessage, message);
        }

        [When(@"I edit '(.*)' and click Save button")]
        public void WhenIEditAndClickSaveButton(string description)
        {
            descriptionObj.AddDescription(description);
        }

    }
}