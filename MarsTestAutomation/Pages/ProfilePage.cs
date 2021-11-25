using System;
using System.Threading;
using MarsTestAutomation.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace MarsTestAutomation.Pages
{
    public class ProfilePage
    {
        private IWebElement descriptionField => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea"));
        private IWebElement addSkillNameField => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
        private IWebElement addSkillLevelDropdownOption => driver.FindElement(By.XPath( "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
        private IWebElement editSkillNameField => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));
        private IWebElement editSkillLevelDropdownOption => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select"));
        private IWebElement sellerProfileField => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[1]"));
        private IWebElement addLanguageField => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
        private IWebElement addLanguageLevelDropdownField => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
        private IWebElement editLanguageField  => driver.FindElement(By.XPath(" //*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td/div/div[1]/input"));
        private IWebElement editLanguageLevelDropdownField => driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td/div/div[2]/select"));
        private IWebDriver driver;

        public ProfilePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void ClickOnDescriptionPenIcon()
        {
            Wait.WaitForElementToBeClickable(driver, "Xpath",
                "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i",
                15);

            IWebElement descriptionPenIcon = driver.FindElement(By.XPath(
                "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i"));
            descriptionPenIcon.Click();
        }

        public void AddDescription(string description)
        {
            descriptionField.Clear();
            descriptionField.SendKeys(description);

            IWebElement saveButton = driver.FindElement(By.XPath(
                "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button"));
            saveButton.Click();
        }

        public String GetDescription()
        {
            return descriptionField.Text;
        }

        public String GetPopUpMessage()
        {
            Wait.WaitForElementToBeClickable(driver, "CssSelector", "div[class='ns-box-inner']", 15);
            IWebElement popup = driver.FindElement(By.CssSelector("div[class='ns-box-inner']"));
            return popup.Text;
        }

        // skill feild

        //Add skill
        public void ClickOnSkillsTab()
        {
            Wait.WaitForElementToBeClickable(driver, "Xpath",
                "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]",
                15);

            IWebElement skill = driver.FindElement(By.XPath(
                "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skill.Click();
        }

        public void cliclOnAddNewButton()
        {
            IWebElement addButton = driver.FindElement(By.XPath(
                "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addButton.Click();
        }

        public void AddSkilldata(string skillName, string skillLevel)
        {
            addSkillNameField.SendKeys(skillName); 
            addSkillLevelDropdownOption.Click();

            //create select element object 
            var selectElement = new SelectElement(addSkillLevelDropdownOption);

            // select by text
            selectElement.SelectByText(skillLevel);

            IWebElement Addbutton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
            Addbutton.Click();
        }

        public String GetSkillsAddPopUpMessage()
        {
            Wait.WaitForElementToBeClickable(driver, "CssSelector", "div[class='ns-box-inner']", 15);
            IWebElement popup = driver.FindElement(By.CssSelector("div[class='ns-box-inner']"));
            return popup.Text;
        }

        // edit skill
        public void ClickEditPenIcon()
        {
            ClickOnSkillsTab();
            Thread.Sleep(5000); // WaitForElementToBeClickable method is not working here so used sleep method

            IWebElement editPenIcon = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i"));
            editPenIcon.Click();
        }

        public void UpdateSkillsData(string skillName, string skillLevel)
        {
            editSkillNameField.Clear();
            editSkillNameField.SendKeys(skillName);

            //create select element object 
            var selectElement = new SelectElement(editSkillLevelDropdownOption);

            // select by text
            selectElement.SelectByText(skillLevel);

            IWebElement updateButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
            updateButton.Click();
        }

        // delete skill

        public void DeleteSkill()
        {
            Wait.WaitForElementToBeClickable(driver, "Xpath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i",
                   15);
            IWebElement clickOnDeleteIcon = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
            clickOnDeleteIcon.Click();
        }

        // seller profile
        public void SelectSellerNameDropDown()
        {
            Wait.WaitForElementToBeClickable(driver, "Xpath",
                "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[1]/i",
                15);

            IWebElement sellerDropdown = driver.FindElement(By.XPath(
                "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[1]/i"));
            sellerDropdown.Click();
        }

        public void EditSellerProfile(string firstName, string lastName)
        {
            Wait.WaitForElementToBeClickable(driver, "CssSelector", "input[name='firstName']", 15);

            IWebElement sellerFirstName = driver.FindElement(By.CssSelector("input[name='firstName']"));
            sellerFirstName.Clear();
            sellerFirstName.SendKeys(firstName);

            IWebElement sellerLastName = driver.FindElement(By.XPath(
                "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div/div[1]/input[2]"));
            sellerLastName.Clear();
            sellerLastName.SendKeys(lastName);

            IWebElement savaButton = driver.FindElement(By.XPath(
                "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div/div[2]/button"));
            savaButton.Click();
        }

        public String GetSellerprofileName()
        {
            return sellerProfileField.Text;
        }

        //Language field
        //Add language
        public void LanguageAddNewButton()
        {
            Wait.WaitForElementToBeClickable(driver, "Xpath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div",
                   15);

            IWebElement addNewButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addNewButton.Click();
        }

        public void EnterDataLanguageField(string addLanguage, string languagelevel)
        {
            Thread.Sleep(5000);
            addLanguageField.SendKeys(addLanguage);

            //create select element object 
            var selectElement = new SelectElement(addLanguageLevelDropdownField);

            // select by text
            selectElement.SelectByText(languagelevel);

            IWebElement addButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            addButton.Click();
        }

        // edit language
        public void EditLanguageButton()
        {
            Thread.Sleep(5000); // WaitForElementToBeClickable method is not working here so used sleep method
            IWebElement editButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[1]/i"));
            editButton.Click();
        }

        public void EditLanguageData(string editLanguage, string editLanguageLevel)
        {
            editLanguageField.Clear();
            editLanguageField.SendKeys(editLanguage);

            //create select element object 
            var selectElement = new SelectElement(editLanguageLevelDropdownField);

            // select by text
            selectElement.SelectByText(editLanguageLevel);

            IWebElement upDate = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td/div/span/input[1]"));
            upDate.Click();
        }

        // delet language
        public void DeleteLanguage()
        {
            Wait.WaitForElementToBeClickable(driver, "Xpath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[2]/i",
                   15);
            IWebElement deleteLanguage = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[2]/i"));
            deleteLanguage.Click();
        }

        // certification
        // certification tab
        public void ClickOnCertificationTab()
        {
            Wait.WaitForElementToBeClickable(driver, "Xpath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]",
                   15);
            //click certification feild
            IWebElement certificationTab = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
            certificationTab.Click();
        }

        //add certification
        public void ClickOnAddNewCertificationButton()
        {
            IWebElement addNewButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));
            addNewButton.Click();
        }

        public void EnterDataInAddCertificationFeilds(string certification, string certificationForm, string Year)
        {
            //certificate or reward field
           IWebElement certificationTestField = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[1]/div/input"));
            certificationTestField.SendKeys(certification);

            //certificate form feild
          IWebElement  certificationFormField = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[1]/input"));
            certificationFormField.SendKeys(certificationForm);
            //certificate year

           IWebElement certificationYearDropdownField = driver.FindElement(By.XPath(
            "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select"));

            //create select element object 
            var selectElement = new SelectElement(certificationYearDropdownField);

            // select by text
            selectElement.SelectByText(Year);

            IWebElement addButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]"));
            addButton.Click();
        }

        //Edit certification
        public void ClickOnEditcertificationIcon()
        {
            Thread.Sleep(5000);
           IWebElement editCertificationField = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[1]/tr/td[4]/span[1]/i"));
            editCertificationField.Click();
        }

        public void EditDataOnCertificationField(string EditCertification, string EditCertificationForm, string EditYear)
        {
            //certificate or reward field
           IWebElement editCertificationTestField = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[1]/tr/td/div/div/div[1]/input"));
            editCertificationTestField.Clear();
            editCertificationTestField.SendKeys(EditCertification);

            //certificate form feild
           IWebElement editCertificationFormField = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[1]/tr/td/div/div/div[2]/input"));
            editCertificationFormField.Clear();
            editCertificationFormField.SendKeys(EditCertificationForm);
            //certificate year

          IWebElement  editCertificationYearDropdownField = driver.FindElement(By.XPath(
            "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[1]/tr/td/div/div/div[3]/select"));

            //create select element object 
            var selectElement = new SelectElement(editCertificationYearDropdownField);

            // select by text
            selectElement.SelectByText(EditYear);

            IWebElement UpdateButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[1]/tr/td/div/span/input[1]"));
            UpdateButton.Click();
        }

        //delete certification
        public void ClickOnDeleteIconCertificationField()
        {
            Wait.WaitForElementToBeClickable(driver, "Xpath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[1]/tr/td[4]/span[2]/i",
                  15);

           IWebElement deletCertification = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[1]/tr/td[4]/span[2]/i"));
            deletCertification.Click();
        }
    }
}