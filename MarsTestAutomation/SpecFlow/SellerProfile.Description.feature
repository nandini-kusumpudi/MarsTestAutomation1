Feature: SellerProfile_Description
As a Seller
I want to add Description in my Profile Details
So that
The people looking my profile can know more about me.

# profile Description
    @sellerprofiletest
    Scenario Outline: Add Profile Description with data 
        Given I logged into Trade Skills portal successfully
        And I click on pen icon
        When I Add '<Description>' and click Save button
        Then A popup should be shown with '<Message>' 
       
         Examples: 
         | Description                | Message |
         | hello, I added description | Description has been saved successfully |
         
    @sellerprofiletest
    Scenario Outline: Add Profile Description without data
        Given I logged into Trade Skills portal successfully
        And I click on pen icon
        When I click Save button without data
        Then A popup should be shown with '<Message>' 
        
        Examples: 
        | Message                       |
        | Please, a description is required |
        
    @sellerprofiletest
    Scenario: Edit Profile Description
        Given I logged into Trade Skills portal successfully
        And I click on pen icon
        When  I edit '<Description>' and click Save button
        Then A popup should be shown with '<Message>' 
        
        Examples: 
         | Description                 | Message |
         | hello, I edited description | Description has been saved successfully |

        
        