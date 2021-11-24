Feature: SellerProfile_Skills
As a Seller
I want to add skills in my Profile Details
So that
The people looking my profile can see what skills i know.

#	profile skills add

    @sellerprofiletest
    Scenario: Add Profile skills with data
        Given I logged into Trade Skills portal successfully
        And I click on skills tab
        And I click on Add New button
        When I enter the data in '<SkillName>' and '<SkillLevel>'  and click on Add button
        Then A popup '<Message>' should be shown

    Examples:
     | SkillName | SkillLevel | Message                               |
     | Testing   | Expert     | Testing has been added to your skills |
     | Editing   | Beginner   | Editing has been added to your skills |

    @sellerprofiletest
    Scenario: Add Profile Skills without data
        Given I logged into Trade Skills portal successfully
        And I click on Add New Button
        When I click on Add button  without data in Skills and Skills level field
        Then a popup should be shown with this message (Please entry Skills and Experience level)

    @sellerprofiletest
    Scenario: Add Profile Skills with only Add skills
        Given I logged into Trade Skills portal successfully
        And I click on Add New button
        When I Enter data in Skills and click on Add button
        Then a popup should be shown with this message (Please entry Skills and Experience level)

    @sellerprofiletest
    Scenario: Add Profile Skills with only Skill level
        Given I logged into Trade Skills portal successfully
        And I click on Add New button
        When I Select Skill level and click on Add button
        Then a popup should be shown with this message (Please entry Skills and Experience level)

    @sellerprofiletest
    Scenario: Add Profile Skills with Specal characters
        Given I logged into Trade Skills portal successfully
        And I click on Add New button
        When I Enter Specal characters in Skills and select Skill level and click on Add button
        Then Skills should be saved successfully


    #	profile skills edit


    @sellerprofiletest
    Scenario: Edit Profile Skills with data
        Given I logged into Trade Skills portal successfully
        And I click on Skill Edit pen icon
        When I Edit the data in '<SkillName>' and '<SkillLevel>'  and click on update button
        Then A popup '<Message>' should be shown

        Examples:
      | SkillName | SkillLevel | Message|
      | English   | Expert |English has been updated to your skills|
        

    Scenario: Edit Profile Skills without data
        Given I logged into Trade Skills portal successfully
        And I click on Skill Edit pen icon
        When I click on update button without data
        Then Skills should be showed a popup with this message (Please entry Skills and Experience level)

    Scenario: Edit Profile Skills without Edited
        Given I logged into Trade Skills portal successfully
        And I click on Skill Edit pen icon
        When I click on update button without edited
        Then Skills should be showed a popup with this message (This Skills is already added to your Skills list)

    Scenario: Edit Profile Skills with only language
        Given I logged into Trade Skills portal successfully
        And I click on pen icon
        When I Edited the Skills click on update button
        Then Laguages should be edited successfully

    Scenario: Edit Profile Skills with only language level
        Given I logged into Trade Skills portal successfully
        And I click on pen icon
        When I edited Skills level and click on update button
        Then Skills should be edited successfully


    #	profile skills delete

    @sellerprofiletest
    Scenario: Profile Skills delete
        Given I logged into Trade Skills portal successfully
        And   I click on skills tab
        When  I click on delete icon
        Then  A popup '<Message>' should be shown

       Examples: 
        |Message|
        |English has been deleted|