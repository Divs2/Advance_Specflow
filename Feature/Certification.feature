Feature: Certification
	

@mytag
Scenario:1 Add Seller's certificate
	Given  Seller has clicked on  Certification tab
	When seller clicks on  certificate Add button
	Then Seller's Cetification must be saved and visible

	Scenario:2 Edit Seller's certificate
	Given  Seller has clicked on  Certification tab
	When seller clicks on  certificate update button
	Then Seller's Cerification must be updated and visible

	Scenario:3 Delete Seller's Certifications
	Given  Seller has clicked on  Education tab
	When seller clicks on certificate delete button
	Then Seller's  certification must be deleted