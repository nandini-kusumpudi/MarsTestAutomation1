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
            skillObj = new ProfilePage(driver);
        }

        [When(@"I click on skills tab")]
        public void GivenIClickOnSkills()
        {
            skillObj.ClickOnSkillsTab();
        }

        [When(@"I click on Add New button")]
        public void GivenIClickOnAddNewButton()
        {
            skillObj.cliclOnAddNewButton();
        }

        [When(@"I enter the data in '(.*)' and '(.*)'  and click on Add button")]
        public void WhenIEnterTheDataInAndAndClickOnAddButton( string skillName, string skillLevel)
        {
            skillObj.AddSkilldata(skillName, skillLevel);
        }


        [Then(@"A popup '(.*)' should be shown")]
        public void ThenAPopupShouldBeShown(string message)
        {
            string skillsPopUpMessage = skillObj.GetSkillsAddPopUpMessage();
            Assert.AreEqual(message, skillsPopUpMessage);
        }

        [When(@"I click on Skill Edit pen icon")]
        public void GivenIClickOnSkillEditPenIcon()
        {
            skillObj.ClickEditPenIcon();
        }

        [When(@"I Edit the data in '(.*)' and '(.*)'  and click on update button")]
        public void WhenIEditTheDataInAndAndClickOnUpdateButton(string skillName, string skillLevel)
        {
            skillObj.UpdateSkillsData(skillName, skillLevel);
        }


        [When(@"I click on delete icon")]
        public void WhenIClickOnDeleteIcon()
        {
            skillObj.DeleteSkill();
        }

    }
}