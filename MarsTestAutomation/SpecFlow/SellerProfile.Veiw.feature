Feature: SellerProfile_Veiw
Seller is able to see the seller’s details on the Profile page. 

	@sellerprofiletest
	Scenario: Seller is able to see the seller’s details on the Profile page. 
		Given I go to the Trade Skills portal successfully
		And I click on Graphics design
		When I select the seller
		Then I can see the seller profile page successfully
