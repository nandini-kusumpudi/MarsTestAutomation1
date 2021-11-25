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
        private ProfilePage CertificationPage;

        [BeforeScenario]
        public void Initialization()
        {
            CertificationPage = new ProfilePage(driver);
        }

        // Add certification
        [Given(@"I click on Certifications and Add New button")]
        public void GivenIClickOnCertificationsAndAddNewButton()
        {
            CertificationPage.ClickOnCertificationTab();
            CertificationPage.ClickOnAddNewCertificationButton();
        }

        [When(@"I Enter seller '(.*)' , '(.*)', '(.*)' details and click on Add button")]
        public void WhenIEnterSellerDetailsAndClickOnAddButton(string Certification, string CertificationForm, string Year)
        {
            CertificationPage.EnterDataInAddCertificationFeilds(Certification, CertificationForm, Year);
        }

        //edit certification
        [Given(@"I click on Certifications tab and Edit icon")]
        public void GivenIClickOnCertificationsTabAndEditIcon()
        {
            CertificationPage.ClickOnCertificationTab();
            CertificationPage.ClickOnEditcertificationIcon();
        }

        [When(@"I Edited  '(.*)', '(.*)', '(.*)'  details and click on Update button")]
        public void WhenIEditedDetailsAndClickOnUpdateButton(string EditCertification, string EditCertificationForm, string EditYear)
        {
            CertificationPage.EditDataOnCertificationField(EditCertification, EditCertificationForm, EditYear);
        }

        //delete certification
        [Given(@"I selected the Certification tab")]
        public void GivenISelectedTheCertificationTab()
        {
            CertificationPage.ClickOnCertificationTab();
        }

        [When(@"I click on certification delete icon")]
        public void WhenIClickOnCertificationDeleteIcon()
        {
            CertificationPage.ClickOnDeleteIconCertificationField();
        }

    }
}
