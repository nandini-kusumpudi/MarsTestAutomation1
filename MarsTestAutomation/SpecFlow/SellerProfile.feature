Feature: SellerProfile
As a Seller
I want to add Profile Name, Availability, Hours, Target in my Profile Details
So that
The people looking my profile can see what is the Name, Availability to work, Hours of woking, cost of the Earn Target.

#	profile Name

    @sellerprofiletest
    Scenario: Edit Profile Name with data
        Given I logged into Trade Skills portal successfully
        And I click on name expand icon
        When I enter '<FirstName>' '<LastName>' and click on Save button
        Then Name should be saved successfully

        Examples: 
         | FirstName | LastName |
          | nandini | kusumpudi |

    @sellerprofiletest
    Scenario: Edit Profile Name without data
        Given I logged into Trade Skills portal successfully
        And I click on name expand icon
        When I click on Save button without entering data
        Then a popup should be shown with this message (First Name, Last Name are reqired)

    @sellerprofiletest
    Scenario: Edit Profile Name with Only First Name
        Given I logged into Trade Skills portal successfully
        And I click on name expand icon
        When I enter First Name and click on Save button
        Then a popup should be shown with this message (First Name, Last Name are reqired)

    @sellerprofiletest
    Scenario: Edit Profile Name with only Last Name
        Given I logged into Trade Skills portal successfully
        And I click on name expand icon
        When I enter Last Name and click on Save button
        Then a popup should be shown with this message (First Name, Last Name are reqired)

    #	profile Availability

    @sellerprofiletest
    Scenario: Add Profile Availability
        Given I logged into Trade Skills portal successfully
        And I click on Availability pen icon
        When I select value from the dorpdown
        Then Availability should be saved successfully

    #	profile Hours

    @sellerprofiletest
    Scenario: Profile Hours
        Given I logged into Trade Skills portal successfully
        And I click on Hours pen icon
        When I select value from the dorpdown
        Then Hours should be saved successfully

    #	profile Earn Target

    @sellerprofiletest
    Scenario:Profile Earn Target
        Given I logged into Trade Skills portal successfully
        And I click on Earn Target pen icon
        When I select value from the dorpdown
        Then Earn Target should be saved successfully