using MarsTestAutomation.Pages;
using MarsTestAutomation.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace MarsTestAutomation.StepDefinition
{
    [Binding]
    public class SellerProfileSkillsSteps : CommonDriver
    {
        private ProfilePage skillObj;

        [BeforeScenario]
        public void Initialization()
        {
            skillObj = new ProfilePage();
        }

        [Given(@"I click on skills tab")]
        public void GivenIClickOnSkills()
        {
            skillObj.ClickOnSkillsTab(driver);
        }

        [Given(@"I click on Add New button")]
        public void GivenIClickOnAddNewButton()
        {
            skillObj.cliclOnAddNewButton(driver);
        }

        [When(@"I enter the data in '(.*)' and '(.*)'  and click on Add button")]
        public void WhenIEnterTheDataInAndAndClickOnAddButton( string skillName, string skillLevel)
        {
            skillObj.AddSkilldata(driver, skillName, skillLevel);
        }


        [Then(@"A popup '(.*)' should be shown")]
        public void ThenAPopupShouldBeShown(string message)
        {
            string skillsPopUpMessage = skillObj.GetSkillsAddPopUpMessage(driver);
            Assert.AreEqual(message, skillsPopUpMessage);
        }

        [Given(@"I click on Skill Edit pen icon")]
        public void GivenIClickOnSkillEditPenIcon()
        {
            skillObj.ClickEditPenIcon(driver);
        }

        [When(@"I Edit the data in '(.*)' and '(.*)'  and click on update button")]
        public void WhenIEditTheDataInAndAndClickOnUpdateButton(string skillName, string skillLevel)
        {
            skillObj.UpdateSkillsData(driver, skillName, skillLevel);
        }


        [When(@"I click on delete icon")]
        public void WhenIClickOnDeleteIcon()
        {
            skillObj.DeleteSkill(driver);
        }

    }
}