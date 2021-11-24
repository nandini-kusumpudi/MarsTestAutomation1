using MarsTestAutomation.Pages;
using MarsTestAutomation.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace MarsTestAutomation.StepDefinition
{
    [Binding]
    class SellerProfileLanguageSteps : CommonDriver
    {
        private ProfilePage languageObj;

        [BeforeScenario]
        public void Initialization()
        {
            languageObj = new ProfilePage();
        }

        [Given(@"I click on language Add New Button")]
        public void GivenIClickOnLanguageAddNewButton()
        {
            languageObj.LanguageAddNewButton(driver);
        }


        [When(@"I Enter the data in '(.*)' and '(.*)' and click on Add button")]
        public void WhenIEnterTheDataInAndAndClickOnAddButton(string addLanguage, string languagelevel)
        {
            languageObj.EnterDataLanguageField(driver, addLanguage, languagelevel);
        }

        [Given(@"I click on language pen icon")]
        public void GivenIClickOnLanguagePenIcon()
        {
            languageObj.EditLanguageButton(driver);
        }

        [When(@"I Edited the data in '(.*)' and '(.*)'  and click on update button")]
        public void WhenIEditedTheDataInAndAndClickOnUpdateButton(string editLanguage, string editLanguageLevel)
        {
            languageObj.EditLanguageData(driver, editLanguage, editLanguageLevel);
        }

        [Given(@"I click language delet icon")]
        public void GivenIClickLanguageDeletIcon()
        {
            languageObj.DeleteLanguage(driver);
        }

    }
}
