Feature: Education


@mytag
Scenario:1 Add Seller's Education
	Given  Seller has clicked on  Education tab
	And Seller has clicked on Add New on Education	
	When seller clicks on Add button on Education
	Then Seller's  education must be saved and visible

	Scenario:2 Edit Seller's Education
	Given  Seller has clicked on  Education tab
	And Seller has clicked on Edit on Education
	When seller clicks on update button on Education
	Then Seller's  Updated education must be saved and visible

	Scenario:3 Delete Seller's Education
	Given  Seller has clicked on  Education tab
	When seller clicks on delete button on Education
	Then Seller's  education must be deleted