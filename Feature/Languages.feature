Feature: Languages
	

@mytag
Scenario:1 Add languages known by Seller
	Given  Seller has clicked on  languges tab
	When seller clicks on Add button
	Then Seller's languages must be saved and visible

	
	
	Scenario:2 Edit languages Added by Seller
	Given  Seller has clicked on  languges tab
	And  Seller has clicked on Edit button
	When seller clicks on Update button
	Then Seller's  Updated language must be saved and visible

	Scenario:3 Delete language Added by Seller
	Given Seller has clicked on  languges tab
	When seller clicks on Delete button
	Then Seller's languages must be Deleted