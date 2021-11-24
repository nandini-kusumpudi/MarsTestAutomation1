using MarsTestAutomation.Pages;
using MarsTestAutomation.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace MarsTestAutomation.StepDefinition 
{
    [Binding]
    class SellerProfileCertificationSteps: CommonDriver
    {
        private ProfilePage CertificationObj;

        [BeforeScenario]
        public void Initialization()
        {
            CertificationObj = new ProfilePage();
        }

        // Add certification
        [Given(@"I click on Certifications and Add New button")]
        public void GivenIClickOnCertificationsAndAddNewButton()
        {
            CertificationObj.ClickOnCertificationTab(driver);
            CertificationObj.ClickOnAddNewCertificationButton(driver);
        }

        [When(@"I Enter seller '(.*)' , '(.*)', '(.*)' details and click on Add button")]
        public void WhenIEnterSellerDetailsAndClickOnAddButton(string Certification, string CertificationForm, string Year)
        {
            CertificationObj.EnterDataInAddCertificationFeilds(driver, Certification, CertificationForm, Year);
        }

        //edit certification
        [Given(@"I click on Certifications and Update button")]
        public void GivenIClickOnCertificationsAndUpdateButton()
        {
            CertificationObj.ClickOnCertificationTab(driver);
            CertificationObj.ClickOnEditcertificationIcon(driver);
        }

        [When(@"I Edited  '(.*)', '(.*)', '(.*)'  details and click on Update button")]
        public void WhenIEditedDetailsAndClickOnUpdateButton(string EditCertification, string EditCertificationForm, string EditYear)
        {
            CertificationObj.EditDataOnCertificationField(driver, EditCertification, EditCertificationForm, EditYear);
        }

        //delete certification
        [Given(@"I selected the Certification tab")]
        public void GivenISelectedTheCertificationTab()
        {
            CertificationObj.ClickOnCertificationTab(driver);
        }

        [When(@"I click on certification delete icon")]
        public void WhenIClickOnCertificationDeleteIcon()
        {
            CertificationObj.ClickOnDeleteIconCertificationField(driver);
        }

    }
}
