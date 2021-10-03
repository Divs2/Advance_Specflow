Feature: ManageRequest
	Simple calculator for adding two numbers

@mytag
Scenario:1  Seller send request
	Given Seller has searched skill
	When  Seller has sent the request
	Then the request should be visible in sent request

	Scenario:2   Seller receive  request
	Given Seller has clicked on Receive request on Managerequest
	When  Seller has received request
	Then the request should be visible in received request