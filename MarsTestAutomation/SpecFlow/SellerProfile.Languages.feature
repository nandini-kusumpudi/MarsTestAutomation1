Feature: SellerProfile_Languages
As a Seller
I want to add Languages in my Profile Details
So that
The people looking my profile can see what language i know.

#	profile language add
	@sellerprofiletest
	Scenario Outline: Add Profile Languages with data
		Given I logged into Trade Skills portal successfully
		And  I click on language Add New Button
		When I Enter the data in '<AddLanguage>' and '<Languagelevel>' and click on Add button
		Then A popup should be shown with '<Message>' 
		
		 Examples: 
         | AddLanguage  | Languagelevel | Message |
         | English      | Fluent        | English has been added to your languages |
		 | Spanish      | Basic         | Spanish has been added to your languages |
		 | Irish        | Basic         | Irish has been added to your languages |

	@sellerprofiletest
	Scenario: Add Profile Languages without data
		Given I logged into Trade Skills portal successfully
		And I click on Add New Button 
		When I click on Add button  without data in Language and language level field 
		Then a popup should be shown with this message (Please entry language and level)
	
	@sellerprofiletest
	Scenario: Add Profile Languages with only Language 
		Given I logged into Trade Skills portal successfully
		And I click on Add New button
		When I Enter Language and click on Add button
		Then a popup should be shown with this message (Please entry language and level)
			
	@sellerprofiletest
	Scenario: Add Profile Languages with only Language level
		Given I logged into Trade Skills portal successfully
		And I click on Add New button
		When I Select language level and click on Add button
		Then a popup should be shown with this message (Please entry language and level)
		
	@sellerprofiletest
	Scenario: Add Profile Languages with Specal characters  languages and with language level
		Given I logged into Trade Skills portalsuccessfully
		And I click on Add New button
		When I Enter Specal characters in Language and select language level and click on Add button
		Then Laguages should be Added and saved successfully
		
		
#	profile language edit
	
	@sellerprofiletest
	Scenario: Edit Profile Languages with data
		Given I logged into Trade Skills portal successfully
		And I click on language pen icon 
		When I Edited the data in '<EditLanguage>' and '<EditLanguagelevel>'  and click on update button
		Then A popup should be shown with '<Message>' 

		Examples: 
         | EditLanguage | EditLanguagelevel | Message                                     |
         | Hindi        | Basic             | Hindi has been updated to your languages    |
		
		
	Scenario: Edit Profile Languages without data
		Given I logged into Trade Skills portal successfully
		And I click on pen icon 
		When I click on update button without data
		Then Laguages should be showed a popup with this message (Please entry language and level)
		
	Scenario: Edit Profile Languages without Edited
		Given I logged into Trade Skills portal successfully
		And I click on pen icon 
		When I click on update button without edited 
		Then Laguages should be showed a popup with this message (This language is already added to your language list)
		
	Scenario: Edit Profile Languages with only language
		Given I logged into Trade Skills portal successfully
		And I click on pen icon 
		When I Edited the Language click on update button
		Then Laguages should be edited successfully
		
	Scenario: Edit Profile Languages with only language level
		Given I logged into Trade Skills portal successfully
		And I click on pen icon 
		When I edited language level and click on update button
		Then Laguages should be edited successfully
		
		
#	profile language delete
		
	@sellerprofiletest
	Scenario: Profile Languages delete
		Given I logged into Trade Skills portal successfully
		And I click language delet icon
		Then A popup should be shown with '<Message>' 
 Examples: 
         | Message |
         | Hindi has been deleted from your languages |
		 
		