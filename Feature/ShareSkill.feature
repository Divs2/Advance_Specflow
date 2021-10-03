Feature: ShareSkill
	Simple calculator for adding two numbers

@mytag
Scenario:1 : Add skills on Share Skill
	Given Seller has clicked on  ShareSkill tab
	When Seller click on add button
	Then seller's skill must be saved and visible


	Scenario:2  Edit skills on Share Skill
	Given Seller has clicked on  ManageListing tab
	When Seller has edited Shareskill
	Then seller's edited skill must be updated and visible


Scenario:3 Delete skills on Share Skill
	Given Seller has clicked on  ManageListing tab
	When Seller has Deleted Shareskill
	Then seller's  skill must be deleted
	
