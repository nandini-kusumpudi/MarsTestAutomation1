Feature: SellerProfile_Education
As a Seller
I want to add Education in my Profile Details
So that
The people looking my profile can see what Education i done.
    
# profile Education Added
    @sellerprofiletest
    Scenario: Add Profile Education with data
        Given I logged into Trade Skills portal successfully
        When I click on Education and Add New button
        And  I Enter seller Education details and click on Add button
        Then Education details should be Added and saved successfully

    @sellerprofiletest
    Scenario: Add Profile Education without data
        Given I logged into Trade Skills portal successfully
        When I click on Education and Add New button
        And I click on Add button with out any data
        Then a popup should be shown with this message (Please entry all the fields)

    @sellerprofiletest
    Scenario: Add Profile Education with only college/University Name field
        Given I logged into Trade Skills portal successfully
        When I click on Education and Add New button
        And I enter college/University Name field click on Add button
        Then a popup should be shown with this message (Please entry all the fields)

    @sellerprofiletest
    Scenario: Add Profile Education with only country of college/University field
        Given I logged into Trade Skills portal successfully
        When I click on Education and Add New button
        And I enter country of college/University field click on Add button
        Then a popup should be shown with this message (Please entry all the fields)

    @sellerprofiletest
    Scenario: Add Profile Education with only title field
        Given I logged into Trade Skills portal successfully
        When I click on Education and Add New button
        And I Selected title field click on Add button
        Then a popup should be shown with this message (Please entry all the fields)

    @sellerprofiletest
    Scenario: Add Profile Education with only degree field
        Given I logged into Trade Skills portal successfully
        When I click on Education and Add New button
        And I enter degree field click on Add button
        Then a popup should be shown with this message (Please entry all the fields)

    @sellerprofiletest
    Scenario: Add Profile Education with only year of Graduation field
        Given I logged into Trade Skills portal successfully
        When I click on Education and Add New button
        And I enter year of Graduation field click on Add button
        Then a popup should be shown with this message (Please entry all the fields)


    #	profile Education edit

    @sellerprofiletest
    Scenario: Edit Profile Education with edited data
        Given I logged into Trade Skills portal successfully
        When I click on Education and pen Icon
        And I Edited seller Education details and click on Update button
        Then Education details should be Added and saved successfully

    @sellerprofiletest
    Scenario: Edit Profile Education without any data
        Given I logged into Trade Skills portal successfully
        When I click on Education and pen Icon
        And I click on update button
        Then a popup should be shown with this message (Please entry all the fields)
        
    @sellerprofiletest
    Scenario: Edit Profile Education without updated  data
        Given I logged into Trade Skills portal successfully
        When I click on Education and pen Icon
        And I click on update button
        Then a popup should be shown with this message (This information is already exist)

    #	profile Education delete
		
    @sellerprofiletest
    Scenario: Profile Education delete
        Given I logged into Trade Skills portal successfully
        When I selected the Education
        And I click on delete icon
        Then Education should be Deleted successfully