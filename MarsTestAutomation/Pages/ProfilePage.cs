using System;
using System.Threading;
using MarsTestAutomation.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace MarsTestAutomation.Pages
{
    public class ProfilePage
    {
        private IWebElement descriptionField;
        private IWebElement skillNameField;
        private IWebElement skillLevelDropdownField;
        private IWebElement skillLevelDropdownOption;
        private IWebElement sellerProfileField;
        private IWebElement languageField;
        private IWebElement languageLevelDropdownField;
        private IWebElement certificationField;
        private IWebElement certificationYearDropdownField;

        public void ClickOnDescriptionPenIcon(IWebDriver driver)
        {
            Wait.WaitForElementToBeClickable(driver, "Xpath",
                "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i",
                15);

            IWebElement descriptionPenIcon = driver.FindElement(By.XPath(
                "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i"));
            descriptionPenIcon.Click();
        }

        internal void LanguageAddNewButton()
        {
            throw new NotImplementedException();
        }

        public void AddDescription(IWebDriver driver, string description)
        {
            descriptionField = driver.FindElement(By.XPath(
                "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea"));
            descriptionField.Clear();
            descriptionField.SendKeys(description);

            IWebElement saveButton = driver.FindElement(By.XPath(
                "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button"));
            saveButton.Click();
        }

        public String GetDescription(IWebDriver driver)
        {
            descriptionField = driver.FindElement(By.XPath(
                "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea"));
            return descriptionField.Text;
        }

        public String GetPopUpMessage(IWebDriver driver)
        {

            Wait.WaitForElementToBeClickable(driver, "CssSelector", "div[class='ns-box-inner']", 15);
            IWebElement popup = driver.FindElement(By.CssSelector("div[class='ns-box-inner']"));
            return popup.Text;
        }

        // skill feild

        //Add skill
        public void ClickOnSkillsTab(IWebDriver driver)
        {
            Wait.WaitForElementToBeClickable(driver, "Xpath",
                "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]",
                15);

            IWebElement skill = driver.FindElement(By.XPath(
                "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skill.Click();
        }

        public void cliclOnAddNewButton(IWebDriver driver)
        {
            IWebElement addButton = driver.FindElement(By.XPath(
                "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addButton.Click();
        }

        public void AddSkilldata(IWebDriver driver, string skillName, string skillLevel)
        {
            skillNameField = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
            skillNameField.SendKeys(skillName);

            skillLevelDropdownOption = driver.FindElement(By.XPath(
                "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
            skillLevelDropdownOption.Click();

            //create select element object 
            var selectElement = new SelectElement(skillLevelDropdownOption);

            // select by text
            selectElement.SelectByText(skillLevel);

            IWebElement Addbutton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
            Addbutton.Click();
        }

        public String GetSkillsAddPopUpMessage(IWebDriver driver)
        {
            Wait.WaitForElementToBeClickable(driver, "CssSelector", "div[class='ns-box-inner']", 15);
            IWebElement popup = driver.FindElement(By.CssSelector("div[class='ns-box-inner']"));
            return popup.Text;
        }

        // edit skill
        public void ClickEditPenIcon(IWebDriver driver)
        {
            ClickOnSkillsTab(driver);
            Thread.Sleep(5000); // WaitForElementToBeClickable method is not working here so used sleep method

            IWebElement editPenIcon = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i"));
            editPenIcon.Click();
        }

        public void UpdateSkillsData(IWebDriver driver, string skillName, string skillLevel)
        {
            skillNameField = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));
            skillNameField.Clear();
            skillNameField.SendKeys(skillName);

            skillLevelDropdownOption = driver.FindElement(By.XPath(
                  "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select"));

            //create select element object 
            var selectElement = new SelectElement(skillLevelDropdownOption);

            // select by text
            selectElement.SelectByText(skillLevel);

            IWebElement updateButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
            updateButton.Click();
        }

        // delete skill

        public void DeleteSkill(IWebDriver driver)
        {
            Wait.WaitForElementToBeClickable(driver, "Xpath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i",
                   15);
            IWebElement clickOnDeleteIcon = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
            clickOnDeleteIcon.Click();
        }

        // seller profile
        public void SelectSellerNameDropDown(IWebDriver driver)
        {
            Wait.WaitForElementToBeClickable(driver, "Xpath",
                "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[1]/i",
                15);

            IWebElement sellerDropdown = driver.FindElement(By.XPath(
                "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[1]/i"));
            sellerDropdown.Click();
        }

        public void EditSellerProfile(IWebDriver driver, string firstName, string lastName)
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

        public String GetSellerprofileName(IWebDriver driver)
        {
            sellerProfileField = driver.FindElement(By.XPath(
                "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[1]"));
            return sellerProfileField.Text;
        }

        //Language field
        //Add language
        public void LanguageAddNewButton(IWebDriver driver)
        {
            Wait.WaitForElementToBeClickable(driver, "Xpath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div",
                   15);

            languageField = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            languageField.Click();
        }

        public void EnterDataLanguageField(IWebDriver driver, string addLanguage, string languagelevel)
        {
            Thread.Sleep(5000);
            languageField = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            languageField.SendKeys(addLanguage);

            languageLevelDropdownField = driver.FindElement(By.XPath(
                "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));

            //create select element object 
            var selectElement = new SelectElement(languageLevelDropdownField);

            // select by text
            selectElement.SelectByText(languagelevel);

            IWebElement addButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            addButton.Click();
        }

        // edit language
        public void EditLanguageButton(IWebDriver driver)
        {
            Thread.Sleep(5000); // WaitForElementToBeClickable method is not working here so used sleep method
            IWebElement editButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[1]/i"));
            editButton.Click();
        }

        public void EditLanguageData(IWebDriver driver, string editLanguage, string editLanguageLevel)
        {
            languageField = driver.FindElement(By.XPath(" //*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td/div/div[1]/input"));
            languageField.Clear();
            languageField.SendKeys(editLanguage);

            languageLevelDropdownField = driver.FindElement(By.XPath(
            "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td/div/div[2]/select"));

            //create select element object 
            var selectElement = new SelectElement(languageLevelDropdownField);

            // select by text
            selectElement.SelectByText(editLanguageLevel);

            IWebElement upDate = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td/div/span/input[1]"));
            upDate.Click();
        }

        // delet language
        public void DeleteLanguage(IWebDriver driver)
        {
            Wait.WaitForElementToBeClickable(driver, "Xpath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[2]/i",
                   15);
            languageField = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[2]/i"));
            languageField.Click();
        }

        // certification
        // certification tab
        public void ClickOnCertificationTab(IWebDriver driver)
        {
            Wait.WaitForElementToBeClickable(driver, "Xpath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]",
                   15);
            //click certification feild
            certificationField = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
            certificationField.Click();
        }

        //add certification
        public void ClickOnAddNewCertificationButton(IWebDriver driver)
        {
            IWebElement addNewButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));
            addNewButton.Click();
        }

        public void EnterDataInAddCertificationFeilds(IWebDriver driver, string certification, string certificationForm, string Year)
        {
            //certificate or reward field
            certificationField = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[1]/div/input"));
            certificationField.SendKeys(certification);

            //certificate form feild
            certificationField = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[1]/input"));
            certificationField.SendKeys(certificationForm);
            //certificate year

            certificationYearDropdownField = driver.FindElement(By.XPath(
            "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select"));

            //create select element object 
            var selectElement = new SelectElement(certificationYearDropdownField);

            // select by text
            selectElement.SelectByText(Year);

            IWebElement addButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]"));
            addButton.Click();
        }

        //Edit certification
        public void ClickOnEditcertificationIcon(IWebDriver driver)
        {
            Thread.Sleep(5000);
            certificationField = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[1]/tr/td[4]/span[1]/i"));
            certificationField.Click();
        }

        public void EditDataOnCertificationField(IWebDriver driver, string EditCertification, string EditCertificationForm, string EditYear)
        {
            //certificate or reward field
            certificationField = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[1]/tr/td/div/div/div[1]/input"));
            certificationField.Clear();
            certificationField.SendKeys(EditCertification);

            //certificate form feild
            certificationField = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[1]/tr/td/div/div/div[2]/input"));
            certificationField.Clear();
            certificationField.SendKeys(EditCertificationForm);
            //certificate year

            certificationYearDropdownField = driver.FindElement(By.XPath(
            "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[1]/tr/td/div/div/div[3]/select"));

            //create select element object 
            var selectElement = new SelectElement(certificationYearDropdownField);

            // select by text
            selectElement.SelectByText(EditYear);

            IWebElement UpdateButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[1]/tr/td/div/span/input[1]"));
            UpdateButton.Click();
        }

        //delete certification
        public void ClickOnDeleteIconCertificationField(IWebDriver driver)
        {
            Wait.WaitForElementToBeClickable(driver, "Xpath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[1]/tr/td[4]/span[2]/i",
                  15);

            certificationField = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[1]/tr/td[4]/span[2]/i"));
            certificationField.Click();
        }
    }
}