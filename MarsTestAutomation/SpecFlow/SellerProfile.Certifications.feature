Feature: SellerProfile_Certifications
As a Seller
I want to add Certification in my Profile Details
So that
The people looking my profile can see what Certification i done.
	
	
	#	profile Certification Add
	@sellerprofiletest
	Scenario: Add Profile Certifications with data
		Given I logged into Trade Skills portal successfully
		And I click on Certifications and Add New button
		When I Enter seller '<Certification>' , '<CertificationForm>', '<Year>' details and click on Add button
		Then A popup should be shown with '<Message>' 

		Examples: 
         | Certification | CertificationForm | Year | Message                                      |
         | Istqb         | Fundation level   | 2017 | Istqb has been added to your certification   |
		 | English       | intership level   | 2015 | English has been added to your certification |
		
	@sellerprofiletest
	Scenario: Add Profile Certifications withot data
		Given I logged into Trade Skills portal successfully
		And I click on Certifications and Add New button
		When I click on Add button
		Then a popup should be shown with this message (Please entry certification Name and certification Form and certification Year)
		
	@sellerprofiletest
	Scenario: Add Profile Certification with only Certification Name field
		Given I logged into Trade Skills portal successfully
		And I click on Certification and Add New button
		When I enter Certification Name field click on Add button
		Then a popup should be shown with this message (Please entry certification Name and certification Form and certification Year)
		
	@sellerprofiletest
	Scenario: Add Profile Certification with only Certification Form field
		Given I logged into Trade Skills portal successfully
		And I click on Certification and Add New button
		When I enter Certification Form field click on Add button
		Then a popup should be shown with this message (Please entry certification Name and certification Form and certification Year)
		
	@sellerprofiletest
	Scenario: Add Profile Certification with only Certification Year field
		Given I logged into Trade Skills portal successfully
		And I click on Certification and Add New button
		When I enter Certification Year field click on Add button
		Then a popup should be shown with this message (Please entry certification Name and certification Form and certification Year)
		
	#	profile Certification edit
	@sellerprofiletest
	Scenario: Edit Profile Certifications with data
		Given I logged into Trade Skills portal successfully
		And I click on Certifications and Update button
		When I Edited  '<EditCertification>', '<EditCertificationForm>', '<EditYear>'  details and click on Update button
		Then A popup should be shown with '<Message>' 
		
		Examples: 
         | EditCertification | EditCertificationForm | EditYear | Message                                       |
         | Testing           | intership level       | 2016     | Testing has been updated to your certification|

	@sellerprofiletest
	Scenario: Edit Profile Certifications withot any data
		Given I logged into Trade Skills portal successfully
		And I click on Certifications and Update button
		When I click on Update button withot any data
		Then a popup should be shown with this message (Please entry certification Name and certification Form and certification Year)
		
	@sellerprofiletest
	Scenario: Edit Profile Certifications withot Update data
		Given I logged into Trade Skills portal successfully
		And I click on Certifications and update button
		When I click on Update button withot Update data
		Then a popup should be shown with this message (This information is already exits)
		
	#	profile Certification delete
	@sellerprofiletest
	Scenario: Profile Certification delete
		Given I logged into Trade Skills portal successfully
		And I selected the Certification tab
		When I click on certification delete icon
		Then A popup should be shown with '<Message>' 
		
		Examples:
		| Message                                          |
		| Testing has been deleted from your certification |