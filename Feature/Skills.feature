Feature: Skills
	
@mytag
Scenario:1 Add Seller's skills
	Given  Seller has clicked on  Skills tab
	And Seller has clicked on skill Add New
	When seller clicks on skill Add button
	Then Seller's Skills must be saved and visible

	Scenario:2 Edit Skills Added by Seller
	Given  Seller has clicked on  Skills tab
	And   Seller has clicked on skill Edit
	When seller clicks on skill Update button
	Then Seller's  updted Skill must be saved and visible

	Scenario:3 Delete Skill Added by Seller
	Given Seller has clicked on  Skills tab
	When seller clicks on skill Delete button
	Then Seller's Skill must be Deleted 